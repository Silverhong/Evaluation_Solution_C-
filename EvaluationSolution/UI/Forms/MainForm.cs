using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using EvaluationSolution.Infrastructure;
using EvaluationSolution.Entity;
using EvaluationSolution.UI.View;
using EvaluationSolution.UI.View.ManagementViewControl;

namespace EvaluationSolution.UI.Forms
{
    public partial class MainForm : MetroForm
    {
        private DateTime dt = DateTime.Now;
        int second, minute, hour;
        string TT = "AM";
        public MainForm()
        {
            InitializeComponent();
            using(LoginForm login = new LoginForm())
            {
                lbDate.Text = dt.Date.ToShortDateString();
                lbTime.Text = dt.ToString("hh:mm:ss tt");
                second = dt.Second;
                minute = dt.Minute;
                hour = dt.Hour;
                tTime.Start();
                if (login.ShowDialog() == DialogResult.OK)
                {

                }
                else
                    Environment.Exit(1);
                
            }   
        }
        private void CurrentDateTime()
        {
            second++;
            if (second > 59)
            {
                second -= 59;
                minute++;
            }
            if (minute > 59)
            {
                minute -= 59;
                hour++;
            }
            if (hour > 12)
            {
                hour -= 12;
                TT = "PM";
            }
            lbTime.Text = $"{hour.ToString("00")}:{minute.ToString("00")}:{second.ToString("00")} {TT}";
        }
        private void Menu_Checked(object sender,EventArgs e)
        {
            string name = ((RadioButton)sender).Text.ToLower().ToString();
            var view = Singleton.Instance.Container.Resolve<MainView>(name);
            view.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(view);
        }
        private void LbLoginAs_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
        private void TTime_Tick(object sender, EventArgs e)
        {
            CurrentDateTime();
        }
    }
}
