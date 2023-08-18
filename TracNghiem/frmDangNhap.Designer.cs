namespace TracNghiem
{
    partial class frmDangNhap
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
            System.Windows.Forms.Label tENCNLabel;
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.button_DN = new System.Windows.Forms.Button();
            this.textBox_Pass = new System.Windows.Forms.TextBox();
            this.textBox_TenDN = new System.Windows.Forms.TextBox();
            this.label_pass = new System.Windows.Forms.Label();
            this.label_LoginName = new System.Windows.Forms.Label();
            this.label_DN = new System.Windows.Forms.Label();
            this.radioButton_SinhVien = new System.Windows.Forms.RadioButton();
            this.radioButton_GiangVien = new System.Windows.Forms.RadioButton();
            this.radioGroup_Roles = new DevExpress.XtraEditors.RadioGroup();
            this.comboBox_TenCN = new System.Windows.Forms.ComboBox();
            this.bdsPM = new System.Windows.Forms.BindingSource(this.components);
            this.dS_DSPM = new TracNghiem.DS_DSPM();
            this.v_DS_PHANMANHTableAdapter = new TracNghiem.DS_DSPMTableAdapters.V_DS_PHANMANHTableAdapter();
            this.tableAdapterManager = new TracNghiem.DS_DSPMTableAdapters.TableAdapterManager();
            tENCNLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup_Roles.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSPM)).BeginInit();
            this.SuspendLayout();
            // 
            // tENCNLabel
            // 
            tENCNLabel.AutoSize = true;
            tENCNLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENCNLabel.Location = new System.Drawing.Point(151, 128);
            tENCNLabel.Name = "tENCNLabel";
            tENCNLabel.Size = new System.Drawing.Size(44, 17);
            tENCNLabel.TabIndex = 0;
            tENCNLabel.Text = "Cơ sở";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.button_DN);
            this.groupControl1.Controls.Add(this.textBox_Pass);
            this.groupControl1.Controls.Add(this.textBox_TenDN);
            this.groupControl1.Controls.Add(this.label_pass);
            this.groupControl1.Controls.Add(this.label_LoginName);
            this.groupControl1.Controls.Add(this.label_DN);
            this.groupControl1.Controls.Add(this.radioButton_SinhVien);
            this.groupControl1.Controls.Add(this.radioButton_GiangVien);
            this.groupControl1.Controls.Add(this.radioGroup_Roles);
            this.groupControl1.Controls.Add(tENCNLabel);
            this.groupControl1.Controls.Add(this.comboBox_TenCN);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(492, 450);
            this.groupControl1.TabIndex = 0;
            // 
            // button_DN
            // 
            this.button_DN.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.button_DN.Location = new System.Drawing.Point(201, 354);
            this.button_DN.Name = "button_DN";
            this.button_DN.Size = new System.Drawing.Size(107, 30);
            this.button_DN.TabIndex = 10;
            this.button_DN.Text = "Đăng nhập";
            this.button_DN.UseVisualStyleBackColor = true;
            this.button_DN.Click += new System.EventHandler(this.button_DN_Click);
            // 
            // textBox_Pass
            // 
            this.textBox_Pass.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Pass.Location = new System.Drawing.Point(201, 289);
            this.textBox_Pass.Name = "textBox_Pass";
            this.textBox_Pass.Size = new System.Drawing.Size(170, 25);
            this.textBox_Pass.TabIndex = 9;
            this.textBox_Pass.Text = "123";
            this.textBox_Pass.UseSystemPasswordChar = true;
            // 
            // textBox_TenDN
            // 
            this.textBox_TenDN.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TenDN.Location = new System.Drawing.Point(201, 242);
            this.textBox_TenDN.Name = "textBox_TenDN";
            this.textBox_TenDN.Size = new System.Drawing.Size(170, 25);
            this.textBox_TenDN.TabIndex = 8;
            // 
            // label_pass
            // 
            this.label_pass.AutoSize = true;
            this.label_pass.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pass.Location = new System.Drawing.Point(105, 292);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(66, 17);
            this.label_pass.TabIndex = 7;
            this.label_pass.Text = "Password";
            // 
            // label_LoginName
            // 
            this.label_LoginName.AutoSize = true;
            this.label_LoginName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_LoginName.Location = new System.Drawing.Point(105, 242);
            this.label_LoginName.Name = "label_LoginName";
            this.label_LoginName.Size = new System.Drawing.Size(77, 17);
            this.label_LoginName.TabIndex = 6;
            this.label_LoginName.Text = "Login name";
            // 
            // label_DN
            // 
            this.label_DN.AutoSize = true;
            this.label_DN.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DN.Location = new System.Drawing.Point(70, 80);
            this.label_DN.Name = "label_DN";
            this.label_DN.Size = new System.Drawing.Size(351, 25);
            this.label_DN.TabIndex = 5;
            this.label_DN.Text = "Đăng nhập hệ thống thi trắc nghiệm";
            // 
            // radioButton_SinhVien
            // 
            this.radioButton_SinhVien.AutoSize = true;
            this.radioButton_SinhVien.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_SinhVien.Location = new System.Drawing.Point(283, 182);
            this.radioButton_SinhVien.Name = "radioButton_SinhVien";
            this.radioButton_SinhVien.Size = new System.Drawing.Size(79, 21);
            this.radioButton_SinhVien.TabIndex = 4;
            this.radioButton_SinhVien.Text = "Sinh viên";
            this.radioButton_SinhVien.UseVisualStyleBackColor = true;
            this.radioButton_SinhVien.CheckedChanged += new System.EventHandler(this.radioButton_SinhVien_CheckedChanged);
            // 
            // radioButton_GiangVien
            // 
            this.radioButton_GiangVien.AutoSize = true;
            this.radioButton_GiangVien.Checked = true;
            this.radioButton_GiangVien.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_GiangVien.Location = new System.Drawing.Point(143, 182);
            this.radioButton_GiangVien.Name = "radioButton_GiangVien";
            this.radioButton_GiangVien.Size = new System.Drawing.Size(88, 21);
            this.radioButton_GiangVien.TabIndex = 3;
            this.radioButton_GiangVien.TabStop = true;
            this.radioButton_GiangVien.Text = "Giảng viên";
            this.radioButton_GiangVien.UseVisualStyleBackColor = true;
            this.radioButton_GiangVien.CheckedChanged += new System.EventHandler(this.radioButton_GiangVien_CheckedChanged);
            // 
            // radioGroup_Roles
            // 
            this.radioGroup_Roles.Location = new System.Drawing.Point(134, 170);
            this.radioGroup_Roles.Name = "radioGroup_Roles";
            this.radioGroup_Roles.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.radioGroup_Roles.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioGroup_Roles.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroup_Roles.Properties.Appearance.Options.UseFont = true;
            this.radioGroup_Roles.Size = new System.Drawing.Size(235, 40);
            this.radioGroup_Roles.TabIndex = 2;
            // 
            // comboBox_TenCN
            // 
            this.comboBox_TenCN.DataSource = this.bdsPM;
            this.comboBox_TenCN.DisplayMember = "TENCN";
            this.comboBox_TenCN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TenCN.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_TenCN.FormattingEnabled = true;
            this.comboBox_TenCN.Location = new System.Drawing.Point(201, 125);
            this.comboBox_TenCN.Name = "comboBox_TenCN";
            this.comboBox_TenCN.Size = new System.Drawing.Size(121, 25);
            this.comboBox_TenCN.TabIndex = 1;
            this.comboBox_TenCN.ValueMember = "TENSERVER";
            this.comboBox_TenCN.SelectedIndexChanged += new System.EventHandler(this.comboBox_TenCN_SelectedIndexChanged);
            // 
            // bdsPM
            // 
            this.bdsPM.DataMember = "V_DS_PHANMANH";
            this.bdsPM.DataSource = this.dS_DSPM;
            // 
            // dS_DSPM
            // 
            this.dS_DSPM.DataSetName = "DS_DSPM";
            this.dS_DSPM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = TracNghiem.DS_DSPMTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 450);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmDangNhap";
            this.Text = "frmDangNhap";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup_Roles.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSPM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DS_DSPM dS_DSPM;
        private System.Windows.Forms.BindingSource bdsPM;
        private DS_DSPMTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private DS_DSPMTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox comboBox_TenCN;
        private System.Windows.Forms.RadioButton radioButton_SinhVien;
        private System.Windows.Forms.RadioButton radioButton_GiangVien;
        private DevExpress.XtraEditors.RadioGroup radioGroup_Roles;
        private System.Windows.Forms.Label label_DN;
        private System.Windows.Forms.TextBox textBox_Pass;
        private System.Windows.Forms.TextBox textBox_TenDN;
        private System.Windows.Forms.Label label_pass;
        private System.Windows.Forms.Label label_LoginName;
        private System.Windows.Forms.Button button_DN;
    }
}