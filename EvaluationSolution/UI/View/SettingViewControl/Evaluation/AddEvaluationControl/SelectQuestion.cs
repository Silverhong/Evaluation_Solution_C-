using EvaluationSolution.Entity;
using EvaluationSolution.Infrastructure;
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
        AddEvaluation obj = Singleton.Instance.Container.Resolve<AddEvaluation>();
        List<Entity.VEvaluationQuestion> listEvQ;
        public SelectQuestion()
        {
            InitializeComponent();
            listEvQ = new List<Entity.VEvaluationQuestion>();
            string url = ApiRouting.GetUrl("", "", "evaluationQuestion", ApiFunction.GetAll).ToString();
            bool confirm = url.Get<Entity.VEvaluationQuestion>(ref listEvQ);
            if (!confirm)
                MessageBox.Show("Operation Failed");
            dataGridMain.DataSource = listEvQ.Select(x => new { Description = x.EvQDescription }).ToList();
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

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            List<Entity.VEvaluationQuestion> newList = new List<VEvaluationQuestion>();
            int i = 0;
            foreach (DataGridViewRow obj in dataGridMain.Rows)
            {
                bool confirm = obj.Cells["Selected"].Value == null ? false : (bool)obj.Cells["Selected"].Value;
                if (confirm)
                {
                    newList.Add(new VEvaluationQuestion()
                    {
                        EvQId = listEvQ[i].EvQId,
                        EvQDescription = obj.Cells[1].Value.ToString()
                    }); 
                    i++;
                }
                else
                {
                    i++;
                    continue;
                }
            }
            obj.AddToDatagridQuestion(newList);
            this.Close();
        }
    }
}
