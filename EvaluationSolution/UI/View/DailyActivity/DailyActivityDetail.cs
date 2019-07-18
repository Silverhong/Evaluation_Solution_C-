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

namespace EvaluationSolution.UI.View.DailyActivity
{
    public partial class DailyActivityDetail : MetroForm
    {
        public DailyActivityDetail()
        {
            InitializeComponent();
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
            dataGridMain.DataSource = listVAddActivity;
        }
    }
}
