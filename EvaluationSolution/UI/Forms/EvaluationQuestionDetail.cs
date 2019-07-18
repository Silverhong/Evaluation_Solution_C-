using EvaluationSolution.Infrastructure;
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

namespace EvaluationSolution.UI.Forms
{
    public partial class EvaluationQuestionDetail : MetroForm
    {
        public EvaluationQuestionDetail(string EvQId)
        {
            InitializeComponent();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "Edit")
            {
                btnEdit.Text = "Save";
                ToggleEntry(false);
            }
            else
            {
                btnEdit.Text = "Edit";
                ToggleEntry(true);
            }
        }
        private void ToggleEntry(bool con = false)
        {
            txtAnswer.ReadOnly = con;
            txtMinScore.ReadOnly = con;
            txtMaxScore.ReadOnly = con;
            txtQuestion.ReadOnly = con;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(StaticMessage.CancelMessage, StaticMessage.CancelEditTitle).DialogResult == DialogResult.OK)
                this.Dispose();
        }
    }
}
