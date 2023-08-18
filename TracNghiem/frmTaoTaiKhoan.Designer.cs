namespace TracNghiem
{
    partial class frmTaoTaiKhoan
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
            System.Windows.Forms.Label hOTENLabel;
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.comboBox_CN = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBox_Username = new System.Windows.Forms.TextBox();
            this.bdsGV = new System.Windows.Forms.BindingSource(this.components);
            this.dS_DSGV_CHUATK = new TracNghiem.DS_DSGV_CHUATK();
            this.button_DK = new System.Windows.Forms.Button();
            this.radioButton_Giangvien = new System.Windows.Forms.RadioButton();
            this.radioButton_Coso = new System.Windows.Forms.RadioButton();
            this.radioButton_Truong = new System.Windows.Forms.RadioButton();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_LoginName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hOTENComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.v_DS_GIAOVIENCHUACOTKTableAdapter = new TracNghiem.DS_DSGV_CHUATKTableAdapters.V_DS_GIAOVIENCHUACOTKTableAdapter();
            this.tableAdapterManager = new TracNghiem.DS_DSGV_CHUATKTableAdapters.TableAdapterManager();
            hOTENLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSGV_CHUATK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // hOTENLabel
            // 
            hOTENLabel.AutoSize = true;
            hOTENLabel.Font = new System.Drawing.Font("Tahoma", 12F);
            hOTENLabel.Location = new System.Drawing.Point(99, 134);
            hOTENLabel.Name = "hOTENLabel";
            hOTENLabel.Size = new System.Drawing.Size(90, 19);
            hOTENLabel.TabIndex = 1;
            hOTENLabel.Text = "GIÁO VIÊN";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.comboBox_CN);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.TextBox_Username);
            this.groupControl1.Controls.Add(this.button_DK);
            this.groupControl1.Controls.Add(this.radioButton_Giangvien);
            this.groupControl1.Controls.Add(this.radioButton_Coso);
            this.groupControl1.Controls.Add(this.radioButton_Truong);
            this.groupControl1.Controls.Add(this.radioGroup1);
            this.groupControl1.Controls.Add(this.textBox_Password);
            this.groupControl1.Controls.Add(this.textBox_LoginName);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(hOTENLabel);
            this.groupControl1.Controls.Add(this.hOTENComboBox);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(524, 471);
            this.groupControl1.TabIndex = 0;
            // 
            // comboBox_CN
            // 
            this.comboBox_CN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_CN.Enabled = false;
            this.comboBox_CN.FormattingEnabled = true;
            this.comboBox_CN.Location = new System.Drawing.Point(224, 91);
            this.comboBox_CN.Name = "comboBox_CN";
            this.comboBox_CN.Size = new System.Drawing.Size(168, 21);
            this.comboBox_CN.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label5.Location = new System.Drawing.Point(99, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "CƠ SỞ";
            // 
            // TextBox_Username
            // 
            this.TextBox_Username.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGV, "MAGV", true));
            this.TextBox_Username.Enabled = false;
            this.TextBox_Username.Location = new System.Drawing.Point(224, 180);
            this.TextBox_Username.Name = "TextBox_Username";
            this.TextBox_Username.Size = new System.Drawing.Size(168, 21);
            this.TextBox_Username.TabIndex = 14;
            // 
            // bdsGV
            // 
            this.bdsGV.DataMember = "V_DS_GIAOVIENCHUACOTK";
            this.bdsGV.DataSource = this.dS_DSGV_CHUATK;
            // 
            // dS_DSGV_CHUATK
            // 
            this.dS_DSGV_CHUATK.DataSetName = "DS_DSGV_CHUATK";
            this.dS_DSGV_CHUATK.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button_DK
            // 
            this.button_DK.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.button_DK.Location = new System.Drawing.Point(224, 406);
            this.button_DK.Name = "button_DK";
            this.button_DK.Size = new System.Drawing.Size(108, 32);
            this.button_DK.TabIndex = 13;
            this.button_DK.Text = "Đăng ký";
            this.button_DK.UseVisualStyleBackColor = true;
            this.button_DK.Click += new System.EventHandler(this.button_DK_Click);
            // 
            // radioButton_Giangvien
            // 
            this.radioButton_Giangvien.AutoSize = true;
            this.radioButton_Giangvien.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.radioButton_Giangvien.Location = new System.Drawing.Point(377, 344);
            this.radioButton_Giangvien.Name = "radioButton_Giangvien";
            this.radioButton_Giangvien.Size = new System.Drawing.Size(91, 21);
            this.radioButton_Giangvien.TabIndex = 12;
            this.radioButton_Giangvien.TabStop = true;
            this.radioButton_Giangvien.Text = "Giảng viên";
            this.radioButton_Giangvien.UseVisualStyleBackColor = true;
            // 
            // radioButton_Coso
            // 
            this.radioButton_Coso.AutoSize = true;
            this.radioButton_Coso.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.radioButton_Coso.Location = new System.Drawing.Point(224, 344);
            this.radioButton_Coso.Name = "radioButton_Coso";
            this.radioButton_Coso.Size = new System.Drawing.Size(62, 21);
            this.radioButton_Coso.TabIndex = 11;
            this.radioButton_Coso.TabStop = true;
            this.radioButton_Coso.Text = "Cơ sở";
            this.radioButton_Coso.UseVisualStyleBackColor = true;
            // 
            // radioButton_Truong
            // 
            this.radioButton_Truong.AutoSize = true;
            this.radioButton_Truong.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.radioButton_Truong.Location = new System.Drawing.Point(66, 344);
            this.radioButton_Truong.Name = "radioButton_Truong";
            this.radioButton_Truong.Size = new System.Drawing.Size(70, 21);
            this.radioButton_Truong.TabIndex = 10;
            this.radioButton_Truong.TabStop = true;
            this.radioButton_Truong.Text = "Trường";
            this.radioButton_Truong.UseVisualStyleBackColor = true;
            // 
            // radioGroup1
            // 
            this.radioGroup1.Location = new System.Drawing.Point(37, 325);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.radioGroup1.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroup1.Size = new System.Drawing.Size(450, 54);
            this.radioGroup1.TabIndex = 9;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(224, 272);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(168, 21);
            this.textBox_Password.TabIndex = 8;
            this.textBox_Password.UseSystemPasswordChar = true;
            // 
            // textBox_LoginName
            // 
            this.textBox_LoginName.Location = new System.Drawing.Point(224, 222);
            this.textBox_LoginName.Name = "textBox_LoginName";
            this.textBox_LoginName.Size = new System.Drawing.Size(168, 21);
            this.textBox_LoginName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.Location = new System.Drawing.Point(100, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "PASSWORD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(99, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "LOGIN NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(99, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "USERNAME";
            // 
            // hOTENComboBox
            // 
            this.hOTENComboBox.DataSource = this.bdsGV;
            this.hOTENComboBox.DisplayMember = "HOTEN";
            this.hOTENComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hOTENComboBox.FormattingEnabled = true;
            this.hOTENComboBox.Location = new System.Drawing.Point(224, 134);
            this.hOTENComboBox.Name = "hOTENComboBox";
            this.hOTENComboBox.Size = new System.Drawing.Size(168, 21);
            this.hOTENComboBox.TabIndex = 2;
            this.hOTENComboBox.ValueMember = "MAGV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(170, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tạo tài khoản";
            // 
            // v_DS_GIAOVIENCHUACOTKTableAdapter
            // 
            this.v_DS_GIAOVIENCHUACOTKTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = TracNghiem.DS_DSGV_CHUATKTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmTaoTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 471);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmTaoTaiKhoan";
            this.Text = "frmTaoTaiKhoan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTaoTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSGV_CHUATK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label1;
        private DS_DSGV_CHUATK dS_DSGV_CHUATK;
        private System.Windows.Forms.BindingSource bdsGV;
        private DS_DSGV_CHUATKTableAdapters.V_DS_GIAOVIENCHUACOTKTableAdapter v_DS_GIAOVIENCHUACOTKTableAdapter;
        private DS_DSGV_CHUATKTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox hOTENComboBox;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_LoginName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton_Giangvien;
        private System.Windows.Forms.RadioButton radioButton_Coso;
        private System.Windows.Forms.RadioButton radioButton_Truong;
        private System.Windows.Forms.Button button_DK;
        private System.Windows.Forms.TextBox TextBox_Username;
        private System.Windows.Forms.ComboBox comboBox_CN;
        private System.Windows.Forms.Label label5;
    }
}