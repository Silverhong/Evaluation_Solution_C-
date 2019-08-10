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

namespace EvaluationSolution.UI.View.SettingViewControl.Evaluation
{
    public partial class AddQuestion : MetroForm
    {
        public AddQuestion()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            //Question
            string description = txtQuestion.Text;
            string minScore = comboMinScore.SelectedItem.ToString();
            string maxScore = comboMaxScore.SelectedItem.ToString();
            string answer = txtAnswer.Text;
            string createDate = DateTime.Now.ToShortDateString();
            Entity.EvaluationQuestion evaluationQuestion = new Entity.EvaluationQuestion()
            {
                CreatedDate = createDate,
                EvQDescription = description,
                EvQId = "",
                StaffId = GlobalVariable.StaffID
            };
            string json = JsonConvert.SerializeObject(evaluationQuestion);
            string url = ApiRouting.GetUrl("", "", "evaluationQuestion", ApiFunction.Add).ToString();
            string responseInsertedId = "";
            bool confirm = url.Post<Entity.EvaluationQuestion>(json,ref responseInsertedId);
            if (confirm)
            {
                Entity.EvaluationQuestionDetail evaluationQuestionDetail = new EvaluationQuestionDetail()
                {
                    Answer = answer,
                    EvQDetailId = "",
                    EvQId = responseInsertedId,
                    EvQName = "Unknown",
                    MaxScore = maxScore,
                    MinScore = minScore
                };
                url = ApiRouting.GetUrl("", "", "evaluationQuestionDetail", ApiFunction.Add).ToString();
                json = JsonConvert.SerializeObject(evaluationQuestionDetail);
                bool deConfirm = url.Post<Entity.EvaluationQuestionDetail>(json);
                if (deConfirm)
                {
                    MessageBox.Show("Operation Successful");
                }
                var obj = Singleton.Instance.Container.Resolve<MainView>("evaluation question");
                obj.Init();
            }
        }
    }
}
