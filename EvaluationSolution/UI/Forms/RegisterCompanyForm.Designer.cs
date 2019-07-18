namespace EvaluationSolution.UI.Forms
{
    partial class RegisterCompanyForm
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.lbCompanyName = new System.Windows.Forms.TextBox();
            this.lbContactNo = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.TextBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.lbAdminEmail = new System.Windows.Forms.TextBox();
            this.lbAdminPass = new System.Windows.Forms.TextBox();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.lbAdminConPass = new System.Windows.Forms.TextBox();
            this.btnSubmit = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(54, 21);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(150, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Register Company";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(246, 134);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(117, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Company Name : ";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(273, 178);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(90, 19);
            this.metroLabel3.TabIndex = 1;
            this.metroLabel3.Text = "Contact No. : ";
            this.metroLabel3.Click += new System.EventHandler(this.MetroLabel3_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(311, 222);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(52, 19);
            this.metroLabel4.TabIndex = 1;
            this.metroLabel4.Text = "Email : ";
            this.metroLabel4.Click += new System.EventHandler(this.MetroLabel3_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(296, 266);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(67, 19);
            this.metroLabel5.TabIndex = 1;
            this.metroLabel5.Text = "Address : ";
            this.metroLabel5.Click += new System.EventHandler(this.MetroLabel3_Click);
            // 
            // lbCompanyName
            // 
            this.lbCompanyName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCompanyName.Location = new System.Drawing.Point(385, 131);
            this.lbCompanyName.Name = "lbCompanyName";
            this.lbCompanyName.Size = new System.Drawing.Size(227, 25);
            this.lbCompanyName.TabIndex = 0;
            // 
            // lbContactNo
            // 
            this.lbContactNo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContactNo.Location = new System.Drawing.Point(385, 175);
            this.lbContactNo.Name = "lbContactNo";
            this.lbContactNo.Size = new System.Drawing.Size(227, 25);
            this.lbContactNo.TabIndex = 1;
            // 
            // lbEmail
            // 
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(385, 219);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(227, 25);
            this.lbEmail.TabIndex = 2;
            // 
            // lbAddress
            // 
            this.lbAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.Location = new System.Drawing.Point(385, 266);
            this.lbAddress.Multiline = true;
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(227, 123);
            this.lbAddress.TabIndex = 3;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(54, 64);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(558, 37);
            this.metroTile1.TabIndex = 5;
            this.metroTile1.Text = "Company Profile";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(213, 485);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(52, 19);
            this.metroLabel6.TabIndex = 1;
            this.metroLabel6.Text = "Email : ";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(191, 529);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(74, 19);
            this.metroLabel7.TabIndex = 1;
            this.metroLabel7.Text = "Password : ";
            // 
            // lbAdminEmail
            // 
            this.lbAdminEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdminEmail.Location = new System.Drawing.Point(273, 482);
            this.lbAdminEmail.Name = "lbAdminEmail";
            this.lbAdminEmail.Size = new System.Drawing.Size(227, 25);
            this.lbAdminEmail.TabIndex = 5;
            // 
            // lbAdminPass
            // 
            this.lbAdminPass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdminPass.Location = new System.Drawing.Point(273, 526);
            this.lbAdminPass.Name = "lbAdminPass";
            this.lbAdminPass.Size = new System.Drawing.Size(227, 25);
            this.lbAdminPass.TabIndex = 6;
            this.lbAdminPass.UseSystemPasswordChar = true;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(54, 419);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(558, 37);
            this.metroTile2.TabIndex = 5;
            this.metroTile2.Text = "Admin Profile";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.metroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile2.UseSelectable = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(139, 573);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(126, 19);
            this.metroLabel8.TabIndex = 1;
            this.metroLabel8.Text = "Confirm Password : ";
            this.metroLabel8.Click += new System.EventHandler(this.MetroLabel3_Click);
            // 
            // lbAdminConPass
            // 
            this.lbAdminConPass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdminConPass.Location = new System.Drawing.Point(273, 570);
            this.lbAdminConPass.Name = "lbAdminConPass";
            this.lbAdminConPass.Size = new System.Drawing.Size(227, 25);
            this.lbAdminConPass.TabIndex = 7;
            this.lbAdminConPass.UseSystemPasswordChar = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(208, 635);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(105, 38);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseSelectable = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(352, 635);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 38);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(105, 329);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(88, 31);
            this.metroButton3.TabIndex = 4;
            this.metroButton3.Text = "Browse";
            this.metroButton3.UseSelectable = true;
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(74, 131);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(152, 182);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            // 
            // RegisterCompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 709);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.lbAdminConPass);
            this.Controls.Add(this.lbAdminPass);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.lbAdminEmail);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.lbContactNo);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.lbCompanyName);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.Name = "RegisterCompanyForm";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.Text = "RegisterCompanyForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.TextBox lbCompanyName;
        private System.Windows.Forms.TextBox lbContactNo;
        private System.Windows.Forms.TextBox lbEmail;
        private System.Windows.Forms.TextBox lbAddress;
        private System.Windows.Forms.PictureBox pictureBox;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.TextBox lbAdminEmail;
        private System.Windows.Forms.TextBox lbAdminPass;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.TextBox lbAdminConPass;
        private MetroFramework.Controls.MetroButton btnSubmit;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton metroButton3;
    }
}