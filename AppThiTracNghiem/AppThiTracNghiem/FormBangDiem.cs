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

        }

        private void btnInDSBD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ReportBangDiem rpt = new ReportBangDiem(cmbTenLop.SelectedValue.ToString(), cmbMaMH.SelectedValue.ToString(), int.Parse(cmbLan.Text));
           // rpt.lbLop.Text = cmbTenLop.Text;
           // rpt.lbMH.Text = cmbMaMH.Text;
           // rpt.lbLanThi.Text = cmbLan.Text.ToString();

            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
            
        }
    }
}