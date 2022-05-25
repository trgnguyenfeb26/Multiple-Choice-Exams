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
    public partial class FormXemDSDKThi : DevExpress.XtraEditors.XtraForm
    {
        public String connstr1 = Program.connstr;
        public FormXemDSDKThi()
        {
            InitializeComponent();
        }

        private void btnInDSBD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dateFrom.Text.ToString().Trim()=="" || dateTo.Text.ToString().Trim()=="")
            {
                MessageBox.Show("Ngày bắt đầu và ngày kết thúc không được để trống", "Lỗi", MessageBoxButtons.OK);
                return;
            }
            if (DateTime.Compare(dateFrom.DateTime, dateTo.DateTime) > 0)
            {
                MessageBox.Show("Ngày bắt đầu không lớn hơn ngày kết thúc", "Lỗi", MessageBoxButtons.OK);
                return;
            }
            ReportDSDKThi rpt = new ReportDSDKThi(dateFrom.DateTime, dateTo.DateTime);
            rpt.lbCoso.Text = cmbCoSo.Text.ToString().ToUpper();
            rpt.lbDateFrom.Text = dateFrom.DateTime.ToString("dd/MM/yyyy");
            rpt.lbDateTo.Text = dateTo.DateTime.ToString("dd/MM/yyyy");
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        

        private void FormXemDSDKThi_Load(object sender, EventArgs e)
        {
            cmbCoSo.DataSource = Program.bds_dspm;
            cmbCoSo.DisplayMember = "TENCS";
            cmbCoSo.ValueMember = "TENSERVER";
            cmbCoSo.SelectedIndex = Program.mCoso;
            if (Program.mGroup == "TRUONG")
            {
                cmbCoSo.Enabled = true;
            }else cmbCoSo.Enabled = false;
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

            }
        }

        private void btnThoatBDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát khỏi form?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}