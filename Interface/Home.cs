using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUL;
using System.IO;

namespace Interface
{
    public partial class Home : Form
    {
        public static Home trangchu;
        public Home()
        {
            InitializeComponent();
            trangchu = this;
            
        }
        GANGIATRISQL_BUL gangiatrisql_bul = new GANGIATRISQL_BUL(tenmaychu, tencsdl);
        BANAN banan = new BANAN();
        MENU menu = new MENU();
        NHANVIEN nhanvien = new NHANVIEN();
        ThongKeDoanhThu thongke = new ThongKeDoanhThu();
        private bool bbanan = false, bmenu = false, bnhanvien = false, bthongke = false;            
        private void MNT_NHANVIEN_Click(object sender, EventArgs e)
        {
            MNT_BANAN.ForeColor = SystemColors.ControlText;
            MNT_DANGXUAT.ForeColor = SystemColors.ControlText;
            MNT_DOANHTHU.ForeColor = SystemColors.ControlText;
            MNT_NHANVIEN.ForeColor = Color.Chocolate;
            MNT_THUCDON.ForeColor = SystemColors.ControlText;
            if (bmenu == true)
            {
                bmenu = false;
                menu.Hide();
                bnhanvien = true;
                nhanvien.TopLevel = false;
                pictureBox1.Controls.Add(nhanvien);
                nhanvien.FormBorderStyle = FormBorderStyle.None;
                nhanvien.Show();
            }
            else if (bbanan == true)
            {
                bbanan = false;
                banan.Hide();
                bnhanvien = true;
                nhanvien.TopLevel = false;
                pictureBox1.Controls.Add(nhanvien);
                nhanvien.FormBorderStyle = FormBorderStyle.None;
                nhanvien.Show();
            }
            else if (bthongke == true)
            {
                bthongke = false;
                thongke.Hide();
                bnhanvien = true;
                nhanvien.TopLevel = false;
                pictureBox1.Controls.Add(nhanvien);
                nhanvien.FormBorderStyle = FormBorderStyle.None;
                nhanvien.Show();
            }
            else
            {
                bnhanvien = true;
                nhanvien.TopLevel = false;
                pictureBox1.Controls.Add(nhanvien);
                nhanvien.FormBorderStyle = FormBorderStyle.None;
                nhanvien.Show();
            }
        }
        private void EnableMNT()
        {
            MNT_BANAN.Enabled = false;
            MNT_DOANHTHU.Enabled = false;
            MNT_NHANVIEN.Enabled = false;
            MNT_THUCDON.Enabled = false;
            MNT_DANGXUAT.Enabled = false;
            lbquyen.Hide();           
        }
        private string IDNV = "", quyenofnv = "";
        internal void EnableQuyen(string quyennv, string tennv, string idnv)
        {
            if (quyennv == "ADMIN")
            {
                MNT_BANAN.Enabled = true;
                MNT_DOANHTHU.Enabled = true;
                MNT_NHANVIEN.Enabled = true;
                MNT_THUCDON.Enabled = true;
                MNT_DANGXUAT.Enabled = true;
                lbquyen.Show();
                lbquyen.Text = "Admin: " + tennv;
                IDNV = idnv;
                quyenofnv = quyennv;
            }
            else if (quyennv == "NHANVIEN")
            {
                MNT_BANAN.Enabled = true;
                MNT_DANGXUAT.Enabled = true;
                lbquyen.Show();
                lbquyen.Text = "Nhân viên: " + tennv;
                IDNV = idnv;
                quyenofnv = quyennv;
            }
        }
        static string duongdan = System.Windows.Forms.Application.StartupPath + "\\";
        //static string duongdan = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
        static string tenmaychu = File.ReadAllText(duongdan + "tenmaychu.txt");
        static string tencsdl = File.ReadAllText(duongdan + "tencsdl.txt");
        string filename = duongdan + "checkdk.txt";
        string checkgiatridangky = File.ReadAllText(duongdan + "checkdk.txt");
        private void Home_Load(object sender, EventArgs e)
        {
            if (checkgiatridangky != "dashow")
            {
                File.WriteAllText(filename, "dashow");
                DANGKY dk = new DANGKY();
                dk.ShowDialog();
            }
            EnableMNT();
            DANGNHAP dn = new DANGNHAP();
            dn.FormClosing += new FormClosingEventHandler(dn.DANGNHAP_FormClosing);
            dn.ShowDialog();          
        }  

        private void MNT_DANGXUAT_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.ShowDialog();
            Application.Exit();
        }

