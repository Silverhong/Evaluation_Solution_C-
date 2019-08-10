namespace EvaluationSolution.UI.View.SettingViewControl.Evaluation.AddEvaluationControl
{
    partial class SelectStaff
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnSubmit = new MetroFramework.Controls.MetroButton();
            this.dataGridMain = new System.Windows.Forms.DataGridView();
            this.comboOffice = new MetroFramework.Controls.MetroComboBox();
            this.comboDepartment = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMain)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(977, 592);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 42);
            this.btnCancel.TabIndex = 67;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseSelectable = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.Location = new System.Drawing.Point(853, 592);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(108, 42);
            this.btnSubmit.TabIndex = 68;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseSelectable = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // dataGridMain
            // 
            this.dataGridMain.AllowUserToAddRows = false;
            this.dataGridMain.AllowUserToDeleteRows = false;
            this.dataGridMain.AllowUserToResizeColumns = false;
            this.dataGridMain.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridMain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridMain.BackgroundColor = System.Drawing.Color.White;
            this.dataGridMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridMain.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridMain.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridMain.ColumnHeadersHeight = 33;
            this.dataGridMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridMain.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridMain.EnableHeadersVisualStyles = false;
            this.dataGridMain.Location = new System.Drawing.Point(33, 125);
            this.dataGridMain.MultiSelect = false;
            this.dataGridMain.Name = "dataGridMain";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridMain.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridMain.RowHeadersVisible = false;
            this.dataGridMain.RowHeadersWidth = 48;
            this.dataGridMain.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridMain.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridMain.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridMain.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.dataGridMain.RowTemplate.Height = 33;
            this.dataGridMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridMain.Size = new System.Drawing.Size(1052, 446);
            this.dataGridMain.TabIndex = 66;
            this.dataGridMain.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridMain_CellDoubleClick);
            // 
            // comboOffice
            // 
            this.comboOffice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboOffice.FormattingEnabled = true;
            this.comboOffice.ItemHeight = 23;
            this.comboOffice.Location = new System.Drawing.Point(880, 64);
            this.comboOffice.Name = "comboOffice";
            this.comboOffice.Size = new System.Drawing.Size(174, 29);
            this.comboOffice.TabIndex = 64;
            this.comboOffice.UseSelectable = true;
            // 
            // comboDepartment
            // 
            this.comboDepartment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboDepartment.FormattingEnabled = true;
            this.comboDepartment.ItemHeight = 23;
            this.comboDepartment.Location = new System.Drawing.Point(596, 64);
            this.comboDepartment.Name = "comboDepartment";
            this.comboDepartment.Size = new System.Drawing.Size(186, 29);
            this.comboDepartment.TabIndex = 65;
            this.comboDepartment.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(806, 65);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(68, 25);
            this.metroLabel3.TabIndex = 61;
            this.metroLabel3.Text = "Office :";
            this.metroLabel3.UseCustomBackColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(478, 17);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(114, 25);
            this.metroLabel4.TabIndex = 62;
            this.metroLabel4.Text = "Select Staff ";
            this.metroLabel4.UseCustomBackColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(474, 65);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(116, 25);
            this.metroLabel1.TabIndex = 63;
            this.metroLabel1.Text = "Department :";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(219, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 30);
            this.textBox1.TabIndex = 60;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(143, 65);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(57, 25);
            this.metroLabel2.TabIndex = 63;
            this.metroLabel2.Text = "Staff :";
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // SelectStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 657);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dataGridMain);
            this.Controls.Add(this.comboOffice);
            this.Controls.Add(this.comboDepartment);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.textBox1);
            this.DisplayHeader = false;
            this.Name = "SelectStaff";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Text = "SelectStaff";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnSubmit;
        private System.Windows.Forms.DataGridView dataGridMain;
        private MetroFramework.Controls.MetroComboBox comboOffice;
        private MetroFramework.Controls.MetroComboBox comboDepartment;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TextBox textBox1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}