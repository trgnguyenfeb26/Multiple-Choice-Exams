using System;
using System.Collections.Generic;
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
        public static String connstrPublisher = "Data Source=DESKTOP-O30665V;Initial Catalog=TN_CSDLPT;Integrated Security=True";

        //public static SqlDataAdapter da;
        public static SqlDataReader myReader;
        public static String servername = "";
        public static String servername1 = "DESKTOP-O30665V\\MSSQLSERVER1";
        public static String servername2 = "DESKTOP-O30665V\\MSSQLSERVER2";
        public static String servername3 = "DESKTOP-O30665V\\MSSQLSERVER3";
        public static String username;
        public static String password;
        public static String mlogin;

        public static String database = "TN_CSDLPT";
        public static String remoteLogin = "HTKN";
        public static String remotePassword = "123";
        public static String loginDN = "";
        public static String passwordDN = "";
        public static String mGroup;
        public static String mHoten;
        public static int mCoso = 0;
        public static String mMaCS = "";

        public static BindingSource bds_dspm = new BindingSource();  // giữ bdsPM khi đăng nhập
        public static FormMain frmChinh;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmChinh = new FormMain();
            Application.Run(frmChinh );
            //Application.Run(new FormMain());
        }
    }
}
