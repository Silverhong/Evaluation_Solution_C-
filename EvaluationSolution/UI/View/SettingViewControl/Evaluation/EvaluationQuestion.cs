using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EvaluationSolution.UI.Forms;
using EvaluationSolution.Infrastructure;

namespace EvaluationSolution.UI.View.SettingViewControl.Evaluation
{
    public partial class EvaluationQuestion : MainView
    {
        List<Entity.VEvaluationQuestion> listEvQ;
        public EvaluationQuestion()
        {
            InitializeComponent();
            listEvQ = new List<Entity.VEvaluationQuestion>();
        }
        public override void Init()
        {
            string url = ApiRouting.GetUrl("", "", "evaluationQuestion", ApiFunction.GetAll).ToString();
            bool confirm = url.Get<Entity.VEvaluationQuestion>(ref listEvQ);
            if (confirm)
            {
                dataGridMain.DataSource = listEvQ;
                
            }
        }
        private void DataGridMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridMain.CurrentCell.RowIndex;
            string EvQId = dataGridMain[0, row].Value.ToString();
            string Question = dataGridMain[2, row].Value.ToString();
            EvaluationQuestionDetail evQDetail = new EvaluationQuestionDetail(EvQId,Question);
            evQDetail.ShowDialog();
        }

        private void DataGridMain_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridMain.ClearSelection();
        }

        private void BtnAddQuestion_Click(object sender, EventArgs e)
        {
            AddQuestion addQuestion = new AddQuestion();
            addQuestion.ShowDialog();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int index = dataGridMain.CurrentCell.RowIndex;
            string id = dataGridMain.Rows[index].Cells[0].Value.ToString();
            Entity.EvaluationQuestion evaluationQuestion = new Entity.EvaluationQuestion()
            {
                CreatedDate = "",
                EvQDescription = "",
                EvQId = id,
                StaffId = ""
            };
            string queryString = evaluationQuestion.GetQueryString();
            string url = ApiRouting.GetUrl("", "", "evaluationQuestion", ApiFunction.DeleteById).ToString() + queryString;
            bool confirm = url.Detete<Entity.EvaluationQuestion>();
            if (confirm)
            {
                Init();
                MessageBox.Show("Operation Successful");
            }
        }
    }
}
