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
            AddDepartmentForm addDepartment = new AddDepartmentForm();
            addDepartment.ShowDialog();
        }
        public override void Init()
        {
            bool status = ApiRouting.GetUrl("", "", "department", ApiFunction.GetAll).ToString().Get<Department>(dataGridMain);
            MessageBox.Confirm(status,"department",dataGridMain);
        }

        private void DataGridMain_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridMain.ClearSelection();
        }
    }
}
