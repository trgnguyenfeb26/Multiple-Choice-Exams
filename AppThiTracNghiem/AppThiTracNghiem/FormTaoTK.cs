using DevExpress.XtraEditors;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppThiTracNghiem
{
    public partial class FormTaoTK : DevExpress.XtraEditors.XtraForm
    {
        public FormTaoTK()
        {
            InitializeComponent();
        }

        private void gIAOVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsGV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormTaoTK_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);


        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "")
            {
                MessageBox.Show("Tên tài khoản không được trống!", "Lỗi", MessageBoxButtons.OK);
                txtLogin.Focus();
                return;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Mật khẩu không được trống!", "Lỗi", MessageBoxButtons.OK);
                txtPassword.Focus();
                return;
            }
            string sql = "EXEC SP_TaoTaiKhoan '" + txtLogin.Text.Trim() + "', '"
                + txtPassword.Text.Trim() + "', '" + txtUser.Text.ToString().Trim() + "', '" + cmbGroup.SelectedItem.ToString().Trim() + "'";
            if (Program.ExecSqlNonQuery(sql) == 0)
            {
                MessageBox.Show("Tạo tài khoản thành công!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void gcGV_Click(object sender, EventArgs e)
        {
            label6.Text = "dzfdsf";
            string strLenh = "EXEC SP_GetRole '" + txtUser.Text + "'";
            try
            {
                Program.myReader = Program.ExecSqlDataReader1(strLenh);
             
                if (Program.myReader == null) return;
                Program.myReader.Read();
                

                if (Program.myReader != null) label6.Text = Program.myReader.GetString(0);     // Lay user name
                
            }
            catch (Exception)
            {
               throw;
            }
            Program.myReader.Close();
            Program.conn.Close();
        }
    }
}