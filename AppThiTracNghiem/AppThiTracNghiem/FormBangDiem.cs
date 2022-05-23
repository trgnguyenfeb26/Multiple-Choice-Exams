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
    public partial class FormBangDiem : DevExpress.XtraEditors.XtraForm
    {
        public FormBangDiem()
        {
            InitializeComponent();
        }

        private void FormBangDiem_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            cmbLan.Items.Add("1");
            cmbLan.Items.Add("2");
            cmbLan.SelectedIndex = 0;
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

        private void btnInDSBD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ReportBangDiem rpt = new ReportBangDiem(cmbTenLop.SelectedValue.ToString(), cmbMaMH.SelectedValue.ToString(), int.Parse(cmbLan.Text));
            rpt.lbLop.Text = cmbTenLop.Text;
            rpt.lbMH.Text = cmbMaMH.Text;
            rpt.lbLanThi.Text = cmbLan.Text.ToString();

            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
            
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
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.dS.LOP);
                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            }

        }

        private void btnThoatBDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát khỏi form?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}