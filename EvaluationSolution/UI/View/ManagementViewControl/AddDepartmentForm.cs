using EvaluationSolution.Infrastructure;
using MetroFramework.Forms;
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
            using(ConditionSetting condition = new ConditionSetting())
            {
                if (condition.isInput(txtDepartmentName))
                {
                    MessageBox.Show("Hello");
                }
            }
        }
    }
}
