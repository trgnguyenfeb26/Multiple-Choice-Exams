using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
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
    public partial class FormXemKQ : DevExpress.XtraEditors.XtraForm
    {
        public FormXemKQ()
        {
            InitializeComponent();
        }

        private void sINHVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsSV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormXemKQ_Load(object sender, EventArgs e)
        {

            dS.EnforceConstraints = false;
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
           
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
           
            this.bANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.bANGDIEMTableAdapter.Fill(this.dS.BANGDIEM);
           
            this.get_SVDaThiTableAdapter.Connection.ConnectionString = Program.connstr;
            this.get_SVDaThiTableAdapter.Fill(this.dS.Get_SVDaThi);
           
            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);
           
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);
            //if (bdsMH.Count == 0) cmbTenMH.SelectedIndex = -1;
            cmbTenMH.SelectedValue = cmbMAMH.Text;
            cmbCoSo.DataSource = Program.bds_dspm;
            cmbCoSo.DisplayMember = "TENCS";
            cmbCoSo.ValueMember = "TENSERVER";
            cmbCoSo.SelectedIndex = Program.mCoso;
            if (Program.mGroup == "TRUONG")
            {
                cmbCoSo.Enabled = true;
            }
            else cmbCoSo.Enabled = false;

        }

       

        private void cmbMAMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbTenMH.SelectedValue = cmbMAMH.Text;
        }

        private void get_SVDaThiGridControl_Click(object sender, EventArgs e)
        {
            cmbTenMH.SelectedValue = cmbMAMH.Text;
        }

        private void btnInDSBD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ReportXemKQ rpt = new ReportXemKQ(txtMaSV.Text, cmbMAMH.SelectedValue.ToString(),  Int32.Parse(cmbLan.Text.ToString()));
            rpt.lblLop.Text = txtTenLop.Text;
            rpt.lblHo.Text = txtHo.Text; rpt.lblTen.Text = txtTen.Text;
            rpt.lblMon.Text = cmbTenMH.Text;
            rpt.lblLan.Text = cmbLan.Text.ToString();
            rpt.lblNgay.Text = txtNgay.Text;

            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void cmbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
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
                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Fill(this.dS.MONHOC);

                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);

                this.bANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
                this.bANGDIEMTableAdapter.Fill(this.dS.BANGDIEM);

                this.get_SVDaThiTableAdapter.Connection.ConnectionString = Program.connstr;
                this.get_SVDaThiTableAdapter.Fill(this.dS.Get_SVDaThi);

                this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);

                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.dS.LOP);
                //if (bdsMH.Count == 0) cmbTenMH.SelectedIndex = -1;
                cmbTenMH.SelectedValue = cmbMAMH.Text;
            }
        }

        private void btnThoatBDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát khỏi form?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void cmbMAMH_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cmbTenMH.SelectedValue = cmbMAMH.Text;
        }
    }
}