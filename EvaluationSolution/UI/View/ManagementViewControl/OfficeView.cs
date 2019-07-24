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

        private void BtnAddOffice_Click(object sender, EventArgs e)
        {
            AddOfficeForm addOffice = new AddOfficeForm();
            addOffice.ShowDialog();
        }
        public override void Init()
        {
            bool status = ApiRouting.GetUrl("", "", "office", ApiFunction.GetAll).ToString().Get<Office>(dataGridMain);
            MessageBox.Confirm(status,"office",dataGridMain);
        }

        private void DataGridMain_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridMain.ClearSelection();
        }
    }
}
