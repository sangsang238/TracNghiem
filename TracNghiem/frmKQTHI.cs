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
    public partial class frmKQTHI : Form
    {
        private String ngay = null;

        public frmKQTHI()
        {
            InitializeComponent();
        }

        private void frmKQTHI_Load(object sender, EventArgs e)
        {
            dSReport.EnforceConstraints = false;
            DS.EnforceConstraints = false;
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.DS.MONHOC);

            GetTenLop();
            labelHoTen.Text = Program.mHoten;
            btnInBC.Enabled = false;
        }

        private void GetTenLop()
        {
            string strLenh = "SELECT TENLOP FROM LOP WHERE MALOP in" +
                " (SELECT MALOP FROM SINHVIEN WHERE MASV= N'" + Program.username + "')";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            if (Program.myReader.Read() == false) return;
            labelLop.Text = Program.myReader.GetString(0);
            Program.myReader.Close();
        }

        private void btnInBC_Click(object sender, EventArgs e)
        {
            XrpKQTHI rpKQT = new XrpKQTHI(Program.username, 
                cbbMH.SelectedValue.ToString(), 
                short.Parse(spin_Lanthi.Value.ToString()));
            rpKQT.lbLop.Text = labelLop.Text;
            rpKQT.lbHoTen.Text = Program.mHoten;
            rpKQT.lbMH.Text = cbbMH.Text;
            rpKQT.lbNgayThi.Text = ngay.ToString();
            rpKQT.lbLan.Text = spin_Lanthi.Text;
            ReportPrintTool report = new ReportPrintTool(rpKQT);
            report.ShowPreviewDialog();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            this.sP_INBAITHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_INBAITHITableAdapter.Fill(this.dSReport.SP_INBAITHI,
                Program.username, cbbMH.SelectedValue.ToString(),
                short.Parse(spin_Lanthi.Value.ToString()));
            string strLenh = "EXEC SP_GET_NT_BANGDIEM N'"
              + Program.username + "', N'"
              + cbbMH.SelectedValue.ToString() + "', "
              + spin_Lanthi.Value;
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            if (Program.myReader.Read()==true)
            {
                ngay = Program.myReader.GetDateTime(0).ToString("dd/MM/yyyy");
                labelNgayThi.Text = ngay.ToString();
            }
            else
            {
                labelNgayThi.Text = "dd/MM/yyyy";
                MessageBox.Show("Không tồn tại bài thi này!", "",
                    MessageBoxButtons.OK);
            }
            Program.myReader.Close();
            Program.conn.Close();

            if (labelNgayThi.Text != "dd/MM/yyyy")
            {
                btnInBC.Enabled = true;
            }
        }

        private void cbbMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnInBC.Enabled = false;
        }

        private void spin_Lanthi_EditValueChanged(object sender, EventArgs e)
        {
            btnInBC.Enabled = false;
        }
    }
}
