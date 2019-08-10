namespace EvaluationSolution.UI.View.SettingViewControl.Evaluation
{
    partial class EvaluationManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.btnDeleteEvaluation = new MetroFramework.Controls.MetroButton();
            this.btnAddEvaluation = new MetroFramework.Controls.MetroButton();
            this.dataGridMain = new System.Windows.Forms.DataGridView();
            this.dtFromDate = new MetroFramework.Controls.MetroDateTime();
            this.dtToDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMain)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.metroTile1.TabIndex = 33;
            this.metroTile1.Text = "Evaluation Management";
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile1.UseCustomBackColor = true;
            this.metroTile1.UseSelectable = true;
            // 
            // btnDeleteEvaluation
            // 
            this.btnDeleteEvaluation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteEvaluation.Location = new System.Drawing.Point(774, 576);
            this.btnDeleteEvaluation.Name = "btnDeleteEvaluation";
            this.btnDeleteEvaluation.Size = new System.Drawing.Size(155, 42);
            this.btnDeleteEvaluation.TabIndex = 31;
            this.btnDeleteEvaluation.Text = "Delete Evaluation";
            this.btnDeleteEvaluation.UseSelectable = true;
            this.btnDeleteEvaluation.Click += new System.EventHandler(this.BtnDeleteEvaluation_Click);
            // 
            // btnAddEvaluation
            // 
            this.btnAddEvaluation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddEvaluation.Location = new System.Drawing.Point(596, 576);
            this.btnAddEvaluation.Name = "btnAddEvaluation";
            this.btnAddEvaluation.Size = new System.Drawing.Size(155, 42);
            this.btnAddEvaluation.TabIndex = 32;
            this.btnAddEvaluation.Text = "Add Evaluation";
            this.btnAddEvaluation.UseSelectable = true;
            this.btnAddEvaluation.Click += new System.EventHandler(this.BtnAddEvaluation_Click);
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
            this.dataGridMain.Location = new System.Drawing.Point(0, 0);
            this.dataGridMain.MultiSelect = false;
            this.dataGridMain.Name = "dataGridMain";
            this.dataGridMain.ReadOnly = true;
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
            this.dataGridMain.Size = new System.Drawing.Size(908, 450);
            this.dataGridMain.TabIndex = 24;
            this.dataGridMain.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridMain_CellDoubleClick);
            this.dataGridMain.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DataGridMain_DataBindingComplete);
            this.dataGridMain.Leave += new System.EventHandler(this.DataGridMain_Leave);
            // 
            // dtFromDate
            // 
            this.dtFromDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtFromDate.Location = new System.Drawing.Point(242, 62);
            this.dtFromDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtFromDate.Name = "dtFromDate";
            this.dtFromDate.Size = new System.Drawing.Size(200, 29);
            this.dtFromDate.TabIndex = 34;
            // 
            // dtToDate
            // 
            this.dtToDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtToDate.Location = new System.Drawing.Point(563, 62);
            this.dtToDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtToDate.Name = "dtToDate";
            this.dtToDate.Size = new System.Drawing.Size(200, 29);
            this.dtToDate.TabIndex = 34;
            this.dtToDate.ValueChanged += new System.EventHandler(this.DtToDate_ValueChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(155, 67);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(81, 19);
            this.metroLabel1.TabIndex = 35;
            this.metroLabel1.Text = "From Date :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(494, 67);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 19);
            this.metroLabel2.TabIndex = 35;
            this.metroLabel2.Text = "To Date :";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridMain);
            this.panel1.Location = new System.Drawing.Point(21, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 450);
            this.panel1.TabIndex = 36;
            // 
            // EvaluationManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dtToDate);
            this.Controls.Add(this.dtFromDate);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.btnDeleteEvaluation);
            this.Controls.Add(this.btnAddEvaluation);
            this.Controls.Add(this.panel1);
            this.Name = "EvaluationManagement";
            this.Size = new System.Drawing.Size(950, 630);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMain)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroButton btnDeleteEvaluation;
        private MetroFramework.Controls.MetroButton btnAddEvaluation;
        private System.Windows.Forms.DataGridView dataGridMain;
        private MetroFramework.Controls.MetroDateTime dtFromDate;
        private MetroFramework.Controls.MetroDateTime dtToDate;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Panel panel1;
    }
}
