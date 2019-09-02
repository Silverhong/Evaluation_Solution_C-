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

namespace EvaluationSolution.UI.View.SettingViewControl.Evaluation
{
    public partial class EvaluationDetailForm : MetroForm
    {
        List<VEvaluation> listEv = new List<VEvaluation>();
        VEvaluationDetail EVD = new VEvaluationDetail();
        string id = "";
        public EvaluationDetailForm(string id)
        {
            InitializeComponent();
            this.id = id;
            string url = ApiRouting.GetUrl("", "", "evaluation", ApiFunction.GetById).ToString() + "?EvId=" + id;
            bool getEv = url.Get<VEvaluation>(ref listEv);
            if (!getEv)
            {
                MessageBox.Show("Cannot Connect To Server!");
                return;
            }
            VEvaluation vEvaluation = listEv[0];
            lbCreatedDate.Text = vEvaluation.CreatedDate;
            lbDescription.Text = vEvaluation.EvDescription;
            lbFromDate.Text = vEvaluation.fromDate;
            lbToDate.Text = vEvaluation.toDate;
            lbStatus.Text = vEvaluation.Status;
            string evQUrl = ApiRouting.GetUrl("", "", "evaluationDetail", ApiFunction.GetByEvId).ToString() + "?EvId=" + id;
            bool getEvQ = evQUrl.GetDeserializeObject<VEvaluationDetail>(ref EVD);
            if (!getEvQ)
            {
                MessageBox.Show("Cannot Connect To Server!");
                return;
            }
            dataGridQuestion.DataSource = EVD.VEvaluationQuestion.Select(x => new { ID = x.EvQId, Description = x.EvQDescription }).ToList();
            dataGridStaff.DataSource = EVD.vEvaluationDetailStaff;
            //dataGridQuestion.DataSource = listEVQ.Select(x=> new {ID = x.EvQId,Description = x.EvQDescription }).ToList();

        }

        private void EvaluationDetailForm_Load(object sender, EventArgs e)
        {

            //foreach (DataGridViewRow dtr in dataGridStaff.Rows)
            //{
            //    if ((string)dtr.Cells["Status"].Value == "Pending")
            //    {
            //        dtr.DefaultCellStyle.ForeColor = Color.White;
            //        dtr.DefaultCellStyle.BackColor = Color.Red;
            //    }
            //}
        }
    }
}
