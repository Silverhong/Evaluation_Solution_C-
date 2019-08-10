using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EvaluationSolution.UI.View.SettingViewControl.User_Management;
using EvaluationSolution.Entity;
using EvaluationSolution.Infrastructure;

namespace EvaluationSolution.UI.View.SettingViewControl
{
    public partial class UserAccount : MainView
    {
        List<VUser> listUser;
        List<VDepartment> listDepartment;
        List<VOffice> listOffice;
        public UserAccount()
        {
            InitializeComponent();
            listDepartment = new List<VDepartment>();
            listOffice = new List<VOffice>();
            bool conDepartment = ApiRouting.GetUrl("", "", "department", ApiFunction.GetAll).ToString().Get<VDepartment>(ref listDepartment);
            bool conOffice = ApiRouting.GetUrl("", "", "office", ApiFunction.GetAll).ToString().Get<VOffice>(ref listOffice);
            comboOffice.DataSource = listOffice.Select(x=>x.OfficeName).ToList();
            comboDepartment.DataSource = listDepartment.Select(x=>x.Deptname).ToList();
            comboOffice.SelectedIndex = -1;
            comboDepartment.SelectedIndex = -1;
            listUser = new List<VUser>();
        }
        public override void Init()
        {
            string url = ApiRouting.GetUrl("", "", "user", ApiFunction.GetAll).ToString();
            bool confirm = url.Get<VUser>(ref listUser);
            if (confirm)
                dataGridMain.DataSource = listUser;
        }
        private void DataGridMain_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridMain.ClearSelection();
        }
        private void BtnAddAccount_Click(object sender, EventArgs e)
        {
            AddUserAccount addUserAccount = new AddUserAccount();
            addUserAccount.ShowDialog();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int index = dataGridMain.CurrentCell.RowIndex;
            string id = dataGridMain.Rows[index].Cells[0].Value.ToString();
            User user = new User()
            {
                Created_date = "",
                Password = "",
                Regcom_id = "",
                StaffId = "",
                Status = "",
                Username = "",
                UserId = id
            };
            string queryString = user.GetQueryString<User>();
            string url = ApiRouting.GetUrl("", "", "user", ApiFunction.DeleteById).ToString() + queryString;
            bool confirm = url.Detete<User>();
            if (!confirm)
            {
                MessageBox.Show("Cannot delete user account!");
            }
            Init();
        }
    }
}
