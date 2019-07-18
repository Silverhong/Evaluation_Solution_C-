namespace EvaluationSolution.UI.View
{
    partial class ManagementView
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
            this.panelDetail = new System.Windows.Forms.Panel();
            this.rbtnStaff = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.rbtnOffice = new System.Windows.Forms.RadioButton();
            this.rbtnDepartment = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDetail
            // 
            this.panelDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDetail.BackColor = System.Drawing.Color.White;
            this.panelDetail.Location = new System.Drawing.Point(289, 24);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(961, 631);
            this.panelDetail.TabIndex = 2;
            // 
            // rbtnStaff
            // 
            this.rbtnStaff.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnStaff.BackColor = System.Drawing.SystemColors.HotTrack;
            this.rbtnStaff.FlatAppearance.BorderSize = 0;
            this.rbtnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnStaff.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnStaff.ForeColor = System.Drawing.Color.White;
            this.rbtnStaff.Location = new System.Drawing.Point(-1, 100);
            this.rbtnStaff.Name = "rbtnStaff";
            this.rbtnStaff.Size = new System.Drawing.Size(256, 55);
            this.rbtnStaff.TabIndex = 3;
            this.rbtnStaff.TabStop = true;
            this.rbtnStaff.Text = "Staff";
            this.rbtnStaff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnStaff.UseVisualStyleBackColor = false;
            this.rbtnStaff.CheckedChanged += new System.EventHandler(this.Menu_Clicked);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Controls.Add(this.rbtnOffice);
            this.panel1.Controls.Add(this.rbtnDepartment);
            this.panel1.Controls.Add(this.rbtnStaff);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 681);
            this.panel1.TabIndex = 4;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.Black;
            this.metroLabel1.Location = new System.Drawing.Point(32, 40);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(193, 25);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Management Control";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // rbtnOffice
            // 
            this.rbtnOffice.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnOffice.BackColor = System.Drawing.SystemColors.HotTrack;
            this.rbtnOffice.FlatAppearance.BorderSize = 0;
            this.rbtnOffice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnOffice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnOffice.ForeColor = System.Drawing.Color.White;
            this.rbtnOffice.Location = new System.Drawing.Point(-1, 210);
            this.rbtnOffice.Name = "rbtnOffice";
            this.rbtnOffice.Size = new System.Drawing.Size(256, 55);
            this.rbtnOffice.TabIndex = 5;
            this.rbtnOffice.TabStop = true;
            this.rbtnOffice.Text = "Office";
            this.rbtnOffice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnOffice.UseVisualStyleBackColor = false;
            this.rbtnOffice.CheckedChanged += new System.EventHandler(this.Menu_Clicked);
            // 
            // rbtnDepartment
            // 
            this.rbtnDepartment.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnDepartment.BackColor = System.Drawing.SystemColors.HotTrack;
            this.rbtnDepartment.FlatAppearance.BorderSize = 0;
            this.rbtnDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnDepartment.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDepartment.ForeColor = System.Drawing.Color.White;
            this.rbtnDepartment.Location = new System.Drawing.Point(-1, 155);
            this.rbtnDepartment.Name = "rbtnDepartment";
            this.rbtnDepartment.Size = new System.Drawing.Size(256, 55);
            this.rbtnDepartment.TabIndex = 4;
            this.rbtnDepartment.TabStop = true;
            this.rbtnDepartment.Text = "Department";
            this.rbtnDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnDepartment.UseVisualStyleBackColor = false;
            this.rbtnDepartment.CheckedChanged += new System.EventHandler(this.Menu_Clicked);
            // 
            // ManagementView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelDetail);
            this.Name = "ManagementView";
            this.Size = new System.Drawing.Size(1280, 680);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.RadioButton rbtnStaff;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtnOffice;
        private System.Windows.Forms.RadioButton rbtnDepartment;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}
