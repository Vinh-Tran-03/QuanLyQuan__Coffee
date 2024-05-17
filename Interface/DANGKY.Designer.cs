namespace Interface
{
    partial class DANGKY
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DANGKY));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbtrangthai = new System.Windows.Forms.Label();
            this.cbgioitinh = new System.Windows.Forms.ComboBox();
            this.datengaysinh = new System.Windows.Forms.DateTimePicker();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txthovaten = new System.Windows.Forms.TextBox();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.txttentk = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdnhanvien = new System.Windows.Forms.RadioButton();
            this.rdadmin = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btthoat = new System.Windows.Forms.Button();
            this.btdangky = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbtrangthai);
            this.groupBox1.Controls.Add(this.cbgioitinh);
            this.groupBox1.Controls.Add(this.datengaysinh);
            this.groupBox1.Controls.Add(this.txtsdt);
            this.groupBox1.Controls.Add(this.txthovaten);
            this.groupBox1.Controls.Add(this.txtmatkhau);
            this.groupBox1.Controls.Add(this.txttentk);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 293);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đăng ký";
            // 
            // lbtrangthai
            // 
            this.lbtrangthai.AutoSize = true;
            this.lbtrangthai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbtrangthai.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbtrangthai.Location = new System.Drawing.Point(6, 272);
            this.lbtrangthai.Name = "lbtrangthai";
            this.lbtrangthai.Size = new System.Drawing.Size(0, 15);
            this.lbtrangthai.TabIndex = 13;
            // 
            // cbgioitinh
            // 
            this.cbgioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbgioitinh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbgioitinh.FormattingEnabled = true;
            this.cbgioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbgioitinh.Location = new System.Drawing.Point(96, 230);
            this.cbgioitinh.Name = "cbgioitinh";
            this.cbgioitinh.Size = new System.Drawing.Size(89, 23);
            this.cbgioitinh.TabIndex = 12;
            // 
            // datengaysinh
            // 
            this.datengaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.datengaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datengaysinh.Location = new System.Drawing.Point(96, 148);
            this.datengaysinh.Name = "datengaysinh";
            this.datengaysinh.Size = new System.Drawing.Size(87, 21);
            this.datengaysinh.TabIndex = 11;
            // 
            // txtsdt
            // 
            this.txtsdt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtsdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtsdt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtsdt.Location = new System.Drawing.Point(96, 190);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(193, 21);
            this.txtsdt.TabIndex = 10;
            this.txtsdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsdt_KeyPress);
            // 
            // txthovaten
            // 
            this.txthovaten.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txthovaten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txthovaten.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txthovaten.Location = new System.Drawing.Point(96, 110);
            this.txthovaten.Name = "txthovaten";
            this.txthovaten.Size = new System.Drawing.Size(193, 21);
            this.txthovaten.TabIndex = 9;
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtmatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtmatkhau.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtmatkhau.Location = new System.Drawing.Point(96, 70);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(193, 21);
            this.txtmatkhau.TabIndex = 8;
            this.txtmatkhau.UseSystemPasswordChar = true;
            // 
            // txttentk
            // 
            this.txttentk.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txttentk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txttentk.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txttentk.Location = new System.Drawing.Point(96, 30);
            this.txttentk.Name = "txttentk";
            this.txttentk.Size = new System.Drawing.Size(193, 21);
            this.txttentk.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(6, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Giới tính:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(6, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số điện thoại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(6, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày sinh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(6, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Họ và tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên tài khoản:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdnhanvien);
            this.groupBox2.Controls.Add(this.rdadmin);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(192, 311);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(115, 83);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quyền";
            // 
            // rdnhanvien
            // 
            this.rdnhanvien.AutoSize = true;
            this.rdnhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdnhanvien.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdnhanvien.Location = new System.Drawing.Point(6, 58);
            this.rdnhanvien.Name = "rdnhanvien";
            this.rdnhanvien.Size = new System.Drawing.Size(80, 19);
            this.rdnhanvien.TabIndex = 1;
            this.rdnhanvien.TabStop = true;
            this.rdnhanvien.Text = "Nhân viên";
            this.rdnhanvien.UseVisualStyleBackColor = true;
            this.rdnhanvien.CheckedChanged += new System.EventHandler(this.rdnhanvien_CheckedChanged);
            // 
            // rdadmin
            // 
            this.rdadmin.AutoSize = true;
            this.rdadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdadmin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdadmin.Location = new System.Drawing.Point(6, 19);
            this.rdadmin.Name = "rdadmin";
            this.rdadmin.Size = new System.Drawing.Size(60, 19);
            this.rdadmin.TabIndex = 0;
            this.rdadmin.TabStop = true;
            this.rdadmin.Text = "Admin";
            this.rdadmin.UseVisualStyleBackColor = true;
            this.rdadmin.CheckedChanged += new System.EventHandler(this.rdadmin_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btthoat);
            this.groupBox3.Controls.Add(this.btdangky);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(12, 311);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(174, 83);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // btthoat
            // 
            this.btthoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btthoat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btthoat.Image = global::Interface.Properties.Resources.Deleteico;
            this.btthoat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btthoat.Location = new System.Drawing.Point(93, 19);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(75, 56);
            this.btthoat.TabIndex = 3;
            this.btthoat.Text = "Thoát";
            this.btthoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // btdangky
            // 
            this.btdangky.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btdangky.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btdangky.Image = global::Interface.Properties.Resources.Aha_Soft_Security_Add_key;
            this.btdangky.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btdangky.Location = new System.Drawing.Point(6, 19);
            this.btdangky.Name = "btdangky";
            this.btdangky.Size = new System.Drawing.Size(75, 56);
            this.btdangky.TabIndex = 2;
            this.btdangky.Text = "Đăng ký";
            this.btdangky.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btdangky.UseVisualStyleBackColor = true;
            this.btdangky.Click += new System.EventHandler(this.btdangky_Click);
            // 
            // DANGKY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(318, 403);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(334, 441);
            this.MinimumSize = new System.Drawing.Size(334, 441);
            this.Name = "DANGKY";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký tài khoản";
            this.Load += new System.EventHandler(this.DANGKY_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbgioitinh;
        private System.Windows.Forms.DateTimePicker datengaysinh;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txthovaten;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.TextBox txttentk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdnhanvien;
        private System.Windows.Forms.RadioButton rdadmin;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btdangky;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Label lbtrangthai;
    }
}