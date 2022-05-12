using DevExpress.XtraBars;
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
    public partial class FormGV : DevExpress.XtraEditors.XtraForm
    {
        private DataTable dt = new DataTable();
        private string maKH = "";
        private int index = 0;
        private string tenKH = "";
        private int vitri = 0;
        private Stack<string> UndoStack = new Stack<string>();
        private bool dangThem;
        public FormGV()
        {
            InitializeComponent();
        }

        private void gIAOVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsGiaoVien.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void FormGV_Load(object sender, EventArgs e)
        {
            
            // Kiểm tra ràng buộc
            DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'DS.KHOA' table. You can move, or remove it, as needed.
            this.KHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.KHOATableAdapter.Fill(this.DS.KHOA);
            // TODO: This line of code loads data into the 'dS.GIAOVIEN' table. You can move, or remove it, as needed.
            this.GIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.GIAOVIENTableAdapter.Fill(this.DS.GIAOVIEN);

            cmbCoSo.DataSource = Program.bds_dspm;
            cmbCoSo.DisplayMember = "TENCS";
            cmbCoSo.ValueMember = "TENSERVER";
            cmbCoSo.SelectedIndex = Program.mCoso;

            //dt= Program.ExecSqlDataTable("SELECT MAKH, TENKH FROM KHOA");
            //cmbKhoa.DataSource = dt;
            //cmbKhoa.DisplayMember = "TENKH";
            //cmbKhoa.ValueMember = "MAKH";
            //cmbKhoa.SelectedIndex = 0;
            //maKH = cmbKhoa.SelectedValue.ToString().Trim();
            //this.bdsGiaoVien.Filter = "MAKH = '" + maKH + "'";

            //Phân quyền
            if (Program.mGroup == "TRUONG")
            {
                cmbCoSo.Enabled = true;
                btnGhi.Enabled = btnThem.Enabled = btnPhucHoi.Enabled = btnXoa.Enabled = btnXoa.Enabled =btnSua.Enabled = false;
            }
            else
            {
                cmbCoSo.Enabled = false;
                btnGhi.Enabled = btnThem.Enabled = btnPhucHoi.Enabled = btnXoa.Enabled = btnXoa.Enabled = true;

            }
        }

        private void cmbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Kiểm tra đã chọn giá trị ở cmbCoSo hay chưa
            if (cmbCoSo.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cmbCoSo.SelectedValue.ToString();
            if (cmbCoSo.SelectedIndex != Program.mCoso)
            {
                Program.mlogin = Program.remoteLogin;
                Program.password = Program.remotePassword;
            }
            else
            {
                Program.mlogin = Program.loginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối tới cơ sở mới!", "Lỗi", MessageBoxButtons.OK);
                cmbCoSo.DisplayMember = "TENCS";
                cmbCoSo.ValueMember = "TENSERVER";
                cmbCoSo.SelectedIndex = Program.mCoso;
            }
               
            else
            {
                this.KHOATableAdapter.Connection.ConnectionString = Program.connstr;
                this.KHOATableAdapter.Fill(this.DS.KHOA);
                this.GIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.GIAOVIENTableAdapter.Fill(this.DS.GIAOVIEN);

                //dt = Program.ExecSqlDataTable("SELECT MAKH, TENKH FROM KHOA");
                //cmbKhoa.DataSource = dt;
                //cmbKhoa.DisplayMember = "TENKH";
                //cmbKhoa.ValueMember = "MAKH";
                //cmbKhoa.SelectedIndex = 0;

                //maKH = cmbKhoa.SelectedValue.ToString().Trim();
                //this.bdsGiaoVien.Filter = "MAKH = '" + maKH + "'";

            }
        }



        private void tENKHTextBox_TextChanged(object sender, EventArgs e)
        {

        }

 

        private void gIAOVIENGridControl_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            bdsGV.AddNew();
            ((DataRowView)bdsGV[bdsGV.Position])["MAKH"] = lbMaK.Text;
            gcGV.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, ItemClickEventArgs e)
        {

            if (TxMaGV.Text == "")
            {
                MessageBox.Show("Mã giáo viên không được trống!", "Lỗi", MessageBoxButtons.OK);
                TxMaGV.Focus();
                return;
            }
            if (TxHo.Text == "")
            {
                MessageBox.Show("Họ giáo viên không được trống!", "Lỗi", MessageBoxButtons.OK);
                TxHo.Focus();
                return;
            }
            if (TxTen.Text == "")
            {
                MessageBox.Show("Họ giáo viên không được trống!", "Lỗi", MessageBoxButtons.OK);
                TxTen.Focus();
                return;
            }
            try
            {

                if (dangThem)
                {

                    if (Program.ExecSqlNonQuery("exec [dbo].[SP_CheckMaSV] '" + TxMaGV.Text + "'") == 1)
                    {
                        TxMaGV.Focus();
                        return;
                    }
                }

                bdsGV.EndEdit();
                bdsGV.ResetCurrentItem();
                this.GIAOVIENTableAdapter.Update(this.DS.GIAOVIEN);
                if (dangThem)
                {
                    MessageBox.Show("Đã thêm Sinh viên thành công", "", MessageBoxButtons.OK);
                    UndoStack.Push("exec [dbo].[SP_UndoThemSV] '" + TxMaGV.Text + "'");
                }
                else
                {
                    MessageBox.Show("Đã sửa Sinh viên thành công", "", MessageBoxButtons.OK);
                }
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = barButtonItem8.Enabled = true;
                btnPhucHoi.Enabled = true;
                btnHuy.Enabled = btnGhi.Enabled = false;
                pnGv.Enabled = false;
                gcGV.Enabled = gcKhoa.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi sinh viên\n" + ex.Message, "Lỗi", MessageBoxButtons.OK);
            }


        }

        private void btnHuy_ItemClick(object sender, ItemClickEventArgs e)
        {
            bdsGV.CancelEdit();
            // gặp lỗi nếu thêm item hơn 1 lần
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Kiểm tra ràng buộc
            DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'DS.KHOA' table. You can move, or remove it, as needed.
            this.KHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.KHOATableAdapter.Fill(this.DS.KHOA);
            // TODO: This line of code loads data into the 'dS.GIAOVIEN' table. You can move, or remove it, as needed.
            this.GIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.GIAOVIENTableAdapter.Fill(this.DS.GIAOVIEN);

            cmbCoSo.DataSource = Program.bds_dspm;
            cmbCoSo.DisplayMember = "TENCS";
            cmbCoSo.ValueMember = "TENSERVER";
            cmbCoSo.SelectedIndex = Program.mCoso;
            this.GIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.GIAOVIENTableAdapter.Fill(this.DS.GIAOVIEN);
        }

        private void btnPhucHoi_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void tENTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSua_ItemClick(object sender, ItemClickEventArgs e)
        {
            vitri = bdsGV.Position;
                                                            
            UndoStack.Push("exec[dbo].[SP_UndoSuaGV] '" + TxMaGV.Text + "', N'"
                + TxHo.Text + "', N'"+ TxTen.Text + "',N'"+ TxDiaChi.Text + "'"  );
            pnGv.Enabled = true;
            gcKhoa.Enabled = false;
            gcGV.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = barButtonItem8.Enabled = btnRefresh.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            TxMaGV.Enabled = false;
            dangThem = false;
        }




        //private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cmbKhoa.SelectedValue != null)
        //    {
        //        maKH = cmbKhoa.SelectedValue.ToString().Trim();
        //        tenKH = cmbKhoa.GetItemText(cmbKhoa.SelectedItem);
        //        index = cmbKhoa.SelectedIndex;
        //    }
        //    this.bdsGiaoVien.Filter = "MAKH = '" + maKH + "'";
        //    cmbKhoa.Text = tenKH;
        //    if (bdsGiaoVien.Count != 0)
        //        //btnXoa.Enabled = true;
        //    return;
        //}
    }
}