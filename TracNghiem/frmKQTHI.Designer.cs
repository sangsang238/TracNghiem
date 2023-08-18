namespace TracNghiem
{
    partial class frmKQTHI
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
            this.tENMHLabel = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbbMH = new System.Windows.Forms.ComboBox();
            this.bdsMH = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new TracNghiem.DS();
            this.spin_Lanthi = new DevExpress.XtraEditors.SpinEdit();
            this.btnPreview = new System.Windows.Forms.Button();
            this.labelNgayThi = new System.Windows.Forms.Label();
            this.labelHoTen = new System.Windows.Forms.Label();
            this.labelLop = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInBC = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbLanThi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbTenMonhoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dSReport = new TracNghiem.DSReport();
            this.bdsINBAITHI = new System.Windows.Forms.BindingSource(this.components);
            this.sP_INBAITHITableAdapter = new TracNghiem.DSReportTableAdapters.SP_INBAITHITableAdapter();
            this.tableAdapterManager = new TracNghiem.DSReportTableAdapters.TableAdapterManager();
            this.sP_INBAITHIGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTTTRONGBAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTTTRONGDE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOIDUNG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDAP_AN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDAP_AN_DA_CHON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mONHOCTableAdapter = new TracNghiem.DSTableAdapters.MONHOCTableAdapter();
            this.tableAdapterManager1 = new TracNghiem.DSTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spin_Lanthi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsINBAITHI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_INBAITHIGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tENMHLabel
            // 
            this.tENMHLabel.AutoSize = true;
            this.tENMHLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tENMHLabel.Location = new System.Drawing.Point(123, 112);
            this.tENMHLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tENMHLabel.Name = "tENMHLabel";
            this.tENMHLabel.Size = new System.Drawing.Size(0, 19);
            this.tENMHLabel.TabIndex = 39;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cbbMH);
            this.groupControl1.Controls.Add(this.spin_Lanthi);
            this.groupControl1.Controls.Add(this.btnPreview);
            this.groupControl1.Controls.Add(this.tENMHLabel);
            this.groupControl1.Controls.Add(this.labelNgayThi);
            this.groupControl1.Controls.Add(this.labelHoTen);
            this.groupControl1.Controls.Add(this.labelLop);
            this.groupControl1.Controls.Add(this.label9);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.btnInBC);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.cbbLanThi);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.cbbTenMonhoc);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1370, 190);
            this.groupControl1.TabIndex = 15;
            // 
            // cbbMH
            // 
            this.cbbMH.DataSource = this.bdsMH;
            this.cbbMH.DisplayMember = "TENMH";
            this.cbbMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMH.FormattingEnabled = true;
            this.cbbMH.Location = new System.Drawing.Point(436, 43);
            this.cbbMH.Name = "cbbMH";
            this.cbbMH.Size = new System.Drawing.Size(245, 27);
            this.cbbMH.TabIndex = 45;
            this.cbbMH.ValueMember = "MAMH";
            this.cbbMH.SelectedIndexChanged += new System.EventHandler(this.cbbMH_SelectedIndexChanged);
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
            // spin_Lanthi
            // 
            this.spin_Lanthi.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spin_Lanthi.Location = new System.Drawing.Point(828, 43);
            this.spin_Lanthi.Margin = new System.Windows.Forms.Padding(2);
            this.spin_Lanthi.Name = "spin_Lanthi";
            this.spin_Lanthi.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spin_Lanthi.Properties.Appearance.Options.UseFont = true;
            this.spin_Lanthi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spin_Lanthi.Properties.IsFloatValue = false;
            this.spin_Lanthi.Properties.Mask.EditMask = "N00";
            this.spin_Lanthi.Properties.MaxValue = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.spin_Lanthi.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spin_Lanthi.Size = new System.Drawing.Size(70, 26);
            this.spin_Lanthi.TabIndex = 44;
            this.spin_Lanthi.EditValueChanged += new System.EventHandler(this.spin_Lanthi_EditValueChanged);
            // 
            // btnPreview
            // 
            this.btnPreview.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Location = new System.Drawing.Point(352, 116);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(113, 38);
            this.btnPreview.TabIndex = 42;
            this.btnPreview.Text = "Xem trước";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // labelNgayThi
            // 
            this.labelNgayThi.AutoSize = true;
            this.labelNgayThi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgayThi.Location = new System.Drawing.Point(173, 126);
            this.labelNgayThi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNgayThi.Name = "labelNgayThi";
            this.labelNgayThi.Size = new System.Drawing.Size(97, 19);
            this.labelNgayThi.TabIndex = 39;
            this.labelNgayThi.Text = "dd/MM/yyyy";
            // 
            // labelHoTen
            // 
            this.labelHoTen.AutoSize = true;
            this.labelHoTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoTen.Location = new System.Drawing.Point(173, 45);
            this.labelHoTen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHoTen.Name = "labelHoTen";
            this.labelHoTen.Size = new System.Drawing.Size(86, 19);
            this.labelHoTen.TabIndex = 37;
            this.labelHoTen.Text = "labelHoTen";
            // 
            // labelLop
            // 
            this.labelLop.AutoSize = true;
            this.labelLop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLop.Location = new System.Drawing.Point(173, 85);
            this.labelLop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLop.Name = "labelLop";
            this.labelLop.Size = new System.Drawing.Size(67, 19);
            this.labelLop.TabIndex = 36;
            this.labelLop.Text = "labelLop";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(90, 126);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 19);
            this.label9.TabIndex = 35;
            this.label9.Text = "Ngày Thi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(90, 45);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 19);
            this.label7.TabIndex = 33;
            this.label7.Text = "Họ Tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 19);
            this.label2.TabIndex = 32;
            this.label2.Text = "Lớp:";
            // 
            // btnInBC
            // 
            this.btnInBC.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInBC.Location = new System.Drawing.Point(501, 114);
            this.btnInBC.Margin = new System.Windows.Forms.Padding(2);
            this.btnInBC.Name = "btnInBC";
            this.btnInBC.Size = new System.Drawing.Size(113, 40);
            this.btnInBC.TabIndex = 30;
            this.btnInBC.Text = "In Báo Cáo";
            this.btnInBC.UseVisualStyleBackColor = true;
            this.btnInBC.Click += new System.EventHandler(this.btnInBC_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(749, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Lần thi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(349, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Môn học";
            // 
            // cbbLanThi
            // 
            this.cbbLanThi.FormattingEnabled = true;
            this.cbbLanThi.Location = new System.Drawing.Point(2929, 137);
            this.cbbLanThi.Name = "cbbLanThi";
            this.cbbLanThi.Size = new System.Drawing.Size(179, 21);
            this.cbbLanThi.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2769, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lần thi";
            // 
            // cbbTenMonhoc
            // 
            this.cbbTenMonhoc.FormattingEnabled = true;
            this.cbbTenMonhoc.Location = new System.Drawing.Point(2052, 109);
            this.cbbTenMonhoc.Name = "cbbTenMonhoc";
            this.cbbTenMonhoc.Size = new System.Drawing.Size(463, 21);
            this.cbbTenMonhoc.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1831, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên mô học";
            // 
            // dSReport
            // 
            this.dSReport.DataSetName = "DSReport";
            this.dSReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsINBAITHI
            // 
            this.bdsINBAITHI.DataMember = "SP_INBAITHI";
            this.bdsINBAITHI.DataSource = this.dSReport;
            // 
            // sP_INBAITHITableAdapter
            // 
            this.sP_INBAITHITableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = TracNghiem.DSReportTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sP_INBAITHIGridControl
            // 
            this.sP_INBAITHIGridControl.DataSource = this.bdsINBAITHI;
            this.sP_INBAITHIGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sP_INBAITHIGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.sP_INBAITHIGridControl.Location = new System.Drawing.Point(0, 190);
            this.sP_INBAITHIGridControl.MainView = this.gridView1;
            this.sP_INBAITHIGridControl.Margin = new System.Windows.Forms.Padding(2);
            this.sP_INBAITHIGridControl.Name = "sP_INBAITHIGridControl";
            this.sP_INBAITHIGridControl.Size = new System.Drawing.Size(1370, 235);
            this.sP_INBAITHIGridControl.TabIndex = 17;
            this.sP_INBAITHIGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTTTRONGBAI,
            this.colSTTTRONGDE,
            this.colNOIDUNG,
            this.colA,
            this.colB,
            this.colC,
            this.colD,
            this.colDAP_AN,
            this.colDAP_AN_DA_CHON});
            this.gridView1.DetailHeight = 227;
            this.gridView1.FixedLineWidth = 1;
            this.gridView1.GridControl = this.sP_INBAITHIGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colSTTTRONGBAI
            // 
            this.colSTTTRONGBAI.Caption = "STT";
            this.colSTTTRONGBAI.FieldName = "STTTRONGBAI";
            this.colSTTTRONGBAI.Name = "colSTTTRONGBAI";
            this.colSTTTRONGBAI.Visible = true;
            this.colSTTTRONGBAI.VisibleIndex = 0;
            // 
            // colSTTTRONGDE
            // 
            this.colSTTTRONGDE.Caption = "Câu trong bộ đề";
            this.colSTTTRONGDE.FieldName = "STTTRONGDE";
            this.colSTTTRONGDE.Name = "colSTTTRONGDE";
            this.colSTTTRONGDE.Visible = true;
            this.colSTTTRONGDE.VisibleIndex = 1;
            // 
            // colNOIDUNG
            // 
            this.colNOIDUNG.Caption = "Nội dung câu hỏi";
            this.colNOIDUNG.FieldName = "NOIDUNG";
            this.colNOIDUNG.Name = "colNOIDUNG";
            this.colNOIDUNG.Visible = true;
            this.colNOIDUNG.VisibleIndex = 2;
            // 
            // colA
            // 
            this.colA.Caption = "A";
            this.colA.FieldName = "A";
            this.colA.Name = "colA";
            this.colA.Visible = true;
            this.colA.VisibleIndex = 3;
            // 
            // colB
            // 
            this.colB.Caption = "B";
            this.colB.FieldName = "B";
            this.colB.Name = "colB";
            this.colB.Visible = true;
            this.colB.VisibleIndex = 4;
            // 
            // colC
            // 
            this.colC.Caption = "C";
            this.colC.FieldName = "C";
            this.colC.Name = "colC";
            this.colC.Visible = true;
            this.colC.VisibleIndex = 5;
            // 
            // colD
            // 
            this.colD.Caption = "D";
            this.colD.FieldName = "D";
            this.colD.Name = "colD";
            this.colD.Visible = true;
            this.colD.VisibleIndex = 6;
            // 
            // colDAP_AN
            // 
            this.colDAP_AN.Caption = "Đáp án";
            this.colDAP_AN.FieldName = "DAP_AN";
            this.colDAP_AN.Name = "colDAP_AN";
            this.colDAP_AN.Visible = true;
            this.colDAP_AN.VisibleIndex = 7;
            // 
            // colDAP_AN_DA_CHON
            // 
            this.colDAP_AN_DA_CHON.Caption = "Đáp án đã chọn";
            this.colDAP_AN_DA_CHON.FieldName = "DAP_AN_DA_CHON";
            this.colDAP_AN_DA_CHON.Name = "colDAP_AN_DA_CHON";
            this.colDAP_AN_DA_CHON.Visible = true;
            this.colDAP_AN_DA_CHON.VisibleIndex = 8;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager1.LOPTableAdapter = null;
            this.tableAdapterManager1.MONHOCTableAdapter = this.mONHOCTableAdapter;
            this.tableAdapterManager1.SINHVIENTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = TracNghiem.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmKQTHI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1370, 425);
            this.Controls.Add(this.sP_INBAITHIGridControl);
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmKQTHI";
            this.Text = "Kết Quả Bài Thi";
            this.Load += new System.EventHandler(this.frmKQTHI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spin_Lanthi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsINBAITHI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_INBAITHIGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbLanThi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbTenMonhoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInBC;
        private DSReport dSReport;
        private System.Windows.Forms.BindingSource bdsINBAITHI;
        private DSReportTableAdapters.SP_INBAITHITableAdapter sP_INBAITHITableAdapter;
        private DSReportTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl sP_INBAITHIGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.Columns.GridColumn colSTTTRONGBAI;
        private DevExpress.XtraGrid.Columns.GridColumn colSTTTRONGDE;
        private DevExpress.XtraGrid.Columns.GridColumn colNOIDUNG;
        private DevExpress.XtraGrid.Columns.GridColumn colA;
        private DevExpress.XtraGrid.Columns.GridColumn colB;
        private DevExpress.XtraGrid.Columns.GridColumn colC;
        private DevExpress.XtraGrid.Columns.GridColumn colD;
        private DevExpress.XtraGrid.Columns.GridColumn colDAP_AN;
        private DevExpress.XtraGrid.Columns.GridColumn colDAP_AN_DA_CHON;
        private System.Windows.Forms.Label labelNgayThi;
        private System.Windows.Forms.Label labelHoTen;
        private System.Windows.Forms.Label labelLop;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Label tENMHLabel;
        private DevExpress.XtraEditors.SpinEdit spin_Lanthi;
        private DS DS;
        private System.Windows.Forms.BindingSource bdsMH;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ComboBox cbbMH;
    }
}