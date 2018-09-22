using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace IPQC_Part
{
    public partial class frmChangePass : Form
    {
      public  string username;
        public frmChangePass(string username_)
        {
            InitializeComponent();
            username = username_;
            AcceptButton = btnOk;
        }

  
        private void btnOk_Click(object sender, EventArgs e)
        {

            IPQC_Motor.TfSQL con = new IPQC_Motor.TfSQL();
            string sqlpass = "select user_pass from m_user where  user_name = '" + username + "'";
            if (txtOldPass.Text == con.sqlExecuteScalarString(sqlpass))
            {//update new password
                if (txtNewPass.Text == txtConfirmPass.Text)
                {
                    string sqlupdatepass = "update m_user set user_pass = '" + txtNewPass.Text + "' where user_name = '" + username + "'";
                    IPQC_Motor.TfSQL update = new IPQC_Motor.TfSQL();
                    update.sqlExecuteScalarString(sqlupdatepass);
                    MessageBox.Show("your Password is changed", "Info");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("New Pasword is incorrect", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                MessageBox.Show("Old Pasword is incorrect", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void frmChangePass_Load(object sender, EventArgs e)
        {

        }
    }
}
