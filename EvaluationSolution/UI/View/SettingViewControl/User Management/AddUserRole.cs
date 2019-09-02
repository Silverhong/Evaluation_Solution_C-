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
    public partial class AddUserRole : MetroForm
    {
        public AddUserRole()
        {
            InitializeComponent();
        }

        private void AddUserRole_Load(object sender, EventArgs e)
        {

        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string role = txtRole.Text.Trim();
            if(MessageBox.Show($"Do you want to create role : {role}").DialogResult == DialogResult.OK)
            {
                Usergroup usergroup = new Usergroup()
                {
                    Name = role,
                    UserGroupID = ""
                };
                string json = JsonConvert.SerializeObject(usergroup);
                string url = ApiRouting.GetUrl("", "", "usergroup", ApiFunction.Add).ToString();
                bool confirm = url.Post<Usergroup>(json);
                if (confirm)
                {
                    MessageBox.Show($"User Role : {role} is successfully created.");
                    var obj = Singleton.Instance.Container.Resolve<MainView>("user role");
                    obj.Init();
                    this.Dispose();
                }
            }
        }
    }
}
