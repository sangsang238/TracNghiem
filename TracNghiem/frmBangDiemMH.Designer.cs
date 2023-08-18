namespace TracNghiem
{
    partial class frmBangDiemMH
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
            this.comboBox_TenCN = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gcBangDiem = new DevExpress.XtraEditors.GroupControl();
            this.cbboxMH = new System.Windows.Forms.ComboBox();
            this.bdsMH = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new TracNghiem.DS();
            this.cbboxLOP = new System.Windows.Forms.ComboBox();
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.spinEditLAN = new DevExpress.XtraEditors.SpinEdit();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnInBC = new System.Windows.Forms.Button();
            this.dSReport = new TracNghiem.DSReport();
            this.sP_BANGDIEMMHGridControl = new DevExpress.XtraGrid.GridControl();
            this.bdsBANGDIEMMH = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEMCHU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sP_BANGDIEMMHTableAdapter = new TracNghiem.DSReportTableAdapters.SP_BANGDIEMMHTableAdapter();
            this.tableAdapterManager = new TracNghiem.DSReportTableAdapters.TableAdapterManager();
            this.lOPTableAdapter = new TracNghiem.DSTableAdapters.LOPTableAdapter();
            this.tableAdapterManager1 = new TracNghiem.DSTableAdapters.TableAdapterManager();
            this.mONHOCTableAdapter = new TracNghiem.DSTableAdapters.MONHOCTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gcBangDiem)).BeginInit();
            this.gcBangDiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditLAN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_BANGDIEMMHGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBANGDIEMMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_TenCN
            // 
            this.comboBox_TenCN.DisplayMember = "TENCN";
            this.comboBox_TenCN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TenCN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_TenCN.FormattingEnabled = true;
            this.comboBox_TenCN.Location = new System.Drawing.Point(267, 39);
            this.comboBox_TenCN.Name = "comboBox_TenCN";
            this.comboBox_TenCN.Size = new System.Drawing.Size(237, 27);
            this.comboBox_TenCN.TabIndex = 3;
            this.comboBox_TenCN.ValueMember = "TENSERVER";
            this.comboBox_TenCN.SelectedIndexChanged += new System.EventHandler(this.comboBox_TenCN_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(189, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cơ Sở";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(640, 104);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Lần thi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(305, 103);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Môn học";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Lớp";
            // 
            // gcBangDiem
            // 
            this.gcBangDiem.Controls.Add(this.cbboxMH);
            this.gcBangDiem.Controls.Add(this.cbboxLOP);
            this.gcBangDiem.Controls.Add(this.spinEditLAN);
            this.gcBangDiem.Controls.Add(this.btnPreview);
            this.gcBangDiem.Controls.Add(this.btnInBC);
            this.gcBangDiem.Controls.Add(this.label6);
            this.gcBangDiem.Controls.Add(this.label5);
            this.gcBangDiem.Controls.Add(this.label1);
            this.gcBangDiem.Controls.Add(this.comboBox_TenCN);
            this.gcBangDiem.Controls.Add(this.label2);
            this.gcBangDiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcBangDiem.Location = new System.Drawing.Point(0, 0);
            this.gcBangDiem.Name = "gcBangDiem";
            this.gcBangDiem.Size = new System.Drawing.Size(794, 233);
            this.gcBangDiem.TabIndex = 2;
            this.gcBangDiem.Text = "Thông Tin";
            // 
            // cbboxMH
            // 
            this.cbboxMH.DataSource = this.bdsMH;
            this.cbboxMH.DisplayMember = "TENMH";
            this.cbboxMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbboxMH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbboxMH.FormattingEnabled = true;
            this.cbboxMH.Location = new System.Drawing.Point(380, 101);
            this.cbboxMH.Name = "cbboxMH";
            this.cbboxMH.Size = new System.Drawing.Size(224, 27);
            this.cbboxMH.TabIndex = 47;
            this.cbboxMH.ValueMember = "MAMH";
            this.cbboxMH.SelectedIndexChanged += new System.EventHandler(this.cbboxMH_SelectedIndexChanged);
            // 
            // bdsMH
            // 
            this.bdsMH.DataMember = "MONHOC";
            this.bdsMH.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbboxLOP
            // 
            this.cbboxLOP.DataSource = this.bdsLop;
            this.cbboxLOP.DisplayMember = "TENLOP";
            this.cbboxLOP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbboxLOP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbboxLOP.FormattingEnabled = true;
            this.cbboxLOP.Location = new System.Drawing.Point(94, 102);
            this.cbboxLOP.Name = "cbboxLOP";
            this.cbboxLOP.Size = new System.Drawing.Size(160, 27);
            this.cbboxLOP.TabIndex = 46;
            this.cbboxLOP.ValueMember = "MALOP";
            this.cbboxLOP.SelectedIndexChanged += new System.EventHandler(this.cbboxLOP_SelectedIndexChanged);
            // 
            // bdsLop
            // 
            this.bdsLop.DataMember = "LOP";
            this.bdsLop.DataSource = this.DS;
            // 
            // spinEditLAN
            // 
            this.spinEditLAN.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditLAN.Location = new System.Drawing.Point(713, 101);
            this.spinEditLAN.Margin = new System.Windows.Forms.Padding(2);
            this.spinEditLAN.Name = "spinEditLAN";
            this.spinEditLAN.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinEditLAN.Properties.Appearance.Options.UseFont = true;
            this.spinEditLAN.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditLAN.Properties.IsFloatValue = false;
            this.spinEditLAN.Properties.Mask.EditMask = "N00";
            this.spinEditLAN.Properties.MaxValue = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.spinEditLAN.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditLAN.Size = new System.Drawing.Size(70, 26);
            this.spinEditLAN.TabIndex = 45;
            this.spinEditLAN.EditValueChanged += new System.EventHandler(this.spinEditLAN_EditValueChanged);
            // 
            // btnPreview
            // 
            this.btnPreview.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Location = new System.Drawing.Point(226, 173);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(113, 40);
            this.btnPreview.TabIndex = 44;
            this.btnPreview.Text = "Xem trước";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnInBC
            // 
            this.btnInBC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInBC.Location = new System.Drawing.Point(416, 173);
            this.btnInBC.Margin = new System.Windows.Forms.Padding(2);
            this.btnInBC.Name = "btnInBC";
            this.btnInBC.Size = new System.Drawing.Size(113, 40);
            this.btnInBC.TabIndex = 28;
            this.btnInBC.Text = "In Báo Cáo";
            this.btnInBC.UseVisualStyleBackColor = true;
            this.btnInBC.Click += new System.EventHandler(this.btnInBC_Click);
            // 
            // dSReport
            // 
            this.dSReport.DataSetName = "DSReport";
            this.dSReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_BANGDIEMMHGridControl
            // 
            this.sP_BANGDIEMMHGridControl.DataSource = this.bdsBANGDIEMMH;
            this.sP_BANGDIEMMHGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sP_BANGDIEMMHGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.sP_BANGDIEMMHGridControl.Location = new System.Drawing.Point(0, 233);
            this.sP_BANGDIEMMHGridControl.MainView = this.gridView1;
            this.sP_BANGDIEMMHGridControl.Margin = new System.Windows.Forms.Padding(2);
            this.sP_BANGDIEMMHGridControl.Name = "sP_BANGDIEMMHGridControl";
            this.sP_BANGDIEMMHGridControl.Size = new System.Drawing.Size(794, 248);
            this.sP_BANGDIEMMHGridControl.TabIndex = 4;
            this.sP_BANGDIEMMHGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bdsBANGDIEMMH
            // 
            this.bdsBANGDIEMMH.DataMember = "SP_BANGDIEMMH";
            this.bdsBANGDIEMMH.DataSource = this.dSReport;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colHO,
            this.colTEN,
            this.colDIEM,
            this.colDIEMCHU});
            this.gridView1.DetailHeight = 227;
            this.gridView1.FixedLineWidth = 1;
            this.gridView1.GridControl = this.sP_BANGDIEMMHGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colMASV
            // 
            this.colMASV.Caption = "Mã Sinh Viên";
            this.colMASV.FieldName = "MASV";
            this.colMASV.Name = "colMASV";
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
            // 
            // colHO
            // 
            this.colHO.Caption = "Họ";
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "Tên";
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            // 
            // colDIEM
            // 
            this.colDIEM.Caption = "Điểm";
            this.colDIEM.FieldName = "DIEM";
            this.colDIEM.Name = "colDIEM";
            this.colDIEM.Visible = true;
            this.colDIEM.VisibleIndex = 3;
            // 
            // colDIEMCHU
            // 
            this.colDIEMCHU.Caption = "Điểm Chữ";
            this.colDIEMCHU.FieldName = "DIEMCHU";
            this.colDIEMCHU.Name = "colDIEMCHU";
            this.colDIEMCHU.Visible = true;
            this.colDIEMCHU.VisibleIndex = 4;
            // 
            // sP_BANGDIEMMHTableAdapter
            // 
            this.sP_BANGDIEMMHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = TracNghiem.DSReportTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.BANGDIEMTableAdapter = null;
            this.tableAdapterManager1.BODETableAdapter = null;
            this.tableAdapterManager1.CHITIETBAITHITableAdapter = null;
            this.tableAdapterManager1.COSOTableAdapter = null;
            this.tableAdapterManager1.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager1.GIAOVIENTableAdapter = null;
            this.tableAdapterManager1.KHOATableAdapter = null;
            this.tableAdapterManager1.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager1.MONHOCTableAdapter = this.mONHOCTableAdapter;
            this.tableAdapterManager1.SINHVIENTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = TracNghiem.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // frmBangDiemMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 481);
            this.Controls.Add(this.sP_BANGDIEMMHGridControl);
            this.Controls.Add(this.gcBangDiem);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmBangDiemMH";
            this.Text = "Bảng Điểm Môn Học";
            this.Load += new System.EventHandler(this.frmBangDiemMH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcBangDiem)).EndInit();
            this.gcBangDiem.ResumeLayout(false);
            this.gcBangDiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditLAN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_BANGDIEMMHGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBANGDIEMMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox_TenCN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl gcBangDiem;
        private System.Windows.Forms.Button btnInBC;
        //private DSReportTableAdapters.SP_DSLANTHIDKTableAdapter sP_DSLANTHIDKTableAdapter;
        private System.Windows.Forms.Button btnPreview;
        private DevExpress.XtraGrid.GridControl sP_BANGDIEMMHGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEMCHU;
        private DSReport dSReport;
        private System.Windows.Forms.BindingSource bdsBANGDIEMMH;
        private DSReportTableAdapters.SP_BANGDIEMMHTableAdapter sP_BANGDIEMMHTableAdapter;
        private DSReportTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.SpinEdit spinEditLAN;
        private DS DS;
        private System.Windows.Forms.BindingSource bdsLop;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ComboBox cbboxLOP;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.BindingSource bdsMH;
        private System.Windows.Forms.ComboBox cbboxMH;
    }
}