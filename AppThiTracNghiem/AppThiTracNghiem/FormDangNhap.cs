using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppThiTracNghiem
{
    public partial class FormDangNhap : DevExpress.XtraEditors.XtraForm
    {
        private SqlConnection connPublisher = new SqlConnection();
        
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
            cbbTenCS.SelectedIndex = 1;cbbTenCS.SelectedIndex = 0;
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
            if ((txtLogin.Text.Trim() == "" || txtPassword.Text.Trim() == "") )
            {
                MessageBox.Show("Login name và mật mã không được trống", "", MessageBoxButtons.OK);
                return;
            }
            if ((rdbGV.Checked || rdbSV.Checked))
            {
                MessageBox.Show("Vui lòng chọn Sinh viên hoặc Giáo viên", "", MessageBoxButtons.OK);
                return;
            }

             
        }
    }
}