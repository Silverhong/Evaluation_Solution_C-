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
        private string[] st;
        public SelectStaff(string[] st)
        {
            InitializeComponent();
            this.st=st;
            List<VStaff> listStaff = new List<VStaff>();
            int i = 1;
            listStaff.Add(new VStaff()
            {
                ID = i + "",
                Name = "Kimhong",
                Address = "Phnom Penh",
                DateOfBirth = "06/06/1999",
                Email = "kimhongvuthy@gmail.com",
                Gender = "Male",
                PlaceOfBirth = "Prey Veng",
                Position = "IT Manager",
                Department = "Project Development"
            });
            i++;
            listStaff.Add(new VStaff()
            {
                ID = i + "",
                Name = "Visal",
                Address = "Phnom Penh",
                DateOfBirth = "06/06/1999",
                Email = "kimhongvuthy@gmail.com",
                Gender = "Male",
                PlaceOfBirth = "Prey Veng",
                Position = "Network Engineer",
                Department="Network"
            });
            i++;
            listStaff.Add(new VStaff()
            {
                ID = i + "",
                Name = "Seyla",
                Address = "Phnom Penh",
                DateOfBirth = "06/06/1999",
                Email = "kimhongvuthy@gmail.com",
                Gender = "Male",
                PlaceOfBirth = "Prey Veng",
                Position="Senior Media Creator",
                Department = "Media"
            });
            i++;
            listStaff.Add(new VStaff()
            {
                ID = i + "",
                Name = "Kheang",
                Address = "Phnom Penh",
                DateOfBirth = "06/06/1999",
                Email = "kimhongvuthy@gmail.com",
                Gender = "Male",
                PlaceOfBirth = "Prey Veng",
                Position = "Senior Network Security",
                Department = "Network"
            });
            dataGridMain.DataSource = listStaff.Select(y => new { y.ID, y.Name, y.Position ,y.Department}).ToList();
            dataGridMain.Columns.Add(new DataGridViewCheckBoxColumn() { HeaderText = "Selected", Name = "Selected", TrueValue = true, FalseValue = false,Selected=false });
            foreach (DataGridViewColumn col in dataGridMain.Columns)
            {
                if (col.HeaderText != "Selected")
                    col.ReadOnly = true;
            }
            dataGridMain.AutoGenerateColumns = true;
            dataGridMain.Rows[1].Cells[4].Value = true;
        }
        public void SelectedStaff()
        {
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

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to cancel Question Selection ?", "Question Selection").DialogResult == DialogResult.OK)
            {
                this.Dispose();
            }
        }

        private void DataGridMain_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridMain.ClearSelection();
        }

        private void SelectStaff_Load(object sender, EventArgs e)
        {
            SelectedStaff();
        }
    }
}
