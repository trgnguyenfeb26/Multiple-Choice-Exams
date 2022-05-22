
namespace AppThiTracNghiem
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaoTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.btnSinhVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnKhoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnGiaoVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnMonHoc = new DevExpress.XtraBars.BarButtonItem();
            this.btnBoDe = new DevExpress.XtraBars.BarButtonItem();
            this.btnThongTinSV = new DevExpress.XtraBars.BarButtonItem();
            this.btnChonMonThi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXemKQ = new DevExpress.XtraBars.BarButtonItem();
            this.btnXemBD = new DevExpress.XtraBars.BarButtonItem();
            this.btnDSDK = new DevExpress.XtraBars.BarButtonItem();
            this.btnLop = new DevExpress.XtraBars.BarButtonItem();
            this.btnCMT = new DevExpress.XtraBars.BarButtonItem();
            this.btnDMK = new DevExpress.XtraBars.BarButtonItem();
            this.ribHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribDanhMuc = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnLapLichThi = new DevExpress.XtraBars.BarButtonItem();
            this.ribThi = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribReport = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup10 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.btnLogin = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MaGVSV = new System.Windows.Forms.ToolStripStatusLabel();
            this.HoTen = new System.Windows.Forms.ToolStripStatusLabel();
            this.Nhom = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnDangNhap,
            this.btnDangXuat,
            this.btnTaoTaiKhoan,
            this.btnSinhVien,
            this.btnKhoa,
            this.btnGiaoVien,
            this.btnMonHoc,
            this.btnBoDe,
            this.btnThongTinSV,
            this.btnChonMonThi,
            this.btnXemKQ,
            this.btnXemBD,
            this.btnDSDK,
            this.btnLop,
            this.btnCMT,
            this.btnDMK});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(12);
            this.ribbon.MaxItemId = 25;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribHeThong,
            this.ribDanhMuc,
            this.ribThi,
            this.ribReport});
            this.ribbon.Size = new System.Drawing.Size(1023, 193);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click_1);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Caption = "Đăng nhập";
            this.btnDangNhap.Id = 1;
            this.btnDangNhap.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDangNhap.ImageOptions.SvgImage")));
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangNhap_ItemClick);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng xuất";
            this.btnDangXuat.Id = 2;
            this.btnDangXuat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDangXuat.ImageOptions.SvgImage")));
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // btnTaoTaiKhoan
            // 
            this.btnTaoTaiKhoan.Caption = "Tạo tài khoản";
            this.btnTaoTaiKhoan.Id = 6;
            this.btnTaoTaiKhoan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTaoTaiKhoan.ImageOptions.SvgImage")));
            this.btnTaoTaiKhoan.Name = "btnTaoTaiKhoan";
            this.btnTaoTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaoTaiKhoan_ItemClick);
            // 
            // btnSinhVien
            // 
            this.btnSinhVien.Caption = "Sinh viên";
            this.btnSinhVien.Id = 8;
            this.btnSinhVien.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSinhVien.ImageOptions.SvgImage")));
            this.btnSinhVien.Name = "btnSinhVien";
            this.btnSinhVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSinhVien_ItemClick);
            // 
            // btnKhoa
            // 
            this.btnKhoa.Caption = "Khoa";
            this.btnKhoa.Id = 9;
            this.btnKhoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKhoa.ImageOptions.SvgImage")));
            this.btnKhoa.Name = "btnKhoa";
            this.btnKhoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKhoa_ItemClick);
            // 
            // btnGiaoVien
            // 
            this.btnGiaoVien.Caption = "Giáo viên";
            this.btnGiaoVien.Id = 10;
            this.btnGiaoVien.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGiaoVien.ImageOptions.SvgImage")));
            this.btnGiaoVien.Name = "btnGiaoVien";
            this.btnGiaoVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGiaoVien_ItemClick);
            // 
            // btnMonHoc
            // 
            this.btnMonHoc.Caption = "Môn học";
            this.btnMonHoc.Id = 11;
            this.btnMonHoc.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnMonHoc.ImageOptions.SvgImage")));
            this.btnMonHoc.Name = "btnMonHoc";
            this.btnMonHoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMonHoc_ItemClick);
            // 
            // btnBoDe
            // 
            this.btnBoDe.Caption = "Bộ đề";
            this.btnBoDe.Id = 12;
            this.btnBoDe.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBoDe.ImageOptions.SvgImage")));
            this.btnBoDe.Name = "btnBoDe";
            this.btnBoDe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBoDe_ItemClick);
            // 
            // btnThongTinSV
            // 
            this.btnThongTinSV.Caption = "Thông tin sinh viên";
            this.btnThongTinSV.Id = 14;
            this.btnThongTinSV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThongTinSV.ImageOptions.SvgImage")));
            this.btnThongTinSV.Name = "btnThongTinSV";
            // 
            // btnChonMonThi
            // 
            this.btnChonMonThi.Caption = "Chọn môn thi";
            this.btnChonMonThi.Id = 15;
            this.btnChonMonThi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnChonMonThi.ImageOptions.SvgImage")));
            this.btnChonMonThi.Name = "btnChonMonThi";
            // 
            // btnXemKQ
            // 
            this.btnXemKQ.Caption = "Xem kết quả";
            this.btnXemKQ.Id = 16;
            this.btnXemKQ.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXemKQ.ImageOptions.SvgImage")));
            this.btnXemKQ.Name = "btnXemKQ";
            this.btnXemKQ.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXemKQ_ItemClick);
            // 
            // btnXemBD
            // 
            this.btnXemBD.Caption = "Xem bản điểm";
            this.btnXemBD.Id = 17;
            this.btnXemBD.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXemBD.ImageOptions.SvgImage")));
            this.btnXemBD.Name = "btnXemBD";
            this.btnXemBD.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXemBD_ItemClick);
            // 
            // btnDSDK
            // 
            this.btnDSDK.Caption = "Xem DSĐK thi";
            this.btnDSDK.Id = 19;
            this.btnDSDK.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDSDK.ImageOptions.SvgImage")));
            this.btnDSDK.Name = "btnDSDK";
            this.btnDSDK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDSDK_ItemClick);
            // 
            // btnLop
            // 
            this.btnLop.Caption = "Lớp";
            this.btnLop.Id = 20;
            this.btnLop.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLop.ImageOptions.SvgImage")));
            this.btnLop.Name = "btnLop";
            this.btnLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLop_ItemClick);
            // 
            // btnCMT
            // 
            this.btnCMT.Caption = "Chọn môn thi";
            this.btnCMT.Id = 23;
            this.btnCMT.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCMT.ImageOptions.SvgImage")));
            this.btnCMT.Name = "btnCMT";
            this.btnCMT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCMT_ItemClick);
            // 
            // btnDMK
            // 
            this.btnDMK.Caption = "Đổi mật khẩu";
            this.btnDMK.Enabled = false;
            this.btnDMK.Id = 24;
            this.btnDMK.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDMK.ImageOptions.SvgImage")));
            this.btnDMK.Name = "btnDMK";
            this.btnDMK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDMK_ItemClick);
            // 
            // ribHeThong
            // 
            this.ribHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribHeThong.Name = "ribHeThong";
            this.ribHeThong.Text = "Hệ Thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDangNhap);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDangXuat);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnTaoTaiKhoan);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDMK);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribDanhMuc
            // 
            this.ribDanhMuc.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup6});
            this.ribDanhMuc.Name = "ribDanhMuc";
            this.ribDanhMuc.Text = "Danh Mục";
            this.ribDanhMuc.Visible = false;
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnSinhVien);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnKhoa);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnLop);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnGiaoVien);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnMonHoc);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnBoDe);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnLapLichThi);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // btnLapLichThi
            // 
            this.btnLapLichThi.Caption = "Lập lịch thi";
            this.btnLapLichThi.Id = 13;
            this.btnLapLichThi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLapLichThi.ImageOptions.SvgImage")));
            this.btnLapLichThi.Name = "btnLapLichThi";
            this.btnLapLichThi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLapLichThi_ItemClick);
            // 
            // ribThi
            // 
            this.ribThi.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup8});
            this.ribThi.Name = "ribThi";
            this.ribThi.Text = "Thi";
            this.ribThi.Visible = false;
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.btnCMT);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            // 
            // ribReport
            // 
            this.ribReport.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup9,
            this.ribbonPageGroup10});
            this.ribReport.Name = "ribReport";
            this.ribReport.Text = "Báo Cáo";
            this.ribReport.Visible = false;
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.ItemLinks.Add(this.btnXemKQ);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            // 
            // ribbonPageGroup10
            // 
            this.ribbonPageGroup10.ItemLinks.Add(this.btnXemBD);
            this.ribbonPageGroup10.ItemLinks.Add(this.btnDSDK);
            this.ribbonPageGroup10.Name = "ribbonPageGroup10";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 466);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(12);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1023, 30);
            // 
            // btnLogin
            // 
            this.btnLogin.Caption = "Đăng nhập";
            this.btnLogin.Id = 1;
            this.btnLogin.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLogin.ImageOptions.SvgImage")));
            this.btnLogin.Name = "btnLogin";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MaGVSV,
            this.HoTen,
            this.Nhom});
            this.statusStrip1.Location = new System.Drawing.Point(0, 444);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1023, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MaGVSV
            // 
            this.MaGVSV.Name = "MaGVSV";
            this.MaGVSV.Size = new System.Drawing.Size(0, 16);
            this.MaGVSV.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // HoTen
            // 
            this.HoTen.Name = "HoTen";
            this.HoTen.Size = new System.Drawing.Size(0, 16);
            // 
            // Nhom
            // 
            this.Nhom.Name = "Nhom";
            this.Nhom.Size = new System.Drawing.Size(0, 16);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 496);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "FormMain";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "THI TRẮC NGHIỆM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnDangNhap;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnLogin;
        private DevExpress.XtraBars.BarButtonItem btnTaoTaiKhoan;
     
        private DevExpress.XtraBars.Ribbon.RibbonPage ribDanhMuc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnSinhVien;
        private DevExpress.XtraBars.BarButtonItem btnKhoa;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btnGiaoVien;
        private DevExpress.XtraBars.BarButtonItem btnMonHoc;
        private DevExpress.XtraBars.BarButtonItem btnBoDe;
        private DevExpress.XtraBars.BarButtonItem btnLapLichThi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem btnThongTinSV;
        private DevExpress.XtraBars.BarButtonItem btnChonMonThi;
        private DevExpress.XtraBars.BarButtonItem btnXemKQ;
        private DevExpress.XtraBars.BarButtonItem btnXemBD;
        private DevExpress.XtraBars.BarButtonItem btnDSDK;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribThi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribReport;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup10;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel MaGVSV;
        private System.Windows.Forms.ToolStripStatusLabel HoTen;
        private System.Windows.Forms.ToolStripStatusLabel Nhom;
        private DevExpress.XtraBars.BarButtonItem btnLop;
        private DevExpress.XtraBars.BarButtonItem btnCMT;
        private DevExpress.XtraBars.BarButtonItem btnDMK;
    }
}