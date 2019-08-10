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

namespace EvaluationSolution.UI.View.SettingViewControl.User_Management
{
    public partial class AddUserAccount : MetroForm
    {
        List<VDepartment> listDepartment;
        List<VOffice> listOffice;
        List<VStaff> listStaff;
        public AddUserAccount()
        {
            InitializeComponent();
            listDepartment = new List<VDepartment>();
            bool conDepartment = ApiRouting.GetUrl("", "", "department", ApiFunction.GetAll).ToString().Get<VDepartment>(ref listDepartment);
            bool conOffice = ApiRouting.GetUrl("", "", "office", ApiFunction.GetAll).ToString().Get<VOffice>(ref listOffice);
            bool conStaff = ApiRouting.GetUrl("", "", "staff", ApiFunction.GetAll).ToString().Get<VStaff>(ref listStaff);
            comboStaff.DataSource = listStaff.Select(x =>x.Sname).ToList();
            comboDepartment.DataSource = listDepartment.Select(x => x.Deptname).ToList();
            comboOffice.DataSource = listOffice.Select(x => x.OfficeName).ToList();
            if (!conDepartment||!conOffice||!conStaff)
                MessageBox.Show("Cannot connect to server!", "Error");
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string regcom_id = GlobalVariable.CompanyId;
            string username = txtUsername.Text.Trim();
            if (txtPass.Text != txtConPass.Text)
            {
                MessageBox.Show("Please confirm password!");
                return;
            }
            string password = txtPass.Text;
            string createdDate = DateTime.Now.ToShortDateString();
            string status = "Active";
            string staffName = comboStaff.SelectedItem.ToString();
            string staffId = listStaff.Where(x => x.Sname == staffName).Select(x => x.StaffId).FirstOrDefault();
            User user = new User()
            {
                Created_date = createdDate,
                Password = password,
                Regcom_id = regcom_id,
                Status = status,
                StaffId = staffId,
                Username = username
            };
            string json = JsonConvert.SerializeObject(user);
            string url = ApiRouting.GetUrl("", "", "user", ApiFunction.Add).ToString();
            bool confirm = url.Post<User>(json);
            if (!confirm)
            {
                MessageBox.Show("User account added succesful.", "Successful");
            }
            var objUser = Singleton.Instance.Container.Resolve<MainView>("user account");
            objUser.Init();
            ClearInput();
            Close();
        }
        private void ClearInput()
        {
            txtConPass.Clear();
            txtPass.Clear();
            txtUsername.Clear();
            comboDepartment.SelectedIndex = -1;
            comboOffice.SelectedIndex = -1;
            comboStaff.SelectedIndex = -1;
        }
    }
}
