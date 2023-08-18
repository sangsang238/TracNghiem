namespace TracNghiem
{
    partial class frmNhapDe
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
            System.Windows.Forms.Label cAUHOILabel;
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label tRINHDOLabel;
            System.Windows.Forms.Label nOIDUNGLabel;
            System.Windows.Forms.Label aLabel;
            System.Windows.Forms.Label bLabel;
            System.Windows.Forms.Label cLabel;
            System.Windows.Forms.Label dLabel;
            System.Windows.Forms.Label dAP_ANLabel;
            System.Windows.Forms.Label mAGVLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapDe));
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
            this.DS = new TracNghiem.DS();
            this.bdsBD = new System.Windows.Forms.BindingSource(this.components);
            this.bODETableAdapter = new TracNghiem.DSTableAdapters.BODETableAdapter();
            this.tableAdapterManager = new TracNghiem.DSTableAdapters.TableAdapterManager();
            this.mONHOCTableAdapter = new TracNghiem.DSTableAdapters.MONHOCTableAdapter();
            this.GridControl_BODE = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCAUHOI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRINHDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOIDUNG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDAP_AN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label_TD = new System.Windows.Forms.Label();
            this.ComboBox_TD = new System.Windows.Forms.ComboBox();
            this.TextBox_MAGV = new System.Windows.Forms.TextBox();
            this.ComboBox_DA = new System.Windows.Forms.ComboBox();
            this.TextBox_D = new System.Windows.Forms.TextBox();
            this.TextBox_C = new System.Windows.Forms.TextBox();
            this.TextBox_B = new System.Windows.Forms.TextBox();
            this.TextBox_A = new System.Windows.Forms.TextBox();
            this.TextBox_ND = new System.Windows.Forms.TextBox();
            this.ComboBox_MAMH = new System.Windows.Forms.ComboBox();
            this.bdsMH = new System.Windows.Forms.BindingSource(this.components);
            this.TextBox_CH = new System.Windows.Forms.TextBox();
            cAUHOILabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            tRINHDOLabel = new System.Windows.Forms.Label();
            nOIDUNGLabel = new System.Windows.Forms.Label();
            aLabel = new System.Windows.Forms.Label();
            bLabel = new System.Windows.Forms.Label();
            cLabel = new System.Windows.Forms.Label();
            dLabel = new System.Windows.Forms.Label();
            dAP_ANLabel = new System.Windows.Forms.Label();
            mAGVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl_BODE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMH)).BeginInit();
            this.SuspendLayout();
            // 
            // cAUHOILabel
            // 
            cAUHOILabel.AutoSize = true;
            cAUHOILabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cAUHOILabel.Location = new System.Drawing.Point(35, 66);
            cAUHOILabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cAUHOILabel.Name = "cAUHOILabel";
            cAUHOILabel.Size = new System.Drawing.Size(86, 21);
            cAUHOILabel.TabIndex = 0;
            cAUHOILabel.Text = "CAUHOI:";
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAMHLabel.Location = new System.Drawing.Point(48, 123);
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
            tRINHDOLabel.Location = new System.Drawing.Point(27, 185);
            tRINHDOLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tRINHDOLabel.Name = "tRINHDOLabel";
            tRINHDOLabel.Size = new System.Drawing.Size(98, 21);
            tRINHDOLabel.TabIndex = 5;
            tRINHDOLabel.Text = "TRINHDO:";
            // 
            // nOIDUNGLabel
            // 
            nOIDUNGLabel.AutoSize = true;
            nOIDUNGLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nOIDUNGLabel.Location = new System.Drawing.Point(577, 58);
            nOIDUNGLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nOIDUNGLabel.Name = "nOIDUNGLabel";
            nOIDUNGLabel.Size = new System.Drawing.Size(100, 21);
            nOIDUNGLabel.TabIndex = 7;
            nOIDUNGLabel.Text = "NOIDUNG:";
            // 
            // aLabel
            // 
            aLabel.AutoSize = true;
            aLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            aLabel.Location = new System.Drawing.Point(631, 103);
            aLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            aLabel.Name = "aLabel";
            aLabel.Size = new System.Drawing.Size(27, 21);
            aLabel.TabIndex = 9;
            aLabel.Text = "A:";
            // 
            // bLabel
            // 
            bLabel.AutoSize = true;
            bLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bLabel.Location = new System.Drawing.Point(632, 144);
            bLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            bLabel.Name = "bLabel";
            bLabel.Size = new System.Drawing.Size(26, 21);
            bLabel.TabIndex = 11;
            bLabel.Text = "B:";
            // 
            // cLabel
            // 
            cLabel.AutoSize = true;
            cLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cLabel.Location = new System.Drawing.Point(631, 186);
            cLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cLabel.Name = "cLabel";
            cLabel.Size = new System.Drawing.Size(27, 21);
            cLabel.TabIndex = 13;
            cLabel.Text = "C:";
            // 
            // dLabel
            // 
            dLabel.AutoSize = true;
            dLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dLabel.Location = new System.Drawing.Point(632, 225);
            dLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dLabel.Name = "dLabel";
            dLabel.Size = new System.Drawing.Size(27, 21);
            dLabel.TabIndex = 15;
            dLabel.Text = "D:";
            // 
            // dAP_ANLabel
            // 
            dAP_ANLabel.AutoSize = true;
            dAP_ANLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dAP_ANLabel.Location = new System.Drawing.Point(592, 268);
            dAP_ANLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dAP_ANLabel.Name = "dAP_ANLabel";
            dAP_ANLabel.Size = new System.Drawing.Size(80, 21);
            dAP_ANLabel.TabIndex = 17;
            dAP_ANLabel.Text = "DAP AN:";
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAGVLabel.Location = new System.Drawing.Point(51, 245);
            mAGVLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(69, 21);
            mAGVLabel.TabIndex = 19;
            mAGVLabel.Text = "MAGV:";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1812, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 601);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1812, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 601);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1812, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 601);
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsBD
            // 
            this.bdsBD.DataMember = "BODE";
            this.bdsBD.DataSource = this.DS;
            // 
            // bODETableAdapter
            // 
            this.bODETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = this.bODETableAdapter;
            this.tableAdapterManager.CHITIETBAITHITableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = this.mONHOCTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TracNghiem.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // GridControl_BODE
            // 
            this.GridControl_BODE.DataSource = this.bdsBD;
            this.GridControl_BODE.Dock = System.Windows.Forms.DockStyle.Top;
            // 
            // 
            // 
            this.GridControl_BODE.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.GridControl_BODE.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridControl_BODE.Location = new System.Drawing.Point(0, 0);
            this.GridControl_BODE.MainView = this.gridView1;
            this.GridControl_BODE.Margin = new System.Windows.Forms.Padding(4);
            this.GridControl_BODE.MenuManager = this.barManager1;
            this.GridControl_BODE.Name = "GridControl_BODE";
            this.GridControl_BODE.Size = new System.Drawing.Size(1812, 257);
            this.GridControl_BODE.TabIndex = 5;
            this.GridControl_BODE.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCAUHOI,
            this.colMAMH,
            this.colTRINHDO,
            this.colNOIDUNG,
            this.colA,
            this.colB,
            this.colC,
            this.colD,
            this.colDAP_AN,
            this.colMAGV});
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.GridControl_BODE;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colCAUHOI
            // 
            this.colCAUHOI.FieldName = "CAUHOI";
            this.colCAUHOI.MinWidth = 27;
            this.colCAUHOI.Name = "colCAUHOI";
            this.colCAUHOI.Visible = true;
            this.colCAUHOI.VisibleIndex = 0;
            this.colCAUHOI.Width = 100;
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
            // colTRINHDO
            // 
            this.colTRINHDO.FieldName = "TRINHDO";
            this.colTRINHDO.MinWidth = 27;
            this.colTRINHDO.Name = "colTRINHDO";
            this.colTRINHDO.Visible = true;
            this.colTRINHDO.VisibleIndex = 2;
            this.colTRINHDO.Width = 100;
            // 
            // colNOIDUNG
            // 
            this.colNOIDUNG.FieldName = "NOIDUNG";
            this.colNOIDUNG.MinWidth = 27;
            this.colNOIDUNG.Name = "colNOIDUNG";
            this.colNOIDUNG.Visible = true;
            this.colNOIDUNG.VisibleIndex = 3;
            this.colNOIDUNG.Width = 100;
            // 
            // colA
            // 
            this.colA.FieldName = "A";
            this.colA.MinWidth = 27;
            this.colA.Name = "colA";
            this.colA.Visible = true;
            this.colA.VisibleIndex = 4;
            this.colA.Width = 100;
            // 
            // colB
            // 
            this.colB.FieldName = "B";
            this.colB.MinWidth = 27;
            this.colB.Name = "colB";
            this.colB.Visible = true;
            this.colB.VisibleIndex = 5;
            this.colB.Width = 100;
            // 
            // colC
            // 
            this.colC.FieldName = "C";
            this.colC.MinWidth = 27;
            this.colC.Name = "colC";
            this.colC.Visible = true;
            this.colC.VisibleIndex = 6;
            this.colC.Width = 100;
            // 
            // colD
            // 
            this.colD.FieldName = "D";
            this.colD.MinWidth = 27;
            this.colD.Name = "colD";
            this.colD.Visible = true;
            this.colD.VisibleIndex = 7;
            this.colD.Width = 100;
            // 
            // colDAP_AN
            // 
            this.colDAP_AN.FieldName = "DAP_AN";
            this.colDAP_AN.MinWidth = 27;
            this.colDAP_AN.Name = "colDAP_AN";
            this.colDAP_AN.Visible = true;
            this.colDAP_AN.VisibleIndex = 8;
            this.colDAP_AN.Width = 100;
            // 
            // colMAGV
            // 
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.MinWidth = 27;
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 9;
            this.colMAGV.Width = 100;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.label_TD);
            this.groupControl1.Controls.Add(this.ComboBox_TD);
            this.groupControl1.Controls.Add(mAGVLabel);
            this.groupControl1.Controls.Add(this.TextBox_MAGV);
            this.groupControl1.Controls.Add(dAP_ANLabel);
            this.groupControl1.Controls.Add(this.ComboBox_DA);
            this.groupControl1.Controls.Add(dLabel);
            this.groupControl1.Controls.Add(this.TextBox_D);
            this.groupControl1.Controls.Add(cLabel);
            this.groupControl1.Controls.Add(this.TextBox_C);
            this.groupControl1.Controls.Add(bLabel);
            this.groupControl1.Controls.Add(this.TextBox_B);
            this.groupControl1.Controls.Add(aLabel);
            this.groupControl1.Controls.Add(this.TextBox_A);
            this.groupControl1.Controls.Add(nOIDUNGLabel);
            this.groupControl1.Controls.Add(this.TextBox_ND);
            this.groupControl1.Controls.Add(tRINHDOLabel);
            this.groupControl1.Controls.Add(mAMHLabel);
            this.groupControl1.Controls.Add(this.ComboBox_MAMH);
            this.groupControl1.Controls.Add(cAUHOILabel);
            this.groupControl1.Controls.Add(this.TextBox_CH);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 257);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1812, 344);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "groupControl1";
            // 
            // label_TD
            // 
            this.label_TD.AutoSize = true;
            this.label_TD.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.label_TD.Location = new System.Drawing.Point(293, 181);
            this.label_TD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TD.Name = "label_TD";
            this.label_TD.Size = new System.Drawing.Size(116, 21);
            this.label_TD.TabIndex = 22;
            this.label_TD.Text = "Chọn trình độ";
            // 
            // ComboBox_TD
            // 
            this.ComboBox_TD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsBD, "TRINHDO", true));
            this.ComboBox_TD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_TD.Font = new System.Drawing.Font("Tahoma", 11F);
            this.ComboBox_TD.FormattingEnabled = true;
            this.ComboBox_TD.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.ComboBox_TD.Location = new System.Drawing.Point(151, 175);
            this.ComboBox_TD.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBox_TD.Name = "ComboBox_TD";
            this.ComboBox_TD.Size = new System.Drawing.Size(124, 30);
            this.ComboBox_TD.TabIndex = 21;
            this.ComboBox_TD.SelectedIndexChanged += new System.EventHandler(this.ComboBox_TD_SelectedIndexChanged);
            // 
            // TextBox_MAGV
            // 
            this.TextBox_MAGV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsBD, "MAGV", true));
            this.TextBox_MAGV.Enabled = false;
            this.TextBox_MAGV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_MAGV.Location = new System.Drawing.Point(151, 242);
            this.TextBox_MAGV.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_MAGV.Name = "TextBox_MAGV";
            this.TextBox_MAGV.Size = new System.Drawing.Size(124, 29);
            this.TextBox_MAGV.TabIndex = 20;
            this.TextBox_MAGV.TextChanged += new System.EventHandler(this.TextBox_MAGV_TextChanged);
            // 
            // ComboBox_DA
            // 
            this.ComboBox_DA.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsBD, "DAP_AN", true));
            this.ComboBox_DA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_DA.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_DA.FormattingEnabled = true;
            this.ComboBox_DA.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.ComboBox_DA.Location = new System.Drawing.Point(711, 265);
            this.ComboBox_DA.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBox_DA.Name = "ComboBox_DA";
            this.ComboBox_DA.Size = new System.Drawing.Size(141, 29);
            this.ComboBox_DA.TabIndex = 18;
            // 
            // TextBox_D
            // 
            this.TextBox_D.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsBD, "D", true));
            this.TextBox_D.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_D.Location = new System.Drawing.Point(711, 222);
            this.TextBox_D.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_D.Name = "TextBox_D";
            this.TextBox_D.Size = new System.Drawing.Size(1073, 29);
            this.TextBox_D.TabIndex = 16;
            // 
            // TextBox_C
            // 
            this.TextBox_C.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsBD, "C", true));
            this.TextBox_C.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_C.Location = new System.Drawing.Point(709, 182);
            this.TextBox_C.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_C.Name = "TextBox_C";
            this.TextBox_C.Size = new System.Drawing.Size(1075, 29);
            this.TextBox_C.TabIndex = 14;
            // 
            // TextBox_B
            // 
            this.TextBox_B.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsBD, "B", true));
            this.TextBox_B.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_B.Location = new System.Drawing.Point(709, 140);
            this.TextBox_B.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_B.Name = "TextBox_B";
            this.TextBox_B.Size = new System.Drawing.Size(1075, 29);
            this.TextBox_B.TabIndex = 12;
            // 
            // TextBox_A
            // 
            this.TextBox_A.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsBD, "A", true));
            this.TextBox_A.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_A.Location = new System.Drawing.Point(709, 100);
            this.TextBox_A.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_A.Name = "TextBox_A";
            this.TextBox_A.Size = new System.Drawing.Size(1075, 29);
            this.TextBox_A.TabIndex = 10;
            // 
            // TextBox_ND
            // 
            this.TextBox_ND.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsBD, "NOIDUNG", true));
            this.TextBox_ND.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_ND.Location = new System.Drawing.Point(709, 54);
            this.TextBox_ND.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_ND.Name = "TextBox_ND";
            this.TextBox_ND.Size = new System.Drawing.Size(1075, 29);
            this.TextBox_ND.TabIndex = 8;
            // 
            // ComboBox_MAMH
            // 
            this.ComboBox_MAMH.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsBD, "MAMH", true));
            this.ComboBox_MAMH.DataSource = this.bdsMH;
            this.ComboBox_MAMH.DisplayMember = "TENMH";
            this.ComboBox_MAMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_MAMH.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_MAMH.FormattingEnabled = true;
            this.ComboBox_MAMH.Location = new System.Drawing.Point(151, 119);
            this.ComboBox_MAMH.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBox_MAMH.Name = "ComboBox_MAMH";
            this.ComboBox_MAMH.Size = new System.Drawing.Size(316, 29);
            this.ComboBox_MAMH.TabIndex = 3;
            this.ComboBox_MAMH.ValueMember = "MAMH";
            this.ComboBox_MAMH.SelectedIndexChanged += new System.EventHandler(this.ComboBox_MAMH_SelectedIndexChanged);
            // 
            // bdsMH
            // 
            this.bdsMH.DataMember = "MONHOC";
            this.bdsMH.DataSource = this.DS;
            // 
            // TextBox_CH
            // 
            this.TextBox_CH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsBD, "CAUHOI", true));
            this.TextBox_CH.Enabled = false;
            this.TextBox_CH.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_CH.Location = new System.Drawing.Point(151, 58);
            this.TextBox_CH.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_CH.Name = "TextBox_CH";
            this.TextBox_CH.Size = new System.Drawing.Size(124, 29);
            this.TextBox_CH.TabIndex = 1;
            // 
            // frmNhapDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1812, 601);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.GridControl_BODE);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNhapDe";
            this.Text = "Bộ đề";
            this.Load += new System.EventHandler(this.frmNhapDe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl_BODE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
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
        private System.Windows.Forms.BindingSource bdsBD;
        private DS DS;
        private DSTableAdapters.BODETableAdapter bODETableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl GridControl_BODE;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox TextBox_CH;
        private DevExpress.XtraGrid.Columns.GridColumn colCAUHOI;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTRINHDO;
        private DevExpress.XtraGrid.Columns.GridColumn colNOIDUNG;
        private DevExpress.XtraGrid.Columns.GridColumn colA;
        private DevExpress.XtraGrid.Columns.GridColumn colB;
        private DevExpress.XtraGrid.Columns.GridColumn colC;
        private DevExpress.XtraGrid.Columns.GridColumn colD;
        private DevExpress.XtraGrid.Columns.GridColumn colDAP_AN;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.BindingSource bdsMH;
        private System.Windows.Forms.ComboBox ComboBox_MAMH;
        private System.Windows.Forms.TextBox TextBox_MAGV;
        private System.Windows.Forms.ComboBox ComboBox_DA;
        private System.Windows.Forms.TextBox TextBox_D;
        private System.Windows.Forms.TextBox TextBox_C;
        private System.Windows.Forms.TextBox TextBox_B;
        private System.Windows.Forms.TextBox TextBox_A;
        private System.Windows.Forms.TextBox TextBox_ND;
        private System.Windows.Forms.ComboBox ComboBox_TD;
        private System.Windows.Forms.Label label_TD;
    }
}