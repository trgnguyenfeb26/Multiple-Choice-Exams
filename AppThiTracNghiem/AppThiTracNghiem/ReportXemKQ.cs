using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace AppThiTracNghiem
{
    public partial class ReportXemKQ : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportXemKQ(string MaSV, string MaMH, int Lan)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = MaSV;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = MaMH;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = Lan;
            this.sqlDataSource1.Fill();
        }

    }
}
