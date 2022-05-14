
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThi));
            System.Windows.Forms.Label tENMHLabel;
            this.gIAOVIEN_DANGKYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new AppThiTracNghiem.DS();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mONHOCTableAdapter = new AppThiTracNghiem.DSTableAdapters.MONHOCTableAdapter();
            this.tableAdapterManager = new AppThiTracNghiem.DSTableAdapters.TableAdapterManager();
            this.gIAOVIEN_DANGKYTableAdapter = new AppThiTracNghiem.DSTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnNopBai = new DevExpress.XtraBars.BarButtonItem();
            this.btnXemKQ = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl6 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.label3 = new System.Windows.Forms.Label();
            this.tENMHTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.txtB_IDClass = new System.Windows.Forms.TextBox();
            this.lb_IDClass = new System.Windows.Forms.Label();
            this.txtB_FullName = new System.Windows.Forms.TextBox();
            this.txtB_NameClass = new System.Windows.Forms.TextBox();
            this.txtB_IDStudent = new System.Windows.Forms.TextBox();
            this.lb_NameClass = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gcNoiDung = new DevExpress.XtraEditors.GroupControl();
            this.rdbDapAn = new DevExpress.XtraEditors.RadioGroup();
            this.rdbCauHoi = new DevExpress.XtraEditors.RadioGroup();
            this.bar3 = new DevExpress.XtraBars.Bar();
            tENMHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIEN_DANGKYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).BeginInit();
            this.panelControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tENMHTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNoiDung)).BeginInit();
            this.gcNoiDung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdbDapAn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdbCauHoi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gIAOVIEN_DANGKYBindingSource
            // 
            this.gIAOVIEN_DANGKYBindingSource.DataMember = "GIAOVIEN_DANGKY";
            this.gIAOVIEN_DANGKYBindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.dS;
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
            this.btnXemKQ,
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnNopBai),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXemKQ),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThoat)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
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
            // btnXemKQ
            // 
            this.btnXemKQ.Caption = "Xem kết quả";
            this.btnXemKQ.Id = 2;
            this.btnXemKQ.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXemKQ.ImageOptions.SvgImage")));
            this.btnXemKQ.Name = "btnXemKQ";
            this.btnXemKQ.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 1;
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Time";
            this.barStaticItem1.Id = 3;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlTop.Size = new System.Drawing.Size(1518, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 802);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1518, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 772);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1518, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 772);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.panelControl5);
            this.panelControl2.Controls.Add(this.panelControl4);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 30);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1518, 175);
            this.panelControl2.TabIndex = 9;
            // 
            // panelControl3
            // 
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(0, 205);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1518, 125);
            this.panelControl3.TabIndex = 10;
            // 
            // panelControl6
            // 
            this.panelControl6.Controls.Add(this.gcNoiDung);
            this.panelControl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl6.Location = new System.Drawing.Point(0, 330);
            this.panelControl6.Name = "panelControl6";
            this.panelControl6.Size = new System.Drawing.Size(1518, 472);
            this.panelControl6.TabIndex = 2;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.label3);
            this.panelControl4.Controls.Add(tENMHLabel);
            this.panelControl4.Controls.Add(this.tENMHTextEdit);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl4.Location = new System.Drawing.Point(2, 2);
            this.panelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(733, 171);
            this.panelControl4.TabIndex = 4;
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
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(21, 61);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(57, 17);
            tENMHLabel.TabIndex = 0;
            tENMHLabel.Text = "TENMH:";
            // 
            // tENMHTextEdit
            // 
            this.tENMHTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mONHOCBindingSource, "TENMH", true));
            this.tENMHTextEdit.Location = new System.Drawing.Point(100, 58);
            this.tENMHTextEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tENMHTextEdit.Name = "tENMHTextEdit";
            this.tENMHTextEdit.Size = new System.Drawing.Size(205, 22);
            this.tENMHTextEdit.TabIndex = 1;
            // 
            // panelControl5
            // 
            this.panelControl5.Controls.Add(this.label1);
            this.panelControl5.Controls.Add(this.txtB_IDClass);
            this.panelControl5.Controls.Add(this.lb_IDClass);
            this.panelControl5.Controls.Add(this.txtB_FullName);
            this.panelControl5.Controls.Add(this.txtB_NameClass);
            this.panelControl5.Controls.Add(this.txtB_IDStudent);
            this.panelControl5.Controls.Add(this.lb_NameClass);
            this.panelControl5.Controls.Add(this.label2);
            this.panelControl5.Controls.Add(this.label4);
            this.panelControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl5.Location = new System.Drawing.Point(735, 2);
            this.panelControl5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(781, 171);
            this.panelControl5.TabIndex = 5;
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
            // txtB_IDClass
            // 
            this.txtB_IDClass.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtB_IDClass.Enabled = false;
            this.txtB_IDClass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtB_IDClass.Location = new System.Drawing.Point(450, 36);
            this.txtB_IDClass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtB_IDClass.Name = "txtB_IDClass";
            this.txtB_IDClass.Size = new System.Drawing.Size(191, 23);
            this.txtB_IDClass.TabIndex = 16;
            // 
            // lb_IDClass
            // 
            this.lb_IDClass.AutoSize = true;
            this.lb_IDClass.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_IDClass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_IDClass.Location = new System.Drawing.Point(383, 41);
            this.lb_IDClass.Name = "lb_IDClass";
            this.lb_IDClass.Size = new System.Drawing.Size(52, 17);
            this.lb_IDClass.TabIndex = 15;
            this.lb_IDClass.Text = "Mã lớp:";
            // 
            // txtB_FullName
            // 
            this.txtB_FullName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtB_FullName.Enabled = false;
            this.txtB_FullName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtB_FullName.Location = new System.Drawing.Point(129, 98);
            this.txtB_FullName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtB_FullName.Name = "txtB_FullName";
            this.txtB_FullName.Size = new System.Drawing.Size(195, 23);
            this.txtB_FullName.TabIndex = 14;
            // 
            // txtB_NameClass
            // 
            this.txtB_NameClass.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtB_NameClass.Enabled = false;
            this.txtB_NameClass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtB_NameClass.Location = new System.Drawing.Point(450, 98);
            this.txtB_NameClass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtB_NameClass.Name = "txtB_NameClass";
            this.txtB_NameClass.Size = new System.Drawing.Size(191, 23);
            this.txtB_NameClass.TabIndex = 13;
            // 
            // txtB_IDStudent
            // 
            this.txtB_IDStudent.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtB_IDStudent.Enabled = false;
            this.txtB_IDStudent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtB_IDStudent.Location = new System.Drawing.Point(129, 36);
            this.txtB_IDStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtB_IDStudent.Name = "txtB_IDStudent";
            this.txtB_IDStudent.Size = new System.Drawing.Size(195, 23);
            this.txtB_IDStudent.TabIndex = 12;
            // 
            // lb_NameClass
            // 
            this.lb_NameClass.AutoSize = true;
            this.lb_NameClass.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_NameClass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_NameClass.Location = new System.Drawing.Point(383, 101);
            this.lb_NameClass.Name = "lb_NameClass";
            this.lb_NameClass.Size = new System.Drawing.Size(58, 17);
            this.lb_NameClass.TabIndex = 11;
            this.lb_NameClass.Text = "Tên lớp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(36, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Họ và tên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(36, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mã sinh viên:";
            // 
            // gcNoiDung
            // 
            this.gcNoiDung.Controls.Add(this.rdbDapAn);
            this.gcNoiDung.Controls.Add(this.rdbCauHoi);
            this.gcNoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcNoiDung.Location = new System.Drawing.Point(2, 2);
            this.gcNoiDung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcNoiDung.Name = "gcNoiDung";
            this.gcNoiDung.Size = new System.Drawing.Size(1514, 468);
            this.gcNoiDung.TabIndex = 2;
            this.gcNoiDung.Text = "Nội dung";
            // 
            // rdbDapAn
            // 
            this.rdbDapAn.Dock = System.Windows.Forms.DockStyle.Top;
            this.rdbDapAn.Location = new System.Drawing.Point(2, 218);
            this.rdbDapAn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbDapAn.Name = "rdbDapAn";
            this.rdbDapAn.Size = new System.Drawing.Size(1510, 180);
            this.rdbDapAn.TabIndex = 1;
            // 
            // rdbCauHoi
            // 
            this.rdbCauHoi.Dock = System.Windows.Forms.DockStyle.Top;
            this.rdbCauHoi.Location = new System.Drawing.Point(2, 28);
            this.rdbCauHoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbCauHoi.Name = "rdbCauHoi";
            this.rdbCauHoi.Size = new System.Drawing.Size(1510, 190);
            this.rdbCauHoi.TabIndex = 0;
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
            // FormThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1518, 802);
            this.Controls.Add(this.panelControl6);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormThi";
            this.Text = "Thi";
            this.Load += new System.EventHandler(this.FormThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIEN_DANGKYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).EndInit();
            this.panelControl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tENMHTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            this.panelControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNoiDung)).EndInit();
            this.gcNoiDung.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rdbDapAn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdbCauHoi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DS dS;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DSTableAdapters.GIAOVIEN_DANGKYTableAdapter gIAOVIEN_DANGKYTableAdapter;
        private System.Windows.Forms.BindingSource gIAOVIEN_DANGKYBindingSource;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnNopBai;
        private DevExpress.XtraBars.BarButtonItem btnXemKQ;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl panelControl6;
        private DevExpress.XtraEditors.GroupControl gcNoiDung;
        private DevExpress.XtraEditors.RadioGroup rdbDapAn;
        private DevExpress.XtraEditors.RadioGroup rdbCauHoi;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtB_IDClass;
        private System.Windows.Forms.Label lb_IDClass;
        private System.Windows.Forms.TextBox txtB_FullName;
        private System.Windows.Forms.TextBox txtB_NameClass;
        private System.Windows.Forms.TextBox txtB_IDStudent;
        private System.Windows.Forms.Label lb_NameClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit tENMHTextEdit;
        private DevExpress.XtraBars.Bar bar3;
    }
}