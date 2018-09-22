using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Drawing;
using System.IO;
namespace IPQC_Part
{
    public partial class frmFMS : Form
    {
        public string username;
        public string drawingcd;
        DataTable dtInspectItems;
        public frmFMS(string username_, string drawingcd_)
        {
            InitializeComponent();
            username = username_;
            drawingcd = drawingcd_;
            txtUser.Text = username;
            gpbBanVe.Text = "Bản Vẽ Số: " + drawingcd;
        }
        void callpic()
        {
            IPQC_Motor.TfSQL tfSql = new IPQC_Motor.TfSQL();
            string bytePic = tfSql.sqlExecuteScalarString("select dwr_image from m_drawing where dwr_cd = '" + drawingcd + "'");
            if (bytePic != "")
            {
                byte[] imgBytes = Convert.FromBase64String(bytePic);
                MemoryStream ms = new MemoryStream(imgBytes, 0, imgBytes.Length);
                ms.Write(imgBytes, 0, imgBytes.Length);
                Image image = Image.FromStream(ms, true);

                picbox.Image = image;
                picbox.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
        private void cmbMaSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlPageID = "select case when max(page_id) is null then 1 else max(page_id) +1 end as maxcode from  m_header";
            IPQC_Motor.TfSQL con = new IPQC_Motor.TfSQL();
            con.sqlExecuteScalarString(sqlPageID);
        }
        private void frmFMS_Load(object sender, EventArgs e)
        {
            IPQC_Motor.TfSQL con = new IPQC_Motor.TfSQL();
            string sqlProcedure = @"
            select distinct header_procedure from
            (select header_procedure, user_dept_cd from m_header a, m_user b where a.user_id = b.user_id)t, m_user a
            where a.user_dept_cd = t.user_dept_cd and a.user_name = '" + username + "' order by header_procedure";
            con.getComboBoxData(sqlProcedure, ref cmbQuiTrinh);

            string sqlMachine = @"
            select distinct header_machine from
            (select header_machine, user_dept_cd from m_header a, m_user b where a.user_id = b.user_id)t, m_user a
            where a.user_dept_cd = t.user_dept_cd and a.user_name = '" + username + "' order by header_machine";
            con.getComboBoxData(sqlMachine, ref cmbMaSo);

            callpic();

        }


        bool checkdata()
        {
            if (cmbQuiTrinh.Text == "")
                return false;
            if (cmbSLMau.SelectedItem == null)
                return false;
            if (dtpKhungGio.Text == "")
                return false;
            if (cmbPhuongThuc.SelectedItem == null)
                return false;
            if (cmbKhuVuc.SelectedItem == null)
                return false;
            if (cmbNgoaiQuan.SelectedItem == null)
                return false;
            if (txtUser.Text == "")
                return false;
            if (cmbDanhGia.Text == "OK")
            {
                MessageBox.Show("Không thể đánh giá OK Khi chưa đo xong Hàng", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
            return true;
        }

        void insertintodatabase()
        {
            NpgsqlConnection connection = new NpgsqlConnection(IPQC_Motor.TfSQL.conStringIpqcDbP4);
            connection.Open();
            try
            {
                //create page id
                string sqlPageID = "select case when max(page_id) is null then 1 else max(page_id) +1 end as maxcode from  m_header";
                NpgsqlCommand commandPageId = new NpgsqlCommand(sqlPageID, connection);
                int pageId = int.Parse(commandPageId.ExecuteScalar().ToString());

                //insert into m_data
                string sql1 = @"insert into m_data
                            (page_id, item_id, item_lower, item_upper, data_check, user_id, registration_date_time )
                            (select " + pageId + @", a.item_id, a.item_lower, a.item_upper,'" + cmbNgoaiQuan.Text + @"',(select user_id from m_user where user_name= '" + username + @"'), now() from m_item a 
                            left join m_drawing b  on b.dwr_id = a.dwr_id
                            where 
                            b.dwr_cd = '" + drawingcd + "')";
                NpgsqlCommand command1 = new NpgsqlCommand(sql1, connection);
                command1.ExecuteScalar();

                //insert into m_header table.
                string sql2 = @"insert into m_header(page_id, header_machine , header_time,  header_procedure, header_method, header_sample,header_area,
                                header_content, footer_note, footer_result, footer_datemake, footer_lot, user_id, registration_date_time) 
                                VALUES (:page_id,
                                 :header_machine, :header_time, :header_procedure, :header_method, :header_sample, :header_area,
                                 :header_content, :footer_note, :footer_result, :footer_datemake, :footer_lot, (select user_id from m_user where user_name= :user_name), now())";
                NpgsqlCommand command2 = new NpgsqlCommand(sql2, connection);

                command2.Parameters.Add(new NpgsqlParameter("header_machine", NpgsqlTypes.NpgsqlDbType.Varchar));    //0
                command2.Parameters.Add(new NpgsqlParameter("header_time", NpgsqlTypes.NpgsqlDbType.Varchar));       // 1
                command2.Parameters.Add(new NpgsqlParameter("header_procedure", NpgsqlTypes.NpgsqlDbType.Varchar));  //2
                command2.Parameters.Add(new NpgsqlParameter("header_method", NpgsqlTypes.NpgsqlDbType.Varchar));     //3
                command2.Parameters.Add(new NpgsqlParameter("header_sample", NpgsqlTypes.NpgsqlDbType.Integer));     //4
                command2.Parameters.Add(new NpgsqlParameter("header_area", NpgsqlTypes.NpgsqlDbType.Varchar));      //5
                command2.Parameters.Add(new NpgsqlParameter("header_content", NpgsqlTypes.NpgsqlDbType.Varchar));   //6
                command2.Parameters.Add(new NpgsqlParameter("footer_note", NpgsqlTypes.NpgsqlDbType.Varchar));      //7
                command2.Parameters.Add(new NpgsqlParameter("footer_result", NpgsqlTypes.NpgsqlDbType.Varchar));    //8
                command2.Parameters.Add(new NpgsqlParameter("footer_datemake", NpgsqlTypes.NpgsqlDbType.Date));     //9
                command2.Parameters.Add(new NpgsqlParameter("footer_lot", NpgsqlTypes.NpgsqlDbType.Varchar));       //10
                command2.Parameters.Add(new NpgsqlParameter("user_name", NpgsqlTypes.NpgsqlDbType.Varchar));        //11
                command2.Parameters.Add(new NpgsqlParameter("page_id", NpgsqlTypes.NpgsqlDbType.Integer));          //12

                //header design
                command2.Parameters[0].Value = cmbMaSo.Text;
                command2.Parameters[1].Value = dtpKhungGio.Text;
                command2.Parameters[2].Value = cmbQuiTrinh.Text;
                command2.Parameters[3].Value = cmbPhuongThuc.Text;
                command2.Parameters[4].Value = int.Parse(cmbSLMau.Text);
                command2.Parameters[5].Value = cmbKhuVuc.Text;
                command2.Parameters[6].Value = txtNoiDung.Text;
                //footder design
                command2.Parameters[7].Value = txtGhiChu.Text;
                command2.Parameters[8].Value = cmbDanhGia.Text;
                command2.Parameters[9].Value = DateTime.Parse(dtpGiaCong.Value.ToString("yyyy-MM-dd"));
                command2.Parameters[10].Value = txtLot.Text;
                command2.Parameters[11].Value = username;
                command2.Parameters[12].Value = pageId;

                command2.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Successful!", "Database Responce", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database not connected + " + ex.ToString(), "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        void buildDGV(ref DataGridView dgv)
        {
            //create datagipview
            dtInspectItems = new DataTable();
            dtInspectItems.Clear();
            string sql = @"
                        select a.item_measure, a.item_detail, a.item_spec_x, a.item_lower, a.item_upper,
                       (a.item_upper  - a.item_spec_x) as tolerance_up , (a.item_lower  - a.item_spec_x) as tolerances_low,a.item_tool,  
                        b.data_1, b.data_2, b.data_3, b.data_4, b.data_5, b.data_x, b.data_est, b.registration_date_time   from m_item a left join
                        (select dwr_cd,dwr_id, user_dept_cd from m_drawing a, m_user b where a.user_id = b.user_id) c on a.dwr_id = c.dwr_id
                        left join m_data b on a.item_id = b.item_id where c.dwr_cd = '" + drawingcd + "' and c.user_dept_cd = (select distinct user_dept_cd from m_user where user_name = '" + username + @"')
                        order by registration_date_time desc, item_measure asc ";
            IPQC_Motor.TfSQL con = new IPQC_Motor.TfSQL();
            con.sqlDataAdapterFillDatatable(sql, ref dtInspectItems);
            dgv.DataSource = dtInspectItems;
        }
        private void defineItemTable(ref DataTable dt)
        {
            dt.Columns.Add("item_measure", Type.GetType("System.String"));
            dt.Columns.Add("item_detail", Type.GetType("System.String"));
            dt.Columns.Add("item_spec_x", Type.GetType("System.String"));
            dt.Columns.Add("item_lower", Type.GetType("System.Double"));
            dt.Columns.Add("item_upper", Type.GetType("System.Double"));
            dt.Columns.Add("tolerance_up", Type.GetType("System.Double"));
            dt.Columns.Add("tolerances_low", Type.GetType("System.Double"));
            dt.Columns.Add("item_tool", Type.GetType("System.String"));
            dt.Columns.Add("data_1", Type.GetType("System.Double"));
            dt.Columns.Add("data_2", Type.GetType("System.Double"));
            dt.Columns.Add("data_3", Type.GetType("System.Double"));
            dt.Columns.Add("data_4", Type.GetType("System.Double"));
            dt.Columns.Add("data_5", Type.GetType("System.Double"));
            dt.Columns.Add("data_x", Type.GetType("System.Double"));
            dt.Columns.Add("data_est", Type.GetType("System.String"));
            dt.Columns.Add("registration_date_time", Type.GetType("System.DateTime"));
        }
        private void btnTaoForm_Click(object sender, EventArgs e)
        {
            if (checkdata())
            {

                //insert data  
                insertintodatabase();
                buildDGV(ref dgvMeasureData);
            }
            else
            {
                MessageBox.Show("Chọn đầy đủ thông tin có dấu (*) ", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

        }

      
    }
}
