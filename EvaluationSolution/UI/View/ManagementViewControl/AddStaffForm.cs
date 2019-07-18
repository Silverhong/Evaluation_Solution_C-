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
    public partial class AddStaffForm : MetroForm
    {
        public AddStaffForm()
        {
            InitializeComponent();
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            btnSubmit.DialogResult = DialogResult.OK;
            if (MessageBox.Show("Do you want to cancel the recruitment ?", "Staff Recruitment").DialogResult == DialogResult.OK)
            {
                this.Dispose();
            }
        }

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            Dispose();
            AddStaffForm addStaff = new AddStaffForm();
            addStaff.ShowDialog();
        }

        private void ComboDepartment_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboDepartment.SelectedItem.ToString() == "Add New..")
            {
                AddDepartmentForm dp = new AddDepartmentForm();
                dp.ShowDialog();
            }
        }
    }
}
