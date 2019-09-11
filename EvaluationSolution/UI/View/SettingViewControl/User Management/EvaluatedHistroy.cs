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
        List<VEvaluationHistoryOnStaff> listEvH = new List<VEvaluationHistoryOnStaff>();
        public EvaluatedHistroy()
        {
            InitializeComponent();
            string url = ApiRouting.GetUrl("", "", "assignstaff", ApiFunction.GetEvByStaffId).ToString() + "?StaffId=" + GlobalVariable.StaffID;
            bool confirm = url.Get<VEvaluationHistoryOnStaff>(ref listEvH);
            if (confirm)
                dataGridMain.DataSource = listEvH.Select(x=>new { ID = x.EvId, Description = x.EvDescription, Duration = x.duration, Status = x.Status }).ToList();
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(StaticMessage.CancelMessage, StaticMessage.CancelSelectTitle).DialogResult == DialogResult.OK)
                this.Dispose();
        }

        private void EvaluatedHistroy_Load(object sender, EventArgs e)
        {
            //dataGridMain.Rows[dataGridMain.RowCount - 1].DefaultCellStyle.BackColor = Color.Red;
            //dataGridMain.Rows[dataGridMain.RowCount - 1].DefaultCellStyle.ForeColor = Color.White;
        }
    }
}
