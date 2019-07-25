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

namespace EvaluationSolution.UI.View.ManagementViewControl
{
    public partial class StaffView : MainView
    {
        public StaffView()
        {
            InitializeComponent();
            List<VStaff> listStaff = new List<VStaff>();
            bool confirm = ApiRouting.GetUrl("", "", "staff", ApiFunction.GetAll).ToString().Get<VStaff>(ref listStaff);
            if (confirm)
            {
                dataGridMain.DataSource = listStaff;
            }
        }

        private void BtnAddStaff_Click(object sender, EventArgs e)
        {
            using (AddStaffForm add = new AddStaffForm())
            {
                add.ShowDialog();
            }
        }
        private void DataGridMain_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridMain.ClearSelection();
        }
        public override void Init()
        {
            List<VStaff> listStaff = new List<VStaff>();
            bool confirm = ApiRouting.GetUrl("", "", "staff", ApiFunction.GetAll).ToString().Get<VStaff>(ref listStaff);
            if (confirm)
            {
                dataGridMain.DataSource = listStaff;
                MessageBox.Confirm(confirm, "staff", dataGridMain);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int index = dataGridMain.CurrentCell.RowIndex;
            string StaffId = dataGridMain.Rows[index].Cells[0].Value.ToString();
            Staff staff = new Staff()
            {
                CreatedBy ="",
                CurrentAddress = "",
                DeptID = "",
                Dob = "",
                Email = "",
                OfficeId = "",
                Phone = "",
                Pid = "",
                Pob = "",
                SName = "",
                Sex = "",
                UserGroupID = "",
                StaffId = StaffId
            };
            string queryString = staff.GetQueryString<Staff>();
            string url = ApiRouting.GetUrl("", "", "staff", ApiFunction.DeleteById).ToString() + queryString;
            bool confirm = url.Detete<Staff>();
            if (confirm)
            {
                MessageBox.Show("Deleted Successful", "Deleted Successful");
                Init();
            }
        }
    }
}
