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
            btnTaoTK.Enabled = true;
            if (Program.mGroup == "Sinhvien")
            {
                ribThi.Visible = true;
                ribDanhMuc.Visible = false;
                btnTaoTK.Enabled = false;
                btnXemBD.Enabled = false;
                btnDSDK.Enabled = false;
            }
            else
            {
                if (Program.mGroup == "Giangvien")
                    btnTaoTK.Enabled = false;
                ribThi.Visible = true;
                ribDanhMuc.Visible = true;
                btnXemBD.Enabled = true;
                btnDSDK.Enabled = true;
            }
        }
        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            MessageBox.Show("Đăng xuất thành công!", "Thông báo", MessageBoxButtons.OK);
            return;
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

        }
    }
}