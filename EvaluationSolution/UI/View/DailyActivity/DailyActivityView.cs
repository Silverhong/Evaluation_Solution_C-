using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EvaluationSolution.Entity;
using EvaluationSolution.Infrastructure;

namespace EvaluationSolution.UI.View.DailyActivity
{
    public partial class DailyActivityView : MainView
    {
        List<VAllDailyActivity> listAllDActivity;
        public DailyActivityView()
        {
            InitializeComponent();
            listAllDActivity = new List<VAllDailyActivity>();
        }
        public override void Init()
        {
            string url = ApiRouting.GetUrl("", "", "dailyactivity", ApiFunction.GetAllByManager).ToString() + "?StaffId=" + GlobalVariable.StaffID;
            bool confirm = url.Get<VAllDailyActivity>(ref listAllDActivity);
            dataGridMain.DataSource = listAllDActivity;
            foreach (DataGridViewRow dt in dataGridMain.Rows)
            {
                if ((string)dt.Cells["Status"].Value == "Pending")
                {
                    dt.DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }
        private void DataGridMain_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridMain.ClearSelection();
        }

        private void DataGridMain_Leave(object sender, EventArgs e)
        {
            dataGridMain.ClearSelection();
        }
        private void DataGridMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string No = dataGridMain.Rows[e.RowIndex].Cells[0].Value.ToString();
            string Date = dataGridMain.Rows[e.RowIndex].Cells[1].Value.ToString();
            string Staff = dataGridMain.Rows[e.RowIndex].Cells[2].Value.ToString();
            string Score = dataGridMain.Rows[e.RowIndex].Cells[3].Value.ToString();
            string Department = dataGridMain.Rows[e.RowIndex].Cells[4].Value.ToString();
            string Office = dataGridMain.Rows[e.RowIndex].Cells[5].Value.ToString();
            string Status = dataGridMain.Rows[e.RowIndex].Cells[6].Value.ToString();
            string[] st = { No, Date, Staff, Score, Department, Office, Status };
            DailyActivityDetail dailyActivityDetail = new DailyActivityDetail(st);
            dailyActivityDetail.ShowDialog();
        }
    }
}
