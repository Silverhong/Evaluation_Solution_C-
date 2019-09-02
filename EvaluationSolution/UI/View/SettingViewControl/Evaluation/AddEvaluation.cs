using EvaluationSolution.Entity;
using EvaluationSolution.Infrastructure;
using EvaluationSolution.UI.View.SettingViewControl.Evaluation.AddEvaluationControl;
using MetroFramework.Forms;
using Newtonsoft.Json;
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
        List<VEvaluationType> listEvaType;
        public AddEvaluation()
        {
            InitializeComponent();
            listEvaType = new List<VEvaluationType>();
            string url = ApiRouting.GetUrl("", "", "evaluationType", ApiFunction.GetAll).ToString();
            bool confirm = url.Get<VEvaluationType>(ref listEvaType);
            if (confirm)
                comboType.DataSource = listEvaType.Select(x => x.EvTName).ToList();
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(StaticMessage.CancelMessage, StaticMessage.CancelMessage).DialogResult == DialogResult.OK)
                this.Dispose();
        }
        private void BtnAddStaff_Click_1(object sender, EventArgs e)
        {
            ///string[] selected = dataGridStaff.Rows.Cast<DataGridViewRow>().Select(x => x.Cells[0].Value.ToString()).ToArray();
            SelectStaff selectStaff = new SelectStaff();
            selectStaff.ShowDialog();
        }
        private void BtnAddQuestion_Click_1(object sender, EventArgs e)
        {
            SelectQuestion selectQuestion = new SelectQuestion();
            selectQuestion.ShowDialog();
        }
        public void AddToDatagridQuestion(List<VEvaluationQuestion> listEvQ)
        {
            dataGridQuestion.Rows.Clear();
            foreach(var obj in listEvQ)
            {
                dataGridQuestion.Rows.Add(obj.EvQId.ToString(), obj.EvQDescription.ToString());
            }
        }
        public void AddToDatagridStaff(List<VStaff> listStaff)
        {
            dataGridStaff.Rows.Clear();
            foreach(var obj in listStaff)
            {
                string[] st = { obj.StaffId, obj.Sname };
                dataGridStaff.Rows.Add(st);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow selected in dataGridQuestion.SelectedRows)
            {
                dataGridQuestion.Rows.Remove(selected);
            }
        }

        private void AddEvaluation_FormClosed(object sender, FormClosedEventArgs e)
        {
            Singleton.Instance.Container.Dispose<AddEvaluation>();
            Singleton.Instance.Container.Bind<AddEvaluation>();
        }
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            bool AssignStaffConfirm, EvDConfirm, confirm;
            string desc = txtDescription.Text;
            string fromDate = dtFromDate.Value.Date.ToShortDateString();
            string toDate = dtToDate.Value.Date.ToShortDateString();
            string type = comboType.SelectedItem.ToString();
            string evTypeId = listEvaType[comboType.SelectedIndex].EvTId;
            string createdDate = DateTime.Now.Date.ToShortDateString();
            string status = "Active";
            Entity.Evaluation ev = new Entity.Evaluation()
            {
                CreatedDate = createdDate,
                EvDescription = desc,
                EvId = "",
                EvTId = evTypeId,
                FromDate = fromDate,
                StaffId = GlobalVariable.StaffID,
                Status = status,
                ToDate = toDate
            };
            string json = JsonConvert.SerializeObject(ev);
            string evId = "";
            string url = ApiRouting.GetUrl("", "", "evaluation", ApiFunction.Add).ToString();
            confirm = url.Post<Entity.Evaluation>(json,ref evId);
            if (confirm)
            {
                List<EvaluationDetail> listEvD = new List<EvaluationDetail>();
                foreach (DataGridViewRow dtr in dataGridQuestion.Rows)
                {
                    listEvD.Add(new EvaluationDetail()
                    {
                        CreatedDate = DateTime.Now.Date.ToShortDateString(),
                        EvId = evId,
                        EvQId = dtr.Cells[0].Value.ToString()
                    });
                }
                string EvDJson = JsonConvert.SerializeObject(listEvD);
                string EvDUrl = ApiRouting.GetUrl("", "", "evaluationDetail", ApiFunction.Add).ToString();
                EvDConfirm = EvDUrl.Post<EvaluationDetail>(EvDJson);
                List<AssignStaff> listAStaff = new List<AssignStaff>();
                foreach (DataGridViewRow dtr in dataGridStaff.Rows)
                {
                    listAStaff.Add(new AssignStaff()
                    {
                        Aid="",
                        Description="",
                        EvID=evId,
                        StaffId=dtr.Cells[0].Value.ToString(),
                        Status="Active"
                    });
                }
                string AssignStaffJson = JsonConvert.SerializeObject(listAStaff);
                string AssignUrl = ApiRouting.GetUrl("", "", "assignstaff", ApiFunction.Add).ToString();
                AssignStaffConfirm = AssignUrl.Post<AssignStaff>(AssignStaffJson);
                if (EvDConfirm && AssignStaffConfirm)
                {
                    MessageBox.Show("Operation Successful!");
                    var obj = Singleton.Instance.Container.Resolve<MainView>("evaluation management");
                    obj.Init();
                    this.Dispose();
                }
            }
        }
    }
}
