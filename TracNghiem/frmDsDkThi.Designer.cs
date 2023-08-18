namespace TracNghiem
{
    partial class frmDsDkThi
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnInBC = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.dateFrom = new DevExpress.XtraEditors.DateEdit();
            this.dateTo = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dSReport = new TracNghiem.DSReport();
            this.bdsDSDKTHI = new System.Windows.Forms.BindingSource(this.components);
            this.sP_DSDANGKYTHITableAdapter = new TracNghiem.DSReportTableAdapters.SP_DSDANGKYTHITableAdapter();
            this.tableAdapterManager = new TracNghiem.DSReportTableAdapters.TableAdapterManager();
            this.sP_DSDANGKYTHIGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOCAUTHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYTHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDATHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOSO = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSDKTHI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DSDANGKYTHIGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnInBC);
            this.groupControl1.Controls.Add(this.btnPreview);
            this.groupControl1.Controls.Add(this.dateFrom);
            this.groupControl1.Controls.Add(this.dateTo);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(957, 211);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin";
            // 
            // btnInBC
            // 
            this.btnInBC.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInBC.Location = new System.Drawing.Point(520, 138);
            this.btnInBC.Margin = new System.Windows.Forms.Padding(2);
            this.btnInBC.Name = "btnInBC";
            this.btnInBC.Size = new System.Drawing.Size(113, 38);
            this.btnInBC.TabIndex = 25;
            this.btnInBC.Text = "In Báo Cáo";
            this.btnInBC.UseVisualStyleBackColor = true;
            this.btnInBC.Click += new System.EventHandler(this.btnInBC_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Location = new System.Drawing.Point(327, 138);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(113, 38);
            this.btnPreview.TabIndex = 24;
            this.btnPreview.Text = "Xem trước";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // dateFrom
            // 
            this.dateFrom.EditValue = new System.DateTime(2020, 12, 1, 0, 0, 0, 0);
            this.dateFrom.Location = new System.Drawing.Point(341, 64);
            this.dateFrom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFrom.Properties.Appearance.Options.UseFont = true;
            this.dateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFrom.Size = new System.Drawing.Size(125, 28);
            this.dateFrom.TabIndex = 23;
            this.dateFrom.EditValueChanged += new System.EventHandler(this.dateFrom_EditValueChanged);
            // 
            // dateTo
            // 
            this.dateTo.EditValue = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dateTo.Location = new System.Drawing.Point(607, 67);
            this.dateTo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dateTo.Name = "dateTo";
            this.dateTo.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTo.Properties.Appearance.Options.UseFont = true;
            this.dateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTo.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dateTo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateTo.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateTo.Size = new System.Drawing.Size(121, 28);
            this.dateTo.TabIndex = 22;
            this.dateTo.EditValueChanged += new System.EventHandler(this.dateTo_EditValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(516, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "Đến ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "Từ ngày";
            // 
            // dSReport
            // 
            this.dSReport.DataSetName = "DSReport";
            this.dSReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsDSDKTHI
            // 
            this.bdsDSDKTHI.DataMember = "SP_DSDANGKYTHI";
            this.bdsDSDKTHI.DataSource = this.dSReport;
            // 
            // sP_DSDANGKYTHITableAdapter
            // 
            this.sP_DSDANGKYTHITableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = TracNghiem.DSReportTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sP_DSDANGKYTHIGridControl
            // 
            this.sP_DSDANGKYTHIGridControl.DataSource = this.bdsDSDKTHI;
            this.sP_DSDANGKYTHIGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sP_DSDANGKYTHIGridControl.Location = new System.Drawing.Point(0, 211);
            this.sP_DSDANGKYTHIGridControl.MainView = this.gridView1;
            this.sP_DSDANGKYTHIGridControl.Name = "sP_DSDANGKYTHIGridControl";
            this.sP_DSDANGKYTHIGridControl.Size = new System.Drawing.Size(957, 323);
            this.sP_DSDANGKYTHIGridControl.TabIndex = 1;
            this.sP_DSDANGKYTHIGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTENLOP,
            this.colTENMH,
            this.colHOTEN,
            this.colSOCAUTHI,
            this.colNGAYTHI,
            this.colDATHI,
            this.colCOSO});
            this.gridView1.GridControl = this.sP_DSDANGKYTHIGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colTENLOP
            // 
            this.colTENLOP.FieldName = "TENLOP";
            this.colTENLOP.Name = "colTENLOP";
            this.colTENLOP.Visible = true;
            this.colTENLOP.VisibleIndex = 0;
            // 
            // colTENMH
            // 
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 1;
            // 
            // colHOTEN
            // 
            this.colHOTEN.FieldName = "HOTEN";
            this.colHOTEN.Name = "colHOTEN";
            this.colHOTEN.Visible = true;
            this.colHOTEN.VisibleIndex = 2;
            // 
            // colSOCAUTHI
            // 
            this.colSOCAUTHI.FieldName = "SOCAUTHI";
            this.colSOCAUTHI.Name = "colSOCAUTHI";
            this.colSOCAUTHI.Visible = true;
            this.colSOCAUTHI.VisibleIndex = 3;
            // 
            // colNGAYTHI
            // 
            this.colNGAYTHI.FieldName = "NGAYTHI";
            this.colNGAYTHI.Name = "colNGAYTHI";
            this.colNGAYTHI.Visible = true;
            this.colNGAYTHI.VisibleIndex = 4;
            // 
            // colDATHI
            // 
            this.colDATHI.FieldName = "DATHI";
            this.colDATHI.Name = "colDATHI";
            this.colDATHI.Visible = true;
            this.colDATHI.VisibleIndex = 5;
            // 
            // colCOSO
            // 
            this.colCOSO.FieldName = "COSO";
            this.colCOSO.Name = "colCOSO";
            this.colCOSO.Visible = true;
            this.colCOSO.VisibleIndex = 6;
            // 
            // frmDsDkThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 534);
            this.Controls.Add(this.sP_DSDANGKYTHIGridControl);
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDsDkThi";
            this.Text = "Danh Sách Đăng Ký Thi";
            this.Load += new System.EventHandler(this.frmDsDkThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSDKTHI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DSDANGKYTHIGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Button btnPreview;
        private DevExpress.XtraEditors.DateEdit dateFrom;
        private DevExpress.XtraEditors.DateEdit dateTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInBC;
        private DSReport dSReport;
        private System.Windows.Forms.BindingSource bdsDSDKTHI;
        private DSReportTableAdapters.SP_DSDANGKYTHITableAdapter sP_DSDANGKYTHITableAdapter;
        private DSReportTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl sP_DSDANGKYTHIGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colSOCAUTHI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYTHI;
        private DevExpress.XtraGrid.Columns.GridColumn colDATHI;
        private DevExpress.XtraGrid.Columns.GridColumn colCOSO;
    }
}