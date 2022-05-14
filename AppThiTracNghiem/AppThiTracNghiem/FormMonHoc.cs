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
    public partial class FormMonHoc : DevExpress.XtraEditors.XtraForm
    {
        private Stack<string> UndoStack = new Stack<string>();
        private int vitri;
        Boolean dangThem;
        public FormMonHoc()
        {
            InitializeComponent();
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsMH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormMonHoc_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            this.bANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.bANGDIEMTableAdapter.Fill(this.dS.BANGDIEM);
            this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.bODETableAdapter.Fill(this.dS.BODE);
            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);
            cmbCoSo.DataSource = Program.bds_dspm;
            cmbCoSo.DisplayMember = "TENCS";
            cmbCoSo.ValueMember = "TENSERVER";
            cmbCoSo.SelectedIndex = Program.mCoso;
            if (Program.mGroup == "TRUONG")
            {

                cmbCoSo.Enabled = true;
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = false;
                btnHuy.Enabled = false;
                pnMH.Enabled = false;
                gcMH.Enabled = true;
            }
            else
            if (Program.mGroup == "GIANGVIEN")
            {

                cmbCoSo.Enabled = false;
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = false;
                btnHuy.Enabled = false;
                pnMH.Enabled = false;
                gcMH.Enabled = true;
            }
            else
            {
                cmbCoSo.Enabled = false;
                btnRefresh.Enabled = btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = true;
                btnPhucHoi.Enabled = btnGhi.Enabled = btnHuy.Enabled = false;
                pnMH.Enabled = false;
                gcMH.Enabled = true;
                if (bdsMH.Count == 0)
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
 

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsMH.Position;
            bdsMH.AddNew();

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            pnMH.Enabled = true;
            gcMH.Enabled = false;
            btnRefresh.Enabled = false;

            gcMH.Enabled = false;

            txtMaMH.Enabled = true;
           
            dangThem = true;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsMH.Position;
            UndoStack.Push("exec[dbo].[SP_UndoSuaMH] '" + txtMaMH.Text + "', N'"
                + txtTen.Text + "'");
            pnMH.Enabled = true;
            gcMH.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = btnThoat.Enabled = btnRefresh.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            txtMaMH.Enabled = false;
            dangThem = false;
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dangThem) bdsMH.RemoveCurrent(); else bdsMH.CancelEdit();
            if (dangThem == false) bdsMH.Position = vitri;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled = btnRefresh.Enabled = btnThoat.Enabled = true;

            pnMH.Enabled = false;
            gcMH.Enabled = true;
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

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaMH.Text == "")
            {
                MessageBox.Show("Mã Môn học không được trống!", "Lỗi", MessageBoxButtons.OK);
                txtMaMH.Focus();
                return;
            }
            if (txtMaMH.Text.Length > 5)
            {
                MessageBox.Show("Mã Môn học không được hơn 5 kí tự!", "Lỗi", MessageBoxButtons.OK);
                txtMaMH.Focus();
                return;
            }
            if (txtTen.Text == "")
            {
                MessageBox.Show("Tên Môn học không được trống!", "Lỗi", MessageBoxButtons.OK);
                txtTen.Focus();
                return;
            }

            try
            {

                if (dangThem)
                {

                    if (Program.ExecSqlNonQuery("exec [dbo].[SP_CheckMaMH] '" + txtMaMH.Text + "'") == 1)
                    {
                        txtMaMH.Focus();
                        return;
                    }
                }
                if (Program.ExecSqlNonQuery("exec [dbo].[SP_CheckTenMH] N'" + txtTen.Text + "'") == 1)
                {
                    txtTen.Focus();
                    return;
                }
                bdsMH.EndEdit();
                bdsMH.ResetCurrentItem();
                this.mONHOCTableAdapter.Update(this.dS.MONHOC);
                if (dangThem)
                {
                    MessageBox.Show("Đã thêm Môn học thành công", "", MessageBoxButtons.OK);
                    UndoStack.Push("exec [dbo].[SP_UndoThemMH] '" + txtMaMH.Text + "'");
                }
                else
                {
                    MessageBox.Show("Đã sửa Môn học thành công", "", MessageBoxButtons.OK);
                }
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = btnThoat.Enabled = true;
                btnPhucHoi.Enabled = true;
                btnHuy.Enabled = btnGhi.Enabled = false;
                pnMH.Enabled = false;
                gcMH.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi Môn học\n" + ex.Message, "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dS.EnforceConstraints = false;
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            this.bANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.bANGDIEMTableAdapter.Fill(this.dS.BANGDIEM);
            this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.bODETableAdapter.Fill(this.dS.BODE);
            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);
            if (bdsMH.Count == 0) btnXoa.Enabled = btnSua.Enabled = false;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát khỏi form?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsBoDe.Count != 0)
            {
                MessageBox.Show("Môn học đã có câu hỏi trong bộ đề, không thể xoá!", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            else if (bdsGVDK.Count != 0)
            {
                MessageBox.Show("Môn học đã có giáo viên đăng ký thi, không thể xoá!", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            else if (bdsBD.Count != 0)
            {
                MessageBox.Show("Môn học đã có bảng điểm, không thể xoá!", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            if (MessageBox.Show("Bạn có muốn xóa Môn học: " + txtTen.Text + " ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {

                    vitri = bdsMH.Position;
                    UndoStack.Push("exec[dbo].[SP_UndoXoaMH] '" + txtMaMH.Text + "', N'"
                        + txtTen.Text + "'");
                    bdsMH.RemoveCurrent();
                    this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.mONHOCTableAdapter.Update(this.dS.MONHOC);
                    btnPhucHoi.Enabled = true;

                }
                catch (Exception ex)
                {
                    UndoStack.Pop();
                    MessageBox.Show("Lỗi xóa Môn học \n" + ex.Message, "", MessageBoxButtons.OK);
                    this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
                    bdsMH.Position = vitri;
                    return;
                }

            }
        }

        private void gcMH_Click(object sender, EventArgs e)
        {
            if (bdsMH.Count == 0 || Program.mGroup == "TRUONG"||Program.mGroup == "GIANGVIEN")
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

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            if (UndoStack.Count == 0) btnPhucHoi.Enabled = false;
            else
            {
                if (Program.ExecSqlNonQuery(UndoStack.Pop()) == 0)
                {
                    this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
                }

            }
            if (UndoStack.Count == 0) btnPhucHoi.Enabled = false;
        }

        private void cmbCoSo_SelectedIndexChanged(object sender, EventArgs e)
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

                dS.EnforceConstraints = false;
                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
                this.bANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
                this.bANGDIEMTableAdapter.Fill(this.dS.BANGDIEM);
                this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
                this.bODETableAdapter.Fill(this.dS.BODE);
                this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);

                //  maLop = ((DataRowView)bdsLop[0])["MALOP"].ToString();
            }
        }
    }
}
