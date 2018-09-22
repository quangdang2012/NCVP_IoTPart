using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;
using System.Management;
using System.Drawing.Drawing2D;
using Npgsql;

namespace IPQC_Motor
{
    public partial class frmItemMaster : Form
    {
        public string Model;
        public string DrawingCd;
        public string User;
        // コンストラクタ
        public frmItemMaster(string drawing_cd, string user)
        {
            InitializeComponent();
            DrawingCd = drawing_cd;
            User = user;
        }

        // ロード時の処理
        private void Form7_2_Load(object sender, EventArgs e)
        {
            LoadItem();
        }
        public DataTable dt;
        public void LoadItem()
        {
            txtDwr.Text = DrawingCd;
            string sql = "select item_id,a.dwr_id , item_measure,  item_symbol,item_tool,item_row,item_detail,item_spec_x,  item_lower, item_upper  from m_item a left join m_drawing b on a.dwr_id = b.dwr_id where b.dwr_cd = '" + DrawingCd + "'  ";
            TfSQL tfSql = new TfSQL();
            dt = new DataTable();
            tfSql.sqlDataAdapterFillDatatable(sql, ref dt);

            dgvTester.DataSource = dt;

            //Fix DGV

            //dgvTester.Columns["item_id"].HeaderText = "Id";
            //dgvTester.Columns["dwr_cd"].HeaderText = "Drawing";
            dgvTester.Columns["item_id"].Visible = false;
            dgvTester.Columns["dwr_id"].Visible = false;
            dgvTester.Columns["item_measure"].HeaderText = "Measure Item";
            dgvTester.Columns["item_symbol"].HeaderText = "Symbol";
            dgvTester.Columns["item_spec_x"].HeaderText = "Spec";
            dgvTester.Columns["item_lower"].HeaderText = "Lower";
            dgvTester.Columns["item_upper"].HeaderText = "Upper";
            dgvTester.Columns["item_tool"].HeaderText = "Tool";
            dgvTester.Columns["item_detail"].HeaderText = "Detail";
            dgvTester.Columns["item_row"].HeaderText = "Row";

            dgvTester.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dgvTester.Columns["item_measure"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgvTester.Columns["item_measure"].Width = 100;

            //Load Image to picture box

            string bytePic = tfSql.sqlExecuteScalarString("select dwr_image from m_drawing where dwr_cd = '" + DrawingCd + "'");
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgvTester.ReadOnly = false;
            dgvTester.AllowUserToAddRows = true;
            btnSave.Enabled = true;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
        }

        // 既存レコードの削除
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTester.Rows.Count > 0)
            {
                int rowIndex = dgvTester.CurrentRow.Index;
                DialogResult dialog = MessageBox.Show("Do you want to delete Measure item no " + dgvTester.Rows[rowIndex].Cells["item_measure"].Value.ToString(), "Note !", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.Yes)
                {
                    TfSQL tfsql = new TfSQL();

                    int item_measure = int.Parse(dgvTester.Rows[rowIndex].Cells["item_measure"].Value.ToString());
                    string sqlDelete = @"delete from m_item where dwr_id = (select dwr_id from m_drawing where dwr_cd = '" + DrawingCd +
                        "') and item_measure = " + item_measure;
                    bool del = tfsql.sqlExecuteNonQuery(sqlDelete, true);
                    LoadItem();
                }
            }
        }

        // 保存
        private void btnSave_Click(object sender, EventArgs e)
        {
            TfSQL tfsql = new TfSQL();

            bool save = tfsql.sqlMultipleInsertItem(DrawingCd, ref dt, User);
            if (save)
            {
                dgvTester.AllowUserToAddRows = false;
                dgvTester.ReadOnly = true;
                btnSave.Enabled = false;
                btnAdd.Enabled = true;
                btnDelete.Enabled = true;
            }
        }
        private void dgvTester_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (btnAdd.Enabled == false)
            {
                TfSQL tf = new TfSQL();
                string itemId = tf.sqlExecuteScalarString("select max(item_id) +1 from m_item");
                string drwId = tf.sqlExecuteScalarString("select dwr_id from m_drawing where dwr_cd = '" + DrawingCd + "'");
                if (dgvTester.Rows.Count >= 1)
                {
                    dgvTester.Rows[dgvTester.Rows.Count - 2].Cells["item_id"].Value = itemId;
                    dgvTester.Rows[dgvTester.Rows.Count - 2].Cells["dwr_id"].Value = drwId;
                }
                else if (dgvTester.Rows.Count == 0)
                {
                    dgvTester.Rows[0].Cells["item_id"].Value = itemId;
                    dgvTester.Rows[0].Cells["dwr_id"].Value = drwId;
                }
            }
        }

        private void frmItemMaster_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btnSave.Enabled == true)
            {
                DialogResult dialog = MessageBox.Show("Data not saved !", "Note !", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Title = "Open Image File";
            file.Filter = "Image files|*.jpg;*.png";

            if (file.ShowDialog() == DialogResult.OK)
            {
                if (file.FileName != "")
                {
                    txtLink.Text = file.FileName.ToString();
                    long size = new System.IO.FileInfo(txtLink.Text).Length / 1024;
                    bool doing = false;
                    if (size > 310)
                    {
                        DialogResult dialog = MessageBox.Show("File size is greater than 300 Kb !" + System.Environment.NewLine + "Do you want continue!", "Note!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dialog == DialogResult.Yes)
                        {
                            doing = true;
                        }
                    }
                    else doing = true;

                    if (doing == true)
                    {

                        byte[] img = System.IO.File.ReadAllBytes(txtLink.Text);
                        MemoryStream meStream = new MemoryStream(img);

                        picbox.Image = new Bitmap(meStream);
                        picbox.SizeMode = PictureBoxSizeMode.Zoom;

                        doing = false;
                    }
                }
                else
                {
                    MessageBox.Show("No file selected!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtLink.Text = "";
                }
            }
        }

        private void btnSaveImg_Click(object sender, EventArgs e)
        {
            if (txtLink.Text != "")
            {
                FileStream fs = new FileStream(txtLink.Text, FileMode.Open, FileAccess.Read);
                byte[] pic = new byte[fs.Length];
                fs.Read(pic, 0, System.Convert.ToInt32(fs.Length));
                fs.Close();

                TfSQL sql = new TfSQL();
                int dwrId = int.Parse(sql.sqlExecuteScalarString("select dwr_id from m_drawing where dwr_cd = '" + DrawingCd + "'"));
                string sqlEx = "update m_drawing set dwr_image = '" + Convert.ToBase64String(pic) + "' where dwr_id = " + dwrId;
                bool bsave = true;
                sql.sqlExecuteNonQueryInt(sqlEx, bsave);
            }
            else
            {
                MessageBox.Show("Select a file !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLink.Text = "";
            }
        }
    }
}