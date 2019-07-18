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

namespace EvaluationSolution.UI.View
{
    public partial class SettingView : MainView
    {
        public SettingView()
        {
            InitializeComponent();
        }
        private bool isCollapse = true;
        private Panel panel;
        private Button button;
        private void ExpandAndCollapsedPanel(Panel panel, Button button)
        {
            this.panel = panel;
            this.button = button;
            isCollapse = panel.Size.Height == panel.MaximumSize.Height ? false : true;
            timer.Start();
        }
        private void UserMgtTimer_Tick(object sender, EventArgs e)
        {
            if (isCollapse)
            {
                panel.Height += 10;
                if(panel.Size == panel.MaximumSize)
                {
                    timer.Stop();
                    isCollapse = false;
                    button.Image = EvaluationSolution.Properties.Resources.collapse_arrow_26px;
                }
            }
            else
            {
                panel.Height -= 10;
                if (panel.Size == panel.MinimumSize)
                {
                    timer.Stop();
                    isCollapse = true;
                    button.Image = EvaluationSolution.Properties.Resources.expand_arrow_26px;
                }
            }
        }

        private void BtnUserMgt_Click(object sender, EventArgs e)
        {
            ExpandAndCollapsedPanel(panelBtnUserMgt,btnUserMgt);
        }

        private void BtnEvaluation_Click(object sender, EventArgs e)
        {
            ExpandAndCollapsedPanel(panelEvaluate, btnEvaluation);
        }

        private void RbtnUserAccount_CheckedChanged(object sender, EventArgs e)
        {
            Menu_Clicked(sender, e);
        }
        private void Menu_Clicked(object sender, EventArgs e)
        {
            ClearCheck((RadioButton)sender);
            string name = ((RadioButton)sender).Text.ToLower().ToString();
            var view = Singleton.Instance.Container.Resolve<MainView>(name);
            view.Init();
            view.Dock = DockStyle.Fill;
            panelDetail.Controls.Clear();
            panelDetail.Controls.Add(view);
            
        }
        private void ClearCheck(RadioButton radioButton)
        {
            if (!radioButton.Checked) return;
            List<RadioButton> list = new List<RadioButton>() { rbtnUserAccount, rbtnUserRole, rbtnEvalutationMgt, rbtnEvaluationQuestion, rbtnEvaluationType };
            foreach(var r in list)
            {
                if (r == radioButton)
                    continue;
                r.Checked = false;

            }
        }
        private void RbtnUserRole_CheckedChanged(object sender, EventArgs e)
        {
            Menu_Clicked(sender, e);
        }

        private void RbtnEvalutationMgt_CheckedChanged(object sender, EventArgs e)
        {
            Menu_Clicked(sender, e);
        }

        private void RbtnEvaluationQuestion_CheckedChanged(object sender, EventArgs e)
        {
            Menu_Clicked(sender, e);
        }

        private void RbtnEvaluationType_CheckedChanged(object sender, EventArgs e)
        {
            Menu_Clicked(sender, e);
        }
    }
}
