namespace Interface
{
    partial class GopBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GopBan));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btgop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dg_cthd = new System.Windows.Forms.DataGridView();
            this.cbmabanconguoi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbanconguoi = new System.Windows.Forms.ComboBox();
            this.cbmabanconguoi1 = new System.Windows.Forms.ComboBox();
            this.cbbanconguoi1 = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_cthd)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btgop);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(303, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(93, 64);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gộp";
            // 
            // btgop
            // 
            this.btgop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btgop.ForeColor = System.Drawing.Color.Transparent;
            this.btgop.Image = global::Interface.Properties.Resources.dining_table;
            this.btgop.Location = new System.Drawing.Point(6, 19);
            this.btgop.Name = "btgop";
            this.btgop.Size = new System.Drawing.Size(74, 39);
            this.btgop.TabIndex = 0;
            this.btgop.UseVisualStyleBackColor = true;
            this.btgop.Click += new System.EventHandler(this.btgop_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dg_cthd);
            this.groupBox1.Controls.Add(this.cbmabanconguoi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbbanconguoi);
            this.groupBox1.Controls.Add(this.cbmabanconguoi1);
            this.groupBox1.Controls.Add(this.cbbanconguoi1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 64);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn bàn cần gộp";
            // 
            // dg_cthd
            // 
            this.dg_cthd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_cthd.Location = new System.Drawing.Point(269, 0);
            this.dg_cthd.Name = "dg_cthd";
            this.dg_cthd.Size = new System.Drawing.Size(22, 22);
            this.dg_cthd.TabIndex = 4;
            // 
            // cbmabanconguoi
            // 
            this.cbmabanconguoi.FormattingEnabled = true;
            this.cbmabanconguoi.Location = new System.Drawing.Point(136, 0);
            this.cbmabanconguoi.Name = "cbmabanconguoi";
            this.cbmabanconguoi.Size = new System.Drawing.Size(61, 26);
            this.cbmabanconguoi.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(116, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sang";
            // 
            // cbbanconguoi
            // 
            this.cbbanconguoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbanconguoi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbbanconguoi.FormattingEnabled = true;
            this.cbbanconguoi.Location = new System.Drawing.Point(6, 28);
            this.cbbanconguoi.Name = "cbbanconguoi";
            this.cbbanconguoi.Size = new System.Drawing.Size(104, 24);
            this.cbbanconguoi.TabIndex = 3;
            // 
            // cbmabanconguoi1
            // 
            this.cbmabanconguoi1.FormattingEnabled = true;
            this.cbmabanconguoi1.Location = new System.Drawing.Point(203, 0);
            this.cbmabanconguoi1.Name = "cbmabanconguoi1";
            this.cbmabanconguoi1.Size = new System.Drawing.Size(61, 26);
            this.cbmabanconguoi1.TabIndex = 2;
            // 
            // cbbanconguoi1
            // 
            this.cbbanconguoi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbanconguoi1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbbanconguoi1.FormattingEnabled = true;
            this.cbbanconguoi1.Location = new System.Drawing.Point(166, 29);
            this.cbbanconguoi1.Name = "cbbanconguoi1";
            this.cbbanconguoi1.Size = new System.Drawing.Size(104, 24);
            this.cbbanconguoi1.TabIndex = 1;
            // 
            // GopBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 85);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(424, 123);
            this.MinimumSize = new System.Drawing.Size(424, 123);
            this.Name = "GopBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gộp bàn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GopBan_FormClosing);
            this.Load += new System.EventHandler(this.GopBan_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_cthd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btgop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbmabanconguoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbanconguoi;
        private System.Windows.Forms.ComboBox cbmabanconguoi1;
        private System.Windows.Forms.ComboBox cbbanconguoi1;
        private System.Windows.Forms.DataGridView dg_cthd;
    }
}