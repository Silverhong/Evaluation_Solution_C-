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

namespace EvaluationSolution.UI.View.SettingViewControl.Evaluation
{
    public partial class EvaluationQuestion : MainView
    {
        public EvaluationQuestion()
        {
            InitializeComponent();
            List<Entity.EvaluationQuestion> listEvQ = new List<Entity.EvaluationQuestion>();
            listEvQ.Add(new Entity.EvaluationQuestion()
            {
                EvQId = "001",
                CreatedDate = "24/06/2019",
                EvQDescription = "How often is they come to work ?",
                StaffId = "GG"
            });
            dataGridMain.DataSource = listEvQ.Select(x=>new { ID = x.EvQId, Created_Date = x.CreatedDate, Description = x.EvQDescription, Created_By = x.StaffId }).ToList();

        }

        private void DataGridMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridMain.CurrentCell.RowIndex;
            string EvQId = dataGridMain[0, row].Value.ToString();
            EvaluationQuestionDetail evQDetail = new EvaluationQuestionDetail(EvQId);
            evQDetail.ShowDialog();
        }

        private void DataGridMain_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridMain.ClearSelection();
        }
    }
}
