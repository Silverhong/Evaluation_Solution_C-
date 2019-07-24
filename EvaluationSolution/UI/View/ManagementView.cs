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
            if (ClearCheck((RadioButton)sender))
                return;
            string name = ((RadioButton)sender).Text.ToLower().ToString();
            var view = Singleton.Instance.Container.Resolve<MainView>(name);
            view.Dock = DockStyle.Fill;
            view.Init();
            panelDetail.Controls.Clear();
            panelDetail.Controls.Add(view);
        }
        private bool ClearCheck(RadioButton radioButton)
        {
            if (!radioButton.Checked)
                return true;
            return false;
        }
    }
}
