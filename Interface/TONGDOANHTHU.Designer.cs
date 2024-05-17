namespace Interface
{
    partial class TONGDOANHTHU
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TONGDOANHTHU));
            this.groupBoxTONGDOANHTHU = new System.Windows.Forms.GroupBox();
            this.dg_dshd = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txttongtien = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bttin = new System.Windows.Forms.Button();
            this.groupBoxTONGDOANHTHU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_dshd)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTONGDOANHTHU
            // 
            this.groupBoxTONGDOANHTHU.Controls.Add(this.dg_dshd);
            this.groupBoxTONGDOANHTHU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBoxTONGDOANHTHU.ForeColor = System.Drawing.Color.Red;
            this.groupBoxTONGDOANHTHU.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTONGDOANHTHU.Name = "groupBoxTONGDOANHTHU";
            this.groupBoxTONGDOANHTHU.Size = new System.Drawing.Size(682, 406);
            this.groupBoxTONGDOANHTHU.TabIndex = 0;
            this.groupBoxTONGDOANHTHU.TabStop = false;
            this.groupBoxTONGDOANHTHU.Text = "Danh sách hóa đơn theo:";
            // 
            // dg_dshd
            // 
            this.dg_dshd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_dshd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dg_dshd.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_dshd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_dshd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_dshd.DefaultCellStyle = dataGridViewCellStyle2;
            this.dg_dshd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_dshd.EnableHeadersVisualStyles = false;
            this.dg_dshd.Location = new System.Drawing.Point(3, 22);
            this.dg_dshd.Name = "dg_dshd";
            this.dg_dshd.Size = new System.Drawing.Size(676, 381);
            this.dg_dshd.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txttongtien);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(15, 424);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(545, 87);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tổng doanh thu";
            // 
            // txttongtien
            // 
            this.txttongtien.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txttongtien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txttongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txttongtien.Location = new System.Drawing.Point(3, 22);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txttongtien.Size = new System.Drawing.Size(539, 62);
            this.txttongtien.TabIndex = 2;
            this.txttongtien.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bttin);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(566, 424);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(128, 87);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "In doanh thu";
            // 
            // bttin
            // 
            this.bttin.BackColor = System.Drawing.Color.Transparent;
            this.bttin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bttin.Image = global::Interface.Properties.Resources.Aha_Soft_Universal_Shop_Print;
            this.bttin.Location = new System.Drawing.Point(6, 19);
            this.bttin.Name = "bttin";
            this.bttin.Size = new System.Drawing.Size(116, 62);
            this.bttin.TabIndex = 0;
            this.bttin.UseVisualStyleBackColor = false;
            this.bttin.Click += new System.EventHandler(this.bttin_Click);
            this.bttin.MouseLeave += new System.EventHandler(this.bttin_MouseLeave);
            this.bttin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bttin_MouseMove);
            // 
            // TONGDOANHTHU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(707, 518);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxTONGDOANHTHU);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(723, 556);
            this.MinimumSize = new System.Drawing.Size(723, 556);
            this.Name = "TONGDOANHTHU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tổng Doanh Thu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TONGDOANHTHU_FormClosing);
            this.Load += new System.EventHandler(this.TONGDOANHTHU_Load);
            this.groupBoxTONGDOANHTHU.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_dshd)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTONGDOANHTHU;
        private System.Windows.Forms.DataGridView dg_dshd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bttin;
        private System.Windows.Forms.RichTextBox txttongtien;
    }
}