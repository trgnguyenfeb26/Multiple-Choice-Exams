using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AppThiTracNghiem
{
    public partial class FormDoiMK : DevExpress.XtraEditors.XtraForm
    {
        public FormDoiMK()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void btnDMK_Click(object sender, EventArgs e)
        {
            if ((txtMK.Text.Trim() == "" || txtMKM.Text.Trim() == ""))
            {
                MessageBox.Show("Mật khẩu cũ và mật mã mới không được trống", "", MessageBoxButtons.OK);
                return;
            }
            if ((txtMKM.Text.ToString() != txtXN.Text.ToString()))
            {
                MessageBox.Show("Nhập lại mật khẩu không trùng với mật khẩu mới ", "", MessageBoxButtons.OK);
                return;
            }
            if (Program.mGroup == "SinhVien")
            {
                try
                {

                    if (Program.ExecSqlNonQuery("exec [dbo].[SP_DoiMatKhauSV] '"
                        + Program.username + "', '" + GetMD5(txtMK.Text.ToString().Trim()) + "', '" + GetMD5(txtMKM.Text.ToString().Trim()) + "'") != 1)
                    {
                        MessageBox.Show("Dổi mật khẩu thành công", "", MessageBoxButtons.OK);
                        this.Close();
                    }

                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {
                try
                {

                    if (Program.ExecSqlNonQuery("ALTER LOGIN "+ Program.mlogin 
                        +" WITH PASSWORD = '"+txtMKM.Text.ToString().Trim() 
                        + "' OLD_PASSWORD = '"+txtMK.Text.ToString().Trim()+"'") != 1)
                    {
                        MessageBox.Show("Dổi mật khẩu thành công", "", MessageBoxButtons.OK);
                        this.Close();
                    }

                }
                catch (Exception )
                {

                    XtraMessageBox.Show("Dổi mật khẩu KHÔNG thành công\n", " ", MessageBoxButtons.OK);
                    //throw;
                    return;
                }
            }
            
        }
    }
}