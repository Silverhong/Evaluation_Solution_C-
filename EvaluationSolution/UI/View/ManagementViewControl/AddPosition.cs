using EvaluationSolution.Entity;
using EvaluationSolution.Infrastructure;
using MetroFramework.Forms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluationSolution.UI.View.ManagementViewControl
{
    public partial class AddPosition : MetroForm
    {
        public AddPosition()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string position = txtPosition.Text.Trim();
            Position obj = new Position()
            {
                Pid = "",
                Pname = position
            };
            string json = JsonConvert.SerializeObject(obj);
            string url = ApiRouting.GetUrl("", "", "position", ApiFunction.Add).ToString();
            bool confirm = url.Post<Position>(json);
            if (confirm)
            {
                MessageBox.Show("Operation Successfull", "Success");
                var objPosition = Singleton.Instance.Container.Resolve<MainView>("position");
                objPosition.Init();
                this.Dispose();
            }
               
        }
    }
}
