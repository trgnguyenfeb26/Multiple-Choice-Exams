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
            this.bdsGV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void FormGV_Load(object sender, EventArgs e)
        {


            // Kiểm tra ràng buộc
            DS.EnforceConstraints = false;
            this.KHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.KHOATableAdapter.Fill(this.DS.KHOA);
            this.GIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.GIAOVIENTableAdapter.Fill(this.DS.GIAOVIEN);
            this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.bODETableAdapter.Fill(this.DS.BODE);
            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.DS.GIAOVIEN_DANGKY);

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
                btnGhi.Enabled = btnThem.Enabled = btnPhucHoi.Enabled = btnXoa.Enabled = btnSua.Enabled = btnHuy.Enabled = false;
                TxMaGV.Enabled = TxDiaChi.Enabled = TxHo.Enabled = TxTen.Enabled = false;

            }
            if (Program.mGroup == "GIANGVIEN")
            {

                cmbCoSo.Enabled = false;
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = false;
                btnHuy.Enabled = false;
                pnGv.Enabled = false;
                gcGV.Enabled = true;
            }
            if (Program.mGroup == "COSO")
            {
                cmbCoSo.Enabled = false;
                TxMaGV.Enabled = TxDiaChi.Enabled = TxHo.Enabled = TxTen.Enabled = false;
                btnPhucHoi.Enabled = btnHuy.Enabled = btnGhi.Enabled = false;
                if (bdsGV.Count == 0)
                {
                    btnXoa.Enabled = btnSua.Enabled = false;
                }

            }
            if (bdsGV.Count == 0 || Program.mGroup == "TRUONG")
            {
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
            }
            else
            {
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
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
            TxMaGV.Enabled = TxDiaChi.Enabled = TxHo.Enabled = TxTen.Enabled = true;
            bdsGV.AddNew();
            ((DataRowView)bdsGV[bdsGV.Position])["MAKH"] = lbMaK.Text;

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            //pnGv.Enabled = true;
            gcGV.Enabled = gcKhoa.Enabled = false;
            btnRefresh.Enabled = false;
            dangThem = true;
        }

        private void btnGhi_ItemClick(object sender, ItemClickEventArgs e)
        {
            TxMaGV.Enabled = TxDiaChi.Enabled = TxHo.Enabled = TxTen.Enabled = false;
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

                    if (Program.ExecSqlNonQuery("exec [dbo].[SP_CheckMaGV] '" + TxMaGV.Text + "'") == 1)
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
                    MessageBox.Show("Đã thêm Giáo viên thành công", "", MessageBoxButtons.OK);
                    UndoStack.Push("exec [dbo].[SP_UndoThemGV] '" + TxMaGV.Text + "'");
                }
                else
                {
                    MessageBox.Show("Đã sửa Giáo viên thành công", "", MessageBoxButtons.OK);
                }
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = btnThoat.Enabled = true;
                btnPhucHoi.Enabled = true;
                btnHuy.Enabled = btnGhi.Enabled = false;
                //pnGv.Enabled = false;
                gcGV.Enabled = gcKhoa.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi giáo viên\n" + ex.Message, "Lỗi", MessageBoxButtons.OK);
            }


        }

        private void btnHuy_ItemClick(object sender, ItemClickEventArgs e)
        {
            TxMaGV.Enabled = TxDiaChi.Enabled = TxHo.Enabled = TxTen.Enabled = false;

            if (dangThem) bdsGV.RemoveCurrent(); else bdsGV.CancelEdit();
            bdsGV.Position = vitri;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled = btnRefresh.Enabled = btnThoat.Enabled = true;

            //pnGv.Enabled = false;
            gcGV.Enabled = gcKhoa.Enabled = true;
            if (UndoStack.Count > 0) { UndoStack.Pop(); btnPhucHoi.Enabled = true; }

            if ((btnThem.Enabled == false) || (btnSua.Enabled == false))
            {
                btnHuy.Enabled = true;
                btnGhi.Enabled = true;
            }
            else
            {
                btnHuy.Enabled = false;
                btnGhi.Enabled = false;
            }
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát khỏi form?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
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
            this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.bODETableAdapter.Fill(this.DS.BODE);
            // TODO: This line of code loads data into the 'DS.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.DS.GIAOVIEN_DANGKY);

            TxMaGV.Enabled = TxDiaChi.Enabled = TxHo.Enabled = TxTen.Enabled = false;

            if (bdsGV.Count == 0) btnXoa.Enabled = btnSua.Enabled = false;
        }

        private void btnPhucHoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            TxMaGV.Enabled = TxDiaChi.Enabled = TxHo.Enabled = TxTen.Enabled = false;

            if (UndoStack.Count == 0) btnPhucHoi.Enabled = false;
            else
            {
                if (Program.ExecSqlNonQuery(UndoStack.Pop()) == 0)
                {
                    this.GIAOVIENTableAdapter.Fill(this.DS.GIAOVIEN);
                }

            }
            if (UndoStack.Count == 0) btnPhucHoi.Enabled = false;
        }

        private void tENTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSua_ItemClick(object sender, ItemClickEventArgs e)
        {
            TxMaGV.Enabled = TxDiaChi.Enabled = TxHo.Enabled = TxTen.Enabled = true;

            vitri = bdsGV.Position;

            UndoStack.Push("exec[dbo].[SP_UndoSuaGV] '" + TxMaGV.Text + "', N'"
                + TxHo.Text + "', N'" + TxTen.Text + "',N'" + TxDiaChi.Text + "'");
            pnGv.Enabled = true;
            gcKhoa.Enabled = false;
            gcGV.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = btnThoat.Enabled = btnRefresh.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            TxMaGV.Enabled = false;
            dangThem = false;
        }

        private void btnXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (bdsGVDK.Count > 0)
            {
                MessageBox.Show("Giáo viên " + TxHo.Text + " " + TxTen.Text + " đã đăng kí thi nên không thể xóa!", "", MessageBoxButtons.OK);
                return;
            }
            if (bdsBD.Count > 0)
            {
                MessageBox.Show("Giáo viên " + TxHo.Text + " " + TxTen.Text + " đã soạn đề thi nên không thể xóa!", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa Giáo viên: " + TxHo.Text + " " + TxTen.Text + " ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {

                    vitri = bdsGV.Position;
                    UndoStack.Push("exec[dbo].[SP_UndoXoaGV] '" + TxMaGV.Text + "', N'"
                        + TxHo.Text + "', N'" + TxTen.Text + "',N'" + TxDiaChi.Text + "','" + lbMaK.Text + "'");
                    bdsGV.RemoveCurrent();
                    this.GIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.GIAOVIENTableAdapter.Update(this.DS.GIAOVIEN);
                    btnPhucHoi.Enabled = true;

                }
                catch (Exception ex)
                {
                    UndoStack.Pop();
                    MessageBox.Show("Lỗi xóa giáo viên \n" + ex.Message, "", MessageBoxButtons.OK);
                    this.GIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.GIAOVIENTableAdapter.Fill(this.DS.GIAOVIEN);
                    bdsGV.Position = vitri;
                    return;
                }

            }
        }

        private void gcKhoa_Click(object sender, EventArgs e)
        {
            if (bdsGV.Count == 0 || Program.mGroup == "TRUONG" || Program.mGroup == "GIANGVIEN")
            {
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
            }
            else
            {
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
            }
        }

        private void cmbCoSo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbCoSo.SelectedValue == null)
            {
                return;
            }

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
                MessageBox.Show("Lỗi kết nối về phòng ban mới!");
            }
            else
            {
                this.KHOATableAdapter.Connection.ConnectionString = Program.connstr;
                this.KHOATableAdapter.Fill(this.DS.KHOA);
                this.GIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.GIAOVIENTableAdapter.Fill(this.DS.GIAOVIEN);
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
}