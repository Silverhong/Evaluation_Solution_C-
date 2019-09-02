namespace EvaluationSolution.UI.View.SettingViewControl.Evaluation
{
    partial class EvaluationQuestion
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
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnAddQuestion = new MetroFramework.Controls.MetroButton();
            this.dataGridMain = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMain)).BeginInit();
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
            this.metroTile1.TabIndex = 39;
            this.metroTile1.Text = "Evaluation Question";
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile1.UseCustomBackColor = true;
            this.metroTile1.UseSelectable = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(821, 576);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 42);
            this.btnDelete.TabIndex = 37;
            this.btnDelete.Text = "Delete Question";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddQuestion.Location = new System.Drawing.Point(689, 576);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(108, 42);
            this.btnAddQuestion.TabIndex = 38;
            this.btnAddQuestion.Text = "Add Question";
            this.btnAddQuestion.UseSelectable = true;
            this.btnAddQuestion.Click += new System.EventHandler(this.BtnAddQuestion_Click);
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
            this.dataGridMain.Location = new System.Drawing.Point(21, 74);
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
            this.dataGridMain.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Khmer OS Siemreap", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridMain.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridMain.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.dataGridMain.RowTemplate.Height = 33;
            this.dataGridMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridMain.Size = new System.Drawing.Size(908, 486);
            this.dataGridMain.TabIndex = 36;
            this.dataGridMain.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridMain_CellDoubleClick);
            this.dataGridMain.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DataGridMain_DataBindingComplete);
            // 
            // EvaluationQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddQuestion);
            this.Controls.Add(this.dataGridMain);
            this.Name = "EvaluationQuestion";
            this.Size = new System.Drawing.Size(950, 630);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnAddQuestion;
        private System.Windows.Forms.DataGridView dataGridMain;
    }
}
