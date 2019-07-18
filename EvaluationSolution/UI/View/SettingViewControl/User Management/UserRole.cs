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
    public partial class UserRole : MainView
    {
        public UserRole()
        {
            InitializeComponent();
            List<Entity.UserRole> listUserRole = new List<Entity.UserRole>();
            listUserRole.Add(new Entity.UserRole()
            {
                UserGroupID = "001",
                Name = "Staff"
            });
            listUserRole.Add(new Entity.UserRole()
            {
                UserGroupID = "002",
                Name = "Manager"
            });
            listUserRole.Add(new Entity.UserRole()
            {
                UserGroupID = "003",
                Name = "Admin"
            });
            DataGridMain.DataSource = listUserRole.Select(x => new { ID = x.UserGroupID, Role = x.Name }).ToList();
            lbTotal.Text = listUserRole.Count.ToString();
        }

        private void DataGridMain_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridMain.ClearSelection();
        }
    }
}
