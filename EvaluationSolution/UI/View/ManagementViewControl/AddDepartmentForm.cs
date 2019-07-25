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
    public partial class AddDepartmentForm : MetroForm
    {
        public AddDepartmentForm()
        {
            InitializeComponent();
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
            if (MessageBox.Show($"Do you want to register department : {txtDepartmentName.Text}", "Department Register").DialogResult != DialogResult.No)
            {
                this.DialogResult = DialogResult.OK;
                Department department = new Department() { DeptId = "", Deptname = txtDepartmentName.Text.Trim() };
                string JSON = JsonConvert.SerializeObject(department);
                string Url = ApiRouting.GetUrl("", "", "department", ApiFunction.Add).ToString();
                bool confirm = Url.Post<Department>(JSON);
                if (confirm)
                {
                    var objDept = Singleton.Instance.Container.Resolve<MainView>("department");
                    objDept.Init();
                }
                    
            }
            else
                this.DialogResult = DialogResult.No;
        }

        private void TxtDepartmentName_TextChanged(object sender, EventArgs e)
        {
            if (txtDepartmentName.TextLength > 0)
                btnSubmit.Enabled = true;
            else
                btnSubmit.Enabled = false;
        }
    }
}
