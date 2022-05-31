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
    public partial class FormChuanBiThi : DevExpress.XtraEditors.XtraForm
    {
        private Stack<string> UndoStack = new Stack<string>();
        private int vitri;
        Boolean dangThem;
        public FormChuanBiThi()
        {
            InitializeComponent();
        }

        private void gIAOVIEN_DANGKYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsGVDK.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormChuanBiThi_Load(object sender, EventArgs e)
        {
          
            dS.EnforceConstraints = false;
            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            cmbCoSo.DataSource = Program.bds_dspm;
            cmbCoSo.DisplayMember = "TENCS";
            cmbCoSo.ValueMember = "TENSERVER";
            cmbCoSo.SelectedIndex = Program.mCoso;

            if (Program.mGroup == "TRUONG")
            {

                cmbCoSo.Enabled = true;
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = false;
                btnHuy.Enabled = false;
                pnGVDK.Enabled = false;
                gcGVDK.Enabled = true;
            }
            else
            {
                cmbCoSo.Enabled = false;
                btnRefresh.Enabled = btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = true;
                btnPhucHoi.Enabled = btnGhi.Enabled = btnHuy.Enabled = false;
                pnGVDK.Enabled = false;
                gcGVDK.Enabled  = true;
                if (bdsGVDK.Count == 0 
                || (Program.username != ((DataRowView)bdsGVDK[bdsGVDK.Position])["MAGV"].ToString().Trim() && Program.mGroup == "GIANGVIEN"))
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
            vitri = bdsGVDK.Position;
            bdsGVDK.AddNew();

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            pnGVDK.Enabled = true;
            gcGVDK.Enabled =  false;
            btnRefresh.Enabled = false;


            txtMaGV.Text = Program.username;
            txtMaGV.Enabled = false;
            
            dangThem = true;
            

        }

 

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsGVDK.Position;
            //UndoStack.Push("exec[dbo].[SP_UndoSuaKH] '" + txtMaKH.Text + "', N'"
            //    + txtTen.Text + "'");
            pnGVDK.Enabled = true;
            gcGVDK.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = btnThoat.Enabled = btnRefresh.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            txtMaGV.Enabled = false;
            dangThem = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DateTime.Compare(DateTime.Parse(dNgayThi.Text.ToString()),
                 DateTime.Parse(DateTime.Now.ToShortDateString())) < 0)
            {
                MessageBox.Show("Lịch thi đã thi không thể xóa!", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa Lịch thi này ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {

                    vitri = bdsGVDK.Position;
                    //UndoStack.Push("exec[dbo].[SP_UndoXoaKH] '" + txtMaKH.Text + "', N'"
                    //    + txtTen.Text + "', '" + txtMaCS.Text + "'");
                    bdsGVDK.RemoveCurrent();
                    this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.gIAOVIEN_DANGKYTableAdapter.Update(this.dS.GIAOVIEN_DANGKY);
                    btnPhucHoi.Enabled = true;

                }
                catch (Exception ex)
                {
                    //UndoStack.Pop();
                    MessageBox.Show("Lỗi xóa Lịch thi \n" + ex.Message, "", MessageBoxButtons.OK);
                    this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);
                    bdsGVDK.Position = vitri;
                    return;
                }

            }
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dangThem) bdsGVDK.RemoveCurrent(); else bdsGVDK.CancelEdit();
            if (dangThem == false) bdsGVDK.Position = vitri;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled = btnRefresh.Enabled = btnThoat.Enabled = true;

            pnGVDK.Enabled = false;
            gcGVDK.Enabled = true;
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
            if (txtMaLop.Text == "")
            {
                MessageBox.Show("Mã Lớp không được trống!", "Lỗi", MessageBoxButtons.OK);
                txtMaLop.Focus();
                return;
            }
            if (txtSCT.Text == "")
            {
                MessageBox.Show("Số câu thi không được trống!", "Lỗi", MessageBoxButtons.OK);
                txtSCT.Focus();
                return;
            }
            if (txtTD.Text == "")
            {
                MessageBox.Show("Trình độ không được trống!", "Lỗi", MessageBoxButtons.OK);
                txtTD.Focus();
                return;
            }
            if (dNgayThi.Text == "")
            {
                MessageBox.Show("Ngày thi không được trống!", "Lỗi", MessageBoxButtons.OK);
                dNgayThi.Focus();
                return;
            }
            if (txtLan.Text == "")
            {
                MessageBox.Show("Lần thi không được trống!", "Lỗi", MessageBoxButtons.OK);
                txtLan.Focus();
                return;
            }
            if (txtTG.Text == "")
            {
                MessageBox.Show("Thời gian không được trống!", "Lỗi", MessageBoxButtons.OK);
                txtTG.Focus();
                return;
            }
    

            if (DateTime.Compare(DateTime.Parse(dNgayThi.Text.ToString()), 
                DateTime.Parse(DateTime.Now.ToShortDateString())) < 0)
            {
                MessageBox.Show("Ngày thi phải lớn hơn hoặc bằng ngày hiện tại!", "Lỗi", MessageBoxButtons.OK);
                return;
            }
            try
            {

                if (dangThem)
                {

                    if (Program.ExecSqlNonQuery("exec [dbo].[SP_ChuanBiThi] '" + txtMaMH.GetItemText(txtMaMH.SelectedValue) + "','" + txtMaLop.GetItemText(txtMaLop.SelectedValue)
                        + "','"+txtTD.Text.Trim()+ "','" +txtSCT.Text.Trim()+"','" +txtLan.Text.Trim()+ "','" +dNgayThi.Text.ToString()+ "'") == 1)
                    {
                        txtMaMH.Focus();
                        return;
                    }
                }
            
                bdsGVDK.EndEdit();
                bdsGVDK.ResetCurrentItem();
                this.gIAOVIEN_DANGKYTableAdapter.Update(this.dS.GIAOVIEN_DANGKY);
                if (dangThem)
                {
                    MessageBox.Show("Đã thêm thành công", "", MessageBoxButtons.OK);
                   // UndoStack.Push("exec [dbo].[SP_UndoThemKH] '" + txtMaKH.Text + "'");
                }
                else
                {
                    MessageBox.Show("Đã sửa thành công", "", MessageBoxButtons.OK);
                }
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = btnThoat.Enabled = true;
                btnPhucHoi.Enabled = true;
                btnHuy.Enabled = btnGhi.Enabled = false;
                pnGVDK.Enabled = false;
                gcGVDK.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi \n" + ex.Message, "Lỗi", MessageBoxButtons.OK);
            }
        }


        private void txtMaMH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gcGVDK_Click(object sender, EventArgs e)
        {
            if (bdsGVDK.Count == 0 || Program.mGroup == "TRUONG" 
                || (Program.username != ((DataRowView)bdsGVDK[bdsGVDK.Position])["MAGV"].ToString().Trim() && Program.mGroup == "GIANGVIEN"))
            {
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
            }
            else
            {
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
            }
             colMAMH.ColumnEditName=txtMaMH.GetItemText(txtMaMH.SelectedValue);
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dS.EnforceConstraints = false;
            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            if (bdsGVDK.Count == 0 || Program.mGroup == "TRUONG"
                || (Program.username != ((DataRowView)bdsGVDK[bdsGVDK.Position])["MAGV"].ToString().Trim()&& Program.mGroup == "GIANGVIEN"))
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

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát khỏi form?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);
            if (UndoStack.Count == 0) btnPhucHoi.Enabled = false;
            else
            {
                if (Program.ExecSqlNonQuery(UndoStack.Pop()) == 0)
                {
                    this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);
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
                this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.dS.LOP);
                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Fill(this.dS.MONHOC);

                //  maLop = ((DataRowView)bdsLop[0])["MALOP"].ToString();
            }
        }

  
    }
}