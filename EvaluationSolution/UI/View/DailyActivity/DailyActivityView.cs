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

namespace EvaluationSolution.UI.View.DailyActivity
{
    public partial class DailyActivityView : MainView
    {
        public DailyActivityView()
        {
            InitializeComponent();
            List<VAllDailyActivity> listAllDActivity = new List<VAllDailyActivity>();
            listAllDActivity.Add(new VAllDailyActivity()
            {
                No = "001",
                Date = "12/07/2019",
                Staff = "Kimhong",
                Score = "90",
                Department = "Programming",
                Office = "C2B3",
                Status = "Approved"
            });
            listAllDActivity.Add(new VAllDailyActivity()
            {
                No = "002",
                Date = "13/07/2019",
                Staff = "Kimhong",
                Score = "80",
                Department = "Programming",
                Office = "C2B3",
                Status = "Approved"
            });
            listAllDActivity.Add(new VAllDailyActivity()
            {
                No = "003",
                Date = "12/07/2019",
                Staff = "Visal",
                Score = "80",
                Department = "Networking",
                Office = "N2B3",
                Status = "Approved"
            });
            listAllDActivity.Add(new VAllDailyActivity()
            {
                No = "004",
                Date = "12/07/2019",
                Staff = "Seyla",
                Score = "90",
                Department = "Media",
                Office = "M2B1",
                Status = "Pending"
            });
            listAllDActivity.Add(new VAllDailyActivity()
            {
                No = "001",
                Date = "12/07/2019",
                Staff = "Phearith",
                Score = "75",
                Department = "Programming",
                Office = "P2B2",
                Status = "Pending"
            });
            dataGridMain.DataSource = listAllDActivity;
            foreach(DataGridViewRow dt in dataGridMain.Rows)
            {
                if ((string)dt.Cells["Status"].Value == "Pending")
                {
                    dt.DefaultCellStyle.BackColor = Color.Red;
                    dt.DefaultCellStyle.ForeColor = Color.White;
                }

            }
        }

        private void MetroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void MetroLabel2_Click(object sender, EventArgs e)
        {

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
            DailyActivityDetail dailyActivityDetail = new DailyActivityDetail();
            dailyActivityDetail.ShowDialog();
        }
    }
}
