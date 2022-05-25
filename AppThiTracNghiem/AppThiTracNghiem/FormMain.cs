using DevExpress.XtraBars;
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
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMain()
        {
            InitializeComponent();
        }
        public void hienThiMenu()
        {
            MaGVSV.Text = "Mã: " + Program.username;
            HoTen.Text = "Tên: " + Program.mHoten;
            Nhom.Text = "Nhóm: " + Program.mGroup;
            ribHeThong.Visible = true;
            btnTaoTaiKhoan.Enabled = false;
            btnDangXuat.Enabled = false;
            ribThi.Visible = true;
            ribDanhMuc.Visible = false;
            ribReport.Visible = false;
            btnDMK.Enabled = false;

            if (Program.mGroup == "SinhVien")
            {
                btnDangNhap.Enabled = false;
                ribThi.Visible = true;
                ribDanhMuc.Visible = false;
                ribReport.Visible = false;
                btnTaoTaiKhoan.Enabled = false ;
                btnDangXuat.Enabled = true;
                btnDMK.Enabled = true;
            }
            else
            if (Program.mGroup == "GIANGVIEN")
                {
                btnDangNhap.Enabled = false;
                ribDanhMuc.Visible = true;
                ribReport.Visible = true;
                btnTaoTaiKhoan.Enabled = false;
                btnDangXuat.Enabled = true;
                btnXemKQ.Enabled = true;
                btnSinhVien.Enabled = true;
                btnKhoa.Enabled = true;
                btnGiaoVien.Enabled = true;
                btnMonHoc.Enabled = true;
                btnDMK.Enabled = true;
            }
            else
            if (Program.mGroup == "TRUONG")
            {
                btnDangNhap.Enabled = false;
                ribThi.Visible = false;
                ribDanhMuc.Visible = true;
                ribReport.Visible = true;
                btnDangXuat.Enabled = true;
                btnTaoTaiKhoan.Enabled = true;
                btnLapLichThi.Enabled=true;
                btnXemKQ.Enabled = true;
                btnDMK.Enabled = true;

            }
            if (Program.mGroup == "COSO")
            {
                btnDangNhap.Enabled = false;
                ribDanhMuc.Visible = true;
                ribReport.Visible = true;
                btnDangXuat.Enabled = true;
                btnTaoTaiKhoan.Enabled = true;
                btnXemKQ.Enabled = true;
                btnDMK.Enabled = true;
            }


        }
        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "CẢNH BÁO", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                Program.username = "";
                Program.mlogin = Program.remoteLogin;
                Program.password = Program.remotePassword;
                Program.mGroup = "";
                Program.mHoten = "";
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm.ShowInTaskbar)
                        frm.Close();
                }
                Program.frmChinh.hienThiMenu();
                btnDangNhap.Enabled = true;
                ribThi.Visible = false;
            }
        }
    
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        private void btnDangNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormDangNhap));
            if (frm != null)
                frm.Activate();
            else
            {
                FormDangNhap f = new FormDangNhap();
                f.MdiParent = this;
            
                f.Show();
            }
            btnDangNhap.Enabled = false;
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            ribHeThong.Visible = true;
            btnTaoTaiKhoan.Enabled = false;
            btnDangXuat.Enabled = false;
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void btnSinhVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormSV));
            if (frm != null) frm.Activate();
            else
            {
                FormSV f = new FormSV();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnGiaoVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormGV));
            if (frm != null) frm.Activate();
            else
            {
                FormGV f = new FormGV();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnKhoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormKhoa));
            if (frm != null) frm.Activate();
            else
            {
                FormKhoa f = new FormKhoa();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnLop_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormLop));
            if (frm != null) frm.Activate();
            else
            {
                FormLop f = new FormLop();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnLapLichThi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormChuanBiThi));
            if (frm != null) frm.Activate();
            else
            {
                FormChuanBiThi f = new FormChuanBiThi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnBoDe_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormBoDe));
            if (frm != null) frm.Activate();
            else
            {
                FormBoDe f = new FormBoDe();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnMonHoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormMonHoc));
            if (frm != null) frm.Activate();
            else
            {
                FormMonHoc f = new FormMonHoc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnTaoTaiKhoan_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormTaoTK));
            if (frm != null) frm.Activate();
            else
            {
                FormTaoTK f = new FormTaoTK();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDMK_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormDoiMK));
            if (frm != null) frm.Activate();
            else
            {
                FormDoiMK f = new FormDoiMK();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnCMT_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormChonMonThi));
            if (frm != null) frm.Activate();
            else
            {
                FormChonMonThi f = new FormChonMonThi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnXemKQ_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormXemKQ));
            if (frm != null) frm.Activate();
            else
            {
                FormXemKQ f = new FormXemKQ();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnXemBD_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormBangDiem));
            if (frm != null) frm.Activate();
            else
            {
                FormBangDiem f = new FormBangDiem();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDSDK_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormXemDSDKThi));
            if (frm != null) frm.Activate();
            else
            {
                FormXemDSDKThi f = new FormXemDSDKThi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void ribbon_Click_1(object sender, EventArgs e)
        {

        }
    }
}