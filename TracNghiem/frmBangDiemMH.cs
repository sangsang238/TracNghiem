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
    public partial class frmBangDiemMH : Form
    {
        public static String macn = "";
        public frmBangDiemMH()
        {
            InitializeComponent();
        }

        private void frmBangDiemMH_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            dSReport.EnforceConstraints = false;

            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.DS.MONHOC);

            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.DS.LOP);

            macn = Program.GetMaCS();
            comboBox_TenCN.DataSource = Program.bds_dspm;// sao chép bds_dspm đã load ở form đăng nhập  qua
            comboBox_TenCN.DisplayMember = "TENCN";
            comboBox_TenCN.ValueMember = "TENSERVER";
            comboBox_TenCN.SelectedIndex = Program.mChinhanh;

            btnInBC.Enabled = false;
            //coso,truong,gv dc truy cap
            if (Program.mGroup == "Coso")
            {
                comboBox_TenCN.Enabled = false;
            }
        }

        private void comboBox_TenCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_TenCN.SelectedIndex == -1) return;
            if (comboBox_TenCN.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = comboBox_TenCN.SelectedValue.ToString();

            if (comboBox_TenCN.SelectedIndex != Program.mChinhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            else
            {
                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Fill(this.DS.MONHOC);
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.DS.LOP);
                macn = Program.GetMaCS();
            }
        }

        private void btnInBC_Click(object sender, EventArgs e)
        {
            XrpBANGDIEM rpBD = new XrpBANGDIEM(cbboxLOP.SelectedValue.ToString(),
                cbboxMH.SelectedValue.ToString(), 
                short.Parse(spinEditLAN.Value.ToString()));
            rpBD.lbLop.Text = cbboxLOP.Text;
            rpBD.lbMH.Text = cbboxMH.Text;
            rpBD.lbLanThi.Text = spinEditLAN.Value.ToString();
            ReportPrintTool report = new ReportPrintTool(rpBD);
            report.ShowPreviewDialog();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            this.sP_BANGDIEMMHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_BANGDIEMMHTableAdapter.Fill(this.dSReport.SP_BANGDIEMMH,
                cbboxLOP.SelectedValue.ToString(),
                cbboxMH.SelectedValue.ToString(),
                short.Parse(spinEditLAN.Value.ToString()));

            string strLenh = "EXEC SP_CHECKSVDATHI N'"
               + cbboxLOP.SelectedValue.ToString() + "', N'"
               + cbboxMH.SelectedValue.ToString() + "', "
               + spinEditLAN.Value;
            int kq = Program.ExecSqlNonQuery(strLenh);
            if (kq == 0)
            {
                MessageBox.Show("Không có sinh viên đã thi!", "",
                    MessageBoxButtons.OK);
            }
            else
            {
                btnInBC.Enabled = true;
            }
        }

        private void cbboxLOP_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnInBC.Enabled = false;
        }

        private void cbboxMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnInBC.Enabled = false;
        }

        private void spinEditLAN_EditValueChanged(object sender, EventArgs e)
        {
            btnInBC.Enabled = false;
        }
    }
}
