namespace TracNghiem
{
    partial class frmKhoa_GiaoVien
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
            System.Windows.Forms.Label mAKHLabel;
            System.Windows.Forms.Label tENKHLabel;
            System.Windows.Forms.Label mACSLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhoa_GiaoVien));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.comboBox_CN = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DS = new TracNghiem.DS();
            this.bdsKhoa = new System.Windows.Forms.BindingSource(this.components);
            this.kHOATableAdapter = new TracNghiem.DSTableAdapters.KHOATableAdapter();
            this.tableAdapterManager = new TracNghiem.DSTableAdapters.TableAdapterManager();
            this.gIAOVIENTableAdapter = new TracNghiem.DSTableAdapters.GIAOVIENTableAdapter();
            this.GridControl_Khoa = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.TextBox_MaCS = new System.Windows.Forms.TextBox();
            this.TextBox_TenKH = new System.Windows.Forms.TextBox();
            this.TextBox_MaKH = new System.Windows.Forms.TextBox();
            this.bdsGV = new System.Windows.Forms.BindingSource(this.components);
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new TracNghiem.DSTableAdapters.LOPTableAdapter();
            this.DataGridView_GiaoVien = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.themGVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoaGVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ghiGVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dS_DSPM = new TracNghiem.DS_DSPM();
            this.bdsGVDK = new System.Windows.Forms.BindingSource(this.components);
            this.gIAOVIEN_DANGKYTableAdapter = new TracNghiem.DSTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            this.bdsBoDe = new System.Windows.Forms.BindingSource(this.components);
            this.bODETableAdapter = new TracNghiem.DSTableAdapters.BODETableAdapter();
            mAKHLabel = new System.Windows.Forms.Label();
            tENKHLabel = new System.Windows.Forms.Label();
            mACSLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl_Khoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_GiaoVien)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGVDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBoDe)).BeginInit();
            this.SuspendLayout();
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAKHLabel.Location = new System.Drawing.Point(92, 62);
            mAKHLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(69, 21);
            mAKHLabel.TabIndex = 0;
            mAKHLabel.Text = "MAKH:";
            // 
            // tENKHLabel
            // 
            tENKHLabel.AutoSize = true;
            tENKHLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENKHLabel.Location = new System.Drawing.Point(92, 138);
            tENKHLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tENKHLabel.Name = "tENKHLabel";
            tENKHLabel.Size = new System.Drawing.Size(76, 21);
            tENKHLabel.TabIndex = 2;
            tENKHLabel.Text = "TENKH:";
            // 
            // mACSLabel
            // 
            mACSLabel.AutoSize = true;
            mACSLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mACSLabel.Location = new System.Drawing.Point(92, 210);
            mACSLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mACSLabel.Name = "mACSLabel";
            mACSLabel.Size = new System.Drawing.Size(67, 21);
            mACSLabel.TabIndex = 4;
            mACSLabel.Text = "MACS:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnGhi,
            this.btnUndo,
            this.btnReload,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 2;
            this.btnGhi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGhi.ImageOptions.SvgImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnUndo
            // 
            this.btnUndo.Caption = "Undo";
            this.btnUndo.Id = 3;
            this.btnUndo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUndo.ImageOptions.SvgImage")));
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndo_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 4;
            this.btnReload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReload.ImageOptions.SvgImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 5;
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(1557, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 789);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1557, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 789);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1557, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 789);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.comboBox_CN);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1557, 87);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "groupControl1";
            // 
            // comboBox_CN
            // 
            this.comboBox_CN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_CN.Font = new System.Drawing.Font("Tahoma", 12F);
            this.comboBox_CN.FormattingEnabled = true;
            this.comboBox_CN.Location = new System.Drawing.Point(288, 37);
            this.comboBox_CN.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_CN.Name = "comboBox_CN";
            this.comboBox_CN.Size = new System.Drawing.Size(321, 32);
            this.comboBox_CN.TabIndex = 1;
            this.comboBox_CN.SelectedIndexChanged += new System.EventHandler(this.comboBox_CN_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(163, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cơ sở";
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsKhoa
            // 
            this.bdsKhoa.DataMember = "KHOA";
            this.bdsKhoa.DataSource = this.DS;
            // 
            // kHOATableAdapter
            // 
            this.kHOATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.CHITIETBAITHITableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = this.gIAOVIENTableAdapter;
            this.tableAdapterManager.KHOATableAdapter = this.kHOATableAdapter;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TracNghiem.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gIAOVIENTableAdapter
            // 
            this.gIAOVIENTableAdapter.ClearBeforeFill = true;
            // 
            // GridControl_Khoa
            // 
            this.GridControl_Khoa.DataSource = this.bdsKhoa;
            this.GridControl_Khoa.Dock = System.Windows.Forms.DockStyle.Top;
            // 
            // 
            // 
            this.GridControl_Khoa.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.GridControl_Khoa.Location = new System.Drawing.Point(0, 87);
            this.GridControl_Khoa.MainView = this.gridView1;
            this.GridControl_Khoa.Margin = new System.Windows.Forms.Padding(4);
            this.GridControl_Khoa.MenuManager = this.barManager1;
            this.GridControl_Khoa.Name = "GridControl_Khoa";
            this.GridControl_Khoa.Size = new System.Drawing.Size(1557, 220);
            this.GridControl_Khoa.TabIndex = 6;
            this.GridControl_Khoa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAKH,
            this.colTENKH,
            this.colMACS});
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.GridControl_Khoa;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colMAKH
            // 
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.MinWidth = 27;
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 0;
            this.colMAKH.Width = 100;
            // 
            // colTENKH
            // 
            this.colTENKH.FieldName = "TENKH";
            this.colTENKH.MinWidth = 27;
            this.colTENKH.Name = "colTENKH";
            this.colTENKH.Visible = true;
            this.colTENKH.VisibleIndex = 1;
            this.colTENKH.Width = 100;
            // 
            // colMACS
            // 
            this.colMACS.FieldName = "MACS";
            this.colMACS.MinWidth = 27;
            this.colMACS.Name = "colMACS";
            this.colMACS.Visible = true;
            this.colMACS.VisibleIndex = 2;
            this.colMACS.Width = 100;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(mACSLabel);
            this.groupControl2.Controls.Add(this.TextBox_MaCS);
            this.groupControl2.Controls.Add(tENKHLabel);
            this.groupControl2.Controls.Add(this.TextBox_TenKH);
            this.groupControl2.Controls.Add(mAKHLabel);
            this.groupControl2.Controls.Add(this.TextBox_MaKH);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl2.Location = new System.Drawing.Point(0, 307);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(685, 482);
            this.groupControl2.TabIndex = 7;
            this.groupControl2.Text = "groupControl2";
            // 
            // TextBox_MaCS
            // 
            this.TextBox_MaCS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKhoa, "MACS", true));
            this.TextBox_MaCS.Enabled = false;
            this.TextBox_MaCS.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_MaCS.Location = new System.Drawing.Point(196, 207);
            this.TextBox_MaCS.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_MaCS.Name = "TextBox_MaCS";
            this.TextBox_MaCS.Size = new System.Drawing.Size(191, 29);
            this.TextBox_MaCS.TabIndex = 5;
            // 
            // TextBox_TenKH
            // 
            this.TextBox_TenKH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKhoa, "TENKH", true));
            this.TextBox_TenKH.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_TenKH.Location = new System.Drawing.Point(196, 134);
            this.TextBox_TenKH.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_TenKH.Name = "TextBox_TenKH";
            this.TextBox_TenKH.Size = new System.Drawing.Size(191, 29);
            this.TextBox_TenKH.TabIndex = 3;
            // 
            // TextBox_MaKH
            // 
            this.TextBox_MaKH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKhoa, "MAKH", true));
            this.TextBox_MaKH.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_MaKH.Location = new System.Drawing.Point(196, 58);
            this.TextBox_MaKH.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_MaKH.Name = "TextBox_MaKH";
            this.TextBox_MaKH.Size = new System.Drawing.Size(191, 29);
            this.TextBox_MaKH.TabIndex = 1;
            this.TextBox_MaKH.TextChanged += new System.EventHandler(this.TextBox_MaKH_TextChanged);
            // 
            // bdsGV
            // 
            this.bdsGV.DataMember = "FK_GIAOVIEN_KHOA";
            this.bdsGV.DataSource = this.bdsKhoa;
            // 
            // bdsLop
            // 
            this.bdsLop.DataMember = "FK_LOP_KHOA";
            this.bdsLop.DataSource = this.bdsKhoa;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // DataGridView_GiaoVien
            // 
            this.DataGridView_GiaoVien.AllowUserToAddRows = false;
            this.DataGridView_GiaoVien.AllowUserToDeleteRows = false;
            this.DataGridView_GiaoVien.AutoGenerateColumns = false;
            this.DataGridView_GiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_GiaoVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.DataGridView_GiaoVien.ContextMenuStrip = this.contextMenuStrip1;
            this.DataGridView_GiaoVien.DataSource = this.bdsGV;
            this.DataGridView_GiaoVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView_GiaoVien.Location = new System.Drawing.Point(685, 307);
            this.DataGridView_GiaoVien.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridView_GiaoVien.Name = "DataGridView_GiaoVien";
            this.DataGridView_GiaoVien.RowHeadersWidth = 51;
            this.DataGridView_GiaoVien.Size = new System.Drawing.Size(872, 482);
            this.DataGridView_GiaoVien.TabIndex = 7;
            this.DataGridView_GiaoVien.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DataGridView_GiaoVien_CellBeginEdit);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MAGV";
            this.dataGridViewTextBoxColumn1.HeaderText = "MAGV";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "HO";
            this.dataGridViewTextBoxColumn2.HeaderText = "HO";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TEN";
            this.dataGridViewTextBoxColumn3.HeaderText = "TEN";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DIACHI";
            this.dataGridViewTextBoxColumn4.HeaderText = "DIACHI";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MAKH";
            this.dataGridViewTextBoxColumn5.HeaderText = "MAKH";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themGVToolStripMenuItem,
            this.xoaGVToolStripMenuItem,
            this.toolStripSeparator1,
            this.ghiGVToolStripMenuItem,
            this.toolStripSeparator2,
            this.thoatToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(189, 112);
            // 
            // themGVToolStripMenuItem
            // 
            this.themGVToolStripMenuItem.Name = "themGVToolStripMenuItem";
            this.themGVToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.themGVToolStripMenuItem.Text = "Thêm giảng viên";
            this.themGVToolStripMenuItem.Click += new System.EventHandler(this.themGVToolStripMenuItem_Click);
            // 
            // xoaGVToolStripMenuItem
            // 
            this.xoaGVToolStripMenuItem.Name = "xoaGVToolStripMenuItem";
            this.xoaGVToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.xoaGVToolStripMenuItem.Text = "Xóa giảng viên";
            this.xoaGVToolStripMenuItem.Click += new System.EventHandler(this.xoaGVToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(185, 6);
            // 
            // ghiGVToolStripMenuItem
            // 
            this.ghiGVToolStripMenuItem.Name = "ghiGVToolStripMenuItem";
            this.ghiGVToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.ghiGVToolStripMenuItem.Text = "Ghi";
            this.ghiGVToolStripMenuItem.Click += new System.EventHandler(this.ghiGVToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(185, 6);
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.thoatToolStripMenuItem.Text = "Thoát";
            this.thoatToolStripMenuItem.Click += new System.EventHandler(this.thoatToolStripMenuItem_Click);
            // 
            // dS_DSPM
            // 
            this.dS_DSPM.DataSetName = "DS_DSPM";
            this.dS_DSPM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsGVDK
            // 
            this.bdsGVDK.DataMember = "FK_GIAOVIEN_DANGKY_GIAOVIEN1";
            this.bdsGVDK.DataSource = this.bdsGV;
            // 
            // gIAOVIEN_DANGKYTableAdapter
            // 
            this.gIAOVIEN_DANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // bdsBoDe
            // 
            this.bdsBoDe.DataMember = "FK_BODE_GIAOVIEN";
            this.bdsBoDe.DataSource = this.bdsGV;
            // 
            // bODETableAdapter
            // 
            this.bODETableAdapter.ClearBeforeFill = true;
            // 
            // frmKhoa_GiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1557, 789);
            this.Controls.Add(this.DataGridView_GiaoVien);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.GridControl_Khoa);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmKhoa_GiaoVien";
            this.Text = "Khoa - Giảng viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmKhoa_GiaoVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl_Khoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_GiaoVien)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGVDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBoDe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bdsKhoa;
        private DS DS;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DSTableAdapters.KHOATableAdapter kHOATableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl GridControl_Khoa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DSTableAdapters.GIAOVIENTableAdapter gIAOVIENTableAdapter;
        private System.Windows.Forms.BindingSource bdsGV;
        private System.Windows.Forms.ComboBox comboBox_CN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBox_MaCS;
        private System.Windows.Forms.TextBox TextBox_TenKH;
        private System.Windows.Forms.TextBox TextBox_MaKH;
        private System.Windows.Forms.BindingSource bdsLop;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.DataGridView DataGridView_GiaoVien;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMACS;
        private DS_DSPM dS_DSPM;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem themGVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xoaGVToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ghiGVToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource bdsGVDK;
        private DSTableAdapters.GIAOVIEN_DANGKYTableAdapter gIAOVIEN_DANGKYTableAdapter;
        private System.Windows.Forms.BindingSource bdsBoDe;
        private DSTableAdapters.BODETableAdapter bODETableAdapter;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
    }
}