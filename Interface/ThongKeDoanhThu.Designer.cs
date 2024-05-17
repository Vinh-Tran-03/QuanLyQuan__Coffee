namespace Interface
{
    partial class ThongKeDoanhThu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKeDoanhThu));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dg_hoadon = new System.Windows.Forms.DataGridView();
            this.btxemcthd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbmahd = new System.Windows.Forms.Label();
            this.bttinhdt = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbnam = new System.Windows.Forms.ComboBox();
            this.cbthang = new System.Windows.Forms.ComboBox();
            this.cbngay = new System.Windows.Forms.ComboBox();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.rdThang = new System.Windows.Forms.RadioButton();
            this.rdNgay = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btlammoi = new System.Windows.Forms.Button();
            this.Soban = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.bttim = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttennhanvien = new System.Windows.Forms.TextBox();
            this.btlammoi1 = new System.Windows.Forms.Button();
            this.bttimnhanvien = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_hoadon)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Soban)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dg_hoadon);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(252, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1100, 660);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hóa đơn của quán";
            // 
            // dg_hoadon
            // 
            this.dg_hoadon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_hoadon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dg_hoadon.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_hoadon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_hoadon.DefaultCellStyle = dataGridViewCellStyle2;
            this.dg_hoadon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_hoadon.EnableHeadersVisualStyles = false;
            this.dg_hoadon.Location = new System.Drawing.Point(3, 22);
            this.dg_hoadon.Name = "dg_hoadon";
            this.dg_hoadon.Size = new System.Drawing.Size(1094, 635);
            this.dg_hoadon.TabIndex = 0;
            this.dg_hoadon.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_hoadon_RowEnter);
            // 
            // btxemcthd
            // 
            this.btxemcthd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btxemcthd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btxemcthd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btxemcthd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btxemcthd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btxemcthd.Location = new System.Drawing.Point(9, 25);
            this.btxemcthd.Name = "btxemcthd";
            this.btxemcthd.Size = new System.Drawing.Size(216, 78);
            this.btxemcthd.TabIndex = 1;
            this.btxemcthd.Text = "Xem chi tiết hóa đơn";
            this.btxemcthd.UseVisualStyleBackColor = true;
            this.btxemcthd.Click += new System.EventHandler(this.btxemcthd_Click);
            this.btxemcthd.MouseLeave += new System.EventHandler(this.btxemcthd_MouseLeave);
            this.btxemcthd.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btxemcthd_MouseMove);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbmahd);
            this.groupBox2.Controls.Add(this.btxemcthd);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 109);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Xem chi tiết";
            // 
            // lbmahd
            // 
            this.lbmahd.AutoSize = true;
            this.lbmahd.Location = new System.Drawing.Point(168, 65);
            this.lbmahd.Name = "lbmahd";
            this.lbmahd.Size = new System.Drawing.Size(57, 20);
            this.lbmahd.TabIndex = 2;
            this.lbmahd.Text = "label2";
            // 
            // bttinhdt
            // 
            this.bttinhdt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bttinhdt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttinhdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bttinhdt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bttinhdt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttinhdt.Location = new System.Drawing.Point(10, 26);
            this.bttinhdt.Name = "bttinhdt";
            this.bttinhdt.Size = new System.Drawing.Size(60, 86);
            this.bttinhdt.TabIndex = 2;
            this.bttinhdt.Text = "Tính";
            this.bttinhdt.UseVisualStyleBackColor = true;
            this.bttinhdt.Click += new System.EventHandler(this.bttinhdt_Click);
            this.bttinhdt.MouseLeave += new System.EventHandler(this.bttinhdt_MouseLeave);
            this.bttinhdt.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bttinhdt_MouseMove);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbnam);
            this.groupBox3.Controls.Add(this.cbthang);
            this.groupBox3.Controls.Add(this.cbngay);
            this.groupBox3.Controls.Add(this.rdNam);
            this.groupBox3.Controls.Add(this.rdThang);
            this.groupBox3.Controls.Add(this.rdNgay);
            this.groupBox3.Controls.Add(this.bttinhdt);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(12, 127);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(234, 126);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tính doanh thu";
            // 
            // cbnam
            // 
            this.cbnam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbnam.FormattingEnabled = true;
            this.cbnam.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.cbnam.Location = new System.Drawing.Point(141, 90);
            this.cbnam.Name = "cbnam";
            this.cbnam.Size = new System.Drawing.Size(84, 24);
            this.cbnam.TabIndex = 8;
            // 
            // cbthang
            // 
            this.cbthang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbthang.FormattingEnabled = true;
            this.cbthang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbthang.Location = new System.Drawing.Point(141, 56);
            this.cbthang.Name = "cbthang";
            this.cbthang.Size = new System.Drawing.Size(84, 24);
            this.cbthang.TabIndex = 7;
            // 
            // cbngay
            // 
            this.cbngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbngay.FormattingEnabled = true;
            this.cbngay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbngay.Location = new System.Drawing.Point(141, 21);
            this.cbngay.Name = "cbngay";
            this.cbngay.Size = new System.Drawing.Size(84, 24);
            this.cbngay.TabIndex = 6;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdNam.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdNam.Location = new System.Drawing.Point(76, 92);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(55, 20);
            this.rdNam.TabIndex = 5;
            this.rdNam.Text = "Năm";
            this.rdNam.UseVisualStyleBackColor = true;
            this.rdNam.CheckedChanged += new System.EventHandler(this.rdNam_CheckedChanged);
            // 
            // rdThang
            // 
            this.rdThang.AutoSize = true;
            this.rdThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdThang.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdThang.Location = new System.Drawing.Point(76, 60);
            this.rdThang.Name = "rdThang";
            this.rdThang.Size = new System.Drawing.Size(65, 20);
            this.rdThang.TabIndex = 4;
            this.rdThang.Text = "Tháng";
            this.rdThang.UseVisualStyleBackColor = true;
            this.rdThang.CheckedChanged += new System.EventHandler(this.rdThang_CheckedChanged);
            // 
            // rdNgay
            // 
            this.rdNgay.AutoSize = true;
            this.rdNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdNgay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdNgay.Location = new System.Drawing.Point(76, 25);
            this.rdNgay.Name = "rdNgay";
            this.rdNgay.Size = new System.Drawing.Size(59, 20);
            this.rdNgay.TabIndex = 3;
            this.rdNgay.Text = "Ngày";
            this.rdNgay.UseVisualStyleBackColor = true;
            this.rdNgay.CheckedChanged += new System.EventHandler(this.rdNgay_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btlammoi);
            this.groupBox4.Controls.Add(this.Soban);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.bttim);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox4.ForeColor = System.Drawing.Color.Red;
            this.groupBox4.Location = new System.Drawing.Point(12, 259);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(234, 97);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm hóa đơn của bàn";
            // 
            // btlammoi
            // 
            this.btlammoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btlammoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btlammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btlammoi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btlammoi.Image = global::Interface.Properties.Resources.Hopstarter_Soft_Scraps_Button_Refresh;
            this.btlammoi.Location = new System.Drawing.Point(178, 24);
            this.btlammoi.Name = "btlammoi";
            this.btlammoi.Size = new System.Drawing.Size(50, 60);
            this.btlammoi.TabIndex = 9;
            this.btlammoi.UseVisualStyleBackColor = true;
            this.btlammoi.Click += new System.EventHandler(this.btlammoi_Click);
            this.btlammoi.MouseLeave += new System.EventHandler(this.btlammoi_MouseLeave);
            this.btlammoi.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btlammoi_MouseMove);
            // 
            // Soban
            // 
            this.Soban.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Soban.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Soban.Location = new System.Drawing.Point(65, 44);
            this.Soban.Name = "Soban";
            this.Soban.Size = new System.Drawing.Size(51, 22);
            this.Soban.TabIndex = 8;
            this.Soban.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Bàn số:";
            // 
            // bttim
            // 
            this.bttim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bttim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bttim.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bttim.Image = global::Interface.Properties.Resources.Zerode_Plump_Search;
            this.bttim.Location = new System.Drawing.Point(122, 24);
            this.bttim.Name = "bttim";
            this.bttim.Size = new System.Drawing.Size(50, 60);
            this.bttim.TabIndex = 6;
            this.bttim.UseVisualStyleBackColor = true;
            this.bttim.Click += new System.EventHandler(this.bttim_Click);
            this.bttim.MouseLeave += new System.EventHandler(this.bttim_MouseLeave);
            this.bttim.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bttim_MouseMove);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.monthCalendar1.Location = new System.Drawing.Point(12, 510);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.txttennhanvien);
            this.groupBox5.Controls.Add(this.btlammoi1);
            this.groupBox5.Controls.Add(this.bttimnhanvien);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox5.ForeColor = System.Drawing.Color.Red;
            this.groupBox5.Location = new System.Drawing.Point(12, 362);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(234, 136);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tìm hóa đơn nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên :";
            // 
            // txttennhanvien
            // 
            this.txttennhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txttennhanvien.Location = new System.Drawing.Point(50, 35);
            this.txttennhanvien.Name = "txttennhanvien";
            this.txttennhanvien.Size = new System.Drawing.Size(175, 22);
            this.txttennhanvien.TabIndex = 10;
            // 
            // btlammoi1
            // 
            this.btlammoi1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btlammoi1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btlammoi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btlammoi1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btlammoi1.Image = global::Interface.Properties.Resources.Hopstarter_Soft_Scraps_Button_Refresh;
            this.btlammoi1.Location = new System.Drawing.Point(122, 70);
            this.btlammoi1.Name = "btlammoi1";
            this.btlammoi1.Size = new System.Drawing.Size(50, 60);
            this.btlammoi1.TabIndex = 9;
            this.btlammoi1.UseVisualStyleBackColor = true;
            this.btlammoi1.Click += new System.EventHandler(this.btlammoi1_Click);
            // 
            // bttimnhanvien
            // 
            this.bttimnhanvien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bttimnhanvien.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttimnhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bttimnhanvien.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bttimnhanvien.Image = global::Interface.Properties.Resources.Zerode_Plump_Search;
            this.bttimnhanvien.Location = new System.Drawing.Point(65, 70);
            this.bttimnhanvien.Name = "bttimnhanvien";
            this.bttimnhanvien.Size = new System.Drawing.Size(50, 60);
            this.bttimnhanvien.TabIndex = 6;
            this.bttimnhanvien.UseVisualStyleBackColor = true;
            this.bttimnhanvien.Click += new System.EventHandler(this.bttimnhanvien_Click);
            // 
            // ThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1364, 750);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1380, 788);
            this.MinimumSize = new System.Drawing.Size(1358, 726);
            this.Name = "ThongKeDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống Kê Doanh Thu";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.ThongKeDoanhThu_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_hoadon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Soban)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btxemcthd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bttinhdt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown Soban;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttim;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btlammoi;
        private System.Windows.Forms.Label lbmahd;
        private System.Windows.Forms.ComboBox cbnam;
        private System.Windows.Forms.ComboBox cbthang;
        private System.Windows.Forms.ComboBox cbngay;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.RadioButton rdThang;
        private System.Windows.Forms.RadioButton rdNgay;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttennhanvien;
        private System.Windows.Forms.Button btlammoi1;
        private System.Windows.Forms.Button bttimnhanvien;
        private System.Windows.Forms.DataGridView dg_hoadon;
    }
}