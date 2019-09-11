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

namespace EvaluationSolution.UI.Forms
{
    public partial class AddDailyActivities : MetroForm
    {
        List<VAddActivity> listAddAct;
        DailyActivities DailyActivities;
        int id = 1;
        public AddDailyActivities(DailyActivities dailyActivities)
        {
            InitializeComponent();
            this.DailyActivities = dailyActivities;
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

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to submit your daily activity ?", "Confirmation").DialogResult == DialogResult.No)
                return;
            DailyActivitiesOnStaff dailyActivitiesOnStaff = new DailyActivitiesOnStaff();
            dailyActivitiesOnStaff.details = new List<DailyActivitiesDetail>();
            dailyActivitiesOnStaff.ApprovedBy = "";
            dailyActivitiesOnStaff.ApprovedDate = "";
            dailyActivitiesOnStaff.ApprovedScore = "";
            dailyActivitiesOnStaff.Date = DateTime.Now.ToShortDateString();
            dailyActivitiesOnStaff.StaffId = GlobalVariable.StaffID;
            dailyActivitiesOnStaff.Status = "Pending";
            dailyActivitiesOnStaff.StaDAId = "";
            dailyActivitiesOnStaff.TScore = txtScore.Text.Trim();
            foreach(DataGridViewRow row in dataGridActivity.Rows)
            {
                DailyActivitiesDetail dailyActivitiesDetail = new DailyActivitiesDetail();
                dailyActivitiesDetail.CreatedDate = DateTime.Now.ToShortTimeString();
                dailyActivitiesDetail.StaDAId = "";
                dailyActivitiesDetail.StaffId = GlobalVariable.StaffID;
                dailyActivitiesDetail.Description = row.Cells[1].Value.ToString();
                dailyActivitiesDetail.StaDADId = "";
                dailyActivitiesOnStaff.details.Add(dailyActivitiesDetail);
            }
            string json = JsonConvert.SerializeObject(dailyActivitiesOnStaff);
            string url = ApiRouting.GetUrl("", "", "dailyactivity", ApiFunction.Add).ToString();
            string response = "";
            bool confirm = url.Post<DailyActivitiesOnStaff>(json, ref response);
            if(confirm && response.ToLower() == "successful")
            {
                MessageBox.Show("Daily Activity Submitted Succesful!", "Succesful");
                DailyActivities.Init();
                Close();
            }
        }
    }
}
