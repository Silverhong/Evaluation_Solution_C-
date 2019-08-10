using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EvaluationSolution.Infrastructure;
using EvaluationSolution.Entity;

namespace EvaluationSolution.UI.View.SettingViewControl.Evaluation
{
    public partial class EvaluationType : MainView
    {
        List<VEvaluationType> listEvT;
        public EvaluationType()
        {
            InitializeComponent();
            listEvT = new List<VEvaluationType>();
            
        }
        public override void Init()
        {
            string url = ApiRouting.GetUrl("", "", "evaluationType", ApiFunction.GetAll).ToString();
            bool confirm = url.Get<VEvaluationType>(ref listEvT);
            if (confirm)
                dataGridMain.DataSource = listEvT;
            else
                MessageBox.Show("Operation Failed");
        }
        private void DataGridMain_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridMain.ClearSelection();
        }

        private void BtnAddType_Click(object sender, EventArgs e)
        {
            AddType addType = new AddType();
            addType.ShowDialog();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int index = dataGridMain.CurrentCell.RowIndex;
            string id = dataGridMain.Rows[index].Cells[0].Value.ToString();
            Entity.EvaluationType evaluationType = new Entity.EvaluationType() { EvTId = id, EvTName = "" };
            string queryString = evaluationType.GetQueryString<Entity.EvaluationType>();
            string url = ApiRouting.GetUrl("", "", "evaluationType", ApiFunction.DeleteById).ToString() + queryString;
            bool confirm = url.Detete<Entity.EvaluationType>();
            if (confirm)
                MessageBox.Show("Operation Successful");
            else
                MessageBox.Show("Operation Falied");
            Init();
        }
    }
}
