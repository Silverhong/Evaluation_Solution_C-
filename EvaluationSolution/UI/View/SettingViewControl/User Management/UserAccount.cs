using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                Status="Enable"
            });
            listUserAcc.Add(new Entity.UserAccount()
            {
                StaffId = "002",
                Username = "SVisal",
                Created_date = "01/02/2019",
                Status = "Enable"
            });
            listUserAcc.Add(new Entity.UserAccount()
            {
                StaffId = "003",
                Username = "SSeyla",
                Created_date = "01/03/2019",
                Status = "Disabled"
            });
            dataGridMain.DataSource = listUserAcc.Select(x => new { Staff_ID = x.StaffId, x.Username, x.Created_date, x.Status }).ToList();
            lbTotal.Text = listUserAcc.Count.ToString();
        }

        private void DataGridMain_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridMain.ClearSelection();
        }
    }
}
