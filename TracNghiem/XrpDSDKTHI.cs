using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace TracNghiem
{
    public partial class XrpDSDKTHI : DevExpress.XtraReports.UI.XtraReport
    {
        public XrpDSDKTHI(DateTime FromDate, DateTime ToDate)
        {
            InitializeComponent();

            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = FromDate;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = ToDate;
            this.sqlDataSource1.Fill();
        }

    }
}
