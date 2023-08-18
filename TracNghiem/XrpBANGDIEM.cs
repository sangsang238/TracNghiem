using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace TracNghiem
{
    public partial class XrpBANGDIEM : DevExpress.XtraReports.UI.XtraReport
    {
        public XrpBANGDIEM(String maLop, String MaMH, short lanThi)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = maLop;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = MaMH;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = lanThi;
            this.sqlDataSource1.Fill();
        }

    }
}
