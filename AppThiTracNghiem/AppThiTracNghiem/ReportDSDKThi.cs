using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace AppThiTracNghiem
{
    public partial class ReportDSDKThi : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportDSDKThi(DateTime dateFrom, DateTime dateTo)
        {
            InitializeComponent();
            
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = dateFrom;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = dateTo;
            this.sqlDataSource1.Fill();
        }

        
    }
}
