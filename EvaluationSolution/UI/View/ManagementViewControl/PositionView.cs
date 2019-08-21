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
    public partial class PositionView : MainView
    {
        List<VPosition> listPosition;
        public PositionView()
        {
            InitializeComponent();
            listPosition = new List<VPosition>();
        }
        public override void Init()
        {
            string url = ApiRouting.GetUrl("", "", "position", ApiFunction.GetAll).ToString();
            bool confirm = url.Get<VPosition>(ref listPosition);
            if (confirm)
                dataGridMain.DataSource = listPosition;
            else
                MessageBox.Show("Cannot Connect To Server!", "Connection Error");
        }

        private void BtnAddOffice_Click(object sender, EventArgs e)
        {
            AddPosition addPosition = new AddPosition();
            addPosition.ShowDialog();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int index = dataGridMain.CurrentCell.RowIndex;
            string id = dataGridMain.Rows[index].Cells[0].Value.ToString();
            Position obj = new Position()
            {
                Pid = id,
                Pname = ""
            };
            string queryString = obj.GetQueryString<Position>();
            string url = ApiRouting.GetUrl("", "", "position", ApiFunction.DeleteById).ToString() + queryString;
            bool confirm = url.Detete<Position>();
            if (confirm)
            {
                MessageBox.Show("Operation Successful", "Deleted Successful");
                Init();
            }
        }
    }
}
