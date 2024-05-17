namespace Interface
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MNT_BANAN = new System.Windows.Forms.ToolStripMenuItem();
            this.MNT_THUCDON = new System.Windows.Forms.ToolStripMenuItem();
            this.MNT_NHANVIEN = new System.Windows.Forms.ToolStripMenuItem();
            this.MNT_DOANHTHU = new System.Windows.Forms.ToolStripMenuItem();
            this.MNT_DANGXUAT = new System.Windows.Forms.ToolStripMenuItem();
            this.lbquyen = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MNT_BANAN,
            this.MNT_THUCDON,
            this.MNT_NHANVIEN,
            this.MNT_DOANHTHU,
            this.MNT_DANGXUAT});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1096, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MNT_BANAN
            // 
            this.MNT_BANAN.Image = global::Interface.Properties.Resources.Archigraphs_Oldies_Coffee_Cup;
            this.MNT_BANAN.Name = "MNT_BANAN";
            this.MNT_BANAN.Size = new System.Drawing.Size(246, 21);
            this.MNT_BANAN.Text = "Sơ đồ bàn và Thanh toán hóa đơn";
            this.MNT_BANAN.Click += new System.EventHandler(this.MNT_BANAN_Click);
            // 
            // MNT_THUCDON
            // 
            this.MNT_THUCDON.Image = global::Interface.Properties.Resources.Babasse_Old_School_Coffee;
            this.MNT_THUCDON.Name = "MNT_THUCDON";
            this.MNT_THUCDON.Size = new System.Drawing.Size(155, 21);
            this.MNT_THUCDON.Text = "Thực đơn của quán";
            this.MNT_THUCDON.Click += new System.EventHandler(this.MNT_THUCDON_Click);
            // 
            // MNT_NHANVIEN
            // 
            this.MNT_NHANVIEN.Image = global::Interface.Properties.Resources.Aha_Soft_People_Engineer;
            this.MNT_NHANVIEN.Name = "MNT_NHANVIEN";
            this.MNT_NHANVIEN.Size = new System.Drawing.Size(182, 21);
            this.MNT_NHANVIEN.Text = "Nhân viên và Tài khoản";
            this.MNT_NHANVIEN.Click += new System.EventHandler(this.MNT_NHANVIEN_Click);
            // 
            // MNT_DOANHTHU
            // 
            this.MNT_DOANHTHU.Image = global::Interface.Properties.Resources.Webalys_Kameleon_pics_Money_Increase;
            this.MNT_DOANHTHU.Name = "MNT_DOANHTHU";
            this.MNT_DOANHTHU.Size = new System.Drawing.Size(162, 21);
            this.MNT_DOANHTHU.Text = "Thống kê doanh thu";
            this.MNT_DOANHTHU.Click += new System.EventHandler(this.MNT_DOANHTHU_Click);
            // 
            // MNT_DANGXUAT
            // 
            this.MNT_DANGXUAT.Image = global::Interface.Properties.Resources.Visualpharm_Must_Have_Log_Out;
            this.MNT_DANGXUAT.Name = "MNT_DANGXUAT";
            this.MNT_DANGXUAT.Size = new System.Drawing.Size(100, 21);
            this.MNT_DANGXUAT.Text = "Đăng xuất";
            this.MNT_DANGXUAT.Click += new System.EventHandler(this.MNT_DANGXUAT_Click);
            // 
            // lbquyen
            // 
            this.lbquyen.AutoSize = true;
            this.lbquyen.BackColor = System.Drawing.Color.Transparent;
            this.lbquyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbquyen.ForeColor = System.Drawing.Color.Red;
            this.lbquyen.Location = new System.Drawing.Point(1034, 4);
            this.lbquyen.Name = "lbquyen";
            this.lbquyen.Size = new System.Drawing.Size(60, 16);
            this.lbquyen.TabIndex = 3;
            this.lbquyen.Text = "Quyền :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Interface.Properties.Resources.grains_cup_coffee_background_83041_1920x1080;
            this.pictureBox1.Location = new System.Drawing.Point(0, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1096, 464);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1096, 489);
            this.Controls.Add(this.lbquyen);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coffee Your Name";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MNT_BANAN;
        private System.Windows.Forms.ToolStripMenuItem MNT_THUCDON;
        private System.Windows.Forms.ToolStripMenuItem MNT_NHANVIEN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem MNT_DOANHTHU;
        private System.Windows.Forms.Label lbquyen;
        private System.Windows.Forms.ToolStripMenuItem MNT_DANGXUAT;
    }
}