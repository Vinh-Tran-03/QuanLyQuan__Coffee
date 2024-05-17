namespace Interface
{
    partial class BANAN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BANAN));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbiddouong = new System.Windows.Forms.ComboBox();
            this.dg_dsban = new System.Windows.Forms.DataGridView();
            this.btthemban = new System.Windows.Forms.Button();
            this.cbiddm = new System.Windows.Forms.ComboBox();
            this.Soban = new System.Windows.Forms.NumericUpDown();
            this.lbthemban = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.THUCDON = new System.Windows.Forms.GroupBox();
            this.btgopban = new System.Windows.Forms.Button();
            this.cbten = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbgia = new System.Windows.Forms.ComboBox();
            this.btthanhtoan = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.numericsoluongdoan = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cbdanhmuc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DSMON = new System.Windows.Forms.GroupBox();
            this.dg_monan_ofban = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnt_banan = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_dsban)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Soban)).BeginInit();
            this.THUCDON.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericsoluongdoan)).BeginInit();
            this.DSMON.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_monan_ofban)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cbiddouong);
            this.groupBox1.Controls.Add(this.dg_dsban);
            this.groupBox1.Controls.Add(this.btthemban);
            this.groupBox1.Controls.Add(this.cbiddm);
            this.groupBox1.Controls.Add(this.Soban);
            this.groupBox1.Controls.Add(this.lbthemban);
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 644);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sơ đồ bàn";
            // 
            // cbiddouong
            // 
            this.cbiddouong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbiddouong.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbiddouong.FormattingEnabled = true;
            this.cbiddouong.Location = new System.Drawing.Point(308, 14);
            this.cbiddouong.Name = "cbiddouong";
            this.cbiddouong.Size = new System.Drawing.Size(34, 26);
            this.cbiddouong.TabIndex = 14;
            // 
            // dg_dsban
            // 
            this.dg_dsban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_dsban.Location = new System.Drawing.Point(380, 18);
            this.dg_dsban.Name = "dg_dsban";
            this.dg_dsban.Size = new System.Drawing.Size(24, 16);
            this.dg_dsban.TabIndex = 7;
            // 
            // btthemban
            // 
            this.btthemban.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btthemban.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btthemban.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btthemban.Location = new System.Drawing.Point(235, 16);
            this.btthemban.Name = "btthemban";
            this.btthemban.Size = new System.Drawing.Size(67, 22);
            this.btthemban.TabIndex = 6;
            this.btthemban.Text = "Thêm";
            this.btthemban.UseVisualStyleBackColor = true;
            this.btthemban.Click += new System.EventHandler(this.btthemban_Click);
            // 
            // cbiddm
            // 
            this.cbiddm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbiddm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbiddm.FormattingEnabled = true;
            this.cbiddm.Location = new System.Drawing.Point(340, 14);
            this.cbiddm.Name = "cbiddm";
            this.cbiddm.Size = new System.Drawing.Size(34, 26);
            this.cbiddm.TabIndex = 13;
            // 
            // Soban
            // 
            this.Soban.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Soban.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Soban.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Soban.Location = new System.Drawing.Point(172, 16);
            this.Soban.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.Soban.Name = "Soban";
            this.Soban.Size = new System.Drawing.Size(57, 22);
            this.Soban.TabIndex = 5;
            this.Soban.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbthemban
            // 
            this.lbthemban.AutoSize = true;
            this.lbthemban.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbthemban.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbthemban.Location = new System.Drawing.Point(76, 18);
            this.lbthemban.Name = "lbthemban";
            this.lbthemban.Size = new System.Drawing.Size(90, 16);
            this.lbthemban.TabIndex = 4;
            this.lbthemban.Text = "Thêm số bàn:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.flowLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 41);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(477, 600);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // THUCDON
            // 
            this.THUCDON.BackColor = System.Drawing.Color.Transparent;
            this.THUCDON.Controls.Add(this.btgopban);
            this.THUCDON.Controls.Add(this.cbten);
            this.THUCDON.Controls.Add(this.label4);
            this.THUCDON.Controls.Add(this.cbgia);
            this.THUCDON.Controls.Add(this.btthanhtoan);
            this.THUCDON.Controls.Add(this.button1);
            this.THUCDON.Controls.Add(this.btXoa);
            this.THUCDON.Controls.Add(this.btThem);
            this.THUCDON.Controls.Add(this.numericsoluongdoan);
            this.THUCDON.Controls.Add(this.label3);
            this.THUCDON.Controls.Add(this.cbdanhmuc);
            this.THUCDON.Controls.Add(this.label2);
            this.THUCDON.Controls.Add(this.label1);
            this.THUCDON.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.THUCDON.ForeColor = System.Drawing.Color.Red;
            this.THUCDON.Location = new System.Drawing.Point(507, 27);
            this.THUCDON.Name = "THUCDON";
            this.THUCDON.Size = new System.Drawing.Size(845, 123);
            this.THUCDON.TabIndex = 3;
            this.THUCDON.TabStop = false;
            this.THUCDON.Text = "Chọn thực đơn";
            // 
            // btgopban
            // 
            this.btgopban.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btgopban.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btgopban.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btgopban.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btgopban.Image = global::Interface.Properties.Resources.dining_table;
            this.btgopban.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btgopban.Location = new System.Drawing.Point(644, 23);
            this.btgopban.Name = "btgopban";
            this.btgopban.Size = new System.Drawing.Size(89, 83);
            this.btgopban.TabIndex = 17;
            this.btgopban.Text = "Gộp bàn...";
            this.btgopban.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btgopban.UseVisualStyleBackColor = true;
            this.btgopban.Click += new System.EventHandler(this.btgopban_Click);
            // 
            // cbten
            // 
            this.cbten.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cbten.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbten.FormattingEnabled = true;
            this.cbten.Location = new System.Drawing.Point(92, 51);
            this.cbten.Name = "cbten";
            this.cbten.Size = new System.Drawing.Size(259, 26);
            this.cbten.TabIndex = 16;
            this.cbten.Click += new System.EventHandler(this.cbten_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(309, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Phần";
            // 
            // cbgia
            // 
            this.cbgia.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cbgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbgia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbgia.FormatString = "C0";
            this.cbgia.FormattingEnabled = true;
            this.cbgia.Location = new System.Drawing.Point(154, 83);
            this.cbgia.Name = "cbgia";
            this.cbgia.Size = new System.Drawing.Size(149, 26);
            this.cbgia.TabIndex = 14;
            // 
            // btthanhtoan
            // 
            this.btthanhtoan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btthanhtoan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btthanhtoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btthanhtoan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btthanhtoan.Image = global::Interface.Properties.Resources.Hopstarter_Sleek_Xp_Basic_Money;
            this.btthanhtoan.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btthanhtoan.Location = new System.Drawing.Point(739, 23);
            this.btthanhtoan.Name = "btthanhtoan";
            this.btthanhtoan.Size = new System.Drawing.Size(89, 83);
            this.btthanhtoan.TabIndex = 12;
            this.btthanhtoan.Text = "Thanh toán...";
            this.btthanhtoan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btthanhtoan.UseVisualStyleBackColor = true;
            this.btthanhtoan.Click += new System.EventHandler(this.btthanhtoan_Click);
            this.btthanhtoan.MouseLeave += new System.EventHandler(this.btthanhtoan_MouseLeave);
            this.btthanhtoan.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btthanhtoan_MouseMove);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Image = global::Interface.Properties.Resources.Hopstarter_Soft_Scraps_Button_Refresh;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(548, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 83);
            this.button1.TabIndex = 11;
            this.button1.Text = "Chuyển bàn...";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            // 
            // btXoa
            // 
            this.btXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btXoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btXoa.Image = global::Interface.Properties.Resources.Deleteico1;
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(452, 22);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(90, 83);
            this.btXoa.TabIndex = 10;
            this.btXoa.Text = "Xóa";
            this.btXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            this.btXoa.MouseLeave += new System.EventHandler(this.btXoa_MouseLeave);
            this.btXoa.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btXoa_MouseMove);
            // 
            // btThem
            // 
            this.btThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btThem.Image = global::Interface.Properties.Resources.SAVEADD;
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(357, 22);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(89, 83);
            this.btThem.TabIndex = 9;
            this.btThem.Text = "Thêm";
            this.btThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            this.btThem.MouseLeave += new System.EventHandler(this.btThem_MouseLeave);
            this.btThem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btThem_MouseMove);
            // 
            // numericsoluongdoan
            // 
            this.numericsoluongdoan.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.numericsoluongdoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.numericsoluongdoan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.numericsoluongdoan.Location = new System.Drawing.Point(92, 84);
            this.numericsoluongdoan.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericsoluongdoan.Name = "numericsoluongdoan";
            this.numericsoluongdoan.Size = new System.Drawing.Size(56, 24);
            this.numericsoluongdoan.TabIndex = 8;
            this.numericsoluongdoan.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số lượng:";
            // 
            // cbdanhmuc
            // 
            this.cbdanhmuc.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cbdanhmuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbdanhmuc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbdanhmuc.FormattingEnabled = true;
            this.cbdanhmuc.Location = new System.Drawing.Point(92, 21);
            this.cbdanhmuc.Name = "cbdanhmuc";
            this.cbdanhmuc.Size = new System.Drawing.Size(259, 26);
            this.cbdanhmuc.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên món:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh mục:";
            // 
            // DSMON
            // 
            this.DSMON.BackColor = System.Drawing.Color.Transparent;
            this.DSMON.Controls.Add(this.dg_monan_ofban);
            this.DSMON.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DSMON.ForeColor = System.Drawing.Color.Red;
            this.DSMON.Location = new System.Drawing.Point(507, 156);
            this.DSMON.Name = "DSMON";
            this.DSMON.Size = new System.Drawing.Size(845, 515);
            this.DSMON.TabIndex = 4;
            this.DSMON.TabStop = false;
            this.DSMON.Text = "Danh sách món ăn của bàn:";
            // 
            // dg_monan_ofban
            // 
            this.dg_monan_ofban.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_monan_ofban.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dg_monan_ofban.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_monan_ofban.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_monan_ofban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_monan_ofban.DefaultCellStyle = dataGridViewCellStyle2;
            this.dg_monan_ofban.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_monan_ofban.EnableHeadersVisualStyles = false;
            this.dg_monan_ofban.Location = new System.Drawing.Point(3, 20);
            this.dg_monan_ofban.Name = "dg_monan_ofban";
            this.dg_monan_ofban.Size = new System.Drawing.Size(839, 492);
            this.dg_monan_ofban.TabIndex = 0;
            this.dg_monan_ofban.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dg_monan_ofban_DataError);
            this.dg_monan_ofban.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_monan_ofban_RowEnter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnt_banan});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1364, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnt_banan
            // 
            this.mnt_banan.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mnt_banan.Image = global::Interface.Properties.Resources.Hopstarter_Soft_Scraps_Text_Edit;
            this.mnt_banan.Name = "mnt_banan";
            this.mnt_banan.Size = new System.Drawing.Size(157, 24);
            this.mnt_banan.Text = "Chỉnh sửa bàn ăn";
            this.mnt_banan.Click += new System.EventHandler(this.mnt_banan_Click);
            // 
            // BANAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1364, 750);
            this.Controls.Add(this.DSMON);
            this.Controls.Add(this.THUCDON);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1380, 788);
            this.MinimumSize = new System.Drawing.Size(1358, 726);
            this.Name = "BANAN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÔNG TIN VÀ SƠ ĐỒ BÀN";
            this.Load += new System.EventHandler(this.BANAN_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_dsban)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Soban)).EndInit();
            this.THUCDON.ResumeLayout(false);
            this.THUCDON.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericsoluongdoan)).EndInit();
            this.DSMON.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_monan_ofban)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox THUCDON;
        private System.Windows.Forms.Button btthemban;
        private System.Windows.Forms.NumericUpDown Soban;
        private System.Windows.Forms.Label lbthemban;
        private System.Windows.Forms.DataGridView dg_dsban;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnt_banan;
        private System.Windows.Forms.NumericUpDown numericsoluongdoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbdanhmuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btthanhtoan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbiddm;
        private System.Windows.Forms.ComboBox cbgia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ComboBox cbiddouong;
        private System.Windows.Forms.ComboBox cbten;
        public System.Windows.Forms.DataGridView dg_monan_ofban;
        public System.Windows.Forms.GroupBox DSMON;
        private System.Windows.Forms.Button btgopban;
    }
}