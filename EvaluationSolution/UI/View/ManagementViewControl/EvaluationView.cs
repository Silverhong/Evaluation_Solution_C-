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
using EvaluationSolution.UI.View.SettingViewControl.User_Management;
using EvaluationSolution.UI.Forms;

namespace EvaluationSolution.UI.View.ManagementViewControl
{
    public partial class EvaluationView : MainView
    {
        DataTable dt = new DataTable();
        System.Windows.Forms.Control cell;
        private int lastCol = 1;
        private int lastRow = 0;
        bool isAlreadyTotal = false;
        bool isColoredTotal = false;
        public EvaluationView()
        {
            InitializeComponent();
            
            dt.Columns.Add(new DataColumn() { ReadOnly = true, ColumnName = "ចំណុចត្រូវវាយតម្លៃ"});
            dataGridMain.DataSource = dt;
            dt.Rows.Add("១- ការគោរពវិន័យ និងគោលការណ៍ការងារ");
            dt.Rows.Add("២- វត្តមាន និងការមកធ្វើការទៀងពេលវេលា");
            dt.Rows.Add("១- ការគោរពវិន័យ និងគោលការណ៍ការងារ");
            dt.Rows.Add("២- វត្តមាន និងការមកធ្វើការទៀងពេលវេលា");
            dt.Rows.Add("១- ការគោរពវិន័យ និងគោលការណ៍ការងារ");
            dt.Rows.Add("២- វត្តមាន និងការមកធ្វើការទៀងពេលវេលា");
            dt.Rows.Add("១- ការគោរពវិន័យ និងគោលការណ៍ការងារ");
            dt.Rows.Add("២- វត្តមាន និងការមកធ្វើការទៀងពេលវេលា");
            dt.Rows.Add("១- ការគោរពវិន័យ និងគោលការណ៍ការងារ");
            for (int i = 1; i <= 11; i++)
                dt.Columns.Add(new DataColumn() { ColumnName = i.ToString("0000"), DataType = typeof(string), AllowDBNull=true});
            dt.Rows.Add("Total");
            //dataGridMain.AutoGenerateColumns = true;
            ConfigureDataGrid();
        }
        public void ConfigureDataGrid()
        {
            dataGridMain.Columns[0].MinimumWidth = 400;
            dataGridMain.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridMain.Columns[0].DefaultCellStyle.Padding = new Padding(2, 1, 10, 1);
            foreach (DataGridViewColumn col in dataGridMain.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
                if (col.Index == 0)
                    continue;
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            }
        }
        private void DataGridMain_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //dataGridMain.ClearSelection();
        }
        private void DataGridMain_CurrentCellChanged(object sender, EventArgs e)
        {
            var cell = dataGridMain.CurrentCell;
            if (cell != null)
            {
                if (cell.RowIndex == dataGridMain.RowCount - 1 && cell.ColumnIndex > 0)
                {
                    dataGridMain.CurrentCell.ReadOnly = true;
                    dataGridMain.CurrentCell.Selected = false;
                }
                if (cell.ColumnIndex == 0)
                {
                    dataGridMain.CurrentCell.ReadOnly = true;
                    dataGridMain.CurrentCell.Selected = false;
                }
                if (cell.ColumnIndex > 0 && cell.RowIndex != dataGridMain.RowCount - 1)
                {
                    int value = int.Parse(dataGridMain[lastCol, lastRow].Value.ToString() == "" ? "0" : dataGridMain[lastCol, lastRow].Value.ToString());
                    if (value > 10)
                        dataGridMain[lastCol, lastRow].Value = 10;
                    TotalByCol(lastCol);
                }
            }
        }
        
        private void DataGridMain_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            cell = e.Control;
            cell.KeyPress += Cell_KeyPress;
            lastCol = dataGridMain.CurrentCell.ColumnIndex;
            lastRow = dataGridMain.CurrentCell.RowIndex;
        }
        //private void Cell_Leave(object sender, EventArgs e)
        //{
        //    int? value = int.Parse(cell.Text == "" ? "0" : cell.Text);
        //    if (value.HasValue && value.Value > 10)
        //    {
        //        dataGridMain.CurrentCell.Value = "10";
        //    }
        //    if (!isAlreadyTotal)
        //    {
        //        TotalByCol(lastCol);
        //        isAlreadyTotal = true;
        //    }
        //}
        private void Cell_KeyPress(object sender, KeyPressEventArgs e)
        {
            isAlreadyTotal = false;
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                if (cell.Text.Length > 1)
                {
                    if (e.KeyChar != (char)Keys.Back)
                        e.Handled = true;
                }        
            }
            else
                e.Handled = true;
        }

        private void BtnHistory_Click(object sender, EventArgs e)
        {
            EvaluatedHistroy evaluatedHistroy = new EvaluatedHistroy();
            evaluatedHistroy.ShowDialog();
        }

        private void DataGridMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string currentValue = dataGridMain.Rows[lastRow].Cells[lastCol].Value.ToString();
            if(currentValue=="")
                dataGridMain.Rows[lastRow].Cells[lastCol].Value = currentValue;
            else
            {
                dataGridMain.Rows[lastRow].Cells[lastCol].Value = int.Parse(currentValue)>10?10: int.Parse(currentValue);
                TotalByCol(lastCol);
            }
            
        }
        private void TotalByCol(int colIndex)
        {
            double total = 0;
            foreach(DataGridViewRow row in dataGridMain.Rows)
            {
                if (row.Index == dataGridMain.RowCount - 1)
                {
                    if (!isColoredTotal) {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
                        row.DefaultCellStyle.ForeColor = Color.White;
                        row.DefaultCellStyle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
                        row.Cells[0].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        row.DefaultCellStyle.Padding = new Padding(0, 5, 0, 5);
                        isColoredTotal = true;
                    }
                    continue;
                }
                if (row.Cells[colIndex].ColumnIndex == colIndex)
                {
                    string value = row.Cells[colIndex].Value.ToString();
                    total += double.Parse(value == "" ? "0" : value);
                }
            }
            if (total == 0)
            {
                dataGridMain.Rows[dataGridMain.RowCount - 1].Cells[colIndex].Value = "";
                return;
            }
            dataGridMain.Rows[dataGridMain.RowCount - 1].Cells[colIndex].Value = total;
        }

        private void BtnClearAll_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to clear all score ?","Cancel Evaluated").DialogResult == DialogResult.OK)
            {
                foreach(DataGridViewRow row in dataGridMain.Rows)
                {
                    foreach(DataGridViewCell cell in row.Cells)
                    {
                        if (cell.ColumnIndex == 0)
                            continue;
                        cell.Value = "";
                    }
                }
            }
        }

        private void EvaluationView_Load(object sender, EventArgs e)
        {

        }

        private void BtnDailyActivities_Click(object sender, EventArgs e)
        {
            DailyActivities dailyActivities = new DailyActivities();
            dailyActivities.ShowDialog();
        }
    }
}
