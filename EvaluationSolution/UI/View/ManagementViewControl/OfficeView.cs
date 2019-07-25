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
    public partial class OfficeView : MainView
    {
        public OfficeView()
        {
            InitializeComponent();
        }
        public DataGridView dataGrid
        {
            get => dataGridMain;
        }
        private void BtnAddOffice_Click(object sender, EventArgs e)
        {
            AddOfficeForm addOffice = new AddOfficeForm();
            addOffice.ShowDialog();
        }
        public override void Init()
        {
            List<VOffice> list = new List<VOffice>();
            bool status = ApiRouting.GetUrl("", "", "office", ApiFunction.GetAll).ToString().Get<VOffice>(ref list);
            dataGridMain.DataSource = list;
            MessageBox.Confirm(status,"office",dataGridMain);
        }

        private void DataGridMain_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridMain.ClearSelection();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int index = dataGridMain.CurrentCell.RowIndex;
            string officeId = dataGridMain.Rows[index].Cells[0].Value.ToString();
            string officeName = dataGridMain.Rows[index].Cells[1].Value.ToString();
            Office office = new Office() { OfficeId = officeId, DeptId = "", OfficeName = "" };
            string queryString = office.GetQueryString<Office>();
            string url = ApiRouting.GetUrl("", "", "office", ApiFunction.DeleteById).ToString() + queryString;
            bool confirm = url.Detete<Office>();
            if (confirm)
            {
                MessageBox.Show($"Office : {officeName} was deleted successfull.","Delete Successful");
                Init();
            }
            else
            {
                MessageBox.Show("Connection Error!","Error!");
            }
        }
    }
}
