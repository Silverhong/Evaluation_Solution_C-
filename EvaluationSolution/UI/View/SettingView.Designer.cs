namespace EvaluationSolution.UI.View
{
    partial class SettingView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelDetail = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panelBtnUserMgt = new System.Windows.Forms.Panel();
            this.btnUserMgt = new System.Windows.Forms.Button();
            this.rbtnUserRole = new System.Windows.Forms.RadioButton();
            this.rbtnUserAccount = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelEvaluate = new System.Windows.Forms.Panel();
            this.btnEvaluation = new System.Windows.Forms.Button();
            this.rbtnEvaluationType = new System.Windows.Forms.RadioButton();
            this.rbtnEvaluationQuestion = new System.Windows.Forms.RadioButton();
            this.rbtnEvalutationMgt = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panelBtnUserMgt.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelEvaluate.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDetail
            // 
            this.panelDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDetail.BackColor = System.Drawing.Color.White;
            this.panelDetail.Location = new System.Drawing.Point(290, 25);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(961, 629);
            this.panelDetail.TabIndex = 5;
            // 
            // timer
            // 
            this.timer.Interval = 5;
            this.timer.Tick += new System.EventHandler(this.UserMgtTimer_Tick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.Black;
            this.metroLabel1.Location = new System.Drawing.Point(25, 31);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(149, 25);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Settings Control";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // panelBtnUserMgt
            // 
            this.panelBtnUserMgt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelBtnUserMgt.Controls.Add(this.btnUserMgt);
            this.panelBtnUserMgt.Controls.Add(this.rbtnUserRole);
            this.panelBtnUserMgt.Controls.Add(this.rbtnUserAccount);
            this.panelBtnUserMgt.Location = new System.Drawing.Point(0, 0);
            this.panelBtnUserMgt.Margin = new System.Windows.Forms.Padding(0);
            this.panelBtnUserMgt.MaximumSize = new System.Drawing.Size(254, 145);
            this.panelBtnUserMgt.MinimumSize = new System.Drawing.Size(254, 55);
            this.panelBtnUserMgt.Name = "panelBtnUserMgt";
            this.panelBtnUserMgt.Size = new System.Drawing.Size(254, 145);
            this.panelBtnUserMgt.TabIndex = 4;
            // 
            // btnUserMgt
            // 
            this.btnUserMgt.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnUserMgt.FlatAppearance.BorderSize = 0;
            this.btnUserMgt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserMgt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserMgt.ForeColor = System.Drawing.Color.White;
            this.btnUserMgt.Image = global::EvaluationSolution.Properties.Resources.expand_arrow_26px;
            this.btnUserMgt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUserMgt.Location = new System.Drawing.Point(0, 0);
            this.btnUserMgt.Name = "btnUserMgt";
            this.btnUserMgt.Padding = new System.Windows.Forms.Padding(20, 0, 10, 0);
            this.btnUserMgt.Size = new System.Drawing.Size(254, 55);
            this.btnUserMgt.TabIndex = 1;
            this.btnUserMgt.Text = "User Management";
            this.btnUserMgt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserMgt.UseVisualStyleBackColor = false;
            this.btnUserMgt.Click += new System.EventHandler(this.BtnUserMgt_Click);
            // 
            // rbtnUserRole
            // 
            this.rbtnUserRole.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnUserRole.BackColor = System.Drawing.Color.White;
            this.rbtnUserRole.FlatAppearance.BorderSize = 0;
            this.rbtnUserRole.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rbtnUserRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnUserRole.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnUserRole.ForeColor = System.Drawing.Color.Black;
            this.rbtnUserRole.Location = new System.Drawing.Point(0, 101);
            this.rbtnUserRole.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnUserRole.Name = "rbtnUserRole";
            this.rbtnUserRole.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.rbtnUserRole.Size = new System.Drawing.Size(254, 46);
            this.rbtnUserRole.TabIndex = 3;
            this.rbtnUserRole.TabStop = true;
            this.rbtnUserRole.Text = "User Role";
            this.rbtnUserRole.UseVisualStyleBackColor = false;
            this.rbtnUserRole.CheckedChanged += new System.EventHandler(this.RbtnUserRole_CheckedChanged);
            // 
            // rbtnUserAccount
            // 
            this.rbtnUserAccount.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnUserAccount.BackColor = System.Drawing.Color.White;
            this.rbtnUserAccount.FlatAppearance.BorderSize = 0;
            this.rbtnUserAccount.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rbtnUserAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnUserAccount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnUserAccount.ForeColor = System.Drawing.Color.Black;
            this.rbtnUserAccount.Location = new System.Drawing.Point(0, 55);
            this.rbtnUserAccount.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnUserAccount.Name = "rbtnUserAccount";
            this.rbtnUserAccount.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.rbtnUserAccount.Size = new System.Drawing.Size(254, 46);
            this.rbtnUserAccount.TabIndex = 3;
            this.rbtnUserAccount.TabStop = true;
            this.rbtnUserAccount.Text = "User Account";
            this.rbtnUserAccount.UseVisualStyleBackColor = false;
            this.rbtnUserAccount.CheckedChanged += new System.EventHandler(this.RbtnUserAccount_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 680);
            this.panel1.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panelBtnUserMgt);
            this.flowLayoutPanel1.Controls.Add(this.panelEvaluate);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 90);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(254, 543);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // panelEvaluate
            // 
            this.panelEvaluate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelEvaluate.Controls.Add(this.btnEvaluation);
            this.panelEvaluate.Controls.Add(this.radioButton1);
            this.panelEvaluate.Controls.Add(this.rbtnEvaluationType);
            this.panelEvaluate.Controls.Add(this.rbtnEvaluationQuestion);
            this.panelEvaluate.Controls.Add(this.rbtnEvalutationMgt);
            this.panelEvaluate.Location = new System.Drawing.Point(0, 145);
            this.panelEvaluate.Margin = new System.Windows.Forms.Padding(0);
            this.panelEvaluate.MaximumSize = new System.Drawing.Size(254, 239);
            this.panelEvaluate.MinimumSize = new System.Drawing.Size(254, 55);
            this.panelEvaluate.Name = "panelEvaluate";
            this.panelEvaluate.Size = new System.Drawing.Size(254, 239);
            this.panelEvaluate.TabIndex = 4;
            // 
            // btnEvaluation
            // 
            this.btnEvaluation.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEvaluation.FlatAppearance.BorderSize = 0;
            this.btnEvaluation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvaluation.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvaluation.ForeColor = System.Drawing.Color.White;
            this.btnEvaluation.Image = global::EvaluationSolution.Properties.Resources.expand_arrow_26px;
            this.btnEvaluation.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEvaluation.Location = new System.Drawing.Point(0, 0);
            this.btnEvaluation.Name = "btnEvaluation";
            this.btnEvaluation.Padding = new System.Windows.Forms.Padding(20, 0, 10, 0);
            this.btnEvaluation.Size = new System.Drawing.Size(254, 55);
            this.btnEvaluation.TabIndex = 1;
            this.btnEvaluation.Text = "Evaluation";
            this.btnEvaluation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEvaluation.UseVisualStyleBackColor = false;
            this.btnEvaluation.Click += new System.EventHandler(this.BtnEvaluation_Click);
            // 
            // rbtnEvaluationType
            // 
            this.rbtnEvaluationType.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnEvaluationType.BackColor = System.Drawing.Color.White;
            this.rbtnEvaluationType.FlatAppearance.BorderSize = 0;
            this.rbtnEvaluationType.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rbtnEvaluationType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnEvaluationType.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnEvaluationType.ForeColor = System.Drawing.Color.Black;
            this.rbtnEvaluationType.Location = new System.Drawing.Point(-1, 147);
            this.rbtnEvaluationType.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnEvaluationType.Name = "rbtnEvaluationType";
            this.rbtnEvaluationType.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.rbtnEvaluationType.Size = new System.Drawing.Size(254, 46);
            this.rbtnEvaluationType.TabIndex = 3;
            this.rbtnEvaluationType.TabStop = true;
            this.rbtnEvaluationType.Text = "Evaluation Type";
            this.rbtnEvaluationType.UseVisualStyleBackColor = false;
            this.rbtnEvaluationType.CheckedChanged += new System.EventHandler(this.RbtnEvaluationType_CheckedChanged);
            // 
            // rbtnEvaluationQuestion
            // 
            this.rbtnEvaluationQuestion.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnEvaluationQuestion.BackColor = System.Drawing.Color.White;
            this.rbtnEvaluationQuestion.FlatAppearance.BorderSize = 0;
            this.rbtnEvaluationQuestion.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rbtnEvaluationQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnEvaluationQuestion.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnEvaluationQuestion.ForeColor = System.Drawing.Color.Black;
            this.rbtnEvaluationQuestion.Location = new System.Drawing.Point(0, 101);
            this.rbtnEvaluationQuestion.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnEvaluationQuestion.Name = "rbtnEvaluationQuestion";
            this.rbtnEvaluationQuestion.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.rbtnEvaluationQuestion.Size = new System.Drawing.Size(254, 46);
            this.rbtnEvaluationQuestion.TabIndex = 3;
            this.rbtnEvaluationQuestion.TabStop = true;
            this.rbtnEvaluationQuestion.Text = "Evaluation Question";
            this.rbtnEvaluationQuestion.UseVisualStyleBackColor = false;
            this.rbtnEvaluationQuestion.CheckedChanged += new System.EventHandler(this.RbtnEvaluationQuestion_CheckedChanged);
            // 
            // rbtnEvalutationMgt
            // 
            this.rbtnEvalutationMgt.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnEvalutationMgt.BackColor = System.Drawing.Color.White;
            this.rbtnEvalutationMgt.FlatAppearance.BorderSize = 0;
            this.rbtnEvalutationMgt.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rbtnEvalutationMgt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnEvalutationMgt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnEvalutationMgt.ForeColor = System.Drawing.Color.Black;
            this.rbtnEvalutationMgt.Location = new System.Drawing.Point(0, 55);
            this.rbtnEvalutationMgt.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnEvalutationMgt.Name = "rbtnEvalutationMgt";
            this.rbtnEvalutationMgt.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.rbtnEvalutationMgt.Size = new System.Drawing.Size(254, 46);
            this.rbtnEvalutationMgt.TabIndex = 3;
            this.rbtnEvalutationMgt.TabStop = true;
            this.rbtnEvalutationMgt.Text = "Evaluation Management";
            this.rbtnEvalutationMgt.UseVisualStyleBackColor = false;
            this.rbtnEvalutationMgt.CheckedChanged += new System.EventHandler(this.RbtnEvalutationMgt_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton1.BackColor = System.Drawing.Color.White;
            this.radioButton1.FlatAppearance.BorderSize = 0;
            this.radioButton1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.Black;
            this.radioButton1.Location = new System.Drawing.Point(-1, 193);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(0);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.radioButton1.Size = new System.Drawing.Size(254, 46);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Evaluation Score";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RbtnEvaluationType_CheckedChanged);
            // 
            // SettingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.panelDetail);
            this.Controls.Add(this.panel1);
            this.Name = "SettingView";
            this.Size = new System.Drawing.Size(1280, 680);
            this.panelBtnUserMgt.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelEvaluate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.Timer timer;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Button btnUserMgt;
        private System.Windows.Forms.Panel panelBtnUserMgt;
        private System.Windows.Forms.RadioButton rbtnUserRole;
        private System.Windows.Forms.RadioButton rbtnUserAccount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelEvaluate;
        private System.Windows.Forms.Button btnEvaluation;
        private System.Windows.Forms.RadioButton rbtnEvaluationQuestion;
        private System.Windows.Forms.RadioButton rbtnEvalutationMgt;
        private System.Windows.Forms.RadioButton rbtnEvaluationType;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}
