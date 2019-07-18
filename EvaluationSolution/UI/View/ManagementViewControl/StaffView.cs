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
    public partial class StaffView : MainView
    {
        public StaffView()
        {
            InitializeComponent();
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
                Department = "Network"
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
                Position = "Senior Media Creator",
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
            dataGridMain.DataSource = listStaff;
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
    }
}
