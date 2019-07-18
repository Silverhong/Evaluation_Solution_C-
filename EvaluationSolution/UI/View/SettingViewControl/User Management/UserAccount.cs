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

namespace EvaluationSolution.UI.View.SettingViewControl
{
    public partial class UserAccount : MainView
    {
        public UserAccount()
        {
            InitializeComponent();
            List<Entity.UserAccount> listUserAcc = new List<Entity.UserAccount>();
            listUserAcc.Add(new Entity.UserAccount()
            {
                StaffId="001",
                Username="VKimhong",
                Created_date ="01/01/2019",
                Role="Manager",
                Status="Enable"
            });
            listUserAcc.Add(new Entity.UserAccount()
            {
                StaffId = "002",
                Username = "SVisal",
                Role="Staff",
                Created_date = "01/02/2019",
                Status = "Enable"
            });
            listUserAcc.Add(new Entity.UserAccount()
            {
                StaffId = "003",
                Username = "SSeyla",
                Role = "Staff",
                Created_date = "01/03/2019",
                Status = "Disabled"
            });
            dataGridMain.DataSource = listUserAcc.Select(x => new { Staff_ID = x.StaffId, x.Username, x.Created_date,x.Role, x.Status }).ToList();
            lbTotal.Text = listUserAcc.Count.ToString();
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
    }
}
