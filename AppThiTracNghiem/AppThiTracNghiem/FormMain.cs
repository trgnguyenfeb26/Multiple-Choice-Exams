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

            
            
            if (Program.mGroup == "SinhVien")
            {
                btnDangNhap.Enabled = false;
                ribThi.Visible = true;
                ribDanhMuc.Visible = false;
                ribReport.Visible = true;
                btnTaoTaiKhoan.Enabled = false ;
                btnXemBD.Enabled = false;
                btnDSDK.Enabled = false;
                btnDangXuat.Enabled = true;
            }
            else
            if (Program.mGroup == "GIANGVIEN")
                {
                btnDangNhap.Enabled = false;
                ribThi.Visible = false;
                ribDanhMuc.Visible = true;
                ribReport.Visible = true;
                btnTaoTaiKhoan.Enabled = false;
                btnDangXuat.Enabled = true;
                btnXemKQ.Enabled = false;
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
                btnLapLichThi.Enabled=false;
                btnXemKQ.Enabled = false;

            }
            if (Program.mGroup == "COSO")
            {
                btnDangNhap.Enabled = false;
                ribThi.Visible = false;
                ribDanhMuc.Visible = true;
                ribReport.Visible = true;
                btnDangXuat.Enabled = true;
                btnTaoTaiKhoan.Enabled = true;
                btnXemKQ.Enabled = false;
            }


        }
        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {

            if (MessageBox.Show("Bạn có thật sự muốn đăng xuất khỏi tài khoản '"
                + Program.loginDN + "' ?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Restart();
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
    }
}