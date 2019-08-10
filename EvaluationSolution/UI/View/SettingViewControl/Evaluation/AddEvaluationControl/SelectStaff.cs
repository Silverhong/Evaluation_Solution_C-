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

namespace EvaluationSolution.UI.View.SettingViewControl.Evaluation.AddEvaluationControl
{
    public partial class SelectStaff : MetroForm
    {
        List<VDepartment> listDepartment;
        List<VOffice> listOffice;
        List<VStaff> listStaff;
        AddEvaluation obj;
        public SelectStaff()
        {
            InitializeComponent();
            obj = Singleton.Instance.Container.Resolve<AddEvaluation>();
            listDepartment = new List<VDepartment>();
            listOffice = new List<VOffice>();
            listStaff = new List<VStaff>();
            bool conDepartment = ApiRouting.GetUrl("", "", "department", ApiFunction.GetAll).ToString().Get<VDepartment>(ref listDepartment);
            bool conOffice = ApiRouting.GetUrl("", "", "office", ApiFunction.GetAll).ToString().Get<VOffice>(ref listOffice);
            bool conStaff = ApiRouting.GetUrl("", "", "staff", ApiFunction.GetAll).ToString().Get<VStaff>(ref listStaff);
            dataGridMain.DataSource = listStaff.Select(x => new { ID = x.StaffId, Name = x.Sname, Office = x.OfficeId, Department = x.DeptId }).ToList();
            comboDepartment.DataSource = listDepartment.Select(x => x.Deptname).ToList();
            comboOffice.DataSource = listOffice.Select(x => x.OfficeName).ToList();
            dataGridMain.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridMain.AutoGenerateColumns = false;
            dataGridMain.Columns.Add(new DataGridViewCheckBoxColumn() { HeaderText = "Selected", Name = "Selected", TrueValue = true, FalseValue = false });
            dataGridMain.Columns[dataGridMain.Columns.Count - 1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            foreach (DataGridViewColumn col in dataGridMain.Columns)
            {
                if (col.HeaderText != "Selected")
                    col.ReadOnly = true;
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            List<VStaff> newList = new List<VStaff>();
            int i = 1;
            foreach (DataGridViewRow obj in dataGridMain.Rows)
            {
                bool confirm = obj.Cells["Selected"].Value == null ? false : (bool)obj.Cells["Selected"].Value;
                if (confirm)
                {
                    newList.Add(new VStaff()
                    {
                        StaffId = obj.Cells[0].Value.ToString(),
                        Sname = obj.Cells[1].Value.ToString(),
                        OfficeId = obj.Cells[2].Value.ToString(),
                        DeptId = obj.Cells[3].Value.ToString(),
                    });
                }
                else
                    continue;
            }
            obj.AddToDatagridStaff(newList);
            this.Close();
        }

        private void DataGridMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridMain.CurrentCell.RowIndex;
            bool? con = (bool?)dataGridMain["Selected", index].Value;
            if (con.HasValue && con.Value == true)
            {
                dataGridMain.Rows[index].Cells["Selected"].Value = false;
                dataGridMain.Rows[index].DefaultCellStyle.ForeColor = Color.Black;
            }
            else
            {
                dataGridMain.Rows[index].Cells["Selected"].Value = true;
                dataGridMain.Rows[index].DefaultCellStyle.ForeColor = Color.Red;
            }
        }
    }
}
