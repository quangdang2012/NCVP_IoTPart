namespace IPQC_Motor
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbUserName = new System.Windows.Forms.ComboBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.Version_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(86, 93);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 15;
            // 
            // cmbUserName
            // 
            this.cmbUserName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserName.FormattingEnabled = true;
            this.cmbUserName.Location = new System.Drawing.Point(102, 28);
            this.cmbUserName.Name = "cmbUserName";
            this.cmbUserName.Size = new System.Drawing.Size(122, 21);
            this.cmbUserName.TabIndex = 10;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(102, 138);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(122, 25);
            this.btnLogIn.TabIndex = 12;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(102, 68);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(122, 20);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.Text = "admin";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(30, 71);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(59, 13);
            this.lblPass.TabIndex = 13;
            this.lblPass.Text = "Password: ";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(30, 31);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(66, 13);
            this.lblUser.TabIndex = 14;
            this.lblUser.Text = "User Name: ";
            // 
            // Version_lbl
            // 
            this.Version_lbl.AutoSize = true;
            this.Version_lbl.Location = new System.Drawing.Point(7, 202);
            this.Version_lbl.Name = "Version_lbl";
            this.Version_lbl.Size = new System.Drawing.Size(48, 13);
            this.Version_lbl.TabIndex = 16;
            this.Version_lbl.Text = " Version:";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 220);
            this.Controls.Add(this.Version_lbl);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cmbUserName);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IP-PQM DB";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbUserName;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label Version_lbl;
    }
}

