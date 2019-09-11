using EvaluationSolution.Entity;
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

namespace EvaluationSolution.UI.Forms
{
    public partial class DailyActivities : MetroForm 
    {
        List<VDailyActivities> listDAct;
        public DailyActivities()
        {
            InitializeComponent();
            listDAct = new List<VDailyActivities>();
            Init();
        }
        private void ConfigureGridAct()
        {
            foreach(DataGridViewRow dgvr in dataGridActivities.Rows)
            {
                if ((string)dgvr.Cells["Status"].Value == "Pending")
                {
                    dgvr.DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }
        public void Init()
        {
            string url = ApiRouting.GetUrl("", "", "dailyactivity", ApiFunction.GetAll).ToString() + "?StaffId=" + GlobalVariable.StaffID;
            bool confirm = url.Get<VDailyActivities>(ref listDAct);
            if (!confirm)
            {
                MessageBox.Show("Cannot connect to server!");
                return;
            }
            dataGridActivities.DataSource = listDAct;
            ConfigureGridAct();
        }
        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            AddDailyActivities dailyActivities = new AddDailyActivities(this);
            dailyActivities.ShowDialog();
        }
        private void DailyActivities_Load(object sender, EventArgs e)
        {
            ConfigureGridAct();
        }
        private void DataGridActivities_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridActivities.ClearSelection();
        }
        private void DataGridActivities_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            List<VAddActivity> listVAddActivity = new List<VAddActivity>();
            int index = e.RowIndex;
            int i = 1;
            if (index == -1)
                return;
            foreach(VDailyActivitiesDetail obj in listDAct[index].details)
            {
                listVAddActivity.Add(new VAddActivity()
                {
                    No=i+"",
                    Description=obj.Description
                });
                i++;
            }
            dataGridActivityDetail.DataSource = null;
            dataGridActivityDetail.DataSource = listVAddActivity;
        }
        private void DataGridActivityDetail_Leave(object sender, EventArgs e)
        {
            dataGridActivityDetail.ClearSelection();
        }

        private void DataGridActivityDetail_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridActivityDetail.ClearSelection();
        }
    }
}
