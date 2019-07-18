using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace EvaluationSolution.UI.View.SettingViewControl.Evaluation
{
    public partial class EvaluationType : MainView
    {
        public EvaluationType()
        {
            InitializeComponent();
            List<Entity.EvaluationType> listEvT = new List<Entity.EvaluationType>();
            listEvT.Add(new Entity.EvaluationType { EvFId = "001", EvFName = "Every Year" });
            listEvT.Add(new Entity.EvaluationType { EvFId = "002", EvFName = "Every Month" });
            listEvT.Add(new Entity.EvaluationType { EvFId = "003", EvFName = "Every Week" });
            dataGridMain.DataSource = listEvT.Select(x => new { ID = x.EvFId, Evaluation_Type = x.EvFName }).ToList();
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
    }
}
