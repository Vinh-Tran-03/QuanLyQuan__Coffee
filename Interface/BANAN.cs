using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PUBLIC;
using BUL;
using System.Threading;
namespace Interface
{
    public partial class BANAN : Form
    {
        public static BANAN formbanan;
        public BANAN()
        {
            InitializeComponent();
            formbanan = this;
        }
        BAN_BUL ban_bul = new BAN_BUL();        
        internal void taobanan()
        {
            
            flowLayoutPanel1.Controls.Clear();// làm mới sơ đồ bàn
            List<BAN_PUBLIC> dsban = ban_bul.Loaddsban();                      
            foreach (BAN_PUBLIC dong in dsban)
            {
                Button bt = new Button();
                bt.Click += bt_click;// tạo sự kiện click cho button
                bt.Tag = dong; // dùng để xác định ID của mỗi button
                bt.Width = 90;
                bt.Height = 90;
                bt.Text = dong.TEN+"\n"+dong.TRANGTHAI;
                if (dong.TRANGTHAI == "Trống")
                {
                    bt.BackColor = Color.YellowGreen;
                }
                else if (dong.TRANGTHAI == "Có người")
                {
                    bt.BackColor = Color.DarkRed;
                }               
                flowLayoutPanel1.Controls.Add(bt);               
            }
        }
        HOADON_BUL hd_bul = new HOADON_BUL();
        CTHD_BUL cthd_bul = new CTHD_BUL();
        int idhd = 0;
        int idban = 0;
        string tenban = "";
        string idnv;
        string trangthaiban = "";  
        void bt_click(object sender, EventArgs e)
        {
            idban = ((sender as Button).Tag as BAN_PUBLIC).IDBAN;
            tenban = ((sender as Button).Tag as BAN_PUBLIC).TEN;
            trangthaiban = ((sender as Button).Tag as BAN_PUBLIC).TRANGTHAI;
            DSMON.Text = "Danh sách món ăn của " + tenban;
            HOADON_PUBLIC hd_public = new HOADON_PUBLIC();          
            hd_public.IDBAN = idban;
            int sohoadonban = hd_bul.count_hoadon_ban(hd_public);
            if (sohoadonban == 0)
            {
                hd_public.IDNV = Idnv;// lấy từ mã từ tài khoản nhân viên đăng nhập vào
                hd_public.NGAYLAP = DateTime.Now;
                hd_public.TRANGTHAI = "Chưa";                
                hd_bul.insert_hoadon(hd_public);            
                taobanan();         
            }
             idhd = hd_bul.load_IDHD_WITH_IDBAN(hd_public);
            Load_CTHD(idhd);
            numericsoluongdoan.Value = 1;
        }
        internal void Load_CTHD(int mahoadon)
        {
            CTHD_PUBLIC cthd_public = new CTHD_PUBLIC();
            cthd_public.IDHOADON = mahoadon;
            bindingSource1.DataSource = cthd_bul.load_cthd(cthd_public);
            dg_monan_ofban.DataSource = bindingSource1;
            dinhdangluoi();
        }
        private void dinhdangluoi()
        {
            dg_monan_ofban.ReadOnly = true;
            string dinhdangso = "###,###,##0";
            dg_monan_ofban.Columns[0].Visible = false;
            dg_monan_ofban.Columns[1].Visible = false;
            dg_monan_ofban.Columns[2].Visible = false;
            dg_monan_ofban.Columns[3].HeaderText = "Tên món";
            dg_monan_ofban.Columns[4].HeaderText = "Số lượng";
            dg_monan_ofban.Columns[5].HeaderText = "Đơn giá (VNĐ)";
            dg_monan_ofban.Columns[5].DefaultCellStyle.Format = dinhdangso;
            dg_monan_ofban.Columns[6].HeaderText = "Thành tiền (VNĐ)";
            dg_monan_ofban.Columns[6].DefaultCellStyle.Format = dinhdangso;
            dg_monan_ofban.Columns[7].Visible = false;
        }
        DOUONG_BUL DOUONG_BUL = new DOUONG_BUL();
        private void quyennv()
        {
            lbthemban.Hide();
            Soban.Hide();
            btthemban.Hide();
            mnt_banan.Enabled = false;
        }
        internal void HideShow_ThemBan()
        {
            dg_dsban.DataSource = ban_bul.load_ban();// show lên lưới để đếm số bàn ! nếu lớn hơn 1 thì ẩn controls thêm bàn ngược lại thì hiện lên
            dg_dsban.Hide();
            if (dg_dsban.Rows.Count > 1)
            {
                lbthemban.Hide();
                Soban.Hide();
                btthemban.Hide();
            }
            else
            {
                lbthemban.Show();
                Soban.Show();
                btthemban.Show();
            }
        }
        private string quyen;
        internal void BANAN_Load(object sender, EventArgs e)
        {
            if (Quyen == "NHANVIEN")
            {
                quyennv();
            }          
            taobanan();
            HideShow_ThemBan();
            cbdanhmuc.DropDownStyle = ComboBoxStyle.DropDownList;
            cbten.DropDownStyle = ComboBoxStyle.DropDownList;
            cbgia.DropDownStyle = ComboBoxStyle.DropDownList;                                
            DataTable dt = new DataTable();
            dt = dmdouong_bul.load_dmdouong();
            cbdanhmuc.DataSource = dt;
            cbdanhmuc.DisplayMember = "TENDM";
            cbiddm.DataSource = dt;
            cbiddm.DisplayMember = "IDDM";         
            cbiddm.Hide();
            cbiddouong.Hide();
            flowLayoutPanel1.AutoScroll = true;             
        }
        DMDOUONG_BUL dmdouong_bul = new DMDOUONG_BUL();
        private void btthemban_Click(object sender, EventArgs e)
        {
            BAN_PUBLIC ban_public = new BAN_PUBLIC();
            for (int i = 1; i <= Convert.ToInt32(Soban.Value); i++)
            {
                ban_public.TEN = "Bàn số: " + i;
                ban_public.TRANGTHAI = "Trống";
                ban_public.ODER = i;
                ban_bul.insert_ban(ban_public);
            }
            taobanan();
            lbthemban.Hide();
            Soban.Hide();
            btthemban.Hide();
        }

