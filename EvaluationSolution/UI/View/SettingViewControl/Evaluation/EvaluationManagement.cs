using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EvaluationSolution.Entity;
namespace EvaluationSolution.UI.View.SettingViewControl.Evaluation
{
    public partial class EvaluationManagement : MainView
    {
        public EvaluationManagement()
        {
            InitializeComponent();
            List<Entity.Evaluation> listEva = new List<Entity.Evaluation>() {
                new Entity.Evaluation()
                {
                    EvId = "001",
                    EvDescription = "SETEC Staff Evaluation of June",
                    fromDate = "01/06/2019",
                    toDate = "31/06/2019",
                    CreatedDate = "24/06/2019",
                    StaffId = "G1",
                    Status="Completed"
                },
                new Entity.Evaluation()
                {
                    EvId = "002",
                    EvDescription = "SETEC Staff Evaluation of July",
                    fromDate = "01/07/2019",
                    toDate = "30/07/2019",
                    CreatedDate = "31/06/2019",
                    StaffId = "G1",
                    Status="Incomplete"
                }
                };
            dataGridMain.DataSource = listEva.Select(x=>new { ID = x.EvId, Description = x.EvDescription, Start_Date = x.fromDate, End_Date = x.toDate, Created_Date = x.CreatedDate, Created_By = x.StaffId,x.Status
            }).ToList();
            foreach(DataGridViewRow dtr in dataGridMain.Rows)
            {
                if ((string)dtr.Cells["Status"].Value == "Incomplete")
                {
                    dtr.DefaultCellStyle.BackColor = Color.Red;
                    dtr.DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }

        private void DataGridMain_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridMain.ClearSelection();
        }

        private void DataGridMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EvaluationDetailForm evaluationDetailForm = new EvaluationDetailForm();
            evaluationDetailForm.ShowDialog();
        }
        public override void Init()
        {
            dataGridMain.ClearSelection();
        }

        private void BtnAddEvaluation_Click(object sender, EventArgs e)
        {
            AddEvaluation addEvaluation = new AddEvaluation();
            addEvaluation.ShowDialog();
        }
        private void DtToDate_ValueChanged(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            if (dtToDate.Value.Date.ToString("dd") != DateTime.Now.Date.ToString("dd")) {
                panel1.Controls.Clear();
                panel1.Controls.Add(new NotFoundView() { Dock = DockStyle.Fill });
            }
            else
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(dataGridMain);
            }
                
        }

        private void DataGridMain_Leave(object sender, EventArgs e)
        {
            dataGridMain.ClearSelection();
        }
    }
}
