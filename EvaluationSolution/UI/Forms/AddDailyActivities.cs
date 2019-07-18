using EvaluationSolution.Entity;
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

namespace EvaluationSolution.UI.Forms
{
    public partial class AddDailyActivities : MetroForm
    {
        List<VAddActivity> listAddAct;
        int id = 1;
        public AddDailyActivities()
        {
            InitializeComponent();
            listAddAct = new List<VAddActivity>();
        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void BtnAddActivity_Click(object sender, EventArgs e)
        {
            if (txtActivity.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please input your activity!!", "Activity Missing");
                return;
            }
            string activity = txtActivity.Text.Trim();
            listAddAct.Add(new VAddActivity() { No = id.ToString("000"), Description = activity });
            dataGridActivity.DataSource = null;
            dataGridActivity.DataSource = listAddAct;
            txtActivity.Text = "";
            txtActivity.Focus();
            id++;
        }

        private void DataGridActivity_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridActivity.ClearSelection();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to cancel submitting daily activity ?","Cancel Confirmation").DialogResult == DialogResult.OK)
            {
                this.Dispose();
            }
        }
    }
}