        private void mnt_banan_Click(object sender, EventArgs e)
        {            
            EditTable suaban = new EditTable();
            suaban.FormClosing += new FormClosingEventHandler(suaban.EditTable_FormClosing);         
            suaban.ShowDialog();        
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (dg_monan_ofban.Rows.Count == 0)
            {
                MessageBox.Show("Chọn một bàn rồi thêm món.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cbten.Text == "")
            {
                MessageBox.Show("Chưa chọn món.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                CTHD_PUBLIC cthd_public = new CTHD_PUBLIC();
                BAN_PUBLIC b_public = new BAN_PUBLIC();
                cthd_public.IDHOADON = idhd;
                cthd_public.IDDOUONG = int.Parse(cbiddouong.Text);
                cthd_public.SOLUONG = (int)numericsoluongdoan.Value;
                cthd_bul.insert_cthd(cthd_public);
                b_public.IDBAN = idban;
                b_public.TRANGTHAI = "Có người";
                ban_bul.update_trangthaiban(b_public);
                if (trangthaiban == "Trống")
                {
                    taobanan();
                }
                Load_CTHD(idhd);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CHUYENBAN cb = new CHUYENBAN();
            cb.ShowDialog();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dg_monan_ofban.Rows.Count == 0)
            {
                MessageBox.Show("Chọn một bàn rồi nhấn vào danh sánh món ăn muốn xóa.","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                CTHD_PUBLIC cthd_public = new CTHD_PUBLIC();
                cthd_public.IDHOADON = MAHOADON_XOA;
                cthd_public.IDDOUONG = MADOUONG_XOA;
                cthd_bul.delete_cthd(cthd_public);
                Load_CTHD(idhd);
            }
        }

        private void dg_monan_ofban_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
        int MAHOADON_XOA = 0;
        int MADOUONG_XOA = 0;

        public string Idnv
        {
            get
            {
                return idnv;
            }

            set
            {
                idnv = value;
            }
        }

        public string Quyen
        {
            get
            {
                return quyen;
            }

            set
            {
                quyen = value;
            }
        }

        private void dg_monan_ofban_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                MAHOADON_XOA = int.Parse(dg_monan_ofban.Rows[dong].Cells[1].Value.ToString());
                MADOUONG_XOA= int.Parse(dg_monan_ofban.Rows[dong].Cells[2].Value.ToString());
            }
            catch
            { }
        }

        private void cbten_Click_1(object sender, EventArgs e)
        {
            try
            {
                DOUONG_PUBLIC douong_public = new DOUONG_PUBLIC();
                douong_public.IDDM = int.Parse(cbiddm.Text);
                DataTable dt = new DataTable();
                dt = DOUONG_BUL.load_douongvoi_where(douong_public);
                cbten.DataSource = dt;
                cbten.DisplayMember = "TENDOUONG";
                cbgia.DataSource = dt;
                cbgia.DisplayMember = "DONGIA";
                cbiddouong.DataSource = dt;
                cbiddouong.DisplayMember = "IDDOUONG";
            }
            catch
            {
                MessageBox.Show("Danh mục trống.","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btthanhtoan_Click(object sender, EventArgs e)
        {
            if (dg_monan_ofban.Rows.Count == 0)
            {
                MessageBox.Show("Chọn một bàn rồi mới thanh toán hóa đơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (dg_monan_ofban.Rows.Count == 1)
            {
                MessageBox.Show("Bàn chưa có món, không thể thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ThanhToan tt = new ThanhToan();
                tt.Idban = idban;
                tt.Tenban = tenban;
                tt.Idnv = this.Idnv;
                tt.FormClosing += new FormClosingEventHandler(tt.ThanhToan_FormClosing);
                tt.ShowDialog();
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

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.ForeColor = Color.Yellow;
            button1.BackColor = Color.Chocolate;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
            button1.ForeColor = SystemColors.ControlText;
        }

        private void btthanhtoan_MouseMove(object sender, MouseEventArgs e)
        {
            btthanhtoan.BackColor = Color.Chocolate;
            btthanhtoan.ForeColor = Color.Yellow;
        }

        private void btthanhtoan_MouseLeave(object sender, EventArgs e)
        {
            btthanhtoan.BackColor = Color.Transparent;
            btthanhtoan.ForeColor = SystemColors.ControlText;
        }
        private void btgopban_Click(object sender, EventArgs e)
        {
            GopBan gp = new GopBan();
            gp.FormClosing += new FormClosingEventHandler(gp.GopBan_FormClosing);
            gp.ShowDialog();
        }
    }
}
