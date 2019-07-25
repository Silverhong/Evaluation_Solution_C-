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
