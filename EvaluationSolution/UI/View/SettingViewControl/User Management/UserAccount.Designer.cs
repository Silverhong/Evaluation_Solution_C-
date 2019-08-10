namespace EvaluationSolution.UI.View.SettingViewControl
{
    partial class UserAccount
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridMain = new System.Windows.Forms.DataGridView();
            this.comboOffice = new MetroFramework.Controls.MetroComboBox();
            this.comboDepartment = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnAddAccount = new MetroFramework.Controls.MetroButton();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.lbTotal = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMain)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridMain
            // 
            this.dataGridMain.AllowUserToAddRows = false;
            this.dataGridMain.AllowUserToDeleteRows = false;
            this.dataGridMain.AllowUserToResizeColumns = false;
            this.dataGridMain.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dataGridMain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridMain.BackgroundColor = System.Drawing.Color.White;
            this.dataGridMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridMain.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridMain.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridMain.ColumnHeadersHeight = 33;
            this.dataGridMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridMain.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridMain.EnableHeadersVisualStyles = false;
            this.dataGridMain.Location = new System.Drawing.Point(21, 110);
            this.dataGridMain.MultiSelect = false;
            this.dataGridMain.Name = "dataGridMain";
            this.dataGridMain.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridMain.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridMain.RowHeadersVisible = false;
            this.dataGridMain.RowHeadersWidth = 48;
            this.dataGridMain.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridMain.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridMain.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridMain.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.dataGridMain.RowTemplate.Height = 33;
            this.dataGridMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridMain.Size = new System.Drawing.Size(908, 450);
            this.dataGridMain.TabIndex = 4;
            this.dataGridMain.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DataGridMain_DataBindingComplete);
            // 
            // comboOffice
            // 
            this.comboOffice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboOffice.FormattingEnabled = true;
            this.comboOffice.ItemHeight = 23;
            this.comboOffice.Location = new System.Drawing.Point(755, 61);
            this.comboOffice.Name = "comboOffice";
            this.comboOffice.Size = new System.Drawing.Size(174, 29);
            this.comboOffice.TabIndex = 19;
            this.comboOffice.UseSelectable = true;
            // 
            // comboDepartment
            // 
            this.comboDepartment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboDepartment.FormattingEnabled = true;
            this.comboDepartment.ItemHeight = 23;
            this.comboDepartment.Location = new System.Drawing.Point(467, 61);
            this.comboDepartment.Name = "comboDepartment";
            this.comboDepartment.Size = new System.Drawing.Size(186, 29);
            this.comboDepartment.TabIndex = 20;
            this.comboDepartment.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(681, 62);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(68, 25);
            this.metroLabel3.TabIndex = 16;
            this.metroLabel3.Text = "Office :";
            this.metroLabel3.UseCustomBackColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(345, 62);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(116, 25);
            this.metroLabel1.TabIndex = 17;
            this.metroLabel1.Text = "Department :";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(21, 62);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(57, 25);
            this.metroLabel2.TabIndex = 18;
            this.metroLabel2.Text = "Staff :";
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(91, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 30);
            this.textBox1.TabIndex = 15;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(821, 576);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 42);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete Account";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAccount.Location = new System.Drawing.Point(689, 576);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(108, 42);
            this.btnAddAccount.TabIndex = 22;
            this.btnAddAccount.Text = "Add Account";
            this.btnAddAccount.UseSelectable = true;
            this.btnAddAccount.Click += new System.EventHandler(this.BtnAddAccount_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTile1.BackColor = System.Drawing.SystemColors.Highlight;
            this.metroTile1.Location = new System.Drawing.Point(3, 3);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(944, 41);
            this.metroTile1.TabIndex = 23;
            this.metroTile1.Text = "User Account";
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile1.UseCustomBackColor = true;
            this.metroTile1.UseSelectable = true;
            // 
            // lbTotal
            // 
            this.lbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbTotal.AutoSize = true;
            this.lbTotal.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbTotal.Location = new System.Drawing.Point(83, 588);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(46, 19);
            this.lbTotal.TabIndex = 24;
            this.lbTotal.Text = "$Total";
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(35, 588);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(45, 19);
            this.metroLabel5.TabIndex = 24;
            this.metroLabel5.Text = "Total :";
            // 
            // UserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddAccount);
            this.Controls.Add(this.comboOffice);
            this.Controls.Add(this.comboDepartment);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridMain);
            this.Name = "UserAccount";
            this.Size = new System.Drawing.Size(950, 630);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridMain;
        private MetroFramework.Controls.MetroComboBox comboOffice;
        private MetroFramework.Controls.MetroComboBox comboDepartment;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.TextBox textBox1;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnAddAccount;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel lbTotal;
        private MetroFramework.Controls.MetroLabel metroLabel5;
    }
}
