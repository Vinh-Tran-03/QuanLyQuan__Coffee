using BUL;
using PUBLIC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
namespace Interface
{
    public partial class DANGKY : Form
    {
        public DANGKY()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void DANGKY_Load(object sender, EventArgs e)
        {
            cbgioitinh.DropDownStyle = ComboBoxStyle.DropDownList;
            rdnhanvien.Enabled = false;          
        }
        private void tatlbtrangthai()
        {
            Thread.Sleep(2000);
            lbtrangthai.Text = "";
        }
        NHANVIEN_BUL nv_bul = new NHANVIEN_BUL();
        TAIKHOAN_BUL tk_bul = new TAIKHOAN_BUL();
        HINHNV_BUL hinh_bul = new HINHNV_BUL();
        int manv;
        string quyen = "";
        private void insertnhanvien()
        {
            NHANVIEN_PUBLIC nv_public = new NHANVIEN_PUBLIC();
            manv = nv_bul.count_nhanvien();
            nv_public.IDNV = "NV" + manv.ToString();
            nv_public.TENNV = txthovaten.Text;
            nv_public.NGAYSINH = DateTime.Parse(datengaysinh.Text);
            nv_public.SDT = txtsdt.Text;
            nv_public.GIOITINH = cbgioitinh.Text;
            nv_bul.insert_nhanvien(nv_public);
        }
        private void inserttaikhoan()
        {
            TAIKHOAN_PUBLIC tk_public = new TAIKHOAN_PUBLIC();
            tk_public.TENTK = txttentk.Text;
            tk_public.MATKHAU = txtmatkhau.Text;
            tk_public.QUYEN = quyen;
            tk_public.IDNV = "NV" + manv.ToString();
            tk_bul.insert_taikhoan(tk_public);
        }
        string duongdandk = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private void inserthinh()
        {
            HINHNV_PUBLIC hinhnv_public = new HINHNV_PUBLIC();
            string duongdan = duongdandk + @"\DatabaseCafe\AddIco.png"; // có thể lỗi
            // FileStream để đọc các tập tin hình.
            FileStream fs = new FileStream(duongdan, FileMode.Open, FileAccess.Read);
            // Tạo mảng kiểu byte với cái kích thước của Filestream
            byte[] mangLuuHinh = new byte[fs.Length];
            // Đọc dữ liệu từ FileStream và bỏ vào cái mảng Byte
            fs.Read(mangLuuHinh, 0, Convert.ToInt32(fs.Length));
            // Đóng filestream
            fs.Close();
            hinhnv_public.HINH = mangLuuHinh;
            hinhnv_public.IDNV = "NV" + manv.ToString();
            hinh_bul.insert_hinhnv(hinhnv_public);
        }
        