        private void MNT_DOANHTHU_Click(object sender, EventArgs e)
        {
            MNT_BANAN.ForeColor = SystemColors.ControlText;
            MNT_DANGXUAT.ForeColor = SystemColors.ControlText;
            MNT_DOANHTHU.ForeColor = Color.Chocolate;
            MNT_NHANVIEN.ForeColor = SystemColors.ControlText;
            MNT_THUCDON.ForeColor = SystemColors.ControlText;
            if (bbanan == true)
            {
                bbanan = false;
                banan.Hide();
                bthongke = true;
                thongke.TopLevel = false;
                pictureBox1.Controls.Add(thongke);
                thongke.FormBorderStyle = FormBorderStyle.None;
                thongke.Show();
                thongke.btlammoi_Click(sender, e);
            }
            else if (bmenu == true)
            {
                bmenu = false;
                menu.Hide();
                bthongke = true;
                thongke.TopLevel = false;
                pictureBox1.Controls.Add(thongke);
                thongke.FormBorderStyle = FormBorderStyle.None;
                thongke.Show();
                thongke.btlammoi_Click(sender, e);
            }
            else if (bnhanvien == true)
            {
                bnhanvien = false;
                nhanvien.Hide();
                bthongke = true;
                thongke.TopLevel = false;
                pictureBox1.Controls.Add(thongke);
                thongke.FormBorderStyle = FormBorderStyle.None;
                thongke.Show();
                thongke.btlammoi_Click(sender, e);
            }
            else
            {
                bthongke = true;
                thongke.TopLevel = false;
                pictureBox1.Controls.Add(thongke);
                thongke.FormBorderStyle = FormBorderStyle.None;
                thongke.Show();
                thongke.btlammoi_Click(sender, e);
            }
        }

        private void MNT_THUCDON_Click(object sender, EventArgs e)
        {
            MNT_BANAN.ForeColor = SystemColors.ControlText;
            MNT_DANGXUAT.ForeColor = SystemColors.ControlText;
            MNT_DOANHTHU.ForeColor = SystemColors.ControlText;
            MNT_NHANVIEN.ForeColor = SystemColors.ControlText;
            MNT_THUCDON.ForeColor = Color.Chocolate;
            if (bnhanvien == true)
            {
                bnhanvien = false;
                nhanvien.Hide();
                bmenu = true;
                menu.TopLevel = false;
                pictureBox1.Controls.Add(menu);
                menu.FormBorderStyle = FormBorderStyle.None;
                menu.Show();
            }
            else if (bbanan == true)
            {
                bbanan = false;
                banan.Hide();
                bmenu = true;
                menu.TopLevel = false;
                pictureBox1.Controls.Add(menu);
                menu.FormBorderStyle = FormBorderStyle.None;
                menu.Show();
            }
            else if (bthongke == true)
            {
                bthongke = false;
                thongke.Hide();
                bmenu = true;
                menu.TopLevel = false;
                pictureBox1.Controls.Add(menu);
                menu.FormBorderStyle = FormBorderStyle.None;
                menu.Show();
            }
            else
            {
                bmenu = true;
                menu.TopLevel = false;
                pictureBox1.Controls.Add(menu);
                menu.FormBorderStyle = FormBorderStyle.None;
                menu.Show();
            }
        }
        
        private void MNT_BANAN_Click(object sender, EventArgs e)
        {
            MNT_BANAN.ForeColor = Color.Chocolate;
            MNT_DANGXUAT.ForeColor = SystemColors.ControlText;
            MNT_DOANHTHU.ForeColor = SystemColors.ControlText;
            MNT_NHANVIEN.ForeColor = SystemColors.ControlText;
            MNT_THUCDON.ForeColor = SystemColors.ControlText;
            if (bnhanvien == true)
            {
                bnhanvien = false;
                nhanvien.Hide();
                bbanan = true;
                banan.TopLevel = false;
                pictureBox1.Controls.Add(banan);
                banan.FormBorderStyle = FormBorderStyle.None;
                banan.Idnv = IDNV;
                banan.Quyen = quyenofnv;
                banan.Show();
                banan.BANAN_Load(sender, e);
            }
            else if (bmenu == true)
            {
                bmenu = false;
                menu.Hide();
                bbanan = true;
                banan.TopLevel = false;
                pictureBox1.Controls.Add(banan);
                banan.FormBorderStyle = FormBorderStyle.None;
                banan.Idnv = IDNV;
                banan.Quyen = quyenofnv;
                banan.Show();
                banan.BANAN_Load(sender, e);
            }
            else if (bthongke == true)
            {
                bthongke = false;
                thongke.Hide();
                bbanan = true;
                banan.TopLevel = false;
                pictureBox1.Controls.Add(banan);
                banan.FormBorderStyle = FormBorderStyle.None;
                banan.Idnv = IDNV;
                banan.Quyen = quyenofnv;
                banan.Show();
                banan.BANAN_Load(sender, e);
            }
            else
            {
                bbanan = true;
                banan.TopLevel = false;
                pictureBox1.Controls.Add(banan);
                banan.FormBorderStyle = FormBorderStyle.None;
                banan.Idnv = IDNV;
                banan.Quyen = quyenofnv;
                banan.Show();
                banan.BANAN_Load(sender, e);
            }
        }
       
    }
}
