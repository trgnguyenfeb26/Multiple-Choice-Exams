using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppThiTracNghiem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        //public static String connstrPublisher = "Data Source=MSI;Initial Catalog=TN_CSDLPT;Integrated Security=True";
        public static String connstrPublisher = "Data Source=DESKTOP-O30665V;Initial Catalog=TN_CSDLPT;Integrated Security=True";


        //public static SqlDataAdapter da;
        public static SqlDataReader myReader;
        public static String servername = "";
        public static String username;
        public static String password;
        public static String mlogin;

        public static String database = "TN_CSDLPT";
        public static String remoteLogin = "HTKN";
        public static String remotePassword = "123";
        public static String loginDN = "";
        public static String passwordDN = "";
        public static String mGroup="";
        public static String mHoten="";
        public static int mCoso = 0;
        public static String mMaCS = "";

        public static string MaLopSV;


        // luu thong tin thi
        public static String MAMH;
        public static String TD;
        public static String soCau;
        public static int time;
        public static int lanThi;
        public static String ngayThi;

        public static BindingSource bds_dspm = new BindingSource();  // giữ bdsPM khi đăng nhập
        public static FormMain frmChinh;
        public static int KetNoi()
        {
            if (conn != null && conn.State == ConnectionState.Open)
                conn.Close();
            try
            {
                connstr = "Data Source=" + servername + ";Initial Catalog=" + database +
                    ";User ID=" + mlogin + ";password=" + password;
                conn.ConnectionString = connstr;
                conn.Open();
                return 1;
            }
            catch (Exception e)
            {
                XtraMessageBox.Show("Lỗi kết nối CSDL.\nBạn xem lại tài khoản và mật khẩu.\n" + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }
        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 600;
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader();
                return myreader;
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static SqlDataReader ExecSqlDataReader1(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandTimeout = 600;
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader();
                return myreader;
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public static int ExecSqlNonQuery(String strlenh)
        {
            SqlCommand Sqlcmd = new SqlCommand(strlenh, conn);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 600;// 10 phut 
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sqlcmd.ExecuteNonQuery();
                conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {

                if (ex.Message.Contains("Cannot alter the login '"+Program.mlogin.Trim()+"', because it does not exist or you do not have permission."))
                    MessageBox.Show("Mật khẩu cũ không đúng");
                else MessageBox.Show(ex.Message);
                conn.Close();
                return ex.State; // trang thai lỗi gởi từ RAISERROR trong SQL Server qua
            }
        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmChinh = new FormMain();
            //Application.Run(new FormMain());
            Application.Run(frmChinh);
        }
    }
}
