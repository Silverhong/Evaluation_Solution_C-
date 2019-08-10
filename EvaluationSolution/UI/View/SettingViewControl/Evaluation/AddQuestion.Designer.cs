namespace EvaluationSolution.UI.View.SettingViewControl.Evaluation
{
    partial class AddQuestion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnSubmit = new MetroFramework.Controls.MetroButton();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.comboMinScore = new System.Windows.Forms.ComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.comboMaxScore = new System.Windows.Forms.ComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(316, 361);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 42);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseSelectable = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSubmit.Location = new System.Drawing.Point(188, 361);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(108, 42);
            this.btnSubmit.TabIndex = 24;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseSelectable = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // txtQuestion
            // 
            this.txtQuestion.Font = new System.Drawing.Font("Khmer OS Siemreap", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion.Location = new System.Drawing.Point(150, 85);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(402, 79);
            this.txtQuestion.TabIndex = 21;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(260, 30);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(89, 25);
            this.metroLabel2.TabIndex = 22;
            this.metroLabel2.Text = "Question";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(38, 86);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(93, 25);
            this.metroLabel1.TabIndex = 22;
            this.metroLabel1.Text = "Question :";
            // 
            // comboMinScore
            // 
            this.comboMinScore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMinScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMinScore.FormattingEnabled = true;
            this.comboMinScore.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboMinScore.Location = new System.Drawing.Point(150, 189);
            this.comboMinScore.Name = "comboMinScore";
            this.comboMinScore.Size = new System.Drawing.Size(146, 32);
            this.comboMinScore.TabIndex = 25;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(31, 190);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(100, 25);
            this.metroLabel3.TabIndex = 22;
            this.metroLabel3.Text = "Min Score :";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(316, 190);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(94, 25);
            this.metroLabel4.TabIndex = 22;
            this.metroLabel4.Text = "Max Score";
            // 
            // comboMaxScore
            // 
            this.comboMaxScore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMaxScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMaxScore.FormattingEnabled = true;
            this.comboMaxScore.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboMaxScore.Location = new System.Drawing.Point(416, 189);
            this.comboMaxScore.Name = "comboMaxScore";
            this.comboMaxScore.Size = new System.Drawing.Size(136, 32);
            this.comboMaxScore.TabIndex = 25;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(52, 248);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(79, 25);
            this.metroLabel5.TabIndex = 22;
            this.metroLabel5.Text = "Answer :";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Khmer OS Siemreap", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.Location = new System.Drawing.Point(150, 247);
            this.txtAnswer.Multiline = true;
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(402, 79);
            this.txtAnswer.TabIndex = 21;
            // 
            // AddQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 426);
            this.Controls.Add(this.comboMaxScore);
            this.Controls.Add(this.comboMinScore);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel2);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.Name = "AddQuestion";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Text = "AddQuestion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnSubmit;
        private System.Windows.Forms.TextBox txtQuestion;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ComboBox comboMinScore;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.ComboBox comboMaxScore;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.TextBox txtAnswer;
    }
}