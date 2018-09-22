namespace IPQC_Part
{
    partial class frmChangePass
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
            this.txtOldPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOldPass
            // 
            this.txtOldPass.Location = new System.Drawing.Point(118, 29);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.PasswordChar = '*';
            this.txtOldPass.Size = new System.Drawing.Size(130, 20);
            this.txtOldPass.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Old Password:";
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(118, 65);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '*';
            this.txtNewPass.Size = new System.Drawing.Size(130, 20);
            this.txtNewPass.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "New Password:";
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Location = new System.Drawing.Point(118, 100);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.PasswordChar = '*';
            this.txtConfirmPass.Size = new System.Drawing.Size(130, 20);
            this.txtConfirmPass.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Confirm Password:";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(97, 153);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(97, 34);
            this.btnOk.TabIndex = 13;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 199);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOldPass);
            this.Controls.Add(this.label3);
            this.Name = "frmChangePass";
            this.Text = "ChangePass";
            this.Load += new System.EventHandler(this.frmChangePass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOldPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOk;
    }
}