using EvaluationSolution.Infrastructure;
using EvaluationSolution.UI.View.SettingViewControl.Evaluation.AddEvaluationControl;
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
    public partial class AddEvaluation : MetroForm
    {
        public AddEvaluation()
        {
            InitializeComponent();
            List<Entity.EvaluationQuestion> listQ = new List<Entity.EvaluationQuestion>()
            {
                new Entity.EvaluationQuestion(){CreatedDate="27/06/2019",EvQDescription="១- ការគោរពវិន័យ និងគោលការណ៍ការងារ ?",EvQId="001",StaffId="002"},
                new Entity.EvaluationQuestion(){CreatedDate="27/06/2019",EvQDescription="២- វត្តមាន និងការមកធ្វើការទៀងពេលវេលា ?",EvQId="002",StaffId="002"},
            };
            dataGridQuestion.DataSource = listQ.Select(x => new {No=x.EvQId,Description = x.EvQDescription}).ToList();
            List<Entity.User> listU = new List<Entity.User>();
            for(int i = 1; i <= 30; i++)
            {
                listU.Add(new Entity.User() { ID = i++, Name = $"User {i}" });
            }
            dataGridStaff.DataSource = listU;
        }
        private void BtnAddQuestion_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnAddStaff_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnAddNew_Click(object sender, EventArgs e)
        {

        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(StaticMessage.CancelMessage, StaticMessage.CancelMessage).DialogResult == DialogResult.OK)
                this.Dispose();
        }

        private void BtnAddStaff_Click_1(object sender, EventArgs e)
        {
            string[] selected = dataGridStaff.Rows.Cast<DataGridViewRow>().Select(x => x.Cells[0].Value.ToString()).ToArray();
            SelectStaff selectStaff = new SelectStaff(selected);
            selectStaff.ShowDialog();
        }
        private void BtnAddQuestion_Click_1(object sender, EventArgs e)
        {
            SelectQuestion selectQuestion = new SelectQuestion();
            selectQuestion.ShowDialog();
        }
    }
}
