using EvaluationSolution.Entity;
using EvaluationSolution.Infrastructure;
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

namespace EvaluationSolution.UI.View.ManagementViewControl
{
    public partial class AddOfficeForm : MetroForm
    {
        List<VDepartment> listDepartment;
        public AddOfficeForm()
        {
            InitializeComponent();
            listDepartment = new List<VDepartment>();
            bool confirm = ApiRouting.GetUrl("", "", "department", ApiFunction.GetAll).ToString().Get<VDepartment>(ref listDepartment);
            comboDepartment.DataSource = listDepartment.Select(x => x.Deptname).ToList() ;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(StaticMessage.CancelMessage, StaticMessage.CancelRegisterTitle).DialogResult == DialogResult.OK)
            {
                this.Dispose();
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string officeName = txtOfficeName.Text.Trim();
            if (officeName.Length == 0)
            {
                MessageBox.Show("Office Name Required !", "Invalid Input");
                return;
            }
            string deptName = comboDepartment.SelectedItem.ToString();
            string deptId = listDepartment.Where(x => x.Deptname == deptName).Select(x => x.DeptId).FirstOrDefault();
            Office office = new Office() { DeptId = deptId, OfficeName = officeName};
            string url = ApiRouting.GetUrl("", "", "office", ApiFunction.Add).ToString();
            string json = JsonConvert.SerializeObject(office);
            bool confirm = url.Post<Office>(json);
            var objOffice = Singleton.Instance.Container.Resolve<MainView>("office");
            if (confirm)
            {
                MessageBox.Show("Office added successful", "Successful");
                objOffice.Init();
            }
            else
            {
                MessageBox.Show("Connection Error!", "Error!");
            }
        }
    }
}
