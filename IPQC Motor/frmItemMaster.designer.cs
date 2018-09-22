namespace IPQC_Motor
{
    partial class frmItemMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemMaster));
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvTester = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDwr = new System.Windows.Forms.TextBox();
            this.picbox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSaveImg = new System.Windows.Forms.Button();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTester)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(181, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 33);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add / Edit";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvTester
            // 
            this.dgvTester.AllowUserToAddRows = false;
            this.dgvTester.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.dgvTester.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTester.Location = new System.Drawing.Point(0, 84);
            this.dgvTester.Name = "dgvTester";
            this.dgvTester.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTester.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTester.RowHeadersVisible = false;
            this.dgvTester.RowTemplate.Height = 21;
            this.dgvTester.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvTester.Size = new System.Drawing.Size(639, 378);
            this.dgvTester.TabIndex = 12;
            this.dgvTester.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvTester_RowsAdded);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(433, 25);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 33);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(307, 25);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 33);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Drawing No";
            // 
            // txtDwr
            // 
            this.txtDwr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDwr.Location = new System.Drawing.Point(40, 35);
            this.txtDwr.Name = "txtDwr";
            this.txtDwr.Size = new System.Drawing.Size(130, 20);
            this.txtDwr.TabIndex = 14;
            // 
            // picbox
            // 
            this.picbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbox.Location = new System.Drawing.Point(644, 84);
            this.picbox.Name = "picbox";
            this.picbox.Size = new System.Drawing.Size(378, 378);
            this.picbox.TabIndex = 15;
            this.picbox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSaveImg);
            this.groupBox1.Controls.Add(this.txtLink);
            this.groupBox1.Controls.Add(this.btnBrowser);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(578, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 76);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image";
            // 
            // btnSaveImg
            // 
            this.btnSaveImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveImg.Location = new System.Drawing.Point(331, 25);
            this.btnSaveImg.Name = "btnSaveImg";
            this.btnSaveImg.Size = new System.Drawing.Size(90, 33);
            this.btnSaveImg.TabIndex = 16;
            this.btnSaveImg.Text = "Save Image";
            this.btnSaveImg.UseVisualStyleBackColor = true;
            this.btnSaveImg.Click += new System.EventHandler(this.btnSaveImg_Click);
            // 
            // txtLink
            // 
            this.txtLink.Enabled = false;
            this.txtLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLink.Location = new System.Drawing.Point(89, 19);
            this.txtLink.Multiline = true;
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(236, 51);
            this.txtLink.TabIndex = 15;
            // 
            // btnBrowser
            // 
            this.btnBrowser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowser.Location = new System.Drawing.Point(6, 25);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(74, 33);
            this.btnBrowser.TabIndex = 12;
            this.btnBrowser.Text = "Browser:";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.txtDwr);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(566, 76);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edit";
            // 
            // frmItemMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1023, 464);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picbox);
            this.Controls.Add(this.dgvTester);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmItemMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Measurement Item Edit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmItemMaster_FormClosing);
            this.Load += new System.EventHandler(this.Form7_2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTester)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvTester;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDwr;
        private System.Windows.Forms.PictureBox picbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSaveImg;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

