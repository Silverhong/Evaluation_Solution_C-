namespace EvaluationSolution.UI.Forms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.panelMenuBar = new System.Windows.Forms.Panel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lbTime = new MetroFramework.Controls.MetroLabel();
            this.lbDate = new MetroFramework.Controls.MetroLabel();
            this.lbLoginAs = new MetroFramework.Controls.MetroLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rbtnSetting = new System.Windows.Forms.RadioButton();
            this.rbtnDailyActivity = new System.Windows.Forms.RadioButton();
            this.rbnManagement = new System.Windows.Forms.RadioButton();
            this.panelMain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tTime = new System.Windows.Forms.Timer(this.components);
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.panelMenuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenuBar
            // 
            this.panelMenuBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMenuBar.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelMenuBar.Controls.Add(this.metroLabel1);
            this.panelMenuBar.Controls.Add(this.lbTime);
            this.panelMenuBar.Controls.Add(this.lbDate);
            this.panelMenuBar.Controls.Add(this.lbLoginAs);
            this.panelMenuBar.Controls.Add(this.pictureBox2);
            this.panelMenuBar.Controls.Add(this.pictureBox3);
            this.panelMenuBar.Controls.Add(this.pictureBox1);
            this.panelMenuBar.Controls.Add(this.rbtnSetting);
            this.panelMenuBar.Controls.Add(this.radioButton2);
            this.panelMenuBar.Controls.Add(this.rbtnDailyActivity);
            this.panelMenuBar.Controls.Add(this.rbnManagement);
            this.panelMenuBar.Location = new System.Drawing.Point(0, 0);
            this.panelMenuBar.Name = "panelMenuBar";
            this.panelMenuBar.Size = new System.Drawing.Size(1280, 56);
            this.panelMenuBar.TabIndex = 0;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(89, 14);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(147, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Avengers Heros";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.Click += new System.EventHandler(this.LbLoginAs_Click);
            // 
            // lbTime
            // 
            this.lbTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTime.AutoSize = true;
            this.lbTime.BackColor = System.Drawing.Color.Transparent;
            this.lbTime.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbTime.Location = new System.Drawing.Point(931, 30);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(70, 19);
            this.lbTime.TabIndex = 0;
            this.lbTime.Text = "$LoginAs";
            this.lbTime.UseCustomBackColor = true;
            this.lbTime.UseCustomForeColor = true;
            this.lbTime.Click += new System.EventHandler(this.LbLoginAs_Click);
            // 
            // lbDate
            // 
            this.lbDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDate.AutoSize = true;
            this.lbDate.BackColor = System.Drawing.Color.Transparent;
            this.lbDate.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbDate.Location = new System.Drawing.Point(931, 5);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(70, 19);
            this.lbDate.TabIndex = 0;
            this.lbDate.Text = "$LoginAs";
            this.lbDate.UseCustomBackColor = true;
            this.lbDate.UseCustomForeColor = true;
            this.lbDate.Click += new System.EventHandler(this.LbLoginAs_Click);
            // 
            // lbLoginAs
            // 
            this.lbLoginAs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLoginAs.AutoSize = true;
            this.lbLoginAs.BackColor = System.Drawing.Color.Transparent;
            this.lbLoginAs.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbLoginAs.Location = new System.Drawing.Point(1116, 17);
            this.lbLoginAs.Name = "lbLoginAs";
            this.lbLoginAs.Size = new System.Drawing.Size(66, 19);
            this.lbLoginAs.TabIndex = 0;
            this.lbLoginAs.Text = "$LoginAs";
            this.lbLoginAs.UseCustomBackColor = true;
            this.lbLoginAs.UseCustomForeColor = true;
            this.lbLoginAs.Click += new System.EventHandler(this.LbLoginAs_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::EvaluationSolution.Properties.Resources.icons8_login_rounded_right_60px;
            this.pictureBox2.Location = new System.Drawing.Point(1211, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::EvaluationSolution.Properties.Resources.Logo;
            this.pictureBox3.Location = new System.Drawing.Point(23, 1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 53);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::EvaluationSolution.Properties.Resources.icons8_user_male_circle_filled_100px_2;
            this.pictureBox1.Location = new System.Drawing.Point(1055, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // rbtnSetting
            // 
            this.rbtnSetting.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnSetting.BackColor = System.Drawing.SystemColors.Highlight;
            this.rbtnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rbtnSetting.FlatAppearance.BorderSize = 0;
            this.rbtnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnSetting.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSetting.ForeColor = System.Drawing.Color.White;
            this.rbtnSetting.Location = new System.Drawing.Point(772, 0);
            this.rbtnSetting.Name = "rbtnSetting";
            this.rbtnSetting.Size = new System.Drawing.Size(143, 55);
            this.rbtnSetting.TabIndex = 1;
            this.rbtnSetting.Text = "Setting";
            this.rbtnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnSetting.UseVisualStyleBackColor = false;
            this.rbtnSetting.CheckedChanged += new System.EventHandler(this.Menu_Checked);
            // 
            // rbtnDailyActivity
            // 
            this.rbtnDailyActivity.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnDailyActivity.BackColor = System.Drawing.SystemColors.Highlight;
            this.rbtnDailyActivity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rbtnDailyActivity.FlatAppearance.BorderSize = 0;
            this.rbtnDailyActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnDailyActivity.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDailyActivity.ForeColor = System.Drawing.Color.White;
            this.rbtnDailyActivity.Location = new System.Drawing.Point(489, 0);
            this.rbtnDailyActivity.Name = "rbtnDailyActivity";
            this.rbtnDailyActivity.Size = new System.Drawing.Size(143, 55);
            this.rbtnDailyActivity.TabIndex = 1;
            this.rbtnDailyActivity.Text = "Daily Activity";
            this.rbtnDailyActivity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnDailyActivity.UseVisualStyleBackColor = false;
            this.rbtnDailyActivity.CheckedChanged += new System.EventHandler(this.Menu_Checked);
            // 
            // rbnManagement
            // 
            this.rbnManagement.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbnManagement.BackColor = System.Drawing.SystemColors.Highlight;
            this.rbnManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rbnManagement.FlatAppearance.BorderSize = 0;
            this.rbnManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbnManagement.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnManagement.ForeColor = System.Drawing.Color.White;
            this.rbnManagement.Location = new System.Drawing.Point(632, 0);
            this.rbnManagement.Name = "rbnManagement";
            this.rbnManagement.Size = new System.Drawing.Size(143, 55);
            this.rbnManagement.TabIndex = 1;
            this.rbnManagement.Text = "Management";
            this.rbnManagement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbnManagement.UseVisualStyleBackColor = false;
            this.rbnManagement.CheckedChanged += new System.EventHandler(this.Menu_Checked);
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Location = new System.Drawing.Point(0, 52);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1280, 672);
            this.panelMain.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1103, 734);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server Connected";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Image = global::EvaluationSolution.Properties.Resources.GreenPoint;
            this.pictureBox4.Location = new System.Drawing.Point(1066, 728);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(37, 37);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // tTime
            // 
            this.tTime.Interval = 1000;
            this.tTime.Tick += new System.EventHandler(this.TTime_Tick);
            // 
            // radioButton2
            // 
            this.radioButton2.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton2.BackColor = System.Drawing.SystemColors.Highlight;
            this.radioButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.radioButton2.FlatAppearance.BorderSize = 0;
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(350, 0);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(143, 55);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Evaluation";
            this.radioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.Menu_Checked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 768);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelMenuBar);
            this.Controls.Add(this.panelMain);
            this.DisplayHeader = false;
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelMenuBar.ResumeLayout(false);
            this.panelMenuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuBar;
        private System.Windows.Forms.RadioButton rbnManagement;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroLabel lbLoginAs;
        private System.Windows.Forms.RadioButton rbtnSetting;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.RadioButton rbtnDailyActivity;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroLabel lbDate;
        private System.Windows.Forms.Timer tTime;
        private MetroFramework.Controls.MetroLabel lbTime;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}