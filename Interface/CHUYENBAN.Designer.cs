namespace Interface
{
    partial class CHUYENBAN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CHUYENBAN));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbmabanconguoi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbanconguoi = new System.Windows.Forms.ComboBox();
            this.cbmabantrong = new System.Windows.Forms.ComboBox();
            this.cbtenban = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btchuyen = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cbmabanconguoi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbbanconguoi);
            this.groupBox1.Controls.Add(this.cbmabantrong);
            this.groupBox1.Controls.Add(this.cbtenban);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 64);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn bàn cần chuyển";
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
            // cbmabantrong
            // 
            this.cbmabantrong.FormattingEnabled = true;
            this.cbmabantrong.Location = new System.Drawing.Point(203, 0);
            this.cbmabantrong.Name = "cbmabantrong";
            this.cbmabantrong.Size = new System.Drawing.Size(61, 26);
            this.cbmabantrong.TabIndex = 2;
            // 
            // cbtenban
            // 
            this.cbtenban.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbtenban.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbtenban.FormattingEnabled = true;
            this.cbtenban.Location = new System.Drawing.Point(166, 29);
            this.cbtenban.Name = "cbtenban";
            this.cbtenban.Size = new System.Drawing.Size(104, 24);
            this.cbtenban.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btchuyen);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(297, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(87, 64);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chuyển";
            // 
            // btchuyen
            // 
            this.btchuyen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btchuyen.ForeColor = System.Drawing.Color.Transparent;
            this.btchuyen.Image = global::Interface.Properties.Resources.Hopstarter_Soft_Scraps_Button_Refresh;
            this.btchuyen.Location = new System.Drawing.Point(6, 19);
            this.btchuyen.Name = "btchuyen";
            this.btchuyen.Size = new System.Drawing.Size(74, 39);
            this.btchuyen.TabIndex = 0;
            this.btchuyen.UseVisualStyleBackColor = true;
            this.btchuyen.Click += new System.EventHandler(this.btchuyen_Click);
            // 
            // CHUYENBAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(390, 86);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(406, 124);
            this.MinimumSize = new System.Drawing.Size(406, 124);
            this.Name = "CHUYENBAN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chuyển bàn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CHUYENBAN_FormClosing);
            this.Load += new System.EventHandler(this.CHUYENBAN_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbtenban;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btchuyen;
        private System.Windows.Forms.ComboBox cbmabantrong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbanconguoi;
        private System.Windows.Forms.ComboBox cbmabanconguoi;
    }
}