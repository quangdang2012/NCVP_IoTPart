namespace IPQC_Part
{
    partial class frmRegisterUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPermision = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password:";
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(84, 148);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '*';
            this.txtNewPass.Size = new System.Drawing.Size(142, 20);
            this.txtNewPass.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dept:";
            // 
            // cmbDept
            // 
            this.cmbDept.FormattingEnabled = true;
            this.cmbDept.Location = new System.Drawing.Point(84, 70);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(142, 21);
            this.cmbDept.TabIndex = 3;
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Location = new System.Drawing.Point(84, 186);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.PasswordChar = '*';
            this.txtConfirmPass.Size = new System.Drawing.Size(142, 20);
            this.txtConfirmPass.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Confirm Pass:";
            // 
            // cmbPermision
            // 
            this.cmbPermision.FormattingEnabled = true;
            this.cmbPermision.Location = new System.Drawing.Point(84, 108);
            this.cmbPermision.Name = "cmbPermision";
            this.cmbPermision.Size = new System.Drawing.Size(142, 21);
            this.cmbPermision.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Permision:";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(98, 228);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(87, 34);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(84, 30);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(142, 20);
            this.txtUserName.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "UserName:";
            // 
            // frmRegisterUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 296);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cmbPermision);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbDept);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.label1);
            this.Name = "frmRegisterUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegisterUser";
            this.Load += new System.EventHandler(this.frmRegisterUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDept;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPermision;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label5;
    }
}