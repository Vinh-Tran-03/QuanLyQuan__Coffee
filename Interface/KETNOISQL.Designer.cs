namespace Interface
{
    partial class KETNOISQL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KETNOISQL));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttencsdl = new System.Windows.Forms.ComboBox();
            this.txttensv = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btketnoi = new System.Windows.Forms.Button();
            this.bttaocsdl = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txttencsdl);
            this.groupBox1.Controls.Add(this.txttensv);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 105);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txttencsdl
            // 
            this.txttencsdl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txttencsdl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txttencsdl.FormattingEnabled = true;
            this.txttencsdl.Location = new System.Drawing.Point(119, 67);
            this.txttencsdl.Name = "txttencsdl";
            this.txttencsdl.Size = new System.Drawing.Size(219, 24);
            this.txttencsdl.TabIndex = 3;
            this.txttencsdl.Text = "QuanLyQuanCaPhe";
            this.txttencsdl.Click += new System.EventHandler(this.txttencsdl_Click);
            // 
            // txttensv
            // 
            this.txttensv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txttensv.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txttensv.FormattingEnabled = true;
            this.txttensv.Location = new System.Drawing.Point(119, 19);
            this.txttensv.Name = "txttensv";
            this.txttensv.Size = new System.Drawing.Size(219, 24);
            this.txttensv.TabIndex = 2;
            this.txttensv.Text = "VINHTRAN\\VINHTRAN";
            this.txttensv.Click += new System.EventHandler(this.txttensv_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Cơ sở dữ liệu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên SQL Server:";
            // 
            // btketnoi
            // 
            this.btketnoi.BackColor = System.Drawing.Color.Transparent;
            this.btketnoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btketnoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btketnoi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btketnoi.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btketnoi.Location = new System.Drawing.Point(200, 123);
            this.btketnoi.Name = "btketnoi";
            this.btketnoi.Size = new System.Drawing.Size(105, 41);
            this.btketnoi.TabIndex = 1;
            this.btketnoi.Text = "Kết nối đến máy chủ";
            this.btketnoi.UseVisualStyleBackColor = false;
            this.btketnoi.Click += new System.EventHandler(this.btketnoi_Click);
            this.btketnoi.MouseLeave += new System.EventHandler(this.btketnoi_MouseLeave);
            this.btketnoi.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btketnoi_MouseMove);
            // 
            // bttaocsdl
            // 
            this.bttaocsdl.BackColor = System.Drawing.Color.Transparent;
            this.bttaocsdl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttaocsdl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bttaocsdl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bttaocsdl.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bttaocsdl.Location = new System.Drawing.Point(63, 123);
            this.bttaocsdl.Name = "bttaocsdl";
            this.bttaocsdl.Size = new System.Drawing.Size(105, 41);
            this.bttaocsdl.TabIndex = 2;
            this.bttaocsdl.Text = "Tạo cơ sở dữ liệu";
            this.bttaocsdl.UseVisualStyleBackColor = false;
            this.bttaocsdl.Click += new System.EventHandler(this.bttaocsdl_Click);
            this.bttaocsdl.MouseLeave += new System.EventHandler(this.bttaocsdl_MouseLeave);
            this.bttaocsdl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bttaocsdl_MouseMove);
            // 
            // KETNOISQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(367, 176);
            this.Controls.Add(this.bttaocsdl);
            this.Controls.Add(this.btketnoi);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(383, 215);
            this.MinimumSize = new System.Drawing.Size(383, 215);
            this.Name = "KETNOISQL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kết nối đến Cơ Sở Dữ Liệu";
            this.Load += new System.EventHandler(this.KETNOISQL_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox txttencsdl;
        private System.Windows.Forms.ComboBox txttensv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btketnoi;
        private System.Windows.Forms.Button bttaocsdl;
    }
}