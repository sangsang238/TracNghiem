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
    public partial class frmNhapDe : Form
    {
        int vitri = 0;
        public frmNhapDe()
        {
            InitializeComponent();
        }

        private void frmNhapDe_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;

            this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.bODETableAdapter.Fill(this.DS.BODE);

            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.DS.MONHOC);

            if (bdsBD.Count > 0)
            {
                //fix loi dong dau combobox
                ComboBox_MAMH.SelectedValue = ((DataRowView)bdsBD[0])["MAMH"].ToString();
            }

            //truong,coso,giangvien dc truy cap formNhapDe
            if (Program.mGroup == "Truong")
            {
                btnThem.Enabled = btnThoat.Enabled = btnUndo.Enabled
                    = btnGhi.Enabled = btnXoa.Enabled = false;
            }
            else if (Program.mGroup == "Coso" || Program.mGroup == "Giangvien")
            {
                btnThoat.Enabled = false;
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsBD.AddNew();

            vitri = bdsBD.Position;
            TextBox_MAGV.Text = Program.username;
            ComboBox_MAMH.SelectedIndex = 0;
            ComboBox_DA.SelectedIndex = -1;
            ComboBox_TD.SelectedIndex = -1;

            btnThoat.Enabled = true;
            btnThem.Enabled = btnReload.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            GridControl_BODE.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strLenh = "EXEC SP_CHECKCAUHOI_TRONGCTBT " + TextBox_CH.Text;
            int k = Program.ExecSqlNonQuery(strLenh);
            if (k == 1) return;
            String mach = "";
            if (MessageBox.Show("Bạn có thật sự muốn xóa câu hỏi này ? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    mach = ((DataRowView)bdsBD[bdsBD.Position])["CAUHOI"].ToString(); // giữ lại để khi xóa bij lỗi thì ta sẽ quay về lại
                    bdsBD.RemoveCurrent();
                    this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
                    this.bODETableAdapter.Update(this.DS.BODE);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa câu hỏi. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.bODETableAdapter.Fill(this.DS.BODE);
                    bdsMH.Position = bdsMH.Find("CAUHOI", mach);
                    return;
                }
            }
            if (bdsBD.Count == 0) btnXoa.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ComboBox_TD.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn trình độ!", "", MessageBoxButtons.OK);
                ComboBox_TD.Focus();
                return;
            }
            if (ComboBox_DA.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn đáp án!", "", MessageBoxButtons.OK);
                ComboBox_DA.Focus();
                return;
            }
            try
            {
                bdsBD.EndEdit();
                bdsBD.ResetCurrentItem();
                this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
                this.bODETableAdapter.Update(this.DS.BODE);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("CK_BODE"))
                {
                    MessageBox.Show("Bạn chưa chọn trình độ hoặc trình độ " +
                        "không hợp lệ!", "", MessageBoxButtons.OK);
                }
                else if (ex.Message.Contains("CK_DAPAN"))
                {
                    MessageBox.Show("Bạn chưa chọn đáp án hoặc đáp án " +
                        "không hợp lệ!", "", MessageBoxButtons.OK);
                }
                else MessageBox.Show("Lỗi ghi bộ đề.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }

            btnThoat.Enabled = false;
            btnThem.Enabled = btnReload.Enabled = btnXoa.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = true;
            GridControl_BODE.Enabled = true;
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.bODETableAdapter.Fill(this.DS.BODE);
                this.mONHOCTableAdapter.Fill(this.DS.MONHOC);

                if (bdsBD.Count > 0)
                {
                    //fix loi dong dau combobox
                    ComboBox_MAMH.SelectedValue = ((DataRowView)bdsBD[0])["MAMH"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsBD.RemoveAt(vitri);
            bdsBD.CancelEdit();
            btnThoat.Enabled = false;
            btnThem.Enabled = btnReload.Enabled = btnXoa.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = true;
            GridControl_BODE.Enabled = true;
            btnReload.PerformClick();
            if (bdsBD.Count > 0)
            {
                gridView1.MoveLast();
            }
        }

        private void TextBox_MAGV_TextChanged(object sender, EventArgs e)
        {
            if (Program.mGroup == "Coso") return; //coso toan quyen
            if(TextBox_MAGV.Text.Trim() == Program.username)
            {
                btnGhi.Enabled = true;
                btnXoa.Enabled = true;
            }
            else
            {
                btnGhi.Enabled = false;
                btnXoa.Enabled = false;
            }
        }

        private void ComboBox_TD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox_TD.SelectedIndex == -1)
            {
                label_TD.Text = "Chọn trình độ";
            }
            else
            {
                label_TD.Text = Program.trinhDo[ComboBox_TD.SelectedIndex];
            }
        }

        private void ComboBox_MAMH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
