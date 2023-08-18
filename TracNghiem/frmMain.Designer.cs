namespace TracNghiem
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDN = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaoTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.btnMonHoc = new DevExpress.XtraBars.BarButtonItem();
            this.btnKhoaGV = new DevExpress.XtraBars.BarButtonItem();
            this.btnDX = new DevExpress.XtraBars.BarButtonItem();
            this.btnLopSV = new DevExpress.XtraBars.BarButtonItem();
            this.btnBODE = new DevExpress.XtraBars.BarButtonItem();
            this.btnCBT = new DevExpress.XtraBars.BarButtonItem();
            this.btnThi = new DevExpress.XtraBars.BarButtonItem();
            this.btnBaiThi = new DevExpress.XtraBars.BarButtonItem();
            this.btnBangDiem = new DevExpress.XtraBars.BarButtonItem();
            this.btnDSDK = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage_HeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage_DM = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup_SimpleForm = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup_Subform = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup_CBT = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup_Thi = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage_PhanQuyen = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage_BaoCao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup_BT = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup_BD = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup_DSDKT = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_MaUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_HoTen = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_Nhom = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnDN,
            this.barButtonItem1,
            this.barButtonItem3,
            this.btnTaoTaiKhoan,
            this.btnMonHoc,
            this.btnKhoaGV,
            this.btnDX,
            this.btnLopSV,
            this.btnBODE,
            this.btnCBT,
            this.btnThi,
            this.btnBaiThi,
            this.btnBangDiem,
            this.btnDSDK});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 22;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage_HeThong,
            this.ribbonPage_DM,
            this.ribbonPage_PhanQuyen,
            this.ribbonPage_BaoCao});
            this.ribbonControl1.Size = new System.Drawing.Size(824, 158);
            // 
            // btnDN
            // 
            this.btnDN.Caption = "Đăng nhập";
            this.btnDN.Id = 4;
            this.btnDN.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDN.ImageOptions.SvgImage")));
            this.btnDN.Name = "btnDN";
            this.btnDN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_DN_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Id = 9;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 8;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // btnTaoTaiKhoan
            // 
            this.btnTaoTaiKhoan.Caption = "Tạo tài khoản";
            this.btnTaoTaiKhoan.Enabled = false;
            this.btnTaoTaiKhoan.Id = 10;
            this.btnTaoTaiKhoan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoTaiKhoan.ImageOptions.Image")));
            this.btnTaoTaiKhoan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTaoTaiKhoan.ImageOptions.LargeImage")));
            this.btnTaoTaiKhoan.Name = "btnTaoTaiKhoan";
            this.btnTaoTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_TaoTaiKhoan_ItemClick);
            // 
            // btnMonHoc
            // 
            this.btnMonHoc.Caption = "Môn học";
            this.btnMonHoc.Id = 11;
            this.btnMonHoc.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnMonHoc.ImageOptions.SvgImage")));
            this.btnMonHoc.Name = "btnMonHoc";
            this.btnMonHoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMonHoc_ItemClick);
            // 
            // btnKhoaGV
            // 
            this.btnKhoaGV.Caption = "Khoa-Giảng viên";
            this.btnKhoaGV.Id = 12;
            this.btnKhoaGV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKhoaGV.ImageOptions.SvgImage")));
            this.btnKhoaGV.Name = "btnKhoaGV";
            this.btnKhoaGV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKhoaGV_ItemClick);
            // 
            // btnDX
            // 
            this.btnDX.Caption = "Đăng xuất";
            this.btnDX.Id = 14;
            this.btnDX.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDX.ImageOptions.SvgImage")));
            this.btnDX.Name = "btnDX";
            this.btnDX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_DX_ItemClick);
            // 
            // btnLopSV
            // 
            this.btnLopSV.Caption = "Lớp-Sinh viên";
            this.btnLopSV.Id = 15;
            this.btnLopSV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLopSV.ImageOptions.SvgImage")));
            this.btnLopSV.Name = "btnLopSV";
            this.btnLopSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_LopSV_ItemClick);
            // 
            // btnBODE
            // 
            this.btnBODE.Caption = "Bộ đề";
            this.btnBODE.Id = 16;
            this.btnBODE.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBODE.ImageOptions.SvgImage")));
            this.btnBODE.Name = "btnBODE";
            this.btnBODE.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_BODE_ItemClick);
            // 
            // btnCBT
            // 
            this.btnCBT.Caption = "Chuẩn bị thi";
            this.btnCBT.Id = 17;
            this.btnCBT.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCBT.ImageOptions.SvgImage")));
            this.btnCBT.Name = "btnCBT";
            this.btnCBT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_CBT_ItemClick);
            // 
            // btnThi
            // 
            this.btnThi.Caption = "Thi";
            this.btnThi.Id = 18;
            this.btnThi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThi.ImageOptions.SvgImage")));
            this.btnThi.Name = "btnThi";
            this.btnThi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Thi_ItemClick);
            // 
            // btnBaiThi
            // 
            this.btnBaiThi.Caption = "Bài thi";
            this.btnBaiThi.Id = 19;
            this.btnBaiThi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBaiThi.ImageOptions.SvgImage")));
            this.btnBaiThi.Name = "btnBaiThi";
            this.btnBaiThi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBaiThi_ItemClick);
            // 
            // btnBangDiem
            // 
            this.btnBangDiem.Caption = "Bảng điểm";
            this.btnBangDiem.Id = 20;
            this.btnBangDiem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBangDiem.ImageOptions.SvgImage")));
            this.btnBangDiem.Name = "btnBangDiem";
            this.btnBangDiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBangDiem_ItemClick);
            // 
            // btnDSDK
            // 
            this.btnDSDK.Caption = "Danh sách đăng ký thi";
            this.btnDSDK.Id = 21;
            this.btnDSDK.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDSDK.ImageOptions.SvgImage")));
            this.btnDSDK.Name = "btnDSDK";
            this.btnDSDK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDSDK_ItemClick);
            // 
            // ribbonPage_HeThong
            // 
            this.ribbonPage_HeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup5});
            this.ribbonPage_HeThong.Name = "ribbonPage_HeThong";
            this.ribbonPage_HeThong.Text = "Hệ thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDN);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnDX);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPage_DM
            // 
            this.ribbonPage_DM.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup_SimpleForm,
            this.ribbonPageGroup_Subform,
            this.ribbonPageGroup_CBT,
            this.ribbonPageGroup_Thi});
            this.ribbonPage_DM.Name = "ribbonPage_DM";
            this.ribbonPage_DM.Text = "Danh mục";
            // 
            // ribbonPageGroup_SimpleForm
            // 
            this.ribbonPageGroup_SimpleForm.ItemLinks.Add(this.btnMonHoc);
            this.ribbonPageGroup_SimpleForm.ItemLinks.Add(this.btnBODE);
            this.ribbonPageGroup_SimpleForm.Name = "ribbonPageGroup_SimpleForm";
            this.ribbonPageGroup_SimpleForm.Text = "Simple form";
            // 
            // ribbonPageGroup_Subform
            // 
            this.ribbonPageGroup_Subform.ItemLinks.Add(this.btnKhoaGV);
            this.ribbonPageGroup_Subform.ItemLinks.Add(this.btnLopSV);
            this.ribbonPageGroup_Subform.Name = "ribbonPageGroup_Subform";
            this.ribbonPageGroup_Subform.Text = "Subform";
            // 
            // ribbonPageGroup_CBT
            // 
            this.ribbonPageGroup_CBT.ItemLinks.Add(this.btnCBT);
            this.ribbonPageGroup_CBT.Name = "ribbonPageGroup_CBT";
            this.ribbonPageGroup_CBT.Text = "CBT";
            // 
            // ribbonPageGroup_Thi
            // 
            this.ribbonPageGroup_Thi.ItemLinks.Add(this.btnThi);
            this.ribbonPageGroup_Thi.Name = "ribbonPageGroup_Thi";
            this.ribbonPageGroup_Thi.Text = "Thi";
            // 
            // ribbonPage_PhanQuyen
            // 
            this.ribbonPage_PhanQuyen.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage_PhanQuyen.Name = "ribbonPage_PhanQuyen";
            this.ribbonPage_PhanQuyen.Text = "Phân quyền";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnTaoTaiKhoan);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPage_BaoCao
            // 
            this.ribbonPage_BaoCao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup_BT,
            this.ribbonPageGroup_BD,
            this.ribbonPageGroup_DSDKT});
            this.ribbonPage_BaoCao.Name = "ribbonPage_BaoCao";
            this.ribbonPage_BaoCao.Text = "Báo cáo";
            // 
            // ribbonPageGroup_BT
            // 
            this.ribbonPageGroup_BT.ItemLinks.Add(this.btnBaiThi);
            this.ribbonPageGroup_BT.Name = "ribbonPageGroup_BT";
            // 
            // ribbonPageGroup_BD
            // 
            this.ribbonPageGroup_BD.ItemLinks.Add(this.btnBangDiem);
            this.ribbonPageGroup_BD.Name = "ribbonPageGroup_BD";
            // 
            // ribbonPageGroup_DSDKT
            // 
            this.ribbonPageGroup_DSDKT.ItemLinks.Add(this.btnDSDK);
            this.ribbonPageGroup_DSDKT.Name = "ribbonPageGroup_DSDKT";
            // 
            // popupMenu1
            // 
            this.popupMenu1.Name = "popupMenu1";
            this.popupMenu1.Ribbon = this.ribbonControl1;
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_MaUser,
            this.toolStripStatusLabel_HoTen,
            this.toolStripStatusLabel_Nhom});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(824, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_MaUser
            // 
            this.toolStripStatusLabel_MaUser.Name = "toolStripStatusLabel_MaUser";
            this.toolStripStatusLabel_MaUser.Size = new System.Drawing.Size(56, 17);
            this.toolStripStatusLabel_MaUser.Text = "MA USER";
            // 
            // toolStripStatusLabel_HoTen
            // 
            this.toolStripStatusLabel_HoTen.Name = "toolStripStatusLabel_HoTen";
            this.toolStripStatusLabel_HoTen.Size = new System.Drawing.Size(49, 17);
            this.toolStripStatusLabel_HoTen.Text = "HO TEN";
            // 
            // toolStripStatusLabel_Nhom
            // 
            this.toolStripStatusLabel_Nhom.Name = "toolStripStatusLabel_Nhom";
            this.toolStripStatusLabel_Nhom.Size = new System.Drawing.Size(45, 17);
            this.toolStripStatusLabel_Nhom.Text = "NHOM";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 461);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "THI TRAC NGHIEM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage_HeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage_DM;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup_SimpleForm;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem btnDN;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage_PhanQuyen;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_MaUser;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_HoTen;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Nhom;
        private DevExpress.XtraBars.BarButtonItem btnTaoTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem btnMonHoc;
        private DevExpress.XtraBars.BarButtonItem btnKhoaGV;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup_Subform;
        private DevExpress.XtraBars.BarButtonItem btnDX;
        private DevExpress.XtraBars.BarButtonItem btnLopSV;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btnBODE;
        private DevExpress.XtraBars.BarButtonItem btnCBT;
        private DevExpress.XtraBars.BarButtonItem btnThi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup_CBT;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup_Thi;
        private DevExpress.XtraBars.BarButtonItem btnBaiThi;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage_BaoCao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup_BT;
        private DevExpress.XtraBars.BarButtonItem btnBangDiem;
        private DevExpress.XtraBars.BarButtonItem btnDSDK;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup_BD;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup_DSDKT;
    }
}

