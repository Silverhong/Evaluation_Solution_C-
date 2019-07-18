using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluationSolution.UI.Forms
{
    public partial class RegisterCompanyForm : MetroFramework.Forms.MetroForm
    {
        public RegisterCompanyForm()
        {
            InitializeComponent();
        }

        private void MetroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to cancel the registration ?", "Cannel Confirmation").DialogResult == DialogResult.OK)
            {
                this.Dispose();
            }
        }
    }
}
