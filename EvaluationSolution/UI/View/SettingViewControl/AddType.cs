using EvaluationSolution.Entity;
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
using EvaluationSolution.Infrastructure;
using Newtonsoft.Json;

namespace EvaluationSolution.UI.View.SettingViewControl
{
    public partial class AddType : MetroForm
    {
        public AddType()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (txtType.TextLength == 0)
            {
                MessageBox.Show("Please input information");
                return;
            }
            string text = txtType.Text.Trim();
            EvaluationType evaluationType = new EvaluationType() { EvTName = text, EvTId = "" };
            string json = JsonConvert.SerializeObject(evaluationType);
            string url = ApiRouting.GetUrl("", "", "evaluationType", ApiFunction.Add).ToString();
            bool confirm = url.Post<EvaluationType>(json);
            if (confirm)
                MessageBox.Show("Operation Successful");
            else
                MessageBox.Show("Operation Falied");
            txtType.Clear();
            var evtObj = Singleton.Instance.Container.Resolve<MainView>("evaluation type");
            evtObj.Init();
        }
    }
}
