using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace TracNghiem
{
    public partial class XrpKQTHI : DevExpress.XtraReports.UI.XtraReport
    {
        public XrpKQTHI(String maSV, String maMH, short lan)
        {
            InitializeComponent();

            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = maSV;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = maMH;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = lan;
            this.sqlDataSource1.Fill();
        }

    }
}
