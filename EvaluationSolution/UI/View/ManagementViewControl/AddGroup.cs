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
    public partial class AddGroup : MetroForm
    {
        public AddGroup()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string group = txtGroup.Text.Trim();
            Usergroup usergroup = new Usergroup()
            {
                Name = group,
                UserGroupID = ""
            };
            string json = JsonConvert.SerializeObject(usergroup);
            string url = ApiRouting.GetUrl("", "", "usergroup", ApiFunction.Add).ToString();
            bool confirm = url.Post<Usergroup>(json);
            if (confirm)
            {
                var obj = Singleton.Instance.Container.Resolve<MainView>("group");
                MessageBox.Show("Operation Successful", "Success");
                obj.Init();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Cannot Connect to Server!", "Success");
            }
        }

        private void AddGroup_Load(object sender, EventArgs e)
        {

        }
    }
}
