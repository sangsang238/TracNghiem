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
    public partial class frmTaoTaiKhoan : Form
    {
        public frmTaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            //set ve tai khoan cu
            comboBox_CN.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            comboBox_CN.DisplayMember = "TENCN";
            comboBox_CN.ValueMember = "TENSERVER";
            comboBox_CN.SelectedIndex = Program.mChinhanh;
            if (comboBox_CN.SelectedIndex == -1) return;
            try
            {
                Program.servername = comboBox_CN.SelectedValue.ToString();
            }
            catch (Exception) { }
            Program.mlogin = Program.mloginDN;
            Program.password = Program.passwordDN;
            if (Program.KetNoi() == 0)
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);

            this.v_DS_GIAOVIENCHUACOTKTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_DS_GIAOVIENCHUACOTKTableAdapter.Fill(this.dS_DSGV_CHUATK.V_DS_GIAOVIENCHUACOTK);

            if (Program.mGroup.Equals("Truong"))
            {
                radioButton_Truong.Checked = true;
                radioButton_Coso.Enabled = false;
                radioButton_Giangvien.Enabled = false;
            }
            else if (Program.mGroup.Equals("Coso"))
            {
                radioButton_Truong.Enabled = false;
                radioButton_Coso.Checked = true;
                radioButton_Giangvien.Enabled = true;
            }
            if (bdsGV.Count == 0)
            {
                button_DK.Enabled = false;
            }
        }

        private void button_DK_Click(object sender, EventArgs e)
        {
            if (textBox_LoginName.Text.Trim() == "" || textBox_Password.Text.Trim() == "")
            {
                MessageBox.Show("Login name và password của giảng viên không được để trống!", "", MessageBoxButtons.OK);
                return;
            }
            String role = "";
            if (radioButton_Truong.Checked)
            {
                role = "Truong";
            }
            else if (radioButton_Coso.Checked)
            {
                role = "Coso";
            }
            else
            {
                role = "Giangvien";
            }

            string strLenh = "EXEC SP_TAOTAIKHOAN '" +
                textBox_LoginName.Text.Trim() + "', '" + textBox_Password.Text.Trim()
                + "', '" + TextBox_Username.Text.Trim() + "', '" + role + "'";
            int kq = Program.ExecSqlNonQuery(strLenh);
            if (kq != 0) return;
            MessageBox.Show("Tạo tài khoản thành công!", "", MessageBoxButtons.OK);
            this.v_DS_GIAOVIENCHUACOTKTableAdapter.Fill(this.dS_DSGV_CHUATK.V_DS_GIAOVIENCHUACOTK);//reload
            if (bdsGV.Count == 0)
            {
                button_DK.Enabled = false;
            }
        }
    }
}
