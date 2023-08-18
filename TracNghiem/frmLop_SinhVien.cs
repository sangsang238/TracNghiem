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
    public partial class frmLop_SinhVien : Form
    {
        int vitri = 0;
        string macn = "";
        public frmLop_SinhVien()
        {
            InitializeComponent();
        }

        private void frmLop_SinhVien_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;

            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.DS.LOP);

            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.DS.SINHVIEN);

            this.bANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.bANGDIEMTableAdapter.Fill(this.DS.BANGDIEM);

            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.DS.GIAOVIEN_DANGKY);

            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.DS.KHOA);

            if (bdsLop.Count > 0)
            {
                //fix loi dong dau combobox
                ComboBox_MAKH.SelectedValue = ((DataRowView)bdsLop[0])["MAKH"].ToString();
            }

            macn = Program.GetMaCS();
            comboBox_CN.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            comboBox_CN.DisplayMember = "TENCN";
            comboBox_CN.ValueMember = "TENSERVER";
            comboBox_CN.SelectedIndex = Program.mChinhanh;
            //phan quyen
            //coso,truong dc truy cap formLopSV
            if (Program.mGroup.Equals("Coso"))
            {
                comboBox_CN.Enabled = false;
                btnThoat.Enabled = false;
                thoatToolStripMenuItem.Enabled = false;
            }
            else if (Program.mGroup.Equals("Truong"))
            {
                comboBox_CN.Enabled = true;
                btnThem.Enabled = btnThoat.Enabled = btnUndo.Enabled
                    = btnGhi.Enabled = btnXoa.Enabled = false;
                contextMenuStrip1.Enabled = false;
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsLop.AddNew();

            vitri = bdsLop.Position;
            ComboBox_MAKH.SelectedIndex = 0;

            btnThoat.Enabled = true;
            DataGridView_SV.Enabled = false;
            btnThem.Enabled = btnReload.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            GridControl_Lop.Enabled = false;
        }

        private void comboBox_CN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_CN.SelectedIndex == -1) return;
            if (comboBox_CN.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = comboBox_CN.SelectedValue.ToString();

            if (comboBox_CN.SelectedIndex != Program.mChinhanh)
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
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.DS.LOP);
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
                this.bANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
                this.bANGDIEMTableAdapter.Fill(this.DS.BANGDIEM);
                this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gIAOVIEN_DANGKYTableAdapter.Fill(this.DS.GIAOVIEN_DANGKY);
                this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                this.kHOATableAdapter.Fill(this.DS.KHOA);
                macn = Program.GetMaCS();
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsLop.RemoveAt(vitri);
            bdsLop.CancelEdit();

            btnThem.Enabled = btnReload.Enabled = btnXoa.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = true;
            GridControl_Lop.Enabled = true;
            btnThoat.Enabled = false;
            DataGridView_SV.Enabled = true;
            btnReload.PerformClick();
            if (bdsLop.Count > 0)
            {
                gridView1.MoveLast();
            }
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.lOPTableAdapter.Fill(this.DS.LOP);
                this.sINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
                this.kHOATableAdapter.Fill(this.DS.KHOA);

                if (bdsLop.Count > 0)
                {
                    //fix loi dong dau combobox
                    ComboBox_MAKH.SelectedValue = ((DataRowView)bdsLop[0])["MAKH"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String malop = "";
            if (bdsGVDK.Count > 0)
            {
                MessageBox.Show("Không thể xóa lớp này vì đã có giảng viên đăng ký thi", "",
                       MessageBoxButtons.OK);
                return;
            }
            if (bdsSV.Count > 0)
            {
                MessageBox.Show("Không thể xóa lớp này vì đã có sinh viên", "",
                       MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa lớp này ? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    malop = ((DataRowView)bdsLop[bdsLop.Position])["MALOP"].ToString(); // giữ lại để khi xóa bij lỗi thì ta sẽ quay về lại
                    bdsLop.RemoveCurrent();
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Update(this.DS.LOP);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa lớp. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.kHOATableAdapter.Fill(this.DS.KHOA);
                    bdsLop.Position = bdsLop.Find("MALOP", malop);
                    return;
                }
            }
            if (bdsLop.Count == 0) btnXoa.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TextBox_MALOP.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp không được thiếu!", "", MessageBoxButtons.OK);
                TextBox_MALOP.Focus();
                return;
            }
            if (TextBox_TENLOP.Text.Trim() == "")
            {
                MessageBox.Show("Tên lớp không được thiếu!", "", MessageBoxButtons.OK);
                TextBox_TENLOP.Focus();
                return;
            }
            if (btnThem.Enabled == false) //dang them moi check
            {
                //check ma, ten lop ko trung tren 2 site o site tra cuu
                string strLenh = "EXEC SP_CHECKLOP_TRACUU N'" + TextBox_MALOP.Text.Trim() + "', N'"
                    + TextBox_TENLOP.Text.Trim() + "'";
                int kq = Program.ExecSqlNonQuery(strLenh);
                if (kq == 1 || kq == 2) return;
            }
            else //sua
            {
                //check site ht truoc
                int viTriDangSua = bdsLop.Position;
                int vt = bdsLop.Find("MALOP", TextBox_MALOP.Text);
                int vt1 = bdsLop.Find("TENLOP", TextBox_TENLOP.Text);
                if (viTriDangSua != vt && vt != -1) //trung
                {
                    MessageBox.Show("Lỗi mã lớp bị trùng ở site hiện tại", "SP", MessageBoxButtons.OK);
                    return;
                }
                if (viTriDangSua != vt1 && vt1 != -1) //trung
                {
                    MessageBox.Show("Lỗi tên lớp bị trùng ở site hiện tại", "SP", MessageBoxButtons.OK);
                    return;
                }
                //chuyen sang check site pm
                string strLenh = "EXEC SP_CHECKLOP_PM N'" + TextBox_MALOP.Text.Trim() + "', N'"
                    + TextBox_TENLOP.Text.Trim() + "'";
                int kq = Program.ExecSqlNonQuery(strLenh);
                if (kq == 1 || kq == 2) return;
            }
            //bat dau ghi
            try
            {
                bdsLop.EndEdit();
                bdsLop.ResetCurrentItem();
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Update(this.DS.LOP);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("PK_LOP"))
                {
                    MessageBox.Show("Lỗi mã lớp bị trùng", "", MessageBoxButtons.OK);
                }
                else if (ex.Message.Contains("UN_TENLOP"))
                {
                    MessageBox.Show("Lỗi tên lớp bị trùng", "", MessageBoxButtons.OK);
                }
                else MessageBox.Show("Lỗi ghi lớp.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            btnThem.Enabled = btnReload.Enabled = btnXoa.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = true;
            GridControl_Lop.Enabled = true;
            btnThoat.Enabled = false;
            DataGridView_SV.Enabled = true;
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void themSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bdsSV.AddNew();
            thoatToolStripMenuItem.Enabled = true;
            themSVToolStripMenuItem.Enabled = false;
            xoaSVToolStripMenuItem.Enabled = false;

            btnThoat.Enabled = false;
            btnThem.Enabled = btnReload.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = false;
            GridControl_Lop.Enabled = false;
            groupControl2.Enabled = false;
        }

        private void xoaSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String masv = "";
            if (bdsBangDiem.Count > 0)
            {
                MessageBox.Show("Không thể xóa sinh viên này vì đã có điểm", "",
                       MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa sinh viên này ? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    masv = ((DataRowView)bdsSV[bdsSV.Position])["MASV"].ToString(); // giữ lại để khi xóa bij lỗi thì ta sẽ quay về lại
                    bdsSV.RemoveCurrent();
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter.Update(this.DS.SINHVIEN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa sinh viên. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.sINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
                    bdsSV.Position = bdsSV.Find("MASV", masv);
                    return;
                }
            }
            if (bdsSV.Count == 0) xoaSVToolStripMenuItem.Enabled = false;
        }

        private void ghiSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //dang them
            if (themSVToolStripMenuItem.Enabled == false)
            {
                int index = bdsSV.Count - 1;
                //check thong tin giang vien moi nhap vao
                string maSV = this.DataGridView_SV.Rows[index].Cells[0].Value.ToString();

                if (string.IsNullOrEmpty(maSV.Trim()))
                {
                    MessageBox.Show("Mã sinh viên không được để trống", "", MessageBoxButtons.OK);
                    DataGridView_SV.CurrentCell = this.DataGridView_SV.Rows[index].Cells[0];
                    DataGridView_SV.BeginEdit(true);
                    return;
                }
                string strLenh = "EXEC SP_CHECKSV_TRACUU N'" + maSV.Trim() + "'";
                int kq = Program.ExecSqlNonQuery(strLenh);
                if (kq == 1)
                {
                    DataGridView_SV.CurrentCell = this.DataGridView_SV.Rows[index].Cells[0];
                    DataGridView_SV.BeginEdit(true);
                    return;
                }
            }
            else //sua
            {
                string maSV = this.DataGridView_SV.Rows[bdsSV.Position].Cells[0].Value.ToString();

                if (string.IsNullOrEmpty(maSV.Trim()))
                {
                    MessageBox.Show("Mã sinh viên không được để trống", "", MessageBoxButtons.OK);
                    DataGridView_SV.CurrentCell = this.DataGridView_SV.Rows[bdsSV.Position].Cells[0];
                    DataGridView_SV.BeginEdit(true);
                    return;
                }
                string strLenh = "EXEC SP_CHECKSV_PM N'" + maSV.Trim() + "'";
                int kq = Program.ExecSqlNonQuery(strLenh);
                if (kq == 1)
                {
                    DataGridView_SV.CurrentCell = this.DataGridView_SV.Rows[bdsSV.Position].Cells[0];
                    DataGridView_SV.BeginEdit(true);
                    return;
                }
            }
            //ghi
            try
            {
                bdsSV.EndEdit();
                bdsSV.ResetCurrentItem();
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Update(this.DS.SINHVIEN);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("PK_SINHVIEN"))
                {
                    MessageBox.Show("Lỗi mã sinh viên bị trùng", "", MessageBoxButtons.OK);
                    DataGridView_SV.CurrentCell = this.DataGridView_SV.Rows[bdsSV.Position].Cells[0];
                    DataGridView_SV.BeginEdit(true);
                }
                else
                {
                    this.bdsSV.RemoveCurrent();
                    MessageBox.Show("Lỗi ghi sinh viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                }
                return;
            }
            thoatToolStripMenuItem.Enabled = false;
            themSVToolStripMenuItem.Enabled = true;
            xoaSVToolStripMenuItem.Enabled = true;

            btnThoat.Enabled = false;
            btnThem.Enabled = btnReload.Enabled = btnXoa.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = true;
            GridControl_Lop.Enabled = true;
            groupControl2.Enabled = true;
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.bdsSV.RemoveCurrent();
            thoatToolStripMenuItem.Enabled = false;
            themSVToolStripMenuItem.Enabled = true;
            xoaSVToolStripMenuItem.Enabled = true;

            btnThoat.Enabled = false;
            btnThem.Enabled = btnReload.Enabled = btnXoa.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = true;
            GridControl_Lop.Enabled = true;
            groupControl2.Enabled = true;
        }

        private void DataGridView_SV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ComboBox_MAKH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
