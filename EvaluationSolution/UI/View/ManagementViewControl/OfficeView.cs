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
    public partial class OfficeView : MainView
    {
        public OfficeView()
        {
            InitializeComponent();
            List<Office> listOffice = new List<Office>();
            listOffice.Add(new Office() { OfficeId = "001", Officename = "Programming B1",Department="Programming" });
            listOffice.Add(new Office() { OfficeId = "002", Officename = "Programming B2", Department = "Programming" });
            listOffice.Add(new Office() { OfficeId = "003", Officename = "Design C1", Department = "Media" });
            listOffice.Add(new Office() { OfficeId = "004", Officename = "Design C2", Department = "Media" });
            listOffice.Add(new Office() { OfficeId = "005", Officename = "Accounting D1", Department = "Accounting" });
            listOffice.Add(new Office() { OfficeId = "006", Officename = "Accounting D2", Department = "Accounting" });
            dataGridMain.DataSource = listOffice.Select(x => new { ID = x.OfficeId, Office = x.Officename,x.Department }).ToList();
        }

        private void BtnAddOffice_Click(object sender, EventArgs e)
        {
            AddOfficeForm addOffice = new AddOfficeForm();
            addOffice.ShowDialog();
        }
    }
}
