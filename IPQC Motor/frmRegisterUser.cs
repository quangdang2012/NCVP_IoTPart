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
    public partial class frmRegisterUser : Form
    {
        string username;
        public frmRegisterUser(string username_)
        {
            InitializeComponent();
            username = username_;
        }

        private void frmRegisterUser_Load(object sender, EventArgs e)
        {
            IPQC_Motor.TfSQL con = new IPQC_Motor.TfSQL();
            string sqldept = "select distinct user_dept_cd from m_user order by user_dept_cd";
            con.getComboBoxData(sqldept, ref cmbDept);

            string sqlPermision = "select distinct user_permision from m_user order by user_permision";
            con.getComboBoxData(sqlPermision, ref cmbPermision);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string datetime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            if (checkdata())
            {
                if (txtNewPass.Text == txtConfirmPass.Text)
                {
                    //insert user into database.
                    string sqlinsertUser = @"insert into m_user (user_name, user_pass, user_permision,user_dept_cd,registration_date_time) VALUES  ('"
                       + txtUserName.Text + "','" + txtNewPass.Text + "','" + cmbPermision.Text + "','" + cmbDept.Text + "','"+ datetime+ "')";

                    IPQC_Motor.TfSQL con = new IPQC_Motor.TfSQL();
                    con.sqlExecuteScalarString(sqlinsertUser);
                    MessageBox.Show("User: '" + txtUserName.Text + "' is created", "Info");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Password is incorrect", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                MessageBox.Show("Pls, insert fill full data", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

        }
        bool checkdata()
        {
            if (txtUserName.Text == "")
                return false;
            if (cmbDept.SelectedItem == null)
                return false;
            if (cmbPermision.SelectedItem == null)
                return false;
            if (txtConfirmPass.Text == "")
                return false;
            if (txtNewPass.Text == "")
                return false;
            return true;
                 
        }
    }
}
