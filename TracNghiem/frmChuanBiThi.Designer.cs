namespace TracNghiem
{
    partial class frmChuanBiThi
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
            System.Windows.Forms.Label mAGVLabel;
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label tRINHDOLabel;
            System.Windows.Forms.Label nGAYTHILabel;
            System.Windows.Forms.Label lANLabel;
            System.Windows.Forms.Label sOCAUTHILabel;
            System.Windows.Forms.Label tHOIGIANLabel;
            System.Windows.Forms.Label mALOPLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChuanBiThi));
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
            this.bdsGVDK = new System.Windows.Forms.BindingSource(this.components);
            this.gIAOVIEN_DANGKYTableAdapter = new TracNghiem.DSTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            this.tableAdapterManager = new TracNghiem.DSTableAdapters.TableAdapterManager();
            this.GridControl_GVDK = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRINHDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYTHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOCAUTHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTHOIGIAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.SpinEdit_TG = new DevExpress.XtraEditors.SpinEdit();
            this.SpinEdit_SCT = new DevExpress.XtraEditors.SpinEdit();
            this.SpinEdit_LAN = new DevExpress.XtraEditors.SpinEdit();
            this.ComboBox_MALOP = new System.Windows.Forms.ComboBox();
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.DateEdit_NgayThi = new DevExpress.XtraEditors.DateEdit();
            this.label_TD = new System.Windows.Forms.Label();
            this.ComboBox_TD = new System.Windows.Forms.ComboBox();
            this.ComboBox_MAMH = new System.Windows.Forms.ComboBox();
            this.bdsMH = new System.Windows.Forms.BindingSource(this.components);
            this.TextBox_MAGV = new System.Windows.Forms.TextBox();
            this.mONHOCTableAdapter = new TracNghiem.DSTableAdapters.MONHOCTableAdapter();
            this.lOPTableAdapter = new TracNghiem.DSTableAdapters.LOPTableAdapter();
            mAGVLabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            tRINHDOLabel = new System.Windows.Forms.Label();
            nGAYTHILabel = new System.Windows.Forms.Label();
            lANLabel = new System.Windows.Forms.Label();
            sOCAUTHILabel = new System.Windows.Forms.Label();
            tHOIGIANLabel = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGVDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl_GVDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpinEdit_TG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpinEdit_SCT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpinEdit_LAN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit_NgayThi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit_NgayThi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMH)).BeginInit();
            this.SuspendLayout();
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAGVLabel.Location = new System.Drawing.Point(84, 50);
            mAGVLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(69, 21);
            mAGVLabel.TabIndex = 0;
            mAGVLabel.Text = "MAGV:";
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAMHLabel.Location = new System.Drawing.Point(81, 95);
            mAMHLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(72, 21);
            mAMHLabel.TabIndex = 2;
            mAMHLabel.Text = "MAMH:";
            // 
            // tRINHDOLabel
            // 
            tRINHDOLabel.AutoSize = true;
            tRINHDOLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tRINHDOLabel.Location = new System.Drawing.Point(63, 188);
            tRINHDOLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tRINHDOLabel.Name = "tRINHDOLabel";
            tRINHDOLabel.Size = new System.Drawing.Size(98, 21);
            tRINHDOLabel.TabIndex = 5;
            tRINHDOLabel.Text = "TRINHDO:";
            // 
            // nGAYTHILabel
            // 
            nGAYTHILabel.AutoSize = true;
            nGAYTHILabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nGAYTHILabel.Location = new System.Drawing.Point(697, 50);
            nGAYTHILabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nGAYTHILabel.Name = "nGAYTHILabel";
            nGAYTHILabel.Size = new System.Drawing.Size(96, 21);
            nGAYTHILabel.TabIndex = 23;
            nGAYTHILabel.Text = "NGAYTHI:";
            // 
            // lANLabel
            // 
            lANLabel.AutoSize = true;
            lANLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lANLabel.Location = new System.Drawing.Point(731, 98);
            lANLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lANLabel.Name = "lANLabel";
            lANLabel.Size = new System.Drawing.Size(51, 21);
            lANLabel.TabIndex = 24;
            lANLabel.Text = "LAN:";
            // 
            // sOCAUTHILabel
            // 
            sOCAUTHILabel.AutoSize = true;
            sOCAUTHILabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sOCAUTHILabel.Location = new System.Drawing.Point(687, 144);
            sOCAUTHILabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            sOCAUTHILabel.Name = "sOCAUTHILabel";
            sOCAUTHILabel.Size = new System.Drawing.Size(109, 21);
            sOCAUTHILabel.TabIndex = 25;
            sOCAUTHILabel.Text = "SOCAUTHI:";
            // 
            // tHOIGIANLabel
            // 
            tHOIGIANLabel.AutoSize = true;
            tHOIGIANLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tHOIGIANLabel.Location = new System.Drawing.Point(687, 186);
            tHOIGIANLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tHOIGIANLabel.Name = "tHOIGIANLabel";
            tHOIGIANLabel.Size = new System.Drawing.Size(105, 21);
            tHOIGIANLabel.TabIndex = 26;
            tHOIGIANLabel.Text = "THOIGIAN:";
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mALOPLabel.Location = new System.Drawing.Point(76, 140);
            mALOPLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(79, 21);
            mALOPLabel.TabIndex = 28;
            mALOPLabel.Text = "MALOP:";
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
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(1097, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 598);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1097, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 598);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1097, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 598);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.comboBox_CN);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1097, 96);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "groupControl1";
            // 
            // comboBox_CN
            // 
            this.comboBox_CN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_CN.Font = new System.Drawing.Font("Tahoma", 12F);
            this.comboBox_CN.FormattingEnabled = true;
            this.comboBox_CN.Location = new System.Drawing.Point(256, 46);
            this.comboBox_CN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_CN.Name = "comboBox_CN";
            this.comboBox_CN.Size = new System.Drawing.Size(321, 32);
            this.comboBox_CN.TabIndex = 3;
            this.comboBox_CN.SelectedIndexChanged += new System.EventHandler(this.comboBox_CN_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(131, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cơ sở";
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsGVDK
            // 
            this.bdsGVDK.DataMember = "GIAOVIEN_DANGKY";
            this.bdsGVDK.DataSource = this.DS;
            // 
            // gIAOVIEN_DANGKYTableAdapter
            // 
            this.gIAOVIEN_DANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.CHITIETBAITHITableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = this.gIAOVIEN_DANGKYTableAdapter;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TracNghiem.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // GridControl_GVDK
            // 
            this.GridControl_GVDK.DataSource = this.bdsGVDK;
            this.GridControl_GVDK.Dock = System.Windows.Forms.DockStyle.Top;
            // 
            // 
            // 
            this.GridControl_GVDK.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GridControl_GVDK.Location = new System.Drawing.Point(0, 96);
            this.GridControl_GVDK.MainView = this.gridView1;
            this.GridControl_GVDK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GridControl_GVDK.MenuManager = this.barManager1;
            this.GridControl_GVDK.Name = "GridControl_GVDK";
            this.GridControl_GVDK.Size = new System.Drawing.Size(1097, 213);
            this.GridControl_GVDK.TabIndex = 6;
            this.GridControl_GVDK.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGV,
            this.colMAMH,
            this.colMALOP,
            this.colTRINHDO,
            this.colNGAYTHI,
            this.colLAN,
            this.colSOCAUTHI,
            this.colTHOIGIAN});
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.GridControl_GVDK;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colMAGV
            // 
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.MinWidth = 27;
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 0;
            this.colMAGV.Width = 100;
            // 
            // colMAMH
            // 
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.MinWidth = 27;
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 1;
            this.colMAMH.Width = 100;
            // 
            // colMALOP
            // 
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.MinWidth = 27;
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 2;
            this.colMALOP.Width = 100;
            // 
            // colTRINHDO
            // 
            this.colTRINHDO.FieldName = "TRINHDO";
            this.colTRINHDO.MinWidth = 27;
            this.colTRINHDO.Name = "colTRINHDO";
            this.colTRINHDO.Visible = true;
            this.colTRINHDO.VisibleIndex = 3;
            this.colTRINHDO.Width = 100;
            // 
            // colNGAYTHI
            // 
            this.colNGAYTHI.FieldName = "NGAYTHI";
            this.colNGAYTHI.MinWidth = 27;
            this.colNGAYTHI.Name = "colNGAYTHI";
            this.colNGAYTHI.Visible = true;
            this.colNGAYTHI.VisibleIndex = 4;
            this.colNGAYTHI.Width = 100;
            // 
            // colLAN
            // 
            this.colLAN.FieldName = "LAN";
            this.colLAN.MinWidth = 27;
            this.colLAN.Name = "colLAN";
            this.colLAN.Visible = true;
            this.colLAN.VisibleIndex = 5;
            this.colLAN.Width = 100;
            // 
            // colSOCAUTHI
            // 
            this.colSOCAUTHI.FieldName = "SOCAUTHI";
            this.colSOCAUTHI.MinWidth = 27;
            this.colSOCAUTHI.Name = "colSOCAUTHI";
            this.colSOCAUTHI.Visible = true;
            this.colSOCAUTHI.VisibleIndex = 6;
            this.colSOCAUTHI.Width = 100;
            // 
            // colTHOIGIAN
            // 
            this.colTHOIGIAN.FieldName = "THOIGIAN";
            this.colTHOIGIAN.MinWidth = 27;
            this.colTHOIGIAN.Name = "colTHOIGIAN";
            this.colTHOIGIAN.Visible = true;
            this.colTHOIGIAN.VisibleIndex = 7;
            this.colTHOIGIAN.Width = 100;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.SpinEdit_TG);
            this.groupControl2.Controls.Add(this.SpinEdit_SCT);
            this.groupControl2.Controls.Add(this.SpinEdit_LAN);
            this.groupControl2.Controls.Add(this.ComboBox_MALOP);
            this.groupControl2.Controls.Add(mALOPLabel);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Controls.Add(tHOIGIANLabel);
            this.groupControl2.Controls.Add(sOCAUTHILabel);
            this.groupControl2.Controls.Add(lANLabel);
            this.groupControl2.Controls.Add(nGAYTHILabel);
            this.groupControl2.Controls.Add(this.DateEdit_NgayThi);
            this.groupControl2.Controls.Add(this.label_TD);
            this.groupControl2.Controls.Add(tRINHDOLabel);
            this.groupControl2.Controls.Add(this.ComboBox_TD);
            this.groupControl2.Controls.Add(this.ComboBox_MAMH);
            this.groupControl2.Controls.Add(mAMHLabel);
            this.groupControl2.Controls.Add(mAGVLabel);
            this.groupControl2.Controls.Add(this.TextBox_MAGV);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 309);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1097, 289);
            this.groupControl2.TabIndex = 7;
            this.groupControl2.Text = "groupControl2";
            // 
            // SpinEdit_TG
            // 
            this.SpinEdit_TG.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGVDK, "THOIGIAN", true));
            this.SpinEdit_TG.EditValue = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.SpinEdit_TG.Location = new System.Drawing.Point(837, 180);
            this.SpinEdit_TG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SpinEdit_TG.MenuManager = this.barManager1;
            this.SpinEdit_TG.Name = "SpinEdit_TG";
            // 
            // 
            // 
            this.SpinEdit_TG.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.SpinEdit_TG.Properties.Appearance.Options.UseFont = true;
            this.SpinEdit_TG.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SpinEdit_TG.Properties.IsFloatValue = false;
            this.SpinEdit_TG.Properties.Mask.EditMask = "N00";
            this.SpinEdit_TG.Properties.MaxValue = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.SpinEdit_TG.Properties.MinValue = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.SpinEdit_TG.Size = new System.Drawing.Size(72, 28);
            this.SpinEdit_TG.TabIndex = 33;
            // 
            // SpinEdit_SCT
            // 
            this.SpinEdit_SCT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGVDK, "SOCAUTHI", true));
            this.SpinEdit_SCT.EditValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.SpinEdit_SCT.Location = new System.Drawing.Point(837, 135);
            this.SpinEdit_SCT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SpinEdit_SCT.MenuManager = this.barManager1;
            this.SpinEdit_SCT.Name = "SpinEdit_SCT";
            // 
            // 
            // 
            this.SpinEdit_SCT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.SpinEdit_SCT.Properties.Appearance.Options.UseFont = true;
            this.SpinEdit_SCT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SpinEdit_SCT.Properties.IsFloatValue = false;
            this.SpinEdit_SCT.Properties.Mask.EditMask = "N00";
            this.SpinEdit_SCT.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.SpinEdit_SCT.Properties.MinValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.SpinEdit_SCT.Size = new System.Drawing.Size(72, 28);
            this.SpinEdit_SCT.TabIndex = 32;
            // 
            // SpinEdit_LAN
            // 
            this.SpinEdit_LAN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGVDK, "LAN", true));
            this.SpinEdit_LAN.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SpinEdit_LAN.Location = new System.Drawing.Point(837, 90);
            this.SpinEdit_LAN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SpinEdit_LAN.MenuManager = this.barManager1;
            this.SpinEdit_LAN.Name = "SpinEdit_LAN";
            // 
            // 
            // 
            this.SpinEdit_LAN.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.SpinEdit_LAN.Properties.Appearance.Options.UseFont = true;
            this.SpinEdit_LAN.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SpinEdit_LAN.Properties.IsFloatValue = false;
            this.SpinEdit_LAN.Properties.Mask.EditMask = "N00";
            this.SpinEdit_LAN.Properties.MaxValue = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.SpinEdit_LAN.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SpinEdit_LAN.Size = new System.Drawing.Size(72, 28);
            this.SpinEdit_LAN.TabIndex = 31;
            // 
            // ComboBox_MALOP
            // 
            this.ComboBox_MALOP.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsGVDK, "MALOP", true));
            this.ComboBox_MALOP.DataSource = this.bdsLop;
            this.ComboBox_MALOP.DisplayMember = "TENLOP";
            this.ComboBox_MALOP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_MALOP.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_MALOP.FormattingEnabled = true;
            this.ComboBox_MALOP.Location = new System.Drawing.Point(183, 137);
            this.ComboBox_MALOP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboBox_MALOP.Name = "ComboBox_MALOP";
            this.ComboBox_MALOP.Size = new System.Drawing.Size(296, 29);
            this.ComboBox_MALOP.TabIndex = 30;
            this.ComboBox_MALOP.ValueMember = "MALOP";
            // 
            // bdsLop
            // 
            this.bdsLop.DataMember = "LOP";
            this.bdsLop.DataSource = this.DS;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(917, 183);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 21);
            this.label2.TabIndex = 28;
            this.label2.Text = "phút";
            // 
            // DateEdit_NgayThi
            // 
            this.DateEdit_NgayThi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGVDK, "NGAYTHI", true));
            this.DateEdit_NgayThi.Location = new System.Drawing.Point(837, 47);
            this.DateEdit_NgayThi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DateEdit_NgayThi.MenuManager = this.barManager1;
            this.DateEdit_NgayThi.Name = "DateEdit_NgayThi";
            // 
            // 
            // 
            this.DateEdit_NgayThi.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateEdit_NgayThi.Properties.Appearance.Options.UseFont = true;
            this.DateEdit_NgayThi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            // 
            // 
            // 
            this.DateEdit_NgayThi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateEdit_NgayThi.Size = new System.Drawing.Size(133, 28);
            this.DateEdit_NgayThi.TabIndex = 24;
            // 
            // label_TD
            // 
            this.label_TD.AutoSize = true;
            this.label_TD.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TD.Location = new System.Drawing.Point(337, 188);
            this.label_TD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TD.Name = "label_TD";
            this.label_TD.Size = new System.Drawing.Size(116, 21);
            this.label_TD.TabIndex = 23;
            this.label_TD.Text = "Chọn trình độ";
            // 
            // ComboBox_TD
            // 
            this.ComboBox_TD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGVDK, "TRINHDO", true));
            this.ComboBox_TD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_TD.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_TD.FormattingEnabled = true;
            this.ComboBox_TD.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.ComboBox_TD.Location = new System.Drawing.Point(183, 183);
            this.ComboBox_TD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboBox_TD.Name = "ComboBox_TD";
            this.ComboBox_TD.Size = new System.Drawing.Size(132, 29);
            this.ComboBox_TD.TabIndex = 6;
            this.ComboBox_TD.SelectedIndexChanged += new System.EventHandler(this.ComboBox_TD_SelectedIndexChanged);
            // 
            // ComboBox_MAMH
            // 
            this.ComboBox_MAMH.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsGVDK, "MAMH", true));
            this.ComboBox_MAMH.DataSource = this.bdsMH;
            this.ComboBox_MAMH.DisplayMember = "TENMH";
            this.ComboBox_MAMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_MAMH.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_MAMH.FormattingEnabled = true;
            this.ComboBox_MAMH.Location = new System.Drawing.Point(183, 91);
            this.ComboBox_MAMH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboBox_MAMH.Name = "ComboBox_MAMH";
            this.ComboBox_MAMH.Size = new System.Drawing.Size(296, 29);
            this.ComboBox_MAMH.TabIndex = 5;
            this.ComboBox_MAMH.ValueMember = "MAMH";
            // 
            // bdsMH
            // 
            this.bdsMH.DataMember = "MONHOC";
            this.bdsMH.DataSource = this.DS;
            // 
            // TextBox_MAGV
            // 
            this.TextBox_MAGV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGVDK, "MAGV", true));
            this.TextBox_MAGV.Enabled = false;
            this.TextBox_MAGV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_MAGV.Location = new System.Drawing.Point(183, 47);
            this.TextBox_MAGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBox_MAGV.Name = "TextBox_MAGV";
            this.TextBox_MAGV.Size = new System.Drawing.Size(132, 29);
            this.TextBox_MAGV.TabIndex = 1;
            this.TextBox_MAGV.TextChanged += new System.EventHandler(this.TextBox_MAGV_TextChanged);
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // frmChuanBiThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 598);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.GridControl_GVDK);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmChuanBiThi";
            this.Text = "Chuẩn bị thi";
            this.Load += new System.EventHandler(this.frmChuanBiThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGVDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl_GVDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpinEdit_TG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpinEdit_SCT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpinEdit_LAN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit_NgayThi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEdit_NgayThi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMH)).EndInit();
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
        private System.Windows.Forms.ComboBox comboBox_CN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bdsGVDK;
        private DS DS;
        private DSTableAdapters.GIAOVIEN_DANGKYTableAdapter gIAOVIEN_DANGKYTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl GridControl_GVDK;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTRINHDO;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYTHI;
        private DevExpress.XtraGrid.Columns.GridColumn colLAN;
        private DevExpress.XtraGrid.Columns.GridColumn colSOCAUTHI;
        private DevExpress.XtraGrid.Columns.GridColumn colTHOIGIAN;
        private System.Windows.Forms.TextBox TextBox_MAGV;
        private System.Windows.Forms.BindingSource bdsMH;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.ComboBox ComboBox_MAMH;
        private System.Windows.Forms.ComboBox ComboBox_TD;
        private System.Windows.Forms.Label label_TD;
        private DevExpress.XtraEditors.DateEdit DateEdit_NgayThi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bdsLop;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.ComboBox ComboBox_MALOP;
        private DevExpress.XtraEditors.SpinEdit SpinEdit_LAN;
        private DevExpress.XtraEditors.SpinEdit SpinEdit_SCT;
        private DevExpress.XtraEditors.SpinEdit SpinEdit_TG;
    }
}