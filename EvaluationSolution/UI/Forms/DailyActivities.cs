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
    public partial class DailyActivities : MetroForm 
    {
        List<VDailyActivities> listDAct;
        public DailyActivities()
        {
            InitializeComponent();
            listDAct = new List<VDailyActivities>();
            listDAct.Add(new VDailyActivities() { No = "001", Date = "01/07/2019", Score = "60", Status = "Approved" });
            listDAct.Add(new VDailyActivities() { No = "002", Date = "02/07/2019", Score = "70", Status = "Approved" });
            listDAct.Add(new VDailyActivities() { No = "003", Date = "03/07/2019", Score = "65", Status = "Approved" });
            listDAct.Add(new VDailyActivities() { No = "004", Date = "04/07/2019", Score = "70", Status = "Approved" });
            listDAct.Add(new VDailyActivities() { No = "005", Date = "05/07/2019", Score = "80", Status = "Pending" });
            dataGridActivities.DataSource = listDAct;
            
        }
        private void AddDataGridDetail()
        {

        }
        private void ConfigureGridAct()
        {
            foreach(DataGridViewRow dgvr in dataGridActivities.Rows)
            {
                if ((string)dgvr.Cells["Status"].Value == "Pending")
                {
                    dgvr.DefaultCellStyle.BackColor = Color.Red;
                    dgvr.DefaultCellStyle.ForeColor = Color.White;
                }
                   
            }
        }
        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            AddDailyActivities dailyActivities = new AddDailyActivities();
            dailyActivities.ShowDialog();
        }

        private void DailyActivities_Load(object sender, EventArgs e)
        {
            ConfigureGridAct();
        }

        private void DataGridActivityDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DataGridActivities_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridActivities.ClearSelection();
        }

        private void DataGridActivities_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 1)
            {
                List<VAddActivity> listVAddActivity = new List<VAddActivity>()
            {
                new VAddActivity()
                {
                    No="001",
                    Description="Complete Purchase Order"
                },
                new VAddActivity()
                {
                    No="002",
                    Description="Add Fixed Asset"
                },
                new VAddActivity()
                {
                    No="003",
                    Description="Fix some technical issues"
                },
            };
                dataGridActivityDetail.DataSource = listVAddActivity;
                return;
            }
            dataGridActivityDetail.DataSource = null;
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
