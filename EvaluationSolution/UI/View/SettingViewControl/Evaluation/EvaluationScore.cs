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

namespace EvaluationSolution.UI.View.SettingViewControl.Evaluation
{
    public partial class EvaluationScore : MainView
    {
        public EvaluationScore()
        {
            InitializeComponent();
            List<VEvaluationScore> listStaff = new List<VEvaluationScore>();
            listStaff.Add(new VEvaluationScore()
            {
                No = "001",
                ID = "S001",
                SName = "Kimhong",
                Gender = "Male",
                Rank = "1"
            });
            listStaff.Add(new VEvaluationScore()
            {
                No = "002",
                ID = "S002",
                SName = "Kimkheang",
                Gender = "Male",
                Rank = "2"
            });
            listStaff.Add(new VEvaluationScore()
            {
                No = "003",
                ID = "S003",
                SName = "Visal",
                Gender = "Male",
                Rank = "3"
            });
            listStaff.Add(new VEvaluationScore()
            {
                No = "004",
                ID = "S004",
                SName = "Seyla",
                Gender = "Male",
                Rank = "4"
            });
            listStaff.Add(new VEvaluationScore()
            {
                No = "005",
                ID = "S005",
                SName = "Phearith",
                Gender = "Male",
                Rank = "5"
            });
            listStaff.Add(new VEvaluationScore()
            {
                No = "006",
                ID = "S008",
                SName = "Rith",
                Gender = "Male",
                Rank = "6"
            });
            listStaff.Add(new VEvaluationScore()
            {
                No = "007",
                ID = "S007",
                SName = "Somnang",
                Gender = "Male",
                Rank = "7"
            });
            listStaff.Add(new VEvaluationScore()
            {
                No = "008",
                ID = "S008",
                SName = "JingJing",
                Gender = "Female",
                Rank = "8"
            });
            listStaff.Add(new VEvaluationScore()
            {
                No = "009",
                ID = "S009",
                SName = "Makara",
                Gender = "Male",
                Rank = "9"
            });
            listStaff.Add(new VEvaluationScore()
            {
                No = "0010",
                ID = "S0010",
                SName = "Ratanak",
                Gender = "Male",
                Rank = "10"
            });
            dataGridMain.DataSource = listStaff;
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
