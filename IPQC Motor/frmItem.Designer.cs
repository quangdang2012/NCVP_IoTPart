namespace IPQC_Motor
{
    partial class frmItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItem));
            this.label3 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSubModel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditMaster = new System.Windows.Forms.Button();
            this.dgvMeasureItem = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeasureItem)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(799, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "User: ";
            // 
            // txtUser
            // 
            this.txtUser.Enabled = false;
            this.txtUser.Location = new System.Drawing.Point(802, 53);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(130, 20);
            this.txtUser.TabIndex = 1;
            // 
            // cmbModel
            // 
            this.cmbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(12, 49);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(118, 21);
            this.cmbModel.TabIndex = 10;
            this.cmbModel.SelectedIndexChanged += new System.EventHandler(this.cmbModel_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Model: ";
            // 
            // cmbSubModel
            // 
            this.cmbSubModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubModel.FormattingEnabled = true;
            this.cmbSubModel.Location = new System.Drawing.Point(158, 50);
            this.cmbSubModel.Name = "cmbSubModel";
            this.cmbSubModel.Size = new System.Drawing.Size(170, 21);
            this.cmbSubModel.TabIndex = 12;
            this.cmbSubModel.SelectedIndexChanged += new System.EventHandler(this.cmbSubModel_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Sub Model:";
            // 
            // btnEditMaster
            // 
            this.btnEditMaster.Location = new System.Drawing.Point(938, 50);
            this.btnEditMaster.Name = "btnEditMaster";
            this.btnEditMaster.Size = new System.Drawing.Size(91, 23);
            this.btnEditMaster.TabIndex = 13;
            this.btnEditMaster.Text = "Edit Master";
            this.btnEditMaster.UseVisualStyleBackColor = true;
            this.btnEditMaster.Visible = false;
            this.btnEditMaster.Click += new System.EventHandler(this.btnEditMaster_Click);
            // 
            // dgvMeasureItem
            // 
            this.dgvMeasureItem.AllowUserToAddRows = false;
            this.dgvMeasureItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMeasureItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMeasureItem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMeasureItem.Location = new System.Drawing.Point(0, 93);
            this.dgvMeasureItem.Name = "dgvMeasureItem";
            this.dgvMeasureItem.ReadOnly = true;
            this.dgvMeasureItem.Size = new System.Drawing.Size(1029, 657);
            this.dgvMeasureItem.TabIndex = 14;
            this.dgvMeasureItem.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMeasureItem_CellDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userInfoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1029, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userInfoToolStripMenuItem
            // 
            this.userInfoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem,
            this.registerUserToolStripMenuItem});
            this.userInfoToolStripMenuItem.Name = "userInfoToolStripMenuItem";
            this.userInfoToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.userInfoToolStripMenuItem.Text = "User Info";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // registerUserToolStripMenuItem
            // 
            this.registerUserToolStripMenuItem.Name = "registerUserToolStripMenuItem";
            this.registerUserToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.registerUserToolStripMenuItem.Text = "RegisterUser";
            this.registerUserToolStripMenuItem.Click += new System.EventHandler(this.registerUserToolStripMenuItem_Click);
            // 
            // frmItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1029, 750);
            this.Controls.Add(this.dgvMeasureItem);
            this.Controls.Add(this.btnEditMaster);
            this.Controls.Add(this.cmbSubModel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbModel);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Measurement Item main";
            this.Load += new System.EventHandler(this.frmItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeasureItem)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSubModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEditMaster;
        private System.Windows.Forms.DataGridView dgvMeasureItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerUserToolStripMenuItem;
    }
}

