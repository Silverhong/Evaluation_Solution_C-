using EvaluationSolution.Entity;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EvaluationSolution.UI.View.SettingViewControl.Evaluation.AddEvaluationControl
{
    public partial class SelectQuestion : MetroForm
    {
        public SelectQuestion()
        {
            InitializeComponent();
            List<Entity.EvaluationQuestion> listEvQ = new List<Entity.EvaluationQuestion>();
            listEvQ.Add(new Entity.EvaluationQuestion() { EvQDescription = "១- ការគោរពវិន័យ និងគោលការណ៍ការងារ" });
            listEvQ.Add(new Entity.EvaluationQuestion() { EvQDescription = "២- វត្តមាន និងការមកធ្វើការទៀងពេលវេលា" });
            listEvQ.Add(new Entity.EvaluationQuestion() { EvQDescription = "៣- ការស្លៀកពាក់ និងអនាម័យខ្លួនប្រាណ" });
            listEvQ.Add(new Entity.EvaluationQuestion() { EvQDescription = "៤- ការរៀបចំសណ្តាប់ធ្នាប់ សោភណភាព និង អនាម័យកន្លែងធ្វើការ" });
            listEvQ.Add(new Entity.EvaluationQuestion() { EvQDescription = "៥- ការសហការ និងការធ្វើការជាក្រុម" });
            listEvQ.Add(new Entity.EvaluationQuestion() { EvQDescription = "៦- ភាពទទួលខុសត្រូវលើការងាររបស់ខ្លួន" });
            listEvQ.Add(new Entity.EvaluationQuestion() { EvQDescription = "៧- ចំណេះដឹង និងបច្ចេកទេសក្នុងការដោះស្រាយបញ្ហា" });
            listEvQ.Add(new Entity.EvaluationQuestion() { EvQDescription = "៨- លទ្ធផលការងារដែលសម្រេចបានទាន់ពេលវេលា" });
            listEvQ.Add(new Entity.EvaluationQuestion() { EvQDescription = "៩- មានភាពច្នៃប្រឌិត និងគំនិតផ្តូចផ្តើម" });
            listEvQ.Add(new Entity.EvaluationQuestion() { EvQDescription = "១០-លទ្ធផលស្រាវជ្រាវ និងការចែករំលែកនូវចំណេះដឹង" });
            int num = 1;
            List<VQuestion> vQuestion = listEvQ.Select(q =>
            {
                VQuestion question = new VQuestion()
                {
                    Description = q.EvQDescription
                };
                num++;
                return question;
            }).ToList();
            dataGridMain.DataSource = vQuestion;
            dataGridMain.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.Columns.Add(new DataGridViewCheckBoxColumn() { HeaderText = "Selected", Name = "Selected", TrueValue = true, FalseValue = false});
            dataGridMain.Columns[dataGridMain.Columns.Count-1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            foreach(DataGridViewColumn col in dataGridMain.Columns)
            {
                if (col.HeaderText != "Selected")
                    col.ReadOnly = true;
            }

        }
        private void DataGridMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridMain.CurrentCell.RowIndex;
            bool? con = (bool?)dataGridMain["Selected", index].Value;
            if (con.HasValue && con.Value == true)
            {
                dataGridMain.Rows[index].Cells["Selected"].Value = false;
                dataGridMain.Rows[index].DefaultCellStyle.ForeColor = Color.Black;
            }
            else
            {
                dataGridMain.Rows[index].Cells["Selected"].Value = true;
                dataGridMain.Rows[index].DefaultCellStyle.ForeColor = Color.Red;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to cancel Staff Selection ?", "Staff Selection").DialogResult == DialogResult.OK)
            {
                this.Dispose();
            }
        }
    }
}
