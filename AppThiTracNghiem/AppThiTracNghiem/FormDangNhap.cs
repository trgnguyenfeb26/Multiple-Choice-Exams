using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace AppThiTracNghiem
{
    public partial class FormDangNhap : DevExpress.XtraEditors.XtraForm
    {
        private SqlConnection connPublisher = new SqlConnection();
        private const String accountStudent = "SV";
        private const String passwordStudent = "123";
        private void LayDSPM(string cmd)
        {
            DataTable dt = new DataTable();
            if (connPublisher.State == ConnectionState.Closed) connPublisher.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, connPublisher);
            da.Fill(dt);
            connPublisher.Close();
            Program.bds_dspm.DataSource = dt;
            cbbTenCS.DataSource = Program.bds_dspm;
            cbbTenCS.DisplayMember = "TENCS"; cbbTenCS.ValueMember = "TENSERVER";
        }
        public string GetMD5(string chuoi)
        {
            string str_md5 = "";
            byte[] mang = System.Text.Encoding.UTF8.GetBytes(chuoi);

            MD5CryptoServiceProvider my_md5 = new MD5CryptoServiceProvider();
            mang = my_md5.ComputeHash(mang);

            foreach (byte b in mang)
            {
                str_md5 += b.ToString("X2");
            }

            return str_md5;
        }
        public FormDangNhap()
        {
            InitializeComponent();
        }
        private int KetNoiCSDLGoc()
        {
            if (connPublisher != null && connPublisher.State == ConnectionState.Open)
                connPublisher.Close();
            try
            {
                connPublisher.ConnectionString = Program.connstrPublisher;
                connPublisher.Open();
                return 1;
            }
            catch (Exception e)
            {
                XtraMessageBox.Show("Lỗi kết nối về CSDL gốc.\nBạn xem lại tên server của publiser, và tên CSDL trong chuối kết nối.\n" + e.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            if (KetNoiCSDLGoc() == 0) return;
            LayDSPM("SELECT * FROM Get_Subscribes");

            cbbTenCS.SelectedIndex = 1;
            cbbTenCS.SelectedIndex = 0;
        }



        private void cbbTenCS_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = cbbTenCS.SelectedValue.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if ((txtLogin.Text.Trim() == "" || txtPassword.Text.Trim() == ""))
            {
                MessageBox.Show("Login name và mật mã không được trống", "", MessageBoxButtons.OK);
                return;
            }

            if (rdbSV.Checked)
            {
                Program.mlogin = accountStudent;
                Program.password = passwordStudent;
                if (Program.KetNoi() == 0) return;

                Program.mCoso = cbbTenCS.SelectedIndex;

                Program.loginDN = txtLogin.Text.ToString();
                Program.passwordDN = GetMD5(txtPassword.Text.ToString());
                string strLenh = "EXEC SP_LayThongTinSinhVien '" + Program.loginDN + "','" + Program.passwordDN + "'";
                Program.myReader = Program.ExecSqlDataReader(strLenh);
                if (Program.myReader == null) return;
                Program.myReader.Read();
                Program.username = Program.myReader.GetString(0);
                if (Convert.IsDBNull(Program.username))
                {
                    MessageBox.Show("Không có quyền truy cập dữ liệu \n.", "", MessageBoxButtons.OK);
                    return;

                }
                Program.mHoten = Program.myReader.GetString(1);
                Program.mGroup = Program.myReader.GetString(2);
                //Program.NgaySinhSV = Program.myReader.GetDateTime(3).ToString();
                //Program.DiaChiSV = Program.myReader.GetString(4);
                Program.MaLopSV = Program.myReader.GetString(5);
                Program.myReader.Close();
                Program.conn.Close();
            }
            if (rdbGV.Checked)
            {
                Program.mlogin = txtLogin.Text;
                Program.password = txtPassword.Text;
                if (Program.KetNoi() == 0) return;

                Program.mCoso = cbbTenCS.SelectedIndex;

                Program.loginDN = Program.mlogin;
                Program.passwordDN = Program.password;
                string strLenh = "EXEC SP_LayThongTinGiaoVien'" + Program.mlogin + "'";
                try
                {
                    Program.myReader = Program.ExecSqlDataReader(strLenh);
                    if (Program.myReader == null) return;
                    Program.myReader.Read();
                    Program.username = Program.myReader.GetString(0);     // Lay user name
                    Program.mHoten = Program.myReader.GetString(1);
                }
                catch(Exception )
                {
                    throw;
                   
                }
                
                
                
                if (Convert.IsDBNull(Program.mHoten))
                {
                    MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username, password", "", MessageBoxButtons.OK);
                    return;
                }

                Program.mGroup = Program.myReader.GetString(2);

                if (Convert.IsDBNull(Program.username))
                {
                    MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username, password", "", MessageBoxButtons.OK);
                    return;
                }

                Program.myReader.Close();
                Program.conn.Close();
            }
            Program.frmChinh.hienThiMenu();
            this.Visible = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rdbGV_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Tài khoản:";
        }

        private void rdbSV_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Mã số SV:";
        }
    }
}