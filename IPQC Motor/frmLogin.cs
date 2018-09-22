using System;
using System.Drawing;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Net;
using System.Text;

namespace IPQC_Motor
{
    public partial class frmLogin : Form
    {
        string str_md5;
        // コンストラクタ
        /// <summary>
        // application name that is given from caller application for displaying itself with version on login screen
        /// </summary>
        private string applicationName;
        public frmLogin()
        {
            

            InitializeComponent();
        }

        // ロード時の処理（コンボボックスに、オートコンプリート機能の追加）
        private void Form5_Load(object sender, EventArgs e)
        {
            if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
            {

                Version deploy = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion;

                StringBuilder version = new StringBuilder();
                version.Append("VERSION: ");
                //version.Append(applicationName + "_");
                version.Append(deploy.Major);
                version.Append(".");
                version.Append(deploy.Minor);
                version.Append(".");
                version.Append(deploy.Build);
                version.Append(".");
                version.Append(deploy.Revision);

                Version_lbl.Text = version.ToString();
            }
            TfSQL con = new TfSQL();
            string sql = "select distinct user_name from m_user order by user_name";
            con.getComboBoxData(sql, ref cmbUserName);

            AcceptButton = btnLogIn;
        }
      
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            TfSQL con = new TfSQL();
            string sql = "select user_pass from m_user where  user_name = '" + cmbUserName.Text + "'";
           string pass=  con.sqlExecuteScalarString(sql);
            try
            {
                if (pass == txtPassword.Text)
                {               
                    frmItem frm = new frmItem(cmbUserName.Text);
                    frm.ShowDialog();
                }
                else
                {

                    MessageBox.Show("Pasword is incorrect", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            catch 
            {
                MessageBox.Show("An error happened in the process.", "Error",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
              
            }
        }
    }
}