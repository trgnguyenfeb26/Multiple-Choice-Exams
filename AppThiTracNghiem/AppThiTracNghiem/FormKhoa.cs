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
    public partial class FormKhoa : DevExpress.XtraEditors.XtraForm
    {
        private Stack<string> UndoStack = new Stack<string>();
        private int vitri;
        Boolean dangThem;
        public FormKhoa()
        {
            InitializeComponent();
        }

        private void kHOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKhoa.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormKhoa_Load(object sender, EventArgs e)
        {
          
            
            dS.EnforceConstraints = false;
            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.dS.KHOA);
            this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);

            cmbCoSo.DataSource = Program.bds_dspm;
            cmbCoSo.DisplayMember = "TENCS";
            cmbCoSo.ValueMember = "TENSERVER";
            cmbCoSo.SelectedIndex = Program.mCoso;
            if (Program.mGroup == "TRUONG")
            {

                cmbCoSo.Enabled = true;
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = false;
                btnHuy.Enabled = false;
                pnKhoa.Enabled = false;
                gcKhoa.Enabled = true;
            }
            if (Program.mGroup == "GIANGVIEN")
            {

                cmbCoSo.Enabled = false;
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = false;
                btnHuy.Enabled = false;
                pnKhoa.Enabled = false;
                gcKhoa.Enabled = true;
            }
            if (Program.mGroup == "COSO")
            {
                cmbCoSo.Enabled = false;
                btnRefresh.Enabled = btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = true;
                btnPhucHoi.Enabled = btnGhi.Enabled = btnHuy.Enabled = false;
                pnKhoa.Enabled = false;
                gcKhoa.Enabled = true;
                if (bdsKhoa.Count == 0) btnXoa.Enabled = btnSua.Enabled = false;
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsKhoa.Position;
            bdsKhoa.AddNew();

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            pnKhoa.Enabled = true;
            gcKhoa.Enabled =  false;
            btnRefresh.Enabled = false;

            gcKhoa.Enabled = false;
            
            txtMaKH.Enabled = true;
            txtMaCS.Text = (Program.mCoso==0)?"CS1":"CS2";
            dangThem = true;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsKhoa.Position;
            UndoStack.Push("exec[dbo].[SP_UndoSuaKH] '" + txtMaKH.Text + "', N'"
                + txtTen.Text + "'");
            pnKhoa.Enabled = true;
            gcKhoa.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = btnThoat.Enabled = btnRefresh.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            txtMaKH.Enabled = false;
            dangThem = false;
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dangThem) bdsKhoa.RemoveCurrent(); else bdsKhoa.CancelEdit();
            if (dangThem==false) bdsKhoa.Position = vitri;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled = btnRefresh.Enabled = btnThoat.Enabled = true;

            pnKhoa.Enabled = false;
            gcKhoa.Enabled =  true;
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
            if (txtMaKH.Text == "")
            {
                MessageBox.Show("Mã Khoa không được trống!", "Lỗi", MessageBoxButtons.OK);
                txtMaKH.Focus();
                return;
            }
         
            if (txtTen.Text == "")
            {
                MessageBox.Show("Tên Khoa không được trống!", "Lỗi", MessageBoxButtons.OK);
                txtTen.Focus();
                return;
            }

            try
            {

                if (dangThem)
                {

                    if (Program.ExecSqlNonQuery("exec [dbo].[SP_CheckMaKH] '" + txtMaKH.Text + "'") == 1)
                    {
                        txtMaKH.Focus();
                        return;
                    }
                }
                if (Program.ExecSqlNonQuery("exec [dbo].[SP_CheckTenKH] N'" + txtTen.Text + "'") == 1)
                {
                    txtTen.Focus();
                    return;
                }
                bdsKhoa.EndEdit();
                bdsKhoa.ResetCurrentItem();
                this.kHOATableAdapter.Update(this.dS.KHOA);
                if (dangThem)
                {
                    MessageBox.Show("Đã thêm Khoa thành công", "", MessageBoxButtons.OK);
                    UndoStack.Push("exec [dbo].[SP_UndoThemKH] '" + txtMaKH.Text + "'");
                }
                else
                {
                    MessageBox.Show("Đã sửa Khoa thành công", "", MessageBoxButtons.OK);
                }
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = btnThoat.Enabled = true;
                btnPhucHoi.Enabled = true;
                btnHuy.Enabled = btnGhi.Enabled = false;
                pnKhoa.Enabled = false;
                gcKhoa.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi Khoa\n" + ex.Message, "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dS.EnforceConstraints = false;
            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.dS.KHOA);
            this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);
            if (bdsKhoa.Count == 0) btnXoa.Enabled = btnSua.Enabled = false;
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
            if (bdsGV.Count > 0)
            {
                MessageBox.Show("Khoa " + txtTen.Text + " đang có Giáo viên không thể xóa!", "", MessageBoxButtons.OK);
                return;
            }
            if (bdsLop.Count > 0)
            {
                MessageBox.Show("Khoa " + txtTen.Text + " đang có Lớp không thể xóa!", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa Khoa: "  + txtTen.Text + " ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {

                    vitri = bdsKhoa.Position;
                    UndoStack.Push("exec[dbo].[SP_UndoXoaKH] '" + txtMaKH.Text + "', N'"
                        +  txtTen.Text + "', '"  + txtMaCS.Text + "'");
                    bdsKhoa.RemoveCurrent();
                    this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                    this.kHOATableAdapter.Update(this.dS.KHOA);
                    btnPhucHoi.Enabled = true;

                }
                catch (Exception ex)
                {
                    UndoStack.Pop();
                    MessageBox.Show("Lỗi xóa Khoa \n" + ex.Message, "", MessageBoxButtons.OK);
                    this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                    this.kHOATableAdapter.Fill(this.dS.KHOA);
                    bdsKhoa.Position = vitri;
                    return;
                }

            }
        }

        private void gcKhoa_Click(object sender, EventArgs e)
        {
            if (bdsKhoa.Count == 0 || Program.mGroup == "TRUONG" || Program.mGroup == "GIANGVIEN")
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
            this.kHOATableAdapter.Fill(this.dS.KHOA);
            if (UndoStack.Count == 0) btnPhucHoi.Enabled = false;
            else
            {
                if (Program.ExecSqlNonQuery(UndoStack.Pop()) == 0)
                {
                    this.kHOATableAdapter.Fill(this.dS.KHOA);
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
                this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                this.kHOATableAdapter.Fill(this.dS.KHOA);
                this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.dS.LOP);

                //  maLop = ((DataRowView)bdsLop[0])["MALOP"].ToString();
            }
        }
    }
}