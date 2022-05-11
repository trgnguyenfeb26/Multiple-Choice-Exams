using DevExpress.XtraBars;
using System;
using System.Collections;
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
    public partial class FormSV : DevExpress.XtraEditors.XtraForm
    {
        private int index = 0;
        private string maLop = "";
        Stack undolist = new Stack();
        private int vitri;
        private BindingSource bds = new BindingSource();
        private DataTable dt = new DataTable();
      
        private Boolean isDangThem = false, isDangSua = false, suaLop = false;
        public FormSV()
        {
            InitializeComponent();
        }

        private void FormSV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.
            dS.EnforceConstraints = false;


            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);
            this.bANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.bANGDIEMTableAdapter.Fill(this.dS.BANGDIEM);

            cmbCoSo.DataSource = Program.bds_dspm;
            cmbCoSo.DisplayMember = "TENCS";
            cmbCoSo.ValueMember = "TENSERVER";
            cmbCoSo.SelectedIndex = Program.mCoso;

            if (Program.mGroup == "TRUONG")
            {
               
                cmbCoSo.Enabled = true;
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = false;
                btnHuy.Enabled = false;
                pnSV.Enabled = false;
                gcSV.Enabled = gcLop.Enabled = true;
            }
            if (Program.mGroup == "COSO")
            {
                cmbCoSo.Enabled = false;
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = true;
                btnHuy.Enabled = true;
                pnSV.Enabled = true;
                gcSV.Enabled = gcLop.Enabled = true;
                btnRefresh.Enabled = true;
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
           
        

        }

        private void lOPBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void nGAYSINHLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            vitri = bdsSV.Position;
            bdsSV.AddNew();

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            pnSV.Enabled = true;
            gcSV.Enabled = gcLop.Enabled = false;
            btnRefresh.Enabled = false;

            gcLop.Enabled = false;
            dNgaySinh.EditValue = "";
            txtMaSv.Enabled = true;
        }

        private void btnSua_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnHuy_ItemClick(object sender, ItemClickEventArgs e)
        {
            bdsSV.CancelEdit();
            if (btnThem.Enabled == false) bdsSV.Position = vitri;
        }

        private void btnGhi_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);
            this.bANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.bANGDIEMTableAdapter.Fill(this.dS.BANGDIEM);
        }

        private void btnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát khỏi form?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void sINHVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
          
        

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


                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);

                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.dS.LOP);

                this.bANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
                this.bANGDIEMTableAdapter.Fill(this.dS.BANGDIEM);

                maLop = ((DataRowView)bdsLop[0])["MALOP"].ToString();
            }
        }
    }
}