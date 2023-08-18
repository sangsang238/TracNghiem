using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TracNghiem
{
    public partial class frmKhoa_GiaoVien : Form
    {
        int vitri = 0;
        string macn = "";
        string mgv = "";
        int soLanSua = 0;
        public frmKhoa_GiaoVien()
        {
            InitializeComponent();
        }
        private void frmKhoa_GiaoVien_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;

            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.DS.KHOA);

            this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIENTableAdapter.Fill(this.DS.GIAOVIEN);

            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.DS.LOP);

            this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.bODETableAdapter.Fill(this.DS.BODE);

            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.DS.GIAOVIEN_DANGKY);

            macn = Program.GetMaCS();
            comboBox_CN.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            comboBox_CN.DisplayMember = "TENCN";
            comboBox_CN.ValueMember = "TENSERVER";
            comboBox_CN.SelectedIndex = Program.mChinhanh;
            //phan quyen
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
            bdsKhoa.AddNew();

            vitri = bdsKhoa.Position;
            TextBox_MaCS.Text = macn;

            btnThoat.Enabled = true;
            DataGridView_GiaoVien.Enabled = false;
            btnThem.Enabled = btnReload.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            GridControl_Khoa.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String makh = "";
            if (bdsGV.Count > 0)
            {
                MessageBox.Show("Không thể xóa khoa này vì đã có giảng viên", "",
                       MessageBoxButtons.OK);
                return;
            }
            if (bdsLop.Count > 0)
            {
                MessageBox.Show("Không thể xóa khoa này vì đã có lớp", "",
                       MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa khoa này ? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    makh = ((DataRowView)bdsKhoa[bdsKhoa.Position])["MAKH"].ToString(); // giữ lại để khi xóa bij lỗi thì ta sẽ quay về lại
                    bdsKhoa.RemoveCurrent();
                    this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                    this.kHOATableAdapter.Update(this.DS.KHOA);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa khoa. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.kHOATableAdapter.Fill(this.DS.KHOA);
                    bdsKhoa.Position = bdsKhoa.Find("MAKH", makh);
                    return;
                }
            }
            if (bdsKhoa.Count == 0) btnXoa.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TextBox_MaKH.Text.Trim() == "")
            {
                MessageBox.Show("Mã khoa không được thiếu!", "", MessageBoxButtons.OK);
                TextBox_MaKH.Focus();
                return;
            }
            if (TextBox_TenKH.Text.Trim() == "")
            {
                MessageBox.Show("Tên khoa không được thiếu!", "", MessageBoxButtons.OK);
                TextBox_TenKH.Focus();
                return;
            }

            if (btnThem.Enabled == false) //dang them moi check
            {
                //check ma, ten khoa ko trung tren 2 site o site tra cuu
                string strLenh = "EXEC SP_CHECKKHOA_TRACUU N'" + TextBox_MaKH.Text.Trim() + "', N'"
                    + TextBox_TenKH.Text.Trim() + "'";
                int kq = Program.ExecSqlNonQuery(strLenh);
                if (kq != 0) return;
            }
            else //sua
            {
                //check site ht truoc
                int viTriDangSua = bdsKhoa.Position;
                int vt = bdsKhoa.Find("MAKH", TextBox_MaKH.Text);
                int vt1 = bdsKhoa.Find("TENKH", TextBox_TenKH.Text);
                if (viTriDangSua != vt && vt != -1) //trung
                {
                    MessageBox.Show("Lỗi mã khoa bị trùng ở site hiện tại", "SP", MessageBoxButtons.OK);
                    return;
                }
                if (viTriDangSua != vt1 && vt1 != -1) //trung
                {
                    MessageBox.Show("Lỗi tên khoa bị trùng ở site hiện tại", "SP", MessageBoxButtons.OK);
                    return;
                }
                //chuyen sang check site pm
                string strLenh = "EXEC SP_CHECKKHOA_PM N'" + TextBox_MaKH.Text.Trim() + "', N'"
                    + TextBox_TenKH.Text.Trim() + "'";
                int kq = Program.ExecSqlNonQuery(strLenh);
                if (kq != 0) return;
            }
            //bat dau ghi
            try
            {
                bdsKhoa.EndEdit();
                bdsKhoa.ResetCurrentItem();
                this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                this.kHOATableAdapter.Update(this.DS.KHOA);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("PK_KHOA"))
                {
                    MessageBox.Show("Lỗi mã khoa bị trùng", "", MessageBoxButtons.OK);
                }
                else if (ex.Message.Contains("UN_TENKH"))
                {
                    MessageBox.Show("Lỗi tên khoa bị trùng", "", MessageBoxButtons.OK);
                }
                else MessageBox.Show("Lỗi ghi khoa.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            GridControl_Khoa.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = true;
            btnThoat.Enabled = false;
            DataGridView_GiaoVien.Enabled = true;
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.kHOATableAdapter.Fill(this.DS.KHOA);
                this.gIAOVIENTableAdapter.Fill(this.DS.GIAOVIEN);
                soLanSua = 0;
                mgv = "";
                GridControl_Khoa.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsKhoa.RemoveAt(vitri);
            bdsKhoa.CancelEdit();
            btnThem.Enabled = btnReload.Enabled = btnXoa.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = true;
            GridControl_Khoa.Enabled = true;
            btnThoat.Enabled = false;
            DataGridView_GiaoVien.Enabled = true;
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
                this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                this.kHOATableAdapter.Fill(this.DS.KHOA);
                this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gIAOVIENTableAdapter.Fill(this.DS.GIAOVIEN);
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.DS.LOP);
                this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
                this.bODETableAdapter.Fill(this.DS.BODE);
                this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gIAOVIEN_DANGKYTableAdapter.Fill(this.DS.GIAOVIEN_DANGKY);
                macn = Program.GetMaCS();
            }
        }

        private void themGVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bdsGV.AddNew();

            thoatToolStripMenuItem.Enabled = true;
            themGVToolStripMenuItem.Enabled = false;
            xoaGVToolStripMenuItem.Enabled = false;

            btnThoat.Enabled = false;
            btnThem.Enabled = btnReload.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = false;
            GridControl_Khoa.Enabled = false;
            groupControl2.Enabled = false;
        }

        private void xoaGVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String magv = ((DataRowView)bdsGV[bdsGV.Position])["MAGV"].ToString();// giữ lại để khi xóa bij lỗi thì ta sẽ quay về lại
            if (Program.username.Trim() == magv)
            {
                MessageBox.Show("Không thể xóa vì bạn đang đăng nhập!", "",
                       MessageBoxButtons.OK);
                return;
            }
            if (bdsBoDe.Count > 0)
            {
                MessageBox.Show("Không thể xóa giảng viên này vì đã soạn đề", "",
                       MessageBoxButtons.OK);
                return;
            }
            if (bdsGVDK.Count > 0)
            {
                MessageBox.Show("Không thể xóa giảng viên này vì đã đăng ký thi", "",
                       MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa giảng viên này ? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsGV.RemoveCurrent();
                    this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.gIAOVIENTableAdapter.Update(this.DS.GIAOVIEN);

                    //xoa tai khoan xong sau khi xoa giang vien thanh cong
                    //check giang vien co tk
                    string strLenh = "EXEC SP_CHECKTAIKHOAN N'" + magv + "'";
                    Program.myReader = Program.ExecSqlDataReader(strLenh);
                    if (Program.myReader == null) return;
                    if (Program.myReader.Read() == true)
                    {
                        string logName = Program.myReader.GetString(0);
                        Program.myReader.Close();
                        string strLenh1 = "EXEC SP_XOATAIKHOAN N'" + logName + "', N'"
                            + magv + "'";
                        int i = Program.ExecSqlNonQuery(strLenh1);
                        if (i == 0)
                        {
                            MessageBox.Show("Đã xóa tài khoản của giảng viên!", "", MessageBoxButtons.OK);
                        }
                    }
                    Program.myReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa giảng viên. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.gIAOVIENTableAdapter.Fill(this.DS.GIAOVIEN);
                    bdsGV.Position = bdsGV.Find("MAGV", magv);
                    return;
                }
            }
            if (bdsGV.Count == 0) xoaGVToolStripMenuItem.Enabled = false;
        }

        private void ghiGVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //dang them
            if (themGVToolStripMenuItem.Enabled == false)
            {
                int index = bdsGV.Count - 1;
                //check thong tin giang vien moi nhap vao
                string maGV = this.DataGridView_GiaoVien.Rows[index].Cells[0].Value.ToString();

                if (string.IsNullOrEmpty(maGV.Trim()))
                {
                    MessageBox.Show("Mã giảng viên không được để trống", "", MessageBoxButtons.OK);
                    DataGridView_GiaoVien.CurrentCell = this.DataGridView_GiaoVien.Rows[index].Cells[0];
                    DataGridView_GiaoVien.BeginEdit(true);
                    return;
                }

                string strLenh = "EXEC SP_CHECKGV N'" + maGV.Trim() + "'";
                int kq = Program.ExecSqlNonQuery(strLenh);
                if (kq != 0)
                {
                    DataGridView_GiaoVien.CurrentCell = this.DataGridView_GiaoVien.Rows[index].Cells[0];
                    DataGridView_GiaoVien.BeginEdit(true);
                    return;
                }
            }
            else
            {
                string maGV = this.DataGridView_GiaoVien.Rows[bdsGV.Position].Cells[0].Value.ToString();

                if (string.IsNullOrEmpty(maGV.Trim()))
                {
                    MessageBox.Show("Mã giảng viên không được để trống", "", MessageBoxButtons.OK);
                    DataGridView_GiaoVien.CurrentCell = this.DataGridView_GiaoVien.Rows[bdsGV.Position].Cells[0];
                    DataGridView_GiaoVien.BeginEdit(true);
                    return;
                }

                //check ko sua magv khi da co tai khoan theo magv
                if (maGV.Trim() != mgv.Trim())
                {
                    //check giang vien co tk
                    string logName = "";
                    string strLenh = "EXEC SP_CHECKTAIKHOAN N'" + mgv + "'";
                    Program.myReader = Program.ExecSqlDataReader(strLenh);
                    if (Program.myReader == null) return;
                    if (Program.myReader.Read() == true)
                    {
                        logName = Program.myReader.GetString(0);
                    }
                    Program.myReader.Close();
                    if (!string.IsNullOrEmpty(logName.Trim()))
                    {
                        MessageBox.Show("Giáo viên đã có tài khoản không thể sửa mã GV! ","",MessageBoxButtons.OK);
                        DataGridView_GiaoVien.CurrentCell = this.DataGridView_GiaoVien.Rows[bdsGV.Position].Cells[0];
                        DataGridView_GiaoVien.BeginEdit(true);
                        return;
                    }
                }
            }
            //ghi
            try
            {
                bdsGV.EndEdit();
                bdsGV.ResetCurrentItem();
                this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gIAOVIENTableAdapter.Update(this.DS.GIAOVIEN);
                soLanSua = 0;
                mgv = "";
                GridControl_Khoa.Enabled = true;
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("PK_GIAOVIEN"))
                {
                    MessageBox.Show("Lỗi mã giảng viên bị trùng", "", MessageBoxButtons.OK);
                    if (themGVToolStripMenuItem.Enabled == false)
                    {
                        DataGridView_GiaoVien.CurrentCell = this.DataGridView_GiaoVien.Rows[bdsGV.Count - 1].Cells[0];
                    }
                    else
                    {
                        DataGridView_GiaoVien.CurrentCell = this.DataGridView_GiaoVien.Rows[bdsGV.Position].Cells[0];
                    }
                    DataGridView_GiaoVien.BeginEdit(true);
                }
                else 
                {
                    this.bdsGV.RemoveCurrent();
                    MessageBox.Show("Lỗi ghi giảng viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                }
                return;
            }
            thoatToolStripMenuItem.Enabled = false;
            themGVToolStripMenuItem.Enabled = true;
            xoaGVToolStripMenuItem.Enabled = true;

            btnThoat.Enabled = false;
            btnThem.Enabled = btnReload.Enabled = btnXoa.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = true;
            GridControl_Khoa.Enabled = true;
            groupControl2.Enabled = true;
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.bdsGV.RemoveCurrent();

            thoatToolStripMenuItem.Enabled = false;
            themGVToolStripMenuItem.Enabled = true;
            xoaGVToolStripMenuItem.Enabled = true;

            btnThoat.Enabled = false;
            btnThem.Enabled = btnReload.Enabled = btnXoa.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = true;
            GridControl_Khoa.Enabled = true;
            groupControl2.Enabled = true;
        }

        private void DataGridView_GiaoVien_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            soLanSua++;
            if (bdsGV.Count > 0 && soLanSua == 1 && mgv == "")
            {
                mgv = ((DataRowView)bdsGV[bdsGV.Position])["MAGV"].ToString();
                GridControl_Khoa.Enabled = false;
            }
        }

        private void TextBox_MaKH_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
