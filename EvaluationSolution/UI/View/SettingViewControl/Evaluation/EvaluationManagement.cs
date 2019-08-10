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
using EvaluationSolution.Infrastructure;

namespace EvaluationSolution.UI.View.SettingViewControl.Evaluation
{
    public partial class EvaluationManagement : MainView
    {
        List<Entity.VEvaluation> listEva;
        public EvaluationManagement()
        {
            InitializeComponent();
            listEva = new List<Entity.VEvaluation>();
            //foreach (DataGridViewRow dtr in dataGridMain.Rows)
            //{
            //    if ((string)dtr.Cells["Status"].Value == "Incomplete")
            //    {
            //        dtr.DefaultCellStyle.BackColor = Color.Red;
            //        dtr.DefaultCellStyle.ForeColor = Color.White;
            //    }
            //}
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
            string url = ApiRouting.GetUrl("", "", "evaluation", ApiFunction.GetAll).ToString();
            bool confirm = url.Get<VEvaluation>(ref listEva);
            if (confirm)
                dataGridMain.DataSource = listEva.Select(x => new
                {
                    ID = x.EvId,
                    Description = x.EvDescription,
                    Start_Date = x.fromDate,
                    End_Date = x.toDate,
                    Created_Date = x.CreatedDate,
                    Created_By = x.StaffId,
                    x.Status
                }).ToList();
        }
        private void BtnAddEvaluation_Click(object sender, EventArgs e)
        {
            AddEvaluation addEvaluation = Singleton.Instance.Container.Resolve<AddEvaluation>();
            addEvaluation.ShowDialog();
        }
        private void DtToDate_ValueChanged(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            if (dtToDate.Value.Date.ToString("dd") != DateTime.Now.Date.ToString("dd"))
            {
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

        private void BtnDeleteEvaluation_Click(object sender, EventArgs e)
        {
            int index = dataGridMain.CurrentCell.RowIndex;
            string EvId = dataGridMain.Rows[index].Cells[0].Value.ToString();
            VEvaluation vEvaluation = new VEvaluation()
            {
                CreatedDate = "",
                EvId = EvId,
                EvDescription = "",
                fromDate = "",
                StaffId = "",
                Status = "",
                toDate=""
            };
            string queryString = vEvaluation.GetQueryString();
            string url = ApiRouting.GetUrl("", "", "evaluation", ApiFunction.DeleteById).ToString() + queryString;
            bool confirm = url.Detete<VEvaluation>();
            if (confirm)
            {
                MessageBox.Show("Operation Succesful", "Successful");
                Init();
            }
        }
    }
}
