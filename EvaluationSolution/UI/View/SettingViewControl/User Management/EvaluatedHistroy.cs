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

namespace EvaluationSolution.UI.View.SettingViewControl.User_Management
{
    public partial class EvaluatedHistroy : MetroForm
    {
        public EvaluatedHistroy()
        {
            InitializeComponent();
            List<VEvaluationHistory> listEvH = new List<VEvaluationHistory>();
            listEvH.Add(new VEvaluationHistory() { No = 1, Description = "វាយតម្លៃប្រចាំខែ ឧសភា",  Duration= "01/05/2019 - 31/05/2019", Status = "Completed" });
            listEvH.Add(new VEvaluationHistory() { No = 2, Description = "វាយតម្លៃប្រចាំខែ មិថុនា", Duration = "01/06/2019 - 31/07/2019", Status = "Completed" });
            listEvH.Add(new VEvaluationHistory() { No = 3, Description = "វាយតម្លៃប្រចាំខែ កក្កដា", Duration = "01/07/2019 - 31/08/2019", Status = "Pending" });
            dataGridMain.DataSource = listEvH;
            
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(StaticMessage.CancelMessage, StaticMessage.CancelSelectTitle).DialogResult == DialogResult.OK)
                this.Dispose();
        }

        private void EvaluatedHistroy_Load(object sender, EventArgs e)
        {
            dataGridMain.Rows[dataGridMain.RowCount - 1].DefaultCellStyle.BackColor = Color.Red;
            dataGridMain.Rows[dataGridMain.RowCount - 1].DefaultCellStyle.ForeColor = Color.White;
        }
    }
}
