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
using EvaluationSolution.Infrastructure;
using EvaluationSolution.Entity;

namespace EvaluationSolution.UI.View.SettingViewControl
{
    public partial class UserRole : MainView
    {
        List<VUsergroup> listRole;
        public UserRole()
        {
            InitializeComponent();
        }
        public override void Init()
        {
            listRole = new List<VUsergroup>();
            bool conRole = ApiRouting.GetUrl("", "", "usergroup", ApiFunction.GetAll).ToString().Get<VUsergroup>(ref listRole);
            if (conRole)
                DataGridMain.DataSource = listRole;
        }
        private void DataGridMain_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //DataGridMain.ClearSelection();
        }

        private void BtnAddRole_Click(object sender, EventArgs e)
        {
            AddUserRole addUserRole = new AddUserRole();
            addUserRole.ShowDialog();
        }
    }
}
