namespace Interface
{
    partial class DANGNHAP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DANGNHAP));
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.txttendangnhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btthoat = new System.Windows.Forms.Button();
            this.btdangnhap = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtmatkhau.Location = new System.Drawing.Point(226, 101);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(159, 20);
            this.txtmatkhau.TabIndex = 1;
            this.txtmatkhau.UseSystemPasswordChar = true;
            // 
            // txttendangnhap
            // 
            this.txttendangnhap.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txttendangnhap.Location = new System.Drawing.Point(226, 59);
            this.txttendangnhap.Name = "txttendangnhap";
            this.txttendangnhap.Size = new System.Drawing.Size(159, 20);
            this.txttendangnhap.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên tài khoản:";
            // 
            // btthoat
            // 
            this.btthoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btthoat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btthoat.Location = new System.Drawing.Point(299, 150);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(86, 24);
            this.btthoat.TabIndex = 3;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            this.btthoat.MouseLeave += new System.EventHandler(this.btthoat_MouseLeave);
            this.btthoat.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btthoat_MouseMove);
            // 
            // btdangnhap
            // 
            this.btdangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btdangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btdangnhap.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btdangnhap.Location = new System.Drawing.Point(147, 150);
            this.btdangnhap.Name = "btdangnhap";
            this.btdangnhap.Size = new System.Drawing.Size(86, 24);
            this.btdangnhap.TabIndex = 2;
            this.btdangnhap.Text = "Đăng nhập";
            this.btdangnhap.UseVisualStyleBackColor = true;
            this.btdangnhap.Click += new System.EventHandler(this.btdangnhap_Click);
            this.btdangnhap.MouseLeave += new System.EventHandler(this.btdangnhap_MouseLeave);
            this.btdangnhap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btdangnhap_MouseMove);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btthoat);
            this.panel1.Controls.Add(this.btdangnhap);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtmatkhau);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txttendangnhap);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 189);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(213, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Đăng nhập";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Interface.Properties.Resources.Keys_icon;
            this.pictureBox1.Location = new System.Drawing.Point(17, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // DANGNHAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(417, 212);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(433, 250);
            this.MinimumSize = new System.Drawing.Size(433, 250);
            this.Name = "DANGNHAP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập tài khoản";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DANGNHAP_FormClosing);
            this.Load += new System.EventHandler(this.DANGNHAP_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.TextBox txttendangnhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Button btdangnhap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}