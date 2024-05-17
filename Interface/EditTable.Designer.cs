namespace Interface
{
    partial class EditTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTable));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.treedsban = new System.Windows.Forms.TreeView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btHuy = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttrangthai = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtmaban = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbmaban = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.treedsban);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(316, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 350);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách bàn";
            // 
            // treedsban
            // 
            this.treedsban.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treedsban.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.treedsban.Location = new System.Drawing.Point(3, 20);
            this.treedsban.Name = "treedsban";
            this.treedsban.Size = new System.Drawing.Size(204, 327);
            this.treedsban.TabIndex = 0;
            this.treedsban.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.treedsban_BeforeSelect);
            this.treedsban.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treedsban_AfterSelect);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.btThoat);
            this.groupBox6.Controls.Add(this.btSua);
            this.groupBox6.Controls.Add(this.btThem);
            this.groupBox6.Controls.Add(this.btHuy);
            this.groupBox6.Controls.Add(this.btLuu);
            this.groupBox6.Controls.Add(this.btXoa);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox6.ForeColor = System.Drawing.Color.Red;
            this.groupBox6.Location = new System.Drawing.Point(12, 232);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(298, 130);
            this.groupBox6.TabIndex = 15;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Chức năng";
            // 
            // btThoat
            // 
            this.btThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThoat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btThoat.Image = global::Interface.Properties.Resources.Deleteico;
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Location = new System.Drawing.Point(200, 74);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(90, 45);
            this.btThoat.TabIndex = 7;
            this.btThoat.Text = "Thoát";
            this.btThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            this.btThoat.MouseLeave += new System.EventHandler(this.btThoat_MouseLeave);
            this.btThoat.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btThoat_MouseMove);
            // 
            // btSua
            // 
            this.btSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btSua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btSua.Image = global::Interface.Properties.Resources.UpdateIco;
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSua.Location = new System.Drawing.Point(104, 23);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(90, 45);
            this.btSua.TabIndex = 1;
            this.btSua.Text = "Sửa";
            this.btSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            this.btSua.MouseLeave += new System.EventHandler(this.btSua_MouseLeave);
            this.btSua.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btSua_MouseMove);
            // 
            // btThem
            // 
            this.btThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btThem.Image = global::Interface.Properties.Resources.ICOADD;
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(9, 23);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(89, 45);
            this.btThem.TabIndex = 0;
            this.btThem.Text = "Thêm";
            this.btThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            this.btThem.MouseLeave += new System.EventHandler(this.btThem_MouseLeave);
            this.btThem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btThem_MouseMove);
            // 
            // btHuy
            // 
            this.btHuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btHuy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btHuy.Image = global::Interface.Properties.Resources.btHuy;
            this.btHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHuy.Location = new System.Drawing.Point(104, 74);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(90, 45);
            this.btHuy.TabIndex = 4;
            this.btHuy.Text = "Hủy";
            this.btHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btHuy.UseVisualStyleBackColor = true;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            this.btHuy.MouseLeave += new System.EventHandler(this.btHuy_MouseLeave);
            this.btHuy.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btHuy_MouseMove);
            // 
            // btLuu
            // 
            this.btLuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btLuu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btLuu.Image = global::Interface.Properties.Resources.SAVEADD;
            this.btLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLuu.Location = new System.Drawing.Point(9, 74);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(89, 45);
            this.btLuu.TabIndex = 3;
            this.btLuu.Text = "Lưu";
            this.btLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            this.btLuu.MouseLeave += new System.EventHandler(this.btLuu_MouseLeave);
            this.btLuu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btLuu_MouseMove);
            // 
            // btXoa
            // 
            this.btXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btXoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btXoa.Image = global::Interface.Properties.Resources.Deleteico1;
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(200, 23);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(90, 45);
            this.btXoa.TabIndex = 2;
            this.btXoa.Text = "Xóa";
            this.btXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            this.btXoa.MouseLeave += new System.EventHandler(this.btXoa_MouseLeave);
            this.btXoa.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btXoa_MouseMove);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txttrangthai);
            this.groupBox1.Controls.Add(this.txtten);
            this.groupBox1.Controls.Add(this.txtmaban);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbmaban);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 214);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin bàn";
            // 
            // txttrangthai
            // 
            this.txttrangthai.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txttrangthai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txttrangthai.Location = new System.Drawing.Point(83, 172);
            this.txttrangthai.Name = "txttrangthai";
            this.txttrangthai.Size = new System.Drawing.Size(207, 22);
            this.txttrangthai.TabIndex = 5;
            // 
            // txtten
            // 
            this.txtten.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtten.Location = new System.Drawing.Point(83, 102);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(207, 22);
            this.txtten.TabIndex = 4;
            // 
            // txtmaban
            // 
            this.txtmaban.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtmaban.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtmaban.Location = new System.Drawing.Point(83, 29);
            this.txtmaban.Name = "txtmaban";
            this.txtmaban.Size = new System.Drawing.Size(207, 22);
            this.txtmaban.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(6, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trạng thái:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(6, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên:";
            // 
            // lbmaban
            // 
            this.lbmaban.AutoSize = true;
            this.lbmaban.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbmaban.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbmaban.Location = new System.Drawing.Point(6, 32);
            this.lbmaban.Name = "lbmaban";
            this.lbmaban.Size = new System.Drawing.Size(56, 16);
            this.lbmaban.TabIndex = 0;
            this.lbmaban.Text = "Mã bàn:";
            // 
            // EditTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(537, 374);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(553, 412);
            this.MinimumSize = new System.Drawing.Size(553, 412);
            this.Name = "EditTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chỉnh sửa bàn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditTable_FormClosing);
            this.Load += new System.EventHandler(this.EditTable_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TreeView treedsban;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txttrangthai;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtmaban;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbmaban;
    }
}