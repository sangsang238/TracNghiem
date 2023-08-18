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

namespace TracNghiem
{
    public partial class frmDsDkThi : Form
    {
        public static String macn = "";
        public frmDsDkThi()
        {
            InitializeComponent();
        }

        private void frmDsDkThi_Load(object sender, EventArgs e)
        {
            dSReport.EnforceConstraints = false;
            btnInBC.Enabled = false;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (dateFrom.Text.ToString().Trim().Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập ngày bắt đầu", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (dateTo.Text.ToString().Trim().Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập ngày kết thúc", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            var FromDate = dateFrom.DateTime.Date;
            var ToDate = dateTo.DateTime.Date;
            int compare = DateTime.Compare(FromDate, ToDate);
            if (compare > 0)
            {
                MessageBox.Show("Ngày bắt đầu không thể lớn hơn ngày kết thúc");
                return;
            }
            else
            {
                this.sP_DSDANGKYTHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_DSDANGKYTHITableAdapter.Fill(this.dSReport.SP_DSDANGKYTHI, FromDate, ToDate);
                if (bdsDSDKTHI.Count == 0)
                {
                    MessageBox.Show("Danh sách trống!!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                btnInBC.Enabled = true;
            }
        }

        private void btnInBC_Click(object sender, EventArgs e)
        {
            var FromDate = dateFrom.DateTime.Date;
            var ToDate = dateTo.DateTime.Date;
            XrpDSDKTHI xrp = new XrpDSDKTHI(FromDate, ToDate);
            int compare = DateTime.Compare(FromDate, ToDate);
            this.sP_DSDANGKYTHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_DSDANGKYTHITableAdapter.Fill(this.dSReport.SP_DSDANGKYTHI, FromDate, ToDate);
            if (bdsDSDKTHI.Count == 0)
            {
                MessageBox.Show("Danh sách trống!!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else
            {
                xrp.lbDateFrom.Text = FromDate.ToString("dd/MM/yyyy");
                xrp.lbDateTo.Text = ToDate.ToString("dd/MM/yyyy");

                ReportPrintTool report = new ReportPrintTool(xrp);
                report.ShowPreviewDialog();
            }
        }

        private void dateFrom_EditValueChanged(object sender, EventArgs e)
        {
            btnInBC.Enabled = false;
        }

        private void dateTo_EditValueChanged(object sender, EventArgs e)
        {
            btnInBC.Enabled = false;
        }
    }
}
