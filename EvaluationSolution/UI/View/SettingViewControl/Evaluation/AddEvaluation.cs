using EvaluationSolution.Entity;
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
        List<VEvaluationType> listEvaType;
        public AddEvaluation()
        {
            InitializeComponent();
            listEvaType = new List<VEvaluationType>();
            string url = ApiRouting.GetUrl("", "", "evaluationType", ApiFunction.GetAll).ToString();
            bool confirm = url.Get<VEvaluationType>(ref listEvaType);
            if (confirm)
                comboEvType.DataSource = listEvaType.Select(x => x.EvTName).ToList();
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
    }
}
