
namespace AppThiTracNghiem
{
    partial class FormThi
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
            System.Windows.Forms.Label mAMHLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThi));
            this.bdsGVDK = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new AppThiTracNghiem.DS();
            this.bdsMH = new System.Windows.Forms.BindingSource(this.components);
            this.mONHOCTableAdapter = new AppThiTracNghiem.DSTableAdapters.MONHOCTableAdapter();
            this.tableAdapterManager = new AppThiTracNghiem.DSTableAdapters.TableAdapterManager();
            this.gIAOVIEN_DANGKYTableAdapter = new AppThiTracNghiem.DSTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btn_BatDau = new DevExpress.XtraBars.BarButtonItem();
            this.btnNopBai = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.lb_MASV = new System.Windows.Forms.ComboBox();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lb_MALOP = new System.Windows.Forms.ComboBox();
            this.lb_4 = new System.Windows.Forms.Label();
            this.lb_3 = new System.Windows.Forms.Label();
            this.lb_2 = new System.Windows.Forms.Label();
            this.lb_1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.lblTime = new System.Windows.Forms.Label();
            this.lb_SoCauThi = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lb_TrinhDo = new System.Windows.Forms.Label();
            this.lb_So = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.spin_LanThi = new DevExpress.XtraEditors.SpinEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.date_NgayThi = new DevExpress.XtraEditors.DateEdit();
            this.cmb_MonHoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gcNoiDung = new DevExpress.XtraEditors.GroupControl();
            this.rdbDA = new DevExpress.XtraEditors.RadioGroup();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblCauHoi = new System.Windows.Forms.Label();
            this.rdbListQS = new DevExpress.XtraEditors.RadioGroup();
            this.lOPTableAdapter = new AppThiTracNghiem.DSTableAdapters.LOPTableAdapter();
            this.lb_TENLOP = new System.Windows.Forms.ComboBox();
            this.lb_TENSV = new System.Windows.Forms.ComboBox();
            mAMHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGVDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spin_LanThi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_NgayThi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_NgayThi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNoiDung)).BeginInit();
            this.gcNoiDung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdbDA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdbListQS.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAMHLabel.Location = new System.Drawing.Point(13, 50);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(83, 19);
            mAMHLabel.TabIndex = 19;
            mAMHLabel.Text = "Môn Học:";
            // 
            // bdsGVDK
            // 
            this.bdsGVDK.DataMember = "GIAOVIEN_DANGKY";
            this.bdsGVDK.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsMH
            // 
            this.bdsMH.DataMember = "MONHOC";
            this.bdsMH.DataSource = this.dS;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAITHITableAdapter = null;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = this.gIAOVIEN_DANGKYTableAdapter;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = this.mONHOCTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AppThiTracNghiem.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gIAOVIEN_DANGKYTableAdapter
            // 
            this.gIAOVIEN_DANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnNopBai,
            this.btnThoat,
            this.btn_BatDau,
            this.barStaticItem1});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 4;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_BatDau),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnNopBai),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThoat)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btn_BatDau
            // 
            this.btn_BatDau.Caption = "Bắt đầu";
            this.btn_BatDau.Id = 2;
            this.btn_BatDau.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_BatDau.ImageOptions.SvgImage")));
            this.btn_BatDau.Name = "btn_BatDau";
            this.btn_BatDau.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_BatDau.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_BatDau_ItemClick);
            // 
            // btnNopBai
            // 
            this.btnNopBai.Caption = "Nộp bài";
            this.btnNopBai.Id = 0;
            this.btnNopBai.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNopBai.ImageOptions.SvgImage")));
            this.btnNopBai.Name = "btnNopBai";
            this.btnNopBai.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnNopBai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNopBai_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 1;
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlTop.Size = new System.Drawing.Size(1778, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 722);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1778, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 692);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1778, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 692);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Time";
            this.barStaticItem1.Id = 3;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.panelControl5);
            this.panelControl2.Controls.Add(this.panelControl4);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 30);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1778, 175);
            this.panelControl2.TabIndex = 9;
            // 
            // panelControl5
            // 
            this.panelControl5.Controls.Add(this.lb_TENSV);
            this.panelControl5.Controls.Add(this.lb_TENLOP);
            this.panelControl5.Controls.Add(this.lb_MASV);
            this.panelControl5.Controls.Add(this.lb_MALOP);
            this.panelControl5.Controls.Add(this.lb_4);
            this.panelControl5.Controls.Add(this.lb_3);
            this.panelControl5.Controls.Add(this.lb_2);
            this.panelControl5.Controls.Add(this.lb_1);
            this.panelControl5.Controls.Add(this.label1);
            this.panelControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl5.Location = new System.Drawing.Point(954, 2);
            this.panelControl5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(822, 171);
            this.panelControl5.TabIndex = 5;
            // 
            // lb_MASV
            // 
            this.lb_MASV.FormattingEnabled = true;
            this.lb_MASV.Location = new System.Drawing.Point(192, 46);
            this.lb_MASV.Name = "lb_MASV";
            this.lb_MASV.Size = new System.Drawing.Size(199, 24);
            this.lb_MASV.TabIndex = 27;
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.dS;
            // 
            // lb_MALOP
            // 
            this.lb_MALOP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOPBindingSource, "MALOP", true));
            this.lb_MALOP.DataSource = this.lOPBindingSource;
            this.lb_MALOP.DisplayMember = "MALOP";
            this.lb_MALOP.FormattingEnabled = true;
            this.lb_MALOP.Location = new System.Drawing.Point(616, 46);
            this.lb_MALOP.Name = "lb_MALOP";
            this.lb_MALOP.Size = new System.Drawing.Size(199, 24);
            this.lb_MALOP.TabIndex = 25;
            this.lb_MALOP.ValueMember = "MALOP";
            // 
            // lb_4
            // 
            this.lb_4.AutoSize = true;
            this.lb_4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_4.Location = new System.Drawing.Point(506, 102);
            this.lb_4.Name = "lb_4";
            this.lb_4.Size = new System.Drawing.Size(103, 23);
            this.lb_4.TabIndex = 24;
            this.lb_4.Text = "TÊN LỚP:";
            // 
            // lb_3
            // 
            this.lb_3.AutoSize = true;
            this.lb_3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_3.Location = new System.Drawing.Point(506, 46);
            this.lb_3.Name = "lb_3";
            this.lb_3.Size = new System.Drawing.Size(104, 23);
            this.lb_3.TabIndex = 22;
            this.lb_3.Text = "MÃ LỚP : ";
            // 
            // lb_2
            // 
            this.lb_2.AutoSize = true;
            this.lb_2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_2.Location = new System.Drawing.Point(109, 102);
            this.lb_2.Name = "lb_2";
            this.lb_2.Size = new System.Drawing.Size(85, 23);
            this.lb_2.TabIndex = 20;
            this.lb_2.Text = "TÊN SV:";
            // 
            // lb_1
            // 
            this.lb_1.AutoSize = true;
            this.lb_1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_1.Location = new System.Drawing.Point(109, 46);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(77, 23);
            this.lb_1.TabIndex = 18;
            this.lb_1.Text = "MÃ SV:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Thông tin sinh viên";
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.lblTime);
            this.panelControl4.Controls.Add(this.lb_SoCauThi);
            this.panelControl4.Controls.Add(this.label10);
            this.panelControl4.Controls.Add(this.lb_TrinhDo);
            this.panelControl4.Controls.Add(this.lb_So);
            this.panelControl4.Controls.Add(this.lb);
            this.panelControl4.Controls.Add(this.label4);
            this.panelControl4.Controls.Add(this.spin_LanThi);
            this.panelControl4.Controls.Add(this.label2);
            this.panelControl4.Controls.Add(this.date_NgayThi);
            this.panelControl4.Controls.Add(mAMHLabel);
            this.panelControl4.Controls.Add(this.cmb_MonHoc);
            this.panelControl4.Controls.Add(this.label3);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl4.Location = new System.Drawing.Point(2, 2);
            this.panelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(952, 171);
            this.panelControl4.TabIndex = 4;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(816, 65);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(107, 39);
            this.lblTime.TabIndex = 11;
            this.lblTime.Text = "00:00";
            // 
            // lb_SoCauThi
            // 
            this.lb_SoCauThi.AutoSize = true;
            this.lb_SoCauThi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SoCauThi.Location = new System.Drawing.Point(508, 102);
            this.lb_SoCauThi.Name = "lb_SoCauThi";
            this.lb_SoCauThi.Size = new System.Drawing.Size(20, 23);
            this.lb_SoCauThi.TabIndex = 28;
            this.lb_SoCauThi.Text = "1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(655, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 29);
            this.label10.TabIndex = 10;
            this.label10.Text = "THỜI GIAN:";
            // 
            // lb_TrinhDo
            // 
            this.lb_TrinhDo.AutoSize = true;
            this.lb_TrinhDo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TrinhDo.Location = new System.Drawing.Point(264, 102);
            this.lb_TrinhDo.Name = "lb_TrinhDo";
            this.lb_TrinhDo.Size = new System.Drawing.Size(24, 23);
            this.lb_TrinhDo.TabIndex = 27;
            this.lb_TrinhDo.Text = "A";
            // 
            // lb_So
            // 
            this.lb_So.AutoSize = true;
            this.lb_So.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_So.Location = new System.Drawing.Point(399, 102);
            this.lb_So.Name = "lb_So";
            this.lb_So.Size = new System.Drawing.Size(115, 23);
            this.lb_So.TabIndex = 26;
            this.lb_So.Text = "Số Câu Thi :";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(176, 101);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(98, 23);
            this.lb.TabIndex = 25;
            this.lb.Text = "Trình độ : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 19);
            this.label4.TabIndex = 24;
            this.label4.Text = "Lần";
            // 
            // spin_LanThi
            // 
            this.spin_LanThi.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spin_LanThi.Location = new System.Drawing.Point(65, 99);
            this.spin_LanThi.Margin = new System.Windows.Forms.Padding(4);
            this.spin_LanThi.Name = "spin_LanThi";
            this.spin_LanThi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.spin_LanThi.Properties.Appearance.Options.UseFont = true;
            this.spin_LanThi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spin_LanThi.Properties.MaxValue = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.spin_LanThi.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spin_LanThi.Size = new System.Drawing.Size(42, 28);
            this.spin_LanThi.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(351, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "Ngày Thi";
            // 
            // date_NgayThi
            // 
            this.date_NgayThi.EditValue = new System.DateTime(2022, 5, 17, 0, 0, 0, 0);
            this.date_NgayThi.Location = new System.Drawing.Point(433, 46);
            this.date_NgayThi.Margin = new System.Windows.Forms.Padding(4);
            this.date_NgayThi.Name = "date_NgayThi";
            this.date_NgayThi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.date_NgayThi.Properties.Appearance.Options.UseFont = true;
            this.date_NgayThi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_NgayThi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_NgayThi.Size = new System.Drawing.Size(121, 28);
            this.date_NgayThi.TabIndex = 21;
            // 
            // cmb_MonHoc
            // 
            this.cmb_MonHoc.DataSource = this.bdsMH;
            this.cmb_MonHoc.DisplayMember = "TENMH";
            this.cmb_MonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_MonHoc.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_MonHoc.FormattingEnabled = true;
            this.cmb_MonHoc.Location = new System.Drawing.Point(102, 47);
            this.cmb_MonHoc.Name = "cmb_MonHoc";
            this.cmb_MonHoc.Size = new System.Drawing.Size(223, 27);
            this.cmb_MonHoc.TabIndex = 20;
            this.cmb_MonHoc.ValueMember = "MAMH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(5, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "Thông tin bài thi";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gcNoiDung
            // 
            this.gcNoiDung.Controls.Add(this.rdbDA);
            this.gcNoiDung.Controls.Add(this.panelControl1);
            this.gcNoiDung.Controls.Add(this.rdbListQS);
            this.gcNoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcNoiDung.Location = new System.Drawing.Point(0, 205);
            this.gcNoiDung.Name = "gcNoiDung";
            this.gcNoiDung.Size = new System.Drawing.Size(1778, 517);
            this.gcNoiDung.TabIndex = 24;
            this.gcNoiDung.Text = "Câu hỏi";
            // 
            // rdbDA
            // 
            this.rdbDA.Dock = System.Windows.Forms.DockStyle.Top;
            this.rdbDA.Location = new System.Drawing.Point(92, 200);
            this.rdbDA.MenuManager = this.barManager1;
            this.rdbDA.Name = "rdbDA";
            this.rdbDA.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rdbDA.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.rdbDA.Properties.Appearance.Options.UseBackColor = true;
            this.rdbDA.Properties.Appearance.Options.UseFont = true;
            this.rdbDA.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rdbDA.Size = new System.Drawing.Size(1684, 139);
            this.rdbDA.TabIndex = 1;
            this.rdbDA.SelectedIndexChanged += new System.EventHandler(this.rdbDA_SelectedIndexChanged);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lblCauHoi);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(92, 28);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1684, 172);
            this.panelControl1.TabIndex = 4;
            // 
            // lblCauHoi
            // 
            this.lblCauHoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCauHoi.AutoSize = true;
            this.lblCauHoi.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblCauHoi.Location = new System.Drawing.Point(5, 12);
            this.lblCauHoi.Name = "lblCauHoi";
            this.lblCauHoi.Size = new System.Drawing.Size(68, 24);
            this.lblCauHoi.TabIndex = 1;
            this.lblCauHoi.Text = "Câu 1:";
            // 
            // rdbListQS
            // 
            this.rdbListQS.AllowDrop = true;
            this.rdbListQS.Dock = System.Windows.Forms.DockStyle.Left;
            this.rdbListQS.Location = new System.Drawing.Point(2, 28);
            this.rdbListQS.MenuManager = this.barManager1;
            this.rdbListQS.Name = "rdbListQS";
            this.rdbListQS.Properties.Appearance.BackColor = System.Drawing.SystemColors.HighlightText;
            this.rdbListQS.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.rdbListQS.Properties.Appearance.Options.UseBackColor = true;
            this.rdbListQS.Properties.Appearance.Options.UseFont = true;
            this.rdbListQS.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.rdbListQS.Size = new System.Drawing.Size(90, 487);
            this.rdbListQS.TabIndex = 2;
            this.rdbListQS.SelectedIndexChanged += new System.EventHandler(this.rdbListQS_SelectedIndexChanged);
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // lb_TENLOP
            // 
            this.lb_TENLOP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOPBindingSource, "TENLOP", true));
            this.lb_TENLOP.DataSource = this.lOPBindingSource;
            this.lb_TENLOP.DisplayMember = "TENLOP";
            this.lb_TENLOP.FormattingEnabled = true;
            this.lb_TENLOP.Location = new System.Drawing.Point(616, 100);
            this.lb_TENLOP.Name = "lb_TENLOP";
            this.lb_TENLOP.Size = new System.Drawing.Size(199, 24);
            this.lb_TENLOP.TabIndex = 28;
            this.lb_TENLOP.ValueMember = "MALOP";
            // 
            // lb_TENSV
            // 
            this.lb_TENSV.FormattingEnabled = true;
            this.lb_TENSV.Location = new System.Drawing.Point(192, 102);
            this.lb_TENSV.Name = "lb_TENSV";
            this.lb_TENSV.Size = new System.Drawing.Size(199, 24);
            this.lb_TENSV.TabIndex = 29;
            // 
            // FormThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1778, 722);
            this.Controls.Add(this.gcNoiDung);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormThi";
            this.Text = "Thi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdsGVDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            this.panelControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spin_LanThi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_NgayThi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_NgayThi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNoiDung)).EndInit();
            this.gcNoiDung.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rdbDA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdbListQS.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DS dS;
        private System.Windows.Forms.BindingSource bdsMH;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DSTableAdapters.GIAOVIEN_DANGKYTableAdapter gIAOVIEN_DANGKYTableAdapter;
        private System.Windows.Forms.BindingSource bdsGVDK;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnNopBai;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraBars.Bar bar3;
        private System.Windows.Forms.Label lb_4;
        private System.Windows.Forms.Label lb_3;
        private System.Windows.Forms.Label lb_2;
        private System.Windows.Forms.Label lb_1;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SpinEdit spin_LanThi;
        private System.Windows.Forms.ComboBox cmb_MonHoc;
        private System.Windows.Forms.Label lb_SoCauThi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lb_TrinhDo;
        private System.Windows.Forms.Label lb_So;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.DateEdit date_NgayThi;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.GroupControl gcNoiDung;
        private System.Windows.Forms.Label lblTime;
        private DevExpress.XtraEditors.RadioGroup rdbListQS;
        private DevExpress.XtraEditors.RadioGroup rdbDA;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label lblCauHoi;
        private DevExpress.XtraBars.BarButtonItem btn_BatDau;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.ComboBox lb_MALOP;
        private System.Windows.Forms.ComboBox lb_MASV;
        private System.Windows.Forms.ComboBox lb_TENSV;
        private System.Windows.Forms.ComboBox lb_TENLOP;
    }
}