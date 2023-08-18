namespace TracNghiem
{
    partial class frmLop_SinhVien
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
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label mAKHLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLop_SinhVien));
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
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new TracNghiem.DSTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new TracNghiem.DSTableAdapters.TableAdapterManager();
            this.bANGDIEMTableAdapter = new TracNghiem.DSTableAdapters.BANGDIEMTableAdapter();
            this.gIAOVIEN_DANGKYTableAdapter = new TracNghiem.DSTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            this.sINHVIENTableAdapter = new TracNghiem.DSTableAdapters.SINHVIENTableAdapter();
            this.GridControl_Lop = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.ComboBox_MAKH = new System.Windows.Forms.ComboBox();
            this.bdsKH = new System.Windows.Forms.BindingSource(this.components);
            this.TextBox_TENLOP = new System.Windows.Forms.TextBox();
            this.TextBox_MALOP = new System.Windows.Forms.TextBox();
            this.bdsSV = new System.Windows.Forms.BindingSource(this.components);
            this.DataGridView_SV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.themSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoaSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ghiSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bdsGVDK = new System.Windows.Forms.BindingSource(this.components);
            this.bdsBangDiem = new System.Windows.Forms.BindingSource(this.components);
            this.kHOATableAdapter = new TracNghiem.DSTableAdapters.KHOATableAdapter();
            mALOPLabel = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            mAKHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl_Lop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_SV)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGVDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBangDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mALOPLabel.Location = new System.Drawing.Point(57, 47);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(79, 21);
            mALOPLabel.TabIndex = 0;
            mALOPLabel.Text = "MALOP:";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENLOPLabel.Location = new System.Drawing.Point(53, 107);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(86, 21);
            tENLOPLabel.TabIndex = 2;
            tENLOPLabel.Text = "TENLOP:";
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAKHLabel.Location = new System.Drawing.Point(57, 161);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(69, 21);
            mAKHLabel.TabIndex = 4;
            mAKHLabel.Text = "MAKH:";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1255, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 653);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1255, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 653);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1255, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 653);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.comboBox_CN);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1255, 75);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "groupControl1";
            // 
            // comboBox_CN
            // 
            this.comboBox_CN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_CN.Font = new System.Drawing.Font("Tahoma", 12F);
            this.comboBox_CN.FormattingEnabled = true;
            this.comboBox_CN.Location = new System.Drawing.Point(194, 35);
            this.comboBox_CN.Name = "comboBox_CN";
            this.comboBox_CN.Size = new System.Drawing.Size(242, 32);
            this.comboBox_CN.TabIndex = 2;
            this.comboBox_CN.SelectedIndexChanged += new System.EventHandler(this.comboBox_CN_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(113, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cơ sở";
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsLop
            // 
            this.bdsLop.DataMember = "LOP";
            this.bdsLop.DataSource = this.DS;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = this.bANGDIEMTableAdapter;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.CHITIETBAITHITableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = this.gIAOVIEN_DANGKYTableAdapter;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = this.sINHVIENTableAdapter;
            this.tableAdapterManager.UpdateOrder = TracNghiem.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bANGDIEMTableAdapter
            // 
            this.bANGDIEMTableAdapter.ClearBeforeFill = true;
            // 
            // gIAOVIEN_DANGKYTableAdapter
            // 
            this.gIAOVIEN_DANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // GridControl_Lop
            // 
            this.GridControl_Lop.DataSource = this.bdsLop;
            this.GridControl_Lop.Dock = System.Windows.Forms.DockStyle.Top;
            this.GridControl_Lop.Location = new System.Drawing.Point(0, 75);
            this.GridControl_Lop.MainView = this.gridView1;
            this.GridControl_Lop.MenuManager = this.barManager1;
            this.GridControl_Lop.Name = "GridControl_Lop";
            this.GridControl_Lop.Size = new System.Drawing.Size(1255, 177);
            this.GridControl_Lop.TabIndex = 6;
            this.GridControl_Lop.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALOP,
            this.colTENLOP,
            this.colMAKH});
            this.gridView1.GridControl = this.GridControl_Lop;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colMALOP
            // 
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 0;
            this.colMALOP.Width = 82;
            // 
            // colTENLOP
            // 
            this.colTENLOP.FieldName = "TENLOP";
            this.colTENLOP.Name = "colTENLOP";
            this.colTENLOP.Visible = true;
            this.colTENLOP.VisibleIndex = 1;
            // 
            // colMAKH
            // 
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 2;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.ComboBox_MAKH);
            this.groupControl2.Controls.Add(mAKHLabel);
            this.groupControl2.Controls.Add(tENLOPLabel);
            this.groupControl2.Controls.Add(this.TextBox_TENLOP);
            this.groupControl2.Controls.Add(mALOPLabel);
            this.groupControl2.Controls.Add(this.TextBox_MALOP);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl2.Location = new System.Drawing.Point(0, 252);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(455, 401);
            this.groupControl2.TabIndex = 7;
            this.groupControl2.Text = "groupControl2";
            // 
            // ComboBox_MAKH
            // 
            this.ComboBox_MAKH.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsLop, "MAKH", true));
            this.ComboBox_MAKH.DataSource = this.bdsKH;
            this.ComboBox_MAKH.DisplayMember = "TENKH";
            this.ComboBox_MAKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_MAKH.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_MAKH.FormattingEnabled = true;
            this.ComboBox_MAKH.Location = new System.Drawing.Point(138, 158);
            this.ComboBox_MAKH.Name = "ComboBox_MAKH";
            this.ComboBox_MAKH.Size = new System.Drawing.Size(154, 29);
            this.ComboBox_MAKH.TabIndex = 7;
            this.ComboBox_MAKH.ValueMember = "MAKH";
            this.ComboBox_MAKH.SelectedIndexChanged += new System.EventHandler(this.ComboBox_MAKH_SelectedIndexChanged);
            // 
            // bdsKH
            // 
            this.bdsKH.DataMember = "KHOA";
            this.bdsKH.DataSource = this.DS;
            // 
            // TextBox_TENLOP
            // 
            this.TextBox_TENLOP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLop, "TENLOP", true));
            this.TextBox_TENLOP.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_TENLOP.Location = new System.Drawing.Point(138, 104);
            this.TextBox_TENLOP.Name = "TextBox_TENLOP";
            this.TextBox_TENLOP.Size = new System.Drawing.Size(154, 29);
            this.TextBox_TENLOP.TabIndex = 3;
            // 
            // TextBox_MALOP
            // 
            this.TextBox_MALOP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLop, "MALOP", true));
            this.TextBox_MALOP.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_MALOP.Location = new System.Drawing.Point(138, 44);
            this.TextBox_MALOP.Name = "TextBox_MALOP";
            this.TextBox_MALOP.Size = new System.Drawing.Size(154, 29);
            this.TextBox_MALOP.TabIndex = 1;
            // 
            // bdsSV
            // 
            this.bdsSV.DataMember = "FK_SINHVIEN_LOP";
            this.bdsSV.DataSource = this.bdsLop;
            // 
            // DataGridView_SV
            // 
            this.DataGridView_SV.AllowUserToAddRows = false;
            this.DataGridView_SV.AllowUserToDeleteRows = false;
            this.DataGridView_SV.AutoGenerateColumns = false;
            this.DataGridView_SV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_SV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.DataGridView_SV.ContextMenuStrip = this.contextMenuStrip1;
            this.DataGridView_SV.DataSource = this.bdsSV;
            this.DataGridView_SV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView_SV.Location = new System.Drawing.Point(455, 252);
            this.DataGridView_SV.Name = "DataGridView_SV";
            this.DataGridView_SV.RowHeadersWidth = 51;
            this.DataGridView_SV.Size = new System.Drawing.Size(800, 401);
            this.DataGridView_SV.TabIndex = 7;
            this.DataGridView_SV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_SV_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MASV";
            this.dataGridViewTextBoxColumn1.HeaderText = "MASV";
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
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NGAYSINH";
            this.dataGridViewTextBoxColumn4.HeaderText = "NGAYSINH";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DIACHI";
            this.dataGridViewTextBoxColumn5.HeaderText = "DIACHI";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "MALOP";
            this.dataGridViewTextBoxColumn6.HeaderText = "MALOP";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themSVToolStripMenuItem,
            this.xoaSVToolStripMenuItem,
            this.toolStripSeparator1,
            this.ghiSVToolStripMenuItem,
            this.toolStripSeparator2,
            this.thoatToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(177, 112);
            // 
            // themSVToolStripMenuItem
            // 
            this.themSVToolStripMenuItem.Name = "themSVToolStripMenuItem";
            this.themSVToolStripMenuItem.Size = new System.Drawing.Size(176, 24);
            this.themSVToolStripMenuItem.Text = "Thêm sinh viên";
            this.themSVToolStripMenuItem.Click += new System.EventHandler(this.themSVToolStripMenuItem_Click);
            // 
            // xoaSVToolStripMenuItem
            // 
            this.xoaSVToolStripMenuItem.Name = "xoaSVToolStripMenuItem";
            this.xoaSVToolStripMenuItem.Size = new System.Drawing.Size(176, 24);
            this.xoaSVToolStripMenuItem.Text = "Xóa sinh viên";
            this.xoaSVToolStripMenuItem.Click += new System.EventHandler(this.xoaSVToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(173, 6);
            // 
            // ghiSVToolStripMenuItem
            // 
            this.ghiSVToolStripMenuItem.Name = "ghiSVToolStripMenuItem";
            this.ghiSVToolStripMenuItem.Size = new System.Drawing.Size(176, 24);
            this.ghiSVToolStripMenuItem.Text = "Ghi";
            this.ghiSVToolStripMenuItem.Click += new System.EventHandler(this.ghiSVToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(173, 6);
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(176, 24);
            this.thoatToolStripMenuItem.Text = "Thoát";
            this.thoatToolStripMenuItem.Click += new System.EventHandler(this.thoatToolStripMenuItem_Click);
            // 
            // bdsGVDK
            // 
            this.bdsGVDK.DataMember = "FK_GIAOVIEN_DANGKY_LOP";
            this.bdsGVDK.DataSource = this.bdsLop;
            // 
            // bdsBangDiem
            // 
            this.bdsBangDiem.DataMember = "FK_BANGDIEM_SINHVIEN1";
            this.bdsBangDiem.DataSource = this.bdsSV;
            // 
            // kHOATableAdapter
            // 
            this.kHOATableAdapter.ClearBeforeFill = true;
            // 
            // frmLop_SinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 653);
            this.Controls.Add(this.DataGridView_SV);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.GridControl_Lop);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmLop_SinhVien";
            this.Text = "Lớp - Sinh viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLop_SinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl_Lop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_SV)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsGVDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBangDiem)).EndInit();
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
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_CN;
        private System.Windows.Forms.BindingSource bdsLop;
        private DS DS;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl GridControl_Lop;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOP;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private DSTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private System.Windows.Forms.BindingSource bdsSV;
        private System.Windows.Forms.DataGridView DataGridView_SV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DSTableAdapters.GIAOVIEN_DANGKYTableAdapter gIAOVIEN_DANGKYTableAdapter;
        private System.Windows.Forms.BindingSource bdsGVDK;
        private DSTableAdapters.BANGDIEMTableAdapter bANGDIEMTableAdapter;
        private System.Windows.Forms.BindingSource bdsBangDiem;
        private System.Windows.Forms.TextBox TextBox_TENLOP;
        private System.Windows.Forms.TextBox TextBox_MALOP;
        private System.Windows.Forms.BindingSource bdsKH;
        private DSTableAdapters.KHOATableAdapter kHOATableAdapter;
        private System.Windows.Forms.ComboBox ComboBox_MAKH;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem themSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xoaSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ghiSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
    }
}