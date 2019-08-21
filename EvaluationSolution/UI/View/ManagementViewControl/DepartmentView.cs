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
    public partial class DepartmentView : MainView
    {
        public DepartmentView()
        {
            InitializeComponent();
        }
        private void BtnAddDepartment_Click(object sender, EventArgs e)
        {
            using (AddDepartmentForm addDepartment = new AddDepartmentForm())
            {
                if (addDepartment.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }
        public override void Init()
        {
            List<VDepartment> list = new List<VDepartment>();
            string url = ApiRouting.GetUrl("", "", "department", ApiFunction.GetAll).ToString();
            bool status = url.Get<VDepartment>(ref list);
            dataGridMain.DataSource = list;
            MessageBox.Confirm(status, "department", dataGridMain);
        }

        private void DataGridMain_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridMain.ClearSelection();
        }

        private void BtnDeleteDepartment_Click(object sender, EventArgs e)
        {
            int index = dataGridMain.CurrentCell.RowIndex;
            string id = dataGridMain.Rows[index].Cells[0].Value.ToString();
            Department department = new Department() { Deptname = "", DeptId = id };
            string QueryString = department.GetQueryString<Department>();
            string url = ApiRouting.GetUrl("", "", "department", ApiFunction.DeleteById).ToString() + QueryString;
            bool confirm = url.Detete<Department>();
            if (confirm)
                this.Init();
        }
    }
}
