namespace TracNghiem
{
    partial class frmThi
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
            System.Windows.Forms.Label mAMHLabel;
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label11 = new System.Windows.Forms.Label();
            this.label_Timer = new System.Windows.Forms.Label();
            this.label_TENLOP = new System.Windows.Forms.Label();
            this.label_MALOP = new System.Windows.Forms.Label();
            this.label_TENSV = new System.Windows.Forms.Label();
            this.label_MASV = new System.Windows.Forms.Label();
            this.labelTenLop = new System.Windows.Forms.Label();
            this.labelMaLop = new System.Windows.Forms.Label();
            this.labelTenSV_GV = new System.Windows.Forms.Label();
            this.labelMaSV_GV = new System.Windows.Forms.Label();
            this.label_TT = new System.Windows.Forms.Label();
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new TracNghiem.DS();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.spinEdit_SCT = new DevExpress.XtraEditors.SpinEdit();
            this.comboBox_TD = new System.Windows.Forms.ComboBox();
            this.label_SCT = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label_TD = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button_NOPBAI = new System.Windows.Forms.Button();
            this.button_Find = new System.Windows.Forms.Button();
            this.spinEdit_LAN = new DevExpress.XtraEditors.SpinEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.dateEdit_NT = new DevExpress.XtraEditors.DateEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.ComboBox_MAMH = new System.Windows.Forms.ComboBox();
            this.bdsMH = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.mONHOCTableAdapter = new TracNghiem.DSTableAdapters.MONHOCTableAdapter();
            this.tableAdapterManager = new TracNghiem.DSTableAdapters.TableAdapterManager();
            this.flowLayoutPanel_THI = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lOPTableAdapter = new TracNghiem.DSTableAdapters.LOPTableAdapter();
            mAMHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_SCT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_LAN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_NT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_NT.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMH)).BeginInit();
            this.SuspendLayout();
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAMHLabel.Location = new System.Drawing.Point(34, 69);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(90, 22);
            mAMHLabel.TabIndex = 9;
            mAMHLabel.Text = "Môn học: ";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.label11);
            this.groupControl1.Controls.Add(this.label_Timer);
            this.groupControl1.Controls.Add(this.label_TENLOP);
            this.groupControl1.Controls.Add(this.label_MALOP);
            this.groupControl1.Controls.Add(this.label_TENSV);
            this.groupControl1.Controls.Add(this.label_MASV);
            this.groupControl1.Controls.Add(this.labelTenLop);
            this.groupControl1.Controls.Add(this.labelMaLop);
            this.groupControl1.Controls.Add(this.labelTenSV_GV);
            this.groupControl1.Controls.Add(this.labelMaSV_GV);
            this.groupControl1.Controls.Add(this.label_TT);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1332, 121);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(973, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 34);
            this.label11.TabIndex = 10;
            this.label11.Text = "Thời gian: ";
            // 
            // label_Timer
            // 
            this.label_Timer.AutoSize = true;
            this.label_Timer.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Timer.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_Timer.Location = new System.Drawing.Point(1114, 52);
            this.label_Timer.Name = "label_Timer";
            this.label_Timer.Size = new System.Drawing.Size(122, 51);
            this.label_Timer.TabIndex = 9;
            this.label_Timer.Text = "00:00";
            // 
            // label_TENLOP
            // 
            this.label_TENLOP.AutoSize = true;
            this.label_TENLOP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TENLOP.Location = new System.Drawing.Point(652, 88);
            this.label_TENLOP.Name = "label_TENLOP";
            this.label_TENLOP.Size = new System.Drawing.Size(60, 22);
            this.label_TENLOP.TabIndex = 8;
            this.label_TENLOP.Text = "label9";
            // 
            // label_MALOP
            // 
            this.label_MALOP.AutoSize = true;
            this.label_MALOP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MALOP.Location = new System.Drawing.Point(652, 52);
            this.label_MALOP.Name = "label_MALOP";
            this.label_MALOP.Size = new System.Drawing.Size(60, 22);
            this.label_MALOP.TabIndex = 7;
            this.label_MALOP.Text = "label8";
            // 
            // label_TENSV
            // 
            this.label_TENSV.AutoSize = true;
            this.label_TENSV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TENSV.Location = new System.Drawing.Point(281, 88);
            this.label_TENSV.Name = "label_TENSV";
            this.label_TENSV.Size = new System.Drawing.Size(60, 22);
            this.label_TENSV.TabIndex = 6;
            this.label_TENSV.Text = "label7";
            // 
            // label_MASV
            // 
            this.label_MASV.AutoSize = true;
            this.label_MASV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MASV.Location = new System.Drawing.Point(281, 52);
            this.label_MASV.Name = "label_MASV";
            this.label_MASV.Size = new System.Drawing.Size(60, 22);
            this.label_MASV.TabIndex = 5;
            this.label_MASV.Text = "label6";
            // 
            // labelTenLop
            // 
            this.labelTenLop.AutoSize = true;
            this.labelTenLop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenLop.Location = new System.Drawing.Point(584, 89);
            this.labelTenLop.Name = "labelTenLop";
            this.labelTenLop.Size = new System.Drawing.Size(83, 22);
            this.labelTenLop.TabIndex = 4;
            this.labelTenLop.Text = "Tên lớp: ";
            // 
            // labelMaLop
            // 
            this.labelMaLop.AutoSize = true;
            this.labelMaLop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaLop.Location = new System.Drawing.Point(584, 52);
            this.labelMaLop.Name = "labelMaLop";
            this.labelMaLop.Size = new System.Drawing.Size(79, 22);
            this.labelMaLop.TabIndex = 3;
            this.labelMaLop.Text = "Mã lớp: ";
            // 
            // labelTenSV_GV
            // 
            this.labelTenSV_GV.AutoSize = true;
            this.labelTenSV_GV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenSV_GV.Location = new System.Drawing.Point(209, 89);
            this.labelTenSV_GV.Name = "labelTenSV_GV";
            this.labelTenSV_GV.Size = new System.Drawing.Size(79, 22);
            this.labelTenSV_GV.TabIndex = 2;
            this.labelTenSV_GV.Text = "Tên SV: ";
            // 
            // labelMaSV_GV
            // 
            this.labelMaSV_GV.AutoSize = true;
            this.labelMaSV_GV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaSV_GV.Location = new System.Drawing.Point(208, 52);
            this.labelMaSV_GV.Name = "labelMaSV_GV";
            this.labelMaSV_GV.Size = new System.Drawing.Size(75, 22);
            this.labelMaSV_GV.TabIndex = 1;
            this.labelMaSV_GV.Text = "Mã SV: ";
            // 
            // label_TT
            // 
            this.label_TT.AutoSize = true;
            this.label_TT.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TT.Location = new System.Drawing.Point(12, 32);
            this.label_TT.Name = "label_TT";
            this.label_TT.Size = new System.Drawing.Size(207, 26);
            this.label_TT.TabIndex = 0;
            this.label_TT.Text = "Thông tin sinh viên";
            // 
            // bdsLop
            // 
            this.bdsLop.DataMember = "LOP";
            this.bdsLop.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.spinEdit_SCT);
            this.groupControl2.Controls.Add(this.comboBox_TD);
            this.groupControl2.Controls.Add(this.label_SCT);
            this.groupControl2.Controls.Add(this.label10);
            this.groupControl2.Controls.Add(this.label_TD);
            this.groupControl2.Controls.Add(this.label9);
            this.groupControl2.Controls.Add(this.button_NOPBAI);
            this.groupControl2.Controls.Add(this.button_Find);
            this.groupControl2.Controls.Add(this.spinEdit_LAN);
            this.groupControl2.Controls.Add(this.label8);
            this.groupControl2.Controls.Add(this.dateEdit_NT);
            this.groupControl2.Controls.Add(this.label7);
            this.groupControl2.Controls.Add(mAMHLabel);
            this.groupControl2.Controls.Add(this.ComboBox_MAMH);
            this.groupControl2.Controls.Add(this.label6);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 121);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1332, 124);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "groupControl2";
            // 
            // spinEdit_SCT
            // 
            this.spinEdit_SCT.EditValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.spinEdit_SCT.Location = new System.Drawing.Point(1046, 65);
            this.spinEdit_SCT.Name = "spinEdit_SCT";
            // 
            // 
            // 
            this.spinEdit_SCT.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinEdit_SCT.Properties.Appearance.Options.UseFont = true;
            this.spinEdit_SCT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit_SCT.Properties.IsFloatValue = false;
            this.spinEdit_SCT.Properties.Mask.EditMask = "N00";
            this.spinEdit_SCT.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spinEdit_SCT.Properties.MinValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.spinEdit_SCT.Size = new System.Drawing.Size(56, 28);
            this.spinEdit_SCT.TabIndex = 22;
            this.spinEdit_SCT.TextChanged += new System.EventHandler(this.spinEdit_SCT_TextChanged);
            // 
            // comboBox_TD
            // 
            this.comboBox_TD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TD.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_TD.FormattingEnabled = true;
            this.comboBox_TD.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.comboBox_TD.Location = new System.Drawing.Point(891, 66);
            this.comboBox_TD.Name = "comboBox_TD";
            this.comboBox_TD.Size = new System.Drawing.Size(43, 29);
            this.comboBox_TD.TabIndex = 21;
            this.comboBox_TD.SelectedIndexChanged += new System.EventHandler(this.comboBox_TD_SelectedIndexChanged);
            // 
            // label_SCT
            // 
            this.label_SCT.AutoSize = true;
            this.label_SCT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SCT.Location = new System.Drawing.Point(1042, 68);
            this.label_SCT.Name = "label_SCT";
            this.label_SCT.Size = new System.Drawing.Size(20, 22);
            this.label_SCT.TabIndex = 20;
            this.label_SCT.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(957, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 22);
            this.label10.TabIndex = 19;
            this.label10.Text = "Số câu thi";
            // 
            // label_TD
            // 
            this.label_TD.AutoSize = true;
            this.label_TD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TD.Location = new System.Drawing.Point(891, 69);
            this.label_TD.Name = "label_TD";
            this.label_TD.Size = new System.Drawing.Size(36, 22);
            this.label_TD.TabIndex = 18;
            this.label_TD.Text = "TD";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(819, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 22);
            this.label9.TabIndex = 17;
            this.label9.Text = "Trình độ: ";
            // 
            // button_NOPBAI
            // 
            this.button_NOPBAI.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_NOPBAI.Location = new System.Drawing.Point(1233, 63);
            this.button_NOPBAI.Name = "button_NOPBAI";
            this.button_NOPBAI.Size = new System.Drawing.Size(95, 28);
            this.button_NOPBAI.TabIndex = 16;
            this.button_NOPBAI.Text = "Bắt đầu thi";
            this.button_NOPBAI.UseVisualStyleBackColor = true;
            this.button_NOPBAI.Click += new System.EventHandler(this.button_NOPBAI_Click);
            // 
            // button_Find
            // 
            this.button_Find.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Find.Location = new System.Drawing.Point(1137, 62);
            this.button_Find.Name = "button_Find";
            this.button_Find.Size = new System.Drawing.Size(75, 28);
            this.button_Find.TabIndex = 15;
            this.button_Find.Text = "Find";
            this.button_Find.UseVisualStyleBackColor = true;
            this.button_Find.Click += new System.EventHandler(this.button_Find_Click);
            // 
            // spinEdit_LAN
            // 
            this.spinEdit_LAN.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEdit_LAN.Location = new System.Drawing.Point(717, 65);
            this.spinEdit_LAN.Name = "spinEdit_LAN";
            // 
            // 
            // 
            this.spinEdit_LAN.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinEdit_LAN.Properties.Appearance.Options.UseFont = true;
            this.spinEdit_LAN.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit_LAN.Properties.IsFloatValue = false;
            this.spinEdit_LAN.Properties.Mask.EditMask = "N00";
            this.spinEdit_LAN.Properties.MaxValue = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.spinEdit_LAN.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEdit_LAN.Size = new System.Drawing.Size(62, 28);
            this.spinEdit_LAN.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(662, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 22);
            this.label8.TabIndex = 13;
            this.label8.Text = "Lần: ";
            // 
            // dateEdit_NT
            // 
            this.dateEdit_NT.EditValue = new System.DateTime(2023, 8, 16, 0, 0, 0, 0);
            this.dateEdit_NT.Location = new System.Drawing.Point(474, 66);
            this.dateEdit_NT.Name = "dateEdit_NT";
            // 
            // 
            // 
            this.dateEdit_NT.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEdit_NT.Properties.Appearance.Options.UseFont = true;
            this.dateEdit_NT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            // 
            // 
            // 
            this.dateEdit_NT.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_NT.Size = new System.Drawing.Size(156, 28);
            this.dateEdit_NT.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(398, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 22);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ngày thi: ";
            // 
            // ComboBox_MAMH
            // 
            this.ComboBox_MAMH.DataSource = this.bdsMH;
            this.ComboBox_MAMH.DisplayMember = "TENMH";
            this.ComboBox_MAMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_MAMH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_MAMH.FormattingEnabled = true;
            this.ComboBox_MAMH.Location = new System.Drawing.Point(111, 66);
            this.ComboBox_MAMH.Name = "ComboBox_MAMH";
            this.ComboBox_MAMH.Size = new System.Drawing.Size(229, 30);
            this.ComboBox_MAMH.TabIndex = 10;
            this.ComboBox_MAMH.ValueMember = "MAMH";
            // 
            // bdsMH
            // 
            this.bdsMH.DataMember = "MONHOC";
            this.bdsMH.DataSource = this.DS;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 26);
            this.label6.TabIndex = 9;
            this.label6.Text = "Thông tin thi";
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
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
            // flowLayoutPanel_THI
            // 
            this.flowLayoutPanel_THI.AutoScroll = true;
            this.flowLayoutPanel_THI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_THI.ForeColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel_THI.Location = new System.Drawing.Point(0, 245);
            this.flowLayoutPanel_THI.Name = "flowLayoutPanel_THI";
            this.flowLayoutPanel_THI.Size = new System.Drawing.Size(1332, 343);
            this.flowLayoutPanel_THI.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // frmThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 588);
            this.Controls.Add(this.flowLayoutPanel_THI);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmThi";
            this.Text = "Thi";
            this.Load += new System.EventHandler(this.frmThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_SCT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_LAN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_NT.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_NT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label_TT;
        private System.Windows.Forms.Label label_TENLOP;
        private System.Windows.Forms.Label label_MALOP;
        private System.Windows.Forms.Label label_TENSV;
        private System.Windows.Forms.Label label_MASV;
        private System.Windows.Forms.Label labelTenLop;
        private System.Windows.Forms.Label labelMaLop;
        private System.Windows.Forms.Label labelTenSV_GV;
        private System.Windows.Forms.Label labelMaSV_GV;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Label label6;
        private DS DS;
        private System.Windows.Forms.BindingSource bdsMH;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox ComboBox_MAMH;
        private DevExpress.XtraEditors.SpinEdit spinEdit_LAN;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.DateEdit dateEdit_NT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_Find;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_THI;
        private System.Windows.Forms.Button button_NOPBAI;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_SCT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label_TD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_Timer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource bdsLop;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.ComboBox comboBox_TD;
        private DevExpress.XtraEditors.SpinEdit spinEdit_SCT;
    }
}