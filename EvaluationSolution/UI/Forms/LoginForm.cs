using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EvaluationSolution.Entity;
using EvaluationSolution.Infrastructure;
using MetroFramework.Forms;
using Newtonsoft.Json;

namespace EvaluationSolution.UI.Forms
{
    public partial class LoginForm : MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtCompany.Text.Length == 0 || txtUsername.Text.Length == 0 || txtPassword.Text.Length == 0)
            {
                MessageBox.Show("Incorrect Input!!");
                return;
            }
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string company = txtCompany.Text.Trim();
            
            RegisterCompany registerCompany = new RegisterCompany()
            {
                Regcom_name = company
            };
            string queryString = registerCompany.GetQueryString<RegisterCompany>();
            string companyUrl = ApiRouting.GetUrl("", "", "company", ApiFunction.checkExist).ToString()+queryString;
            string respondJson = "";
            bool statusCompany = companyUrl.Get<RegisterCompany>(ref respondJson);
            if (!statusCompany)
            {
                MessageBox.Show("Cannot Connect ot Server!!");
                return;
            }
            RegisterCompany obj = new RegisterCompany();
            string companyId = "";
            if (respondJson != "0")
            {
                obj = JsonConvert.DeserializeObject<RegisterCompany>(respondJson);
                companyId = obj.Regcom_id;
            }
            else
                companyId = respondJson;
            if (companyId == "0")
            {
                MessageBox.Show("Invalid Company!!");
                return;
            }
            string url = ApiRouting.GetUrl("", "", "user", ApiFunction.checkExist).ToString();
            UserAccount userAccount = new UserAccount()
            {
                Created_date = "",
                Password = password,
                Regcom_id = companyId,
                Role = "",
                StaffId = "",
                Status = "",
                Userid = "",
                Username = username
            };
            string json = JsonConvert.SerializeObject(userAccount);
            string response = "";
            bool status = url.Post<UserAccount>(json,ref response);
            if (response == "Unsuccessfull")
            {
                MessageBox.Show("Incorrect Username or Password!", "Incorrect");
            }
            else
            {
                UserAccount userObj = JsonConvert.DeserializeObject<UserAccount>(response);
                GlobalVariable.Role = userObj.Role;
                GlobalVariable.LoginStaffName = username;
                GlobalVariable.StaffID = JsonConvert.DeserializeObject<UserAccount>(response).StaffId;
                MessageBox.Show("Wellcome to Evaluation Solution.");
                this.DialogResult = DialogResult.OK;
            }
        }
        private void LbRegCompany_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterCompanyForm register = new RegisterCompanyForm();
            register.ShowDialog();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
