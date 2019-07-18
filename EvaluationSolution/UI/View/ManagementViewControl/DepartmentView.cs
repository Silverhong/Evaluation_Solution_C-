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

namespace EvaluationSolution.UI.View.ManagementViewControl
{
    public partial class DepartmentView : MainView
    {
        public DepartmentView()
        {
            InitializeComponent();
            List<Department> listDept = new List<Department>();
            listDept.Add(new Department() { DeptId = "001", Deptname = "Programming" });
            listDept.Add(new Department() { DeptId = "002", Deptname = "Networking" });
            listDept.Add(new Department() { DeptId = "003", Deptname = "Accounting" });
            listDept.Add(new Department() { DeptId = "004", Deptname = "Marketing" });
            dataGridMain.DataSource = listDept.Select(x => new { ID = x.DeptId, Department = x.Deptname }).ToList();
        }

        private void BtnAddDepartment_Click(object sender, EventArgs e)
        {
            AddDepartmentForm addDepartment = new AddDepartmentForm();
            addDepartment.ShowDialog();
        }
    }
}
