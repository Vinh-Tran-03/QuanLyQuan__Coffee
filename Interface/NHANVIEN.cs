using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUL;
using PUBLIC;
using System.IO;
using System.Data.SqlClient;
using System.Threading;
namespace Interface
{
    public partial class NHANVIEN : Form
    {
        public NHANVIEN()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }
        private void xulybuttion(bool b)
        {
            btThem.Enabled=dg_nhanvien.Enabled=bttim.Enabled=btlammoi.Enabled=txttim.Enabled = btSua.Enabled = btXoa.Enabled=btToi.Enabled=btLui.Enabled=btThoat.Enabled = b;
            btLuu.Enabled = btHuy.Enabled = !b;
        }
        private bool nutThem = false, nutSua = false;
        private void NHANVIEN_Load(object sender, EventArgs e)
        {
            xulybuttion(true);
            LoadDataGrid();
            EditDataGrid();          
            dg_nhanvien.Rows[0].Selected = true;
            txtmanv.ReadOnly = true;
            txttentk.ReadOnly=true;
            Tat();
            lbmahinh.Hide();          
            cbquyen.DropDownStyle = ComboBoxStyle.DropDownList;
            dg_nhanvien.Click += Dg_nhanvien_Click;
        }

        private void Dg_nhanvien_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        NHANVIEN_BUL nv_bul = new NHANVIEN_BUL();
        TAIKHOAN_BUL tk_bul = new TAIKHOAN_BUL();
        HINHNV_BUL hinh_bul = new HINHNV_BUL();
        int manv;
        private void Mo()
        {
            txttennv.ReadOnly = false;
            datengaysinh.Enabled = true;
            txtsdt.ReadOnly = false;
            cbgioitinh.Enabled = true;
            txtmatkhau.ReadOnly = false;
            cbquyen.Enabled = true;
            txttentk.ReadOnly = false;
            pictureBox1.Enabled = true;
            txtmanv.Hide();
            lbmanv.Hide();
        }
        private void Tat()
        {
            txttennv.ReadOnly = true;
            datengaysinh.Enabled = false;
            txtsdt.ReadOnly = true;
            cbgioitinh.Enabled = false;
            txtmatkhau.ReadOnly = true;
            cbquyen.Enabled = false;
            txttentk.ReadOnly = true;
            pictureBox1.Enabled = false;
            txtmanv.Show();
            lbmanv.Show();
        }
        private void LoadDataGrid()
        {
            bindingSource1.DataSource = nv_bul.load_nhanvien();
            dg_nhanvien.DataSource = bindingSource1;
        }
        private void EditDataGrid()
        {
            dg_nhanvien.ReadOnly = true;
            dg_nhanvien.Columns[0].HeaderText="Mã nhân viên";
            dg_nhanvien.Columns[1].HeaderText="Tên nhân viên";
            dg_nhanvien.Columns[2].HeaderText="Ngày sinh";
            dg_nhanvien.Columns[3].HeaderText="Số điện thoại";
            dg_nhanvien.Columns[4].HeaderText="Giới tính";
            dg_nhanvien.Columns[5].HeaderText="Tên tài khoản";
            dg_nhanvien.Columns[6].HeaderText="Mật khẩu";
            dg_nhanvien.Columns[7].HeaderText="Quyền";
            dg_nhanvien.Columns[8].Visible = false;
            dg_nhanvien.Columns[9].Visible = false;
        }
        private void InsertNhanVien()
        {
            NHANVIEN_PUBLIC nv_public = new NHANVIEN_PUBLIC();
            manv = nv_bul.count_nhanvien();
            nv_public.IDNV = "NV" + manv.ToString();
            nv_public.TENNV = txttennv.Text;
            nv_public.NGAYSINH = DateTime.Parse(datengaysinh.Text);
            nv_public.SDT = txtsdt.Text;
            nv_public.GIOITINH = cbgioitinh.Text;                   
            nv_bul.insert_nhanvien(nv_public);             
        }
        private void InsertTaiKhoan()
        {

            TAIKHOAN_PUBLIC tk_public = new TAIKHOAN_PUBLIC();
            tk_public.TENTK = txttentk.Text;
            tk_public.MATKHAU = txtmatkhau.Text;
            tk_public.QUYEN = cbquyen.Text;
            tk_public.IDNV = "NV" + manv.ToString();
            tk_bul.insert_taikhoan(tk_public);
        }
        private void InsertHinh()
        {
            HINHNV_PUBLIC hinhnv_public = new HINHNV_PUBLIC();
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
        private void UpdateNhanVien()
        {
            NHANVIEN_PUBLIC nhanvien_public = new NHANVIEN_PUBLIC();
            nhanvien_public.IDNV = txtmanv.Text;
            nhanvien_public.TENNV = txttennv.Text;
            nhanvien_public.NGAYSINH = DateTime.Parse(datengaysinh.Text);
            nhanvien_public.SDT = txtsdt.Text;
            nhanvien_public.GIOITINH = cbgioitinh.Text;
            nv_bul.update_nhanvien(nhanvien_public);
        }
        private void UpdateTaiKhoan()
        {
            TAIKHOAN_PUBLIC taikhoan_public = new TAIKHOAN_PUBLIC();
            taikhoan_public.TENTK = txttentk.Text;
            taikhoan_public.MATKHAU = txtmatkhau.Text;
            taikhoan_public.QUYEN = cbquyen.Text;
            taikhoan_public.IDNV = txtmanv.Text;
            tk_bul.update_taikhoan(taikhoan_public);
        }
        private void UpdateHinh()
        {
            HINHNV_PUBLIC hinh_public = new HINHNV_PUBLIC();
            // FileStream để đọc các tập tin hình.
            FileStream fs = new FileStream(duongdan, FileMode.Open, FileAccess.Read);
            // Tạo mảng kiểu byte với cái kích thước của Filestream
            byte[] mangLuuHinh = new byte[fs.Length];
            // Đọc dữ liệu từ FileStream và bỏ vào cái mảng Byte
            fs.Read(mangLuuHinh, 0, Convert.ToInt32(fs.Length));
            // Đóng filestream
            fs.Close();
            hinh_public.IDHINH = int.Parse(lbmahinh.Text);
            hinh_public.HINH = mangLuuHinh;
            hinh_public.IDNV = txtmanv.Text;
            hinh_bul.update_hinhnv(hinh_public);
        }
        private void DeleteHinh()
        {
            HINHNV_PUBLIC hinh_public = new HINHNV_PUBLIC();
            hinh_public.IDHINH = int.Parse(lbmahinh.Text);
            hinh_bul.delete_hinhnv(hinh_public);
        }
        private void DeleteTaiKhoan()
        {
            TAIKHOAN_PUBLIC taikhoan_public = new TAIKHOAN_PUBLIC();
            taikhoan_public.TENTK = txttentk.Text;
            tk_bul.delete_taikhoan(taikhoan_public);
        }
        private void DeleteNhanVien()
        {
            NHANVIEN_PUBLIC nhanvien_public = new NHANVIEN_PUBLIC();
            nhanvien_public.IDNV = txtmanv.Text;
            nv_bul.delete_nhanvien(nhanvien_public);
        }
        private void DeleteNhanVien_Loi()
        {
            NHANVIEN_PUBLIC nhanvien_public = new NHANVIEN_PUBLIC();
            nhanvien_public.IDNV = "NV" + manv.ToString();
            nv_bul.delete_nhanvien(nhanvien_public);
        }
        private void Clear()
        {
            txttennv.Clear();
            datengaysinh.ResetText();
            txtsdt.Clear();
            cbgioitinh.SelectedIndex = -1;
            txttentk.Clear();
            txtmatkhau.Clear();
            cbquyen.SelectedIndex = -1;
            pictureBox1.Image = null;
        }
      
        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            nutThem = true;
            Mo();
            xulybuttion(false);
            txttennv.Focus();
            Clear();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            nutSua = true;
            Mo();
            txttentk.ReadOnly = true;
            xulybuttion(false);
        }
        private void btLuu_Click(object sender, EventArgs e)
        {          
            if (nutThem == true)
            {
                if (txttennv.TextLength == 0)
                {
                    MessageBox.Show("Chưa điền tên nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (datengaysinh.Value.Year == DateTime.Today.Year)
                {
                    MessageBox.Show("Chưa chọn ngày sinh.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                //else if (txtsdt.TextLength == 0)
                //{
                //    MessageBox.Show("Chưa nhập số điện thoại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}
                else if (cbgioitinh.Text == "")
                {
                    MessageBox.Show("Chưa chọn giới tính.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txttentk.TextLength == 0)
                {
                    MessageBox.Show("Chưa điền tên tài khoản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtmatkhau.TextLength == 0)
                {
                    MessageBox.Show("Chưa điền mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtmatkhau.TextLength < 6)
                {
                    MessageBox.Show("Mật khẩu quá ngắn, phải lớn hơn 6 ký tự.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (cbquyen.Text == "")
                {
                    MessageBox.Show("Chưa chọn quyền.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (pictureBox1.Image==null)
                {
                    MessageBox.Show("Chưa chọn hình.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txttentk.TextLength <= 3)
                {
                    MessageBox.Show("Tên tài khoản quá ngắn, phải dài hơn 3 ký tự.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txttennv.TextLength >= 100)
                {
                    MessageBox.Show("Tên nhân viên quá dài.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtsdt.TextLength >= 13)
                {
                    MessageBox.Show("Số điện thoại quá dài.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txttentk.TextLength >= 50)
                {
                    MessageBox.Show("Tên tài quá dài.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtmatkhau.TextLength > 20)
                {
                    MessageBox.Show("Mật khẩu quá dài.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        nutThem = false;
                        InsertNhanVien();
                        InsertTaiKhoan();
                        InsertHinh();                       
                        LoadDataGrid();
                        Tat();
                        xulybuttion(true);
                    }
                    catch (SqlException loi)
                    {
                        if (loi.Message.Contains("Violation of PRIMARY KEY constraint 'PK_TENTK'"))
                        {
                            MessageBox.Show("Tên tài khoản bị trùng.","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                            DeleteNhanVien_Loi();
                            nutThem = true;
                        }
                    }
                }
            }
            else if (nutSua == true)
            {
                if (txttennv.TextLength == 0)
                {
                    MessageBox.Show("Chưa điền tên nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (datengaysinh.Value.Year == DateTime.Today.Year)
                {
                    MessageBox.Show("Chưa chọn ngày sinh.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                //else if (txtsdt.TextLength == 0)
                //{
                //    MessageBox.Show("Chưa nhập số điện thoại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}
                else if (cbgioitinh.Text == "")
                {
                    MessageBox.Show("Chưa chọn giới tính.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txttentk.TextLength == 0)
                {
                    MessageBox.Show("Chưa điền tên tài khoản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtmatkhau.TextLength == 0)
                {
                    MessageBox.Show("Chưa điền mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtmatkhau.TextLength < 6)
                {
                    MessageBox.Show("Mật khẩu quá ngắn, phải lớn hơn 6 ký tự.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (cbquyen.Text == "")
                {
                    MessageBox.Show("Chưa chọn quyền.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (pictureBox1.Image == null)
                {
                    MessageBox.Show("Chưa chọn hình.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txttentk.TextLength <= 3)
                {
                    MessageBox.Show("Tên tài khoản quá ngắn, phải lớn hơn 3 ký tự.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txttennv.TextLength >= 100)
                {
                    MessageBox.Show("Tên nhân viên quá dài.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtsdt.TextLength >= 13)
                {
                    MessageBox.Show("Số điện thoại quá dài.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);                                    
                }
                else if (txttentk.TextLength >= 50)
                {
                    MessageBox.Show("Tên tài quá dài.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtmatkhau.TextLength > 20)
                {
                    MessageBox.Show("Mật khẩu quá dài.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    UpdateNhanVien();
                    UpdateTaiKhoan();           
                    if (checkopenimage == true)
                    {
                        UpdateHinh();
                        checkopenimage = false;
                    }                    
                    Tat();
                    xulybuttion(true);
                    nutSua = false;
                    LoadDataGrid();
                }
            }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            if (nutThem == true)
            {
                //
                LoadDataGrid();
                xulybuttion(true);
                Tat();
                nutThem = false;
            }
            else if (nutSua == true)
            {
                //
                Tat();
                xulybuttion(true);
                nutSua = false;
            }
        }
        string duongdan = "", tenhinh = "";
        private bool checkopenimage = false;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "(*.JPG ;*.PNG ;*.GIF) |*.jpg;*.png;*.gif";
            if (DialogResult.OK == open.ShowDialog())
            {
                tenhinh = open.SafeFileName;
                duongdan = open.FileName;
                pictureBox1.ImageLocation = duongdan;
                checkopenimage = true;
            }
            else
            {
                checkopenimage = false;
            }
        }

        private void btThem_MouseMove(object sender, MouseEventArgs e)
        {
            btThem.BackColor = Color.Chocolate;
            btThem.ForeColor = Color.Yellow;
        }

        private void btThem_MouseLeave(object sender, EventArgs e)
        {
            btThem.BackColor = Color.Transparent;
            btThem.ForeColor = SystemColors.ControlText;
        }

        private void btSua_MouseMove(object sender, MouseEventArgs e)
        {
            btSua.BackColor = Color.Chocolate;
            btSua.ForeColor = Color.Yellow;
        }

        private void btSua_MouseLeave(object sender, EventArgs e)
        {
            btSua.BackColor = Color.Transparent;
            btSua.ForeColor = SystemColors.ControlText;
        }

        private void btXoa_MouseMove(object sender, MouseEventArgs e)
        {
            btXoa.BackColor = Color.Chocolate;
            btXoa.ForeColor = Color.Yellow;
        }

        private void btXoa_MouseLeave(object sender, EventArgs e)
        {
            btXoa.BackColor = Color.Transparent;
            btXoa.ForeColor = SystemColors.ControlText;
        }

        private void btLuu_MouseMove(object sender, MouseEventArgs e)
        {
            btLuu.BackColor = Color.Chocolate;
            btLuu.ForeColor = Color.Yellow;
        }

        private void btLuu_MouseLeave(object sender, EventArgs e)
        {

            btLuu.BackColor = Color.Transparent;
            btLuu.ForeColor = SystemColors.ControlText;
        }

        private void btHuy_MouseMove(object sender, MouseEventArgs e)
        {
            btHuy.BackColor = Color.Chocolate;
            btHuy.ForeColor = Color.Yellow;
        }

        private void btHuy_MouseLeave(object sender, EventArgs e)
        {
            btHuy.BackColor = Color.Transparent;
            btHuy.ForeColor = SystemColors.ControlText;
        }

        private void btLui_MouseMove(object sender, MouseEventArgs e)
        {
            btLui.BackColor = Color.Chocolate;          
        }

        private void btLui_MouseLeave(object sender, EventArgs e)
        {
            btLui.BackColor = Color.Transparent;   
        }

        private void btToi_MouseMove(object sender, MouseEventArgs e)
        {
            btToi.BackColor = Color.Chocolate;       
        }

        private void btToi_MouseLeave(object sender, EventArgs e)
        {
            btToi.BackColor = Color.Transparent;   
        }

        private void btThoat_MouseMove(object sender, MouseEventArgs e)
        {
            btThoat.BackColor = Color.Chocolate;
            btThoat.ForeColor = Color.Yellow;
        }

        private void btThoat_MouseLeave(object sender, EventArgs e)
        {
            btThoat.BackColor = Color.Transparent;
            btThoat.ForeColor = SystemColors.ControlText;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.BackColor = Color.Chocolate;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = SystemColors.Control;
        }
        byte[] Hinh;       

        private void btToi_Click(object sender, EventArgs e)
        {
            try
            {
                int toi = dg_nhanvien.CurrentRow.Index + 1;
                if (toi != dg_nhanvien.Rows.Count - 1)
                {
                    dg_nhanvien.CurrentCell = dg_nhanvien.Rows[toi].Cells[dg_nhanvien.CurrentCell.ColumnIndex];
                    dg_nhanvien.Rows[toi].Selected = true;
                }
            }
            catch
            { }         
        }

        private void btLui_Click(object sender, EventArgs e)
        {
            try
            {
                int lui = dg_nhanvien.CurrentRow.Index - 1;
                if (lui != dg_nhanvien.Rows.Count + 1)
                {
                    dg_nhanvien.CurrentCell = dg_nhanvien.Rows[lui].Cells[dg_nhanvien.CurrentCell.ColumnIndex];
                    dg_nhanvien.Rows[lui].Selected = true;
                }      
            }
            catch
            { }           
        }

        private void bttim_MouseMove(object sender, MouseEventArgs e)
        {
            bttim.BackColor = Color.Chocolate;
            bttim.ForeColor = Color.Yellow;
        }

        private void bttim_MouseLeave(object sender, EventArgs e)
        {
            bttim.BackColor = Color.Transparent;
            bttim.ForeColor = SystemColors.ControlText;
        }

        private void btlammoi_MouseMove(object sender, MouseEventArgs e)
        {
            btlammoi.BackColor = Color.Chocolate;
        }

        private void btlammoi_MouseLeave(object sender, EventArgs e)
        {
            btlammoi.BackColor = Color.Transparent; 
        }

        private void btlammoi_Click(object sender, EventArgs e)
        {
            dg_nhanvien.DataSource = nv_bul.load_nhanvien();
            txttim.Clear();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Muốn xóa một nhân viên?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                DeleteHinh();
                DeleteTaiKhoan();
                DeleteNhanVien();                
                LoadDataGrid();
            }
        }

        private void bttim_Click(object sender, EventArgs e)
        {
            if (txttim.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập tên nhân viên cần tìm.","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                NHANVIEN_PUBLIC nv_public = new NHANVIEN_PUBLIC();
                nv_public.TIMTEN = txttim.Text;
                dg_nhanvien.DataSource = nv_bul.Tim_nv(nv_public);
                dg_nhanvien.Rows[0].Selected = true;
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

        private void dg_nhanvien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                txtmanv.Text = dg_nhanvien.Rows[dong].Cells[0].Value.ToString();
                txttennv.Text = dg_nhanvien.Rows[dong].Cells[1].Value.ToString();
                datengaysinh.Text = dg_nhanvien.Rows[dong].Cells[2].Value.ToString();
                txtsdt.Text = dg_nhanvien.Rows[dong].Cells[3].Value.ToString();
                cbgioitinh.Text = dg_nhanvien.Rows[dong].Cells[4].Value.ToString();
                txttentk.Text = dg_nhanvien.Rows[dong].Cells[5].Value.ToString();
                txtmatkhau.Text = dg_nhanvien.Rows[dong].Cells[6].Value.ToString();
                cbquyen.Text = dg_nhanvien.Rows[dong].Cells[7].Value.ToString();
                lbmahinh.Text = dg_nhanvien.Rows[dong].Cells[9].Value.ToString();
                Hinh = ((byte[])dg_nhanvien.Rows[dong].Cells[8].Value);
                MemoryStream ms = new MemoryStream(Hinh);
                pictureBox1.Image = new Bitmap(ms);
            }
            catch
            { }
        }

        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            ChiDuocNhapSo(sender, e);
        }

        private void dg_nhanvien_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }      
    }
}
