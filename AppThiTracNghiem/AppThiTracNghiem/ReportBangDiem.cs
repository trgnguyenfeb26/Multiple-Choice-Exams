using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace AppThiTracNghiem
{
    public partial class ReportBangDiem : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportBangDiem(string maMH, string maLop, int lan)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = maMH;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = maLop;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = lan;
            this.sqlDataSource1.Fill();
        }

    }
}
