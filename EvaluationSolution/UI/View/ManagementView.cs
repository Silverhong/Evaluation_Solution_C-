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

namespace EvaluationSolution.UI.View
{
    public partial class ManagementView : MainView
    {
        public ManagementView()
        {
            InitializeComponent();
        }
        private void Menu_Clicked(object sender,EventArgs e)
        {
            string name = ((RadioButton)sender).Text.ToLower().ToString();
            var view = Singleton.Instance.Container.Resolve<MainView>(name);
            view.Dock = DockStyle.Fill;
            panelDetail.Controls.Clear();
            panelDetail.Controls.Add(view);
        }
    }
}
