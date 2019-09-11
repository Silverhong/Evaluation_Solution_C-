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

namespace EvaluationSolution.UI.View.DailyActivity
{
    public partial class DailyActivityDetail : MetroForm
    {
        string StaDAId = "";
        List<VDailyActivitiesNoQuestion> listVAddActivity;
        public DailyActivityDetail(string[] st)
        {
            InitializeComponent();
            listVAddActivity = new List<VDailyActivitiesNoQuestion>();
            lbNo.Text = st[0];
            lbDate.Text = st[1];
            lbStaff.Text = st[2];
            lbScore.Text = st[3];
            lbDepartment.Text = st[4];
            lbOffice.Text = st[5];
            this.StaDAId = st[0];
            Init();
        }
        public void Init()
        {
            string url = ApiRouting.GetUrl("", "", "dailyactivitydetail", ApiFunction.GetByStaDAId).ToString() + "?StaDAId=" + StaDAId;
            bool confirm = url.Get<VDailyActivitiesNoQuestion>(ref listVAddActivity);
            if (!confirm)
            {
                MessageBox.Show("Cannot connect to server!!");
                return;
            }
            dataGridMain.DataSource = listVAddActivity;
        }
    }
}
