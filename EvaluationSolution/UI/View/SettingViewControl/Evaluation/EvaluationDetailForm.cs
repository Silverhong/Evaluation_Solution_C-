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

namespace EvaluationSolution.UI.View.SettingViewControl.Evaluation
{
    public partial class EvaluationDetailForm : MetroForm
    {
        public EvaluationDetailForm()
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
            dataGridQuestion.DataSource = vQuestion;
            List<VStaffScore> listVSScore = new List<VStaffScore>();
            listVSScore.Add(new VStaffScore()
            {
                ID = "001",
                SName = "Kimhong",
                Score = "100",
                Status = "Completed"
            });
            listVSScore.Add(new VStaffScore()
            {
                ID = "002",
                SName = "Kimkheang",
                Score = "90",
                Status = "Completed"
            });
            listVSScore.Add(new VStaffScore()
            {
                ID = "003",
                SName = "Visal",
                Score = "90",
                Status = "Completed"
            });
            listVSScore.Add(new VStaffScore()
            {
                ID = "004",
                SName = "Seyla",
                Score = "92",
                Status = "Completed"
            });
            listVSScore.Add(new VStaffScore()
            {
                ID = "005",
                SName = "Phearith",
                Score = "100",
                Status = "Pending"
            });
            listVSScore.Add(new VStaffScore()
            {
                ID = "006",
                SName = "Phalkun",
                Score = "80",
                Status = "Pending"
            });
            listVSScore.Add(new VStaffScore()
            {
                ID = "007",
                SName = "Chheangmeng",
                Score = "85",
                Status = "Pending"
            });
            listVSScore.Add(new VStaffScore()
            {
                ID = "008",
                SName = "Rith",
                Score = "70",
                Status = "Pending"
            });
            dataGridStaff.DataSource = listVSScore;
        }

        private void EvaluationDetailForm_Load(object sender, EventArgs e)
        {

            foreach (DataGridViewRow dtr in dataGridStaff.Rows)
            {
                if ((string)dtr.Cells["Status"].Value == "Pending")
                {
                    dtr.DefaultCellStyle.ForeColor = Color.White;
                    dtr.DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }
    }
}
