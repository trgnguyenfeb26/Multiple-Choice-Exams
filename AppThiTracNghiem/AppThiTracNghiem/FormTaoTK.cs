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
            // TODO: This line of code loads data into the 'dS.Get_TaoTK' table. You can move, or remove it, as needed.
            
            dS.EnforceConstraints = false;
            this.get_TaoTKTableAdapter.Connection.ConnectionString = Program.connstr;
            this.get_TaoTKTableAdapter.Fill(this.dS.Get_TaoTK);
            if (Program.mGroup == "TRUONG")
            {
                cmbGroup.Items.Add("TRUONG");
            }
            else if (Program.mGroup == "COSO")
            {
                cmbGroup.Items.Add("COSO");
                cmbGroup.Items.Add("GIANGVIEN");
            }

            cmbGroup.SelectedIndex = 0;

        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim() == "")
            {
                MessageBox.Show("Tên tài khoản không được trống!", "Lỗi", MessageBoxButtons.OK);
                txtLogin.Focus();
                return;
            }
            if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu không được trống!", "Lỗi", MessageBoxButtons.OK);
                txtPassword.Focus();
                return;
            }
            if (txtPassword.Text.Trim() != txtXN.Text.Trim())
            {
                MessageBox.Show("Nhập lại mật khẩu không trùng với mật khẩu!", "Lỗi", MessageBoxButtons.OK);
                txtXN.Focus();
                return;
            }
            string sql = "EXEC SP_TaoTaiKhoan '" + txtLogin.Text.Trim() + "', '"
                + txtPassword.Text.Trim() + "', '" + txtUser.Text.ToString().Trim() + "', '" + cmbGroup.SelectedItem.ToString().Trim() + "'";
            if (Program.ExecSqlNonQuery(sql) == 0)
            {
                MessageBox.Show("Tạo tài khoản thành công!", "Thông báo", MessageBoxButtons.OK);
                dS.EnforceConstraints = false;
                this.get_TaoTKTableAdapter.Connection.ConnectionString = Program.connstr;
                this.get_TaoTKTableAdapter.Fill(this.dS.Get_TaoTK);
                txtLogin.Text = "";
                txtPassword.Text = "";
                txtXN.Text = "";
            }
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát khỏi form?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}