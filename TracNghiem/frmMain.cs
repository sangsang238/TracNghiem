using System;
using System.Windows.Forms;

namespace TracNghiem
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
            btnDN.PerformClick();
            btnDX.Enabled = false;
            ribbonPage_DM.Visible = false;
            ribbonPage_PhanQuyen.Visible = false;
            ribbonPage_BaoCao.Visible = false;
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void barButtonItem_DN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                frmDangNhap f = new frmDangNhap();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem_TaoTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTaoTaiKhoan));
            if (frm != null) frm.Activate();
            else
            {
                frmTaoTaiKhoan f = new frmTaoTaiKhoan();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmMonHoc));
            if (frm != null) frm.Activate();
            else
            {
                frmMonHoc f = new frmMonHoc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnKhoaGV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmKhoa_GiaoVien));
            if (frm != null) frm.Activate();
            else
            {
                frmKhoa_GiaoVien f = new frmKhoa_GiaoVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem_LopSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmLop_SinhVien));
            if (frm != null) frm.Activate();
            else
            {
                frmLop_SinhVien f = new frmLop_SinhVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem_BODE_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmNhapDe));
            if (frm != null) frm.Activate();
            else
            {
                frmNhapDe f = new frmNhapDe();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem_DX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn đăng xuất khỏi tài khoản '"
                +Program.mloginDN+"' ?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Restart();
            }
        }

        private void barButtonItem_CBT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmChuanBiThi));
            if (frm != null) frm.Activate();
            else
            {
                frmChuanBiThi f = new frmChuanBiThi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem_Thi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmThi));
            if (frm != null) frm.Activate();
            else
            {
                frmThi f = new frmThi();
                f.MdiParent = this;
                f.Show();
                if (Program.mGroup != "Sinhvien")
                {
                    f.Text = "Thi thử";
                    MessageBox.Show("Giáo viên chỉ có thể thi thử và không ghi điểm!", "", MessageBoxButtons.OK);
                }
            }
        }

        public void HienThiMenu()
        {
            btnDX.Enabled = true;
            btnDN.Enabled = false;
            if (Program.isGV)
            {
                toolStripStatusLabel_MaUser.Text = "Mã giảng viên: " + Program.username;
                toolStripStatusLabel_HoTen.Text = "Họ tên: " + Program.mHoten;
                toolStripStatusLabel_Nhom.Text = "Nhóm: " + Program.mGroup;
            }
            else
            {
                toolStripStatusLabel_MaUser.Text = "Mã sinh viên: " + Program.username;
                toolStripStatusLabel_HoTen.Text = "Họ tên: " + Program.mHoten;
                toolStripStatusLabel_Nhom.Text = "Nhóm: " + Program.mGroup;
            }
            //phan quyen
            ribbonPage_BaoCao.Visible = true;
            if (Program.isGV)
            {
                btnThi.Caption = "Thi thử";
                ribbonPage_DM.Visible = true;
                if (Program.mGroup == "Giangvien")
                {
                    btnMonHoc.Enabled = false;
                    btnKhoaGV.Enabled = false;
                    btnLopSV.Enabled = false;
                    ribbonPageGroup_BT.Visible = false;
                    ribbonPageGroup_DSDKT.Visible = false;
                }
                else
                {
                    btnBaiThi.Enabled = false;
                    ribbonPage_PhanQuyen.Visible = true;
                    btnTaoTaiKhoan.Enabled = true;
                    if (Program.mGroup == "Truong")
                    {
                        ribbonPageGroup_Thi.Visible = false;
                    }
                }
            }
            else
            {
                ribbonPage_DM.Visible = true;
                ribbonPageGroup_CBT.Visible = false;
                ribbonPageGroup_SimpleForm.Visible = false;
                ribbonPageGroup_Subform.Visible = false;
                ribbonPageGroup_BD.Visible = false;
                ribbonPageGroup_DSDKT.Visible = false;
            }
        }

        public void fixLoiChuyenSiteFormCBT()
        {
            if (Program.mlogin == Program.mloginDN) //site ht
            {
                btnBODE.Enabled = true;
                btnThi.Enabled = true;
            }
            else
            {
                btnBODE.Enabled = false;
                btnThi.Enabled = false;
                Form frm = this.CheckExists(typeof(frmThi));
                if (frm != null) frm.Close();
                frm = this.CheckExists(typeof(frmNhapDe));
                if (frm != null) frm.Close();
            }
        }

        private void btnBaiThi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmKQTHI));
            if (frm != null) frm.Activate();
            else
            {
                frmKQTHI f = new frmKQTHI();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnBangDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmBangDiemMH));
            if (frm != null) frm.Activate();
            else
            {
                frmBangDiemMH f = new frmBangDiemMH();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDSDK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDsDkThi));
            if (frm != null) frm.Activate();
            else
            {
                frmDsDkThi f = new frmDsDkThi();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
