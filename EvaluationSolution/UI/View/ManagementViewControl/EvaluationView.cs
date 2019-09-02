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
using EvaluationSolution.Infrastructure;
using Newtonsoft.Json;

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
        private VEvaluationOnStaff VEvaluationOnStaff;
        public EvaluationView()
        {
            InitializeComponent();
            VEvaluationOnStaff = new VEvaluationOnStaff();
            string url = ApiRouting.GetUrl("", "", "evaluation", ApiFunction.GetByStaffId).ToString() + "?StaffId=" + GlobalVariable.StaffID;
            bool confirm = url.GetDeserializeObject<VEvaluationOnStaff>(ref VEvaluationOnStaff);
            if (confirm)
            {
                lbDescription.Text = VEvaluationOnStaff.EvaDescription;
                dt.Columns.Add(new DataColumn() { ReadOnly = true, ColumnName = "ចំណុចត្រូវវាយតម្លៃ" });
                dataGridMain.DataSource = dt;
                int id = 1;
                foreach (var obj in VEvaluationOnStaff.Questions)
                {
                    dt.Rows.Add(id + "." + obj.Description);
                    id++;
                }
                foreach (var obj in VEvaluationOnStaff.Staff)
                {
                    dt.Columns.Add(new DataColumn() { ColumnName = obj.id, DataType = typeof(string), AllowDBNull = true });
                }
                dt.Rows.Add("Total");
                //dataGridMain.AutoGenerateColumns = true;
                ConfigureDataGrid();
            }
            else
            {
                panel3.Controls.Clear();
                panel3.Controls.Add(new NoView() { Dock = DockStyle.Fill });
            }
            
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
        private void BtnDailyActivities_Click(object sender, EventArgs e)
        {
            DailyActivities dailyActivities = new DailyActivities();
            dailyActivities.ShowDialog();
        }
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            List<AssignScore> listAssignScore = new List<AssignScore>();
            if (MessageBox.Show("Do you want to submit your evaluation ?","Confirmation").DialogResult == DialogResult.No)
            {
                return;
            }
            string AssignScoreId = "";
            AssignScore assignScore = new AssignScore();
            foreach(DataGridViewColumn dtc in dataGridMain.Columns)
            {
                if (dtc.Index == 0)
                    continue;
                assignScore = new AssignScore();
                assignScore.Date = DateTime.Now.Date.ToShortDateString();
                assignScore.AssignScoreId = "";
                assignScore.AvgScore = "0";
                assignScore.ByAssignId = VEvaluationOnStaff.AssignId;
                assignScore.ForAssignId = VEvaluationOnStaff.Staff[dtc.Index-1].assignId;
                assignScore.ListAssignScoreDetails = new List<AssignScoreDetail>();
                foreach(DataGridViewRow dtr in dataGridMain.Rows)
                {
                    if (dtr.Index == dataGridMain.RowCount-1)
                        break;
                    if (dtr.Cells[dtc.Index].Value == null || dtr.Cells[dtc.Index].Value.ToString() == "")
                    {
                        MessageBox.Show("Please fill all information!");
                        return;
                    }
                    assignScore.ListAssignScoreDetails.Add(new Entity.AssignScoreDetail()
                    {
                        AssignScoreDetailId = "",
                        AssignScoreId = AssignScoreId,
                        EvQId = VEvaluationOnStaff.Questions[dtr.Index].EvQId,
                        Score = dtr.Cells[dtc.Index].Value.ToString()
                    });
                }
                listAssignScore.Add(assignScore);
            }
            string json = JsonConvert.SerializeObject(listAssignScore);
            string url = ApiRouting.GetUrl("", "", "assignscore", ApiFunction.Add).ToString();
            string respond = "";
            bool confirm = url.Post<AssignScore>(json,ref respond);
            if (respond.ToLower() == "successful")
                MessageBox.Show("Evaluation submitted successful");
        }
    }
}