        private void btdangky_Click(object sender, EventArgs e)
        {
            if (txttentk.TextLength == 0)
            {
                lbtrangthai.ForeColor = Color.Red;
                lbtrangthai.Text = "Chưa điền tên tài khoản.";
                Thread t = new Thread(new ThreadStart(tatlbtrangthai));
                t.IsBackground = false;
                t.Start();
            }
            else if (txttentk.TextLength <= 3)
            {
                lbtrangthai.ForeColor = Color.Red;
                lbtrangthai.Text = "Tên tài khoản quá ngắn.";
                Thread t = new Thread(new ThreadStart(tatlbtrangthai));
                t.IsBackground = false;
                t.Start();
            }
            else if (txttentk.TextLength >= 50)
            {
                lbtrangthai.ForeColor = Color.Red;
                lbtrangthai.Text = "Tên tài khoản quá dài.";
                Thread t = new Thread(new ThreadStart(tatlbtrangthai));
                t.IsBackground = false;
                t.Start();
            }
            else if (txtmatkhau.TextLength == 0)
            {
                lbtrangthai.ForeColor = Color.Red;
                lbtrangthai.Text = "Chưa điền mật khẩu.";
                Thread t = new Thread(new ThreadStart(tatlbtrangthai));
                t.IsBackground = false;
                t.Start();
            }
            else if (txtmatkhau.TextLength <= 6)
            {
                lbtrangthai.ForeColor = Color.Red;
                lbtrangthai.Text = "Mật khẩu quá ngắn.";
                Thread t = new Thread(new ThreadStart(tatlbtrangthai));
                t.IsBackground = false;
                t.Start();
            }
            else if (txtmatkhau.TextLength >= 20)
            {
                lbtrangthai.ForeColor = Color.Red;
                lbtrangthai.Text = "mật khẩu quá dài.";
                Thread t = new Thread(new ThreadStart(tatlbtrangthai));
                t.IsBackground = false;
                t.Start();
            }
            else if (txthovaten.TextLength == 0)
            {
                lbtrangthai.ForeColor = Color.Red;
                lbtrangthai.Text = "Chưa điền họ và tên.";
                Thread t = new Thread(new ThreadStart(tatlbtrangthai));
                t.IsBackground = false;
                t.Start();
            }
            else if (txthovaten.TextLength >= 100)
            {
                lbtrangthai.ForeColor = Color.Red;
                lbtrangthai.Text = "Họ và tên quá dài.";
                Thread t = new Thread(new ThreadStart(tatlbtrangthai));
                t.IsBackground = false;
                t.Start();
            }
            else if (datengaysinh.Value.Year == DateTime.Today.Year)
            {
                lbtrangthai.ForeColor = Color.Red;
                lbtrangthai.Text = "Chưa chọn ngày sinh.";
                Thread t = new Thread(new ThreadStart(tatlbtrangthai));
                t.IsBackground = false;
                t.Start();
            }
            else if (txtsdt.TextLength == 0)
            {
                lbtrangthai.ForeColor = Color.Red;
                lbtrangthai.Text = "Chưa điền số điện thoại.";
                Thread t = new Thread(new ThreadStart(tatlbtrangthai));
                t.IsBackground = false;
                t.Start();
            }
            else if (txtsdt.TextLength >= 12)
            {
                lbtrangthai.ForeColor = Color.Red;
                lbtrangthai.Text = "Số điện thoại quá dài.";
                Thread t = new Thread(new ThreadStart(tatlbtrangthai));
                t.IsBackground = false;
                t.Start();
            }
            else if (cbgioitinh.Text == "")
            {
                lbtrangthai.ForeColor = Color.Red;
                lbtrangthai.Text = "Chưa chọn giới tính.";
                Thread t = new Thread(new ThreadStart(tatlbtrangthai));
                t.IsBackground = false;
                t.Start();
            }
            else if (rdadmin.Checked == false && rdnhanvien.Checked == false)
            {
                lbtrangthai.ForeColor = Color.Red;
                lbtrangthai.Text = "Chưa chọn quyền của tài khoản.";
                Thread t = new Thread(new ThreadStart(tatlbtrangthai));
                t.IsBackground = false;
                t.Start();
            }
            else
            {
               // try
               // {
                    insertnhanvien();
                    inserttaikhoan();
                    inserthinh();
                    this.Close();
               // }
                //catch (SqlException loi)
                //{
                //    if (loi.Message.Contains("Violation of PRIMARY KEY constraint 'PK_TENTK'"))
                //    {
                //        MessageBox.Show("Tên tài khoản bị trùng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //        DeleteNhanVien_Loi();
                //    }
                //}
            }
        }
        private void DeleteNhanVien_Loi()
        {
            NHANVIEN_PUBLIC nhanvien_public = new NHANVIEN_PUBLIC();
            nhanvien_public.IDNV = "NV" + manv.ToString();
            nv_bul.delete_nhanvien(nhanvien_public);
        }
        private void rdadmin_CheckedChanged(object sender, EventArgs e)
        {
            if (rdadmin.Checked == true)
            {
                quyen = "ADMIN";
            }
        }

        private void rdnhanvien_CheckedChanged(object sender, EventArgs e)
        {
            if (rdnhanvien.Checked == true)
            {
                quyen = "NHANVIEN";
            }
        }
        private void ChiDuocNhapSo(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // chỉ cho phép dấu thập phân
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            ChiDuocNhapSo(sender, e);
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
