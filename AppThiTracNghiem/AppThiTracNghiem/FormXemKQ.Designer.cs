
namespace AppThiTracNghiem
{
    partial class FormXemKQ
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
            System.Windows.Forms.Label mASVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label lANLabel;
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label nGAYTHILabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormXemKQ));
            this.pnSV = new DevExpress.XtraEditors.PanelControl();
            this.cmbCoSo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbLan = new System.Windows.Forms.ComboBox();
            this.bANGDIEMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_SVDaThiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new AppThiTracNghiem.DS();
            this.cmbMAMH = new System.Windows.Forms.ComboBox();
            this.txtNgay = new DevExpress.XtraEditors.DateEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnInDSBD = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoatBDiem = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.txtTenLop = new DevExpress.XtraEditors.TextEdit();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtHo = new DevExpress.XtraEditors.TextEdit();
            this.txtMaSV = new DevExpress.XtraEditors.TextEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbTenMH = new System.Windows.Forms.ComboBox();
            this.bdsMH = new System.Windows.Forms.BindingSource(this.components);
            this.bdsBD = new System.Windows.Forms.BindingSource(this.components);
            this.bdsSV = new System.Windows.Forms.BindingSource(this.components);
            this.sINHVIENTableAdapter = new AppThiTracNghiem.DSTableAdapters.SINHVIENTableAdapter();
            this.tableAdapterManager = new AppThiTracNghiem.DSTableAdapters.TableAdapterManager();
            this.bANGDIEMTableAdapter = new AppThiTracNghiem.DSTableAdapters.BANGDIEMTableAdapter();
            this.mONHOCTableAdapter = new AppThiTracNghiem.DSTableAdapters.MONHOCTableAdapter();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.get_SVDaThiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_SVDaThiTableAdapter = new AppThiTracNghiem.DSTableAdapters.Get_SVDaThiTableAdapter();
            this.get_RolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_RolesTableAdapter = new AppThiTracNghiem.DSTableAdapters.Get_RolesTableAdapter();
            this.get_TaoTKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_TaoTKTableAdapter = new AppThiTracNghiem.DSTableAdapters.Get_TaoTKTableAdapter();
            this.get_SVDaThiGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lOPTableAdapter = new AppThiTracNghiem.DSTableAdapters.LOPTableAdapter();
            this.gIAOVIEN_DANGKYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gIAOVIEN_DANGKYTableAdapter = new AppThiTracNghiem.DSTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            this.fKGetSVDaThiBANGDIEMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKGetSVDaThiBANGDIEMBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            mASVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            lANLabel = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            nGAYTHILabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pnSV)).BeginInit();
            this.pnSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bANGDIEMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_SVDaThiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_SVDaThiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_RolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_TaoTKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_SVDaThiGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIEN_DANGKYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKGetSVDaThiBANGDIEMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKGetSVDaThiBANGDIEMBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // mASVLabel
            // 
            mASVLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            mASVLabel.AutoSize = true;
            mASVLabel.Location = new System.Drawing.Point(177, 164);
            mASVLabel.Name = "mASVLabel";
            mASVLabel.Size = new System.Drawing.Size(47, 17);
            mASVLabel.TabIndex = 0;
            mASVLabel.Text = "MASV:";
            // 
            // hOLabel
            // 
            hOLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(653, 107);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(57, 17);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "HOTEN:";
            // 
            // mAMHLabel
            // 
            mAMHLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(660, 163);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(50, 17);
            mAMHLabel.TabIndex = 6;
            mAMHLabel.Text = "MAMH:";
            // 
            // lANLabel
            // 
            lANLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            lANLabel.AutoSize = true;
            lANLabel.Location = new System.Drawing.Point(673, 222);
            lANLabel.Name = "lANLabel";
            lANLabel.Size = new System.Drawing.Size(37, 17);
            lANLabel.TabIndex = 8;
            lANLabel.Text = "LAN:";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Location = new System.Drawing.Point(161, 219);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(63, 17);
            tENLOPLabel.TabIndex = 28;
            tENLOPLabel.Text = "TENLOP:";
            // 
            // nGAYTHILabel
            // 
            nGAYTHILabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            nGAYTHILabel.AutoSize = true;
            nGAYTHILabel.Location = new System.Drawing.Point(844, 222);
            nGAYTHILabel.Name = "nGAYTHILabel";
            nGAYTHILabel.Size = new System.Drawing.Size(68, 17);
            nGAYTHILabel.TabIndex = 29;
            nGAYTHILabel.Text = "NGAYTHI:";
            // 
            // pnSV
            // 
            this.pnSV.Controls.Add(this.cmbCoSo);
            this.pnSV.Controls.Add(this.label2);
            this.pnSV.Controls.Add(this.cmbLan);
            this.pnSV.Controls.Add(this.cmbMAMH);
            this.pnSV.Controls.Add(nGAYTHILabel);
            this.pnSV.Controls.Add(this.txtNgay);
            this.pnSV.Controls.Add(tENLOPLabel);
            this.pnSV.Controls.Add(this.txtTenLop);
            this.pnSV.Controls.Add(this.txtTen);
            this.pnSV.Controls.Add(this.txtHo);
            this.pnSV.Controls.Add(this.txtMaSV);
            this.pnSV.Controls.Add(this.label8);
            this.pnSV.Controls.Add(this.cmbTenMH);
            this.pnSV.Controls.Add(lANLabel);
            this.pnSV.Controls.Add(mAMHLabel);
            this.pnSV.Controls.Add(hOLabel);
            this.pnSV.Controls.Add(mASVLabel);
            this.pnSV.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSV.Location = new System.Drawing.Point(0, 30);
            this.pnSV.Name = "pnSV";
            this.pnSV.Size = new System.Drawing.Size(1262, 306);
            this.pnSV.TabIndex = 0;
            // 
            // cmbCoSo
            // 
            this.cmbCoSo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbCoSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCoSo.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCoSo.FormattingEnabled = true;
            this.cmbCoSo.Location = new System.Drawing.Point(230, 107);
            this.cmbCoSo.Name = "cmbCoSo";
            this.cmbCoSo.Size = new System.Drawing.Size(354, 30);
            this.cmbCoSo.TabIndex = 34;
            this.cmbCoSo.SelectedIndexChanged += new System.EventHandler(this.cmbCoSo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Cơ sở";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbLan
            // 
            this.cmbLan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbLan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bANGDIEMBindingSource, "LAN", true));
            this.cmbLan.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLan.FormattingEnabled = true;
            this.cmbLan.Location = new System.Drawing.Point(716, 215);
            this.cmbLan.Name = "cmbLan";
            this.cmbLan.Size = new System.Drawing.Size(121, 29);
            this.cmbLan.TabIndex = 32;
            // 
            // bANGDIEMBindingSource
            // 
            this.bANGDIEMBindingSource.DataMember = "FK_Get_SVDaThi_BANGDIEM";
            this.bANGDIEMBindingSource.DataSource = this.get_SVDaThiBindingSource1;
            // 
            // get_SVDaThiBindingSource1
            // 
            this.get_SVDaThiBindingSource1.DataMember = "Get_SVDaThi";
            this.get_SVDaThiBindingSource1.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbMAMH
            // 
            this.cmbMAMH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbMAMH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bANGDIEMBindingSource, "MAMH", true));
            this.cmbMAMH.DataSource = this.fKGetSVDaThiBANGDIEMBindingSource;
            this.cmbMAMH.DisplayMember = "MAMH";
            this.cmbMAMH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMAMH.FormattingEnabled = true;
            this.cmbMAMH.Location = new System.Drawing.Point(716, 160);
            this.cmbMAMH.Name = "cmbMAMH";
            this.cmbMAMH.Size = new System.Drawing.Size(121, 29);
            this.cmbMAMH.TabIndex = 31;
            this.cmbMAMH.ValueMember = "MAMH";
            this.cmbMAMH.SelectedIndexChanged += new System.EventHandler(this.cmbMAMH_SelectedIndexChanged_1);
            // 
            // txtNgay
            // 
            this.txtNgay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNgay.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bANGDIEMBindingSource, "NGAYTHI", true));
            this.txtNgay.EditValue = null;
            this.txtNgay.Enabled = false;
            this.txtNgay.Location = new System.Drawing.Point(918, 219);
            this.txtNgay.MenuManager = this.barManager1;
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgay.Properties.Appearance.Options.UseFont = true;
            this.txtNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgay.Size = new System.Drawing.Size(152, 28);
            this.txtNgay.TabIndex = 30;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnInDSBD,
            this.btnThoatBDiem});
            this.barManager1.MainMenu = this.bar1;
            this.barManager1.MaxItemId = 2;
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(335, 163);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnInDSBD, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoatBDiem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // btnInDSBD
            // 
            this.btnInDSBD.Caption = "Xem báo cáo";
            this.btnInDSBD.Id = 0;
            this.btnInDSBD.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnInDSBD.ImageOptions.SvgImage")));
            this.btnInDSBD.Name = "btnInDSBD";
            this.btnInDSBD.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInDSBD_ItemClick);
            // 
            // btnThoatBDiem
            // 
            this.btnThoatBDiem.Caption = "Thoát";
            this.btnThoatBDiem.Id = 1;
            this.btnThoatBDiem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoatBDiem.ImageOptions.SvgImage")));
            this.btnThoatBDiem.Name = "btnThoatBDiem";
            this.btnThoatBDiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoatBDiem_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(1262, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 768);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1262, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 738);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1262, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 738);
            // 
            // txtTenLop
            // 
            this.txtTenLop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenLop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lOPBindingSource, "TENLOP", true));
            this.txtTenLop.Enabled = false;
            this.txtTenLop.Location = new System.Drawing.Point(230, 216);
            this.txtTenLop.MenuManager = this.barManager1;
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLop.Properties.Appearance.Options.UseFont = true;
            this.txtTenLop.Size = new System.Drawing.Size(354, 28);
            this.txtTenLop.TabIndex = 29;
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "FK_Get_SVDaThi_LOP";
            this.lOPBindingSource.DataSource = this.get_SVDaThiBindingSource1;
            // 
            // txtTen
            // 
            this.txtTen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.get_SVDaThiBindingSource1, "TEN", true));
            this.txtTen.Enabled = false;
            this.txtTen.Location = new System.Drawing.Point(930, 102);
            this.txtTen.MenuManager = this.barManager1;
            this.txtTen.Name = "txtTen";
            this.txtTen.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Properties.Appearance.Options.UseFont = true;
            this.txtTen.Size = new System.Drawing.Size(140, 28);
            this.txtTen.TabIndex = 26;
            // 
            // txtHo
            // 
            this.txtHo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtHo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.get_SVDaThiBindingSource1, "HO", true));
            this.txtHo.Enabled = false;
            this.txtHo.Location = new System.Drawing.Point(716, 102);
            this.txtHo.MenuManager = this.barManager1;
            this.txtHo.Name = "txtHo";
            this.txtHo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHo.Properties.Appearance.Options.UseFont = true;
            this.txtHo.Size = new System.Drawing.Size(208, 28);
            this.txtHo.TabIndex = 25;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaSV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.get_SVDaThiBindingSource1, "MASV", true));
            this.txtMaSV.Enabled = false;
            this.txtMaSV.Location = new System.Drawing.Point(230, 161);
            this.txtMaSV.MenuManager = this.barManager1;
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSV.Properties.Appearance.Options.UseFont = true;
            this.txtMaSV.Size = new System.Drawing.Size(354, 28);
            this.txtMaSV.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(484, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(279, 59);
            this.label8.TabIndex = 23;
            this.label8.Text = "XEM KẾT QUẢ THI";
            // 
            // cmbTenMH
            // 
            this.cmbTenMH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbTenMH.DataSource = this.bdsMH;
            this.cmbTenMH.DisplayMember = "TENMH";
            this.cmbTenMH.Enabled = false;
            this.cmbTenMH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTenMH.FormattingEnabled = true;
            this.cmbTenMH.Location = new System.Drawing.Point(843, 160);
            this.cmbTenMH.Name = "cmbTenMH";
            this.cmbTenMH.Size = new System.Drawing.Size(227, 29);
            this.cmbTenMH.TabIndex = 10;
            this.cmbTenMH.ValueMember = "MAMH";
            // 
            // bdsMH
            // 
            this.bdsMH.DataMember = "MONHOC";
            this.bdsMH.DataSource = this.dS;
            // 
            // bdsBD
            // 
            this.bdsBD.DataMember = "FK_BANGDIEM_SINHVIEN1";
            this.bdsBD.DataSource = this.bdsSV;
            // 
            // bdsSV
            // 
            this.bdsSV.DataMember = "SINHVIEN";
            this.bdsSV.DataSource = this.dS;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAITHITableAdapter = null;
            this.tableAdapterManager.BANGDIEMTableAdapter = this.bANGDIEMTableAdapter;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = this.mONHOCTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = this.sINHVIENTableAdapter;
            this.tableAdapterManager.UpdateOrder = AppThiTracNghiem.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bANGDIEMTableAdapter
            // 
            this.bANGDIEMTableAdapter.ClearBeforeFill = true;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(335, 163);
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // get_SVDaThiBindingSource
            // 
            this.get_SVDaThiBindingSource.DataSource = this.dS;
            this.get_SVDaThiBindingSource.Position = 0;
            // 
            // get_SVDaThiTableAdapter
            // 
            this.get_SVDaThiTableAdapter.ClearBeforeFill = true;
            // 
            // get_RolesBindingSource
            // 
            this.get_RolesBindingSource.DataMember = "Get_Roles";
            this.get_RolesBindingSource.DataSource = this.dS;
            // 
            // get_RolesTableAdapter
            // 
            this.get_RolesTableAdapter.ClearBeforeFill = true;
            // 
            // get_TaoTKBindingSource
            // 
            this.get_TaoTKBindingSource.DataMember = "Get_TaoTK";
            this.get_TaoTKBindingSource.DataSource = this.dS;
            // 
            // get_TaoTKTableAdapter
            // 
            this.get_TaoTKTableAdapter.ClearBeforeFill = true;
            // 
            // get_SVDaThiGridControl
            // 
            this.get_SVDaThiGridControl.DataSource = this.get_SVDaThiBindingSource1;
            this.get_SVDaThiGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.get_SVDaThiGridControl.Location = new System.Drawing.Point(0, 336);
            this.get_SVDaThiGridControl.MainView = this.gridView1;
            this.get_SVDaThiGridControl.MenuManager = this.barManager1;
            this.get_SVDaThiGridControl.Name = "get_SVDaThiGridControl";
            this.get_SVDaThiGridControl.Size = new System.Drawing.Size(1262, 432);
            this.get_SVDaThiGridControl.TabIndex = 5;
            this.get_SVDaThiGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.get_SVDaThiGridControl.Click += new System.EventHandler(this.get_SVDaThiGridControl_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colHO,
            this.colTEN,
            this.colNGAYSINH,
            this.colDIACHI,
            this.colMALOP});
            this.gridView1.GridControl = this.get_SVDaThiGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMASV
            // 
            this.colMASV.FieldName = "MASV";
            this.colMASV.MinWidth = 25;
            this.colMASV.Name = "colMASV";
            this.colMASV.OptionsColumn.AllowEdit = false;
            this.colMASV.OptionsColumn.ReadOnly = true;
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
            this.colMASV.Width = 94;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 25;
            this.colHO.Name = "colHO";
            this.colHO.OptionsColumn.AllowEdit = false;
            this.colHO.OptionsColumn.ReadOnly = true;
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 94;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 25;
            this.colTEN.Name = "colTEN";
            this.colTEN.OptionsColumn.AllowEdit = false;
            this.colTEN.OptionsColumn.ReadOnly = true;
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 94;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.MinWidth = 25;
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.OptionsColumn.AllowEdit = false;
            this.colNGAYSINH.OptionsColumn.ReadOnly = true;
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 3;
            this.colNGAYSINH.Width = 94;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 25;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.OptionsColumn.AllowEdit = false;
            this.colDIACHI.OptionsColumn.ReadOnly = true;
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 4;
            this.colDIACHI.Width = 94;
            // 
            // colMALOP
            // 
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.MinWidth = 25;
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.OptionsColumn.AllowEdit = false;
            this.colMALOP.OptionsColumn.ReadOnly = true;
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 5;
            this.colMALOP.Width = 94;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // gIAOVIEN_DANGKYBindingSource
            // 
            this.gIAOVIEN_DANGKYBindingSource.DataMember = "FK_GIAOVIEN_DANGKY_LOP";
            this.gIAOVIEN_DANGKYBindingSource.DataSource = this.lOPBindingSource;
            // 
            // gIAOVIEN_DANGKYTableAdapter
            // 
            this.gIAOVIEN_DANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // fKGetSVDaThiBANGDIEMBindingSource
            // 
            this.fKGetSVDaThiBANGDIEMBindingSource.DataMember = "FK_Get_SVDaThi_BANGDIEM";
            this.fKGetSVDaThiBANGDIEMBindingSource.DataSource = this.get_SVDaThiBindingSource1;
            // 
            // fKGetSVDaThiBANGDIEMBindingSource1
            // 
            this.fKGetSVDaThiBANGDIEMBindingSource1.DataMember = "FK_Get_SVDaThi_BANGDIEM";
            this.fKGetSVDaThiBANGDIEMBindingSource1.DataSource = this.get_SVDaThiBindingSource1;
            // 
            // FormXemKQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 768);
            this.Controls.Add(this.get_SVDaThiGridControl);
            this.Controls.Add(this.pnSV);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormXemKQ";
            this.Text = "Xem kết quả";
            this.Load += new System.EventHandler(this.FormXemKQ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnSV)).EndInit();
            this.pnSV.ResumeLayout(false);
            this.pnSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bANGDIEMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_SVDaThiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_SVDaThiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_RolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_TaoTKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_SVDaThiGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIEN_DANGKYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKGetSVDaThiBANGDIEMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKGetSVDaThiBANGDIEMBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnSV;
        private DS dS;
        private System.Windows.Forms.BindingSource bdsSV;
        private DSTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DSTableAdapters.BANGDIEMTableAdapter bANGDIEMTableAdapter;
        private System.Windows.Forms.BindingSource bdsBD;
        private System.Windows.Forms.ComboBox cmbTenMH;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.BindingSource bdsMH;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnInDSBD;
        private DevExpress.XtraBars.BarButtonItem btnThoatBDiem;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource get_SVDaThiBindingSource;
        private DSTableAdapters.Get_SVDaThiTableAdapter get_SVDaThiTableAdapter;
        private System.Windows.Forms.BindingSource get_RolesBindingSource;
        private DSTableAdapters.Get_RolesTableAdapter get_RolesTableAdapter;
        private System.Windows.Forms.BindingSource get_TaoTKBindingSource;
        private DSTableAdapters.Get_TaoTKTableAdapter get_TaoTKTableAdapter;
        private DevExpress.XtraGrid.GridControl get_SVDaThiGridControl;
        private System.Windows.Forms.BindingSource get_SVDaThiBindingSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.TextEdit txtHo;
        private DevExpress.XtraEditors.TextEdit txtMaSV;
        private System.Windows.Forms.BindingSource bANGDIEMBindingSource;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private DevExpress.XtraEditors.TextEdit txtTenLop;
        private System.Windows.Forms.BindingSource gIAOVIEN_DANGKYBindingSource;
        private DSTableAdapters.GIAOVIEN_DANGKYTableAdapter gIAOVIEN_DANGKYTableAdapter;
        private System.Windows.Forms.ComboBox cmbMAMH;
        private System.Windows.Forms.ComboBox cmbCoSo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbLan;
        private DevExpress.XtraEditors.DateEdit txtNgay;
        private System.Windows.Forms.BindingSource fKGetSVDaThiBANGDIEMBindingSource;
        private System.Windows.Forms.BindingSource fKGetSVDaThiBANGDIEMBindingSource1;
    }
}