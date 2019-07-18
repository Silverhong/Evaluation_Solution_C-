using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EvaluationSolution.Infrastructure;
using MetroFramework.Forms;

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
            this.DialogResult = DialogResult.OK;
        }
        private void LbRegCompany_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterCompanyForm register = new RegisterCompanyForm();
            register.ShowDialog();
        }
    }
}
