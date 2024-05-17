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
namespace Interface
{
    public partial class ThongKeDoanhThu : Form
    {
        public static ThongKeDoanhThu tkdt;
        public ThongKeDoanhThu()
        {
            InitializeComponent();
            tkdt = this;
        }
        HOADON_OLD_BUL hoadon_old_bul = new HOADON_OLD_BUL();
        private void load_hoadon_old()
        {
            bindingSource1.DataSource = hoadon_old_bul.load_hoadon_old();
            dg_hoadon.DataSource = bindingSource1;
        }
        private void dinhdangluoi()
        {
            string dinhdangso = "###,###,##0";
            dg_hoadon.ReadOnly = true;
            dg_hoadon.Columns[0].Visible = false;
            dg_hoadon.Columns[1].HeaderText = "Mã hóa đơn";
            dg_hoadon.Columns[2].HeaderText = "Tên bàn";
            dg_hoadon.Columns[3].HeaderText = "Tên nhân viên";
            dg_hoadon.Columns[4].HeaderText = "Ngày lập hóa đơn";
            dg_hoadon.Columns[5].HeaderText = "Thanh toán";
            dg_hoadon.Columns[6].HeaderText = "Tổng tiền(VNĐ)";
            dg_hoadon.Columns[6].DefaultCellStyle.Format = dinhdangso;
        }
        private void ThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            load_hoadon_old();
            dinhdangluoi();
            lbmahd.Hide();
            cbngay.DropDownStyle = ComboBoxStyle.DropDownList;
            cbngay.Enabled = false;
            cbthang.DropDownStyle = ComboBoxStyle.DropDownList;
            cbthang.Enabled = false;
            cbnam.DropDownStyle = ComboBoxStyle.DropDownList;
            cbnam.Enabled = false;          
        }

        private void btxemcthd_MouseMove(object sender, MouseEventArgs e)
        {
            btxemcthd.BackColor = Color.Chocolate;
            btxemcthd.ForeColor = Color.Yellow;
        }

        private void btxemcthd_MouseLeave(object sender, EventArgs e)
        {
            btxemcthd.BackColor = Color.Transparent;
            btxemcthd.ForeColor = SystemColors.ControlText;
        }

        private void bttinhdt_MouseMove(object sender, MouseEventArgs e)
        {
            bttinhdt.BackColor = Color.Chocolate;
            bttinhdt.ForeColor = Color.Yellow;
        }

        private void bttinhdt_MouseLeave(object sender, EventArgs e)
        {
            bttinhdt.BackColor = Color.Transparent;
            bttinhdt.ForeColor = SystemColors.ControlText;
        }

        private void bttim_MouseMove(object sender, MouseEventArgs e)
        {
            bttim.BackColor = Color.Chocolate;
        }

        private void bttim_MouseLeave(object sender, EventArgs e)
        {
            bttim.BackColor = Color.Transparent;
        }

        private void btlammoi_MouseMove(object sender, MouseEventArgs e)
        {
            btlammoi.BackColor = Color.Chocolate;
        }

        private void btlammoi_MouseLeave(object sender, EventArgs e)
        {
            btlammoi.BackColor = Color.Transparent;
        }

        private void btxemcthd_Click(object sender, EventArgs e)
        {
            CTHD_OLD cthd_old = new CTHD_OLD();
            cthd_old.Mahoadon_old = int.Parse(lbmahd.Text);
            cthd_old.ShowDialog();
        }

        private void dg_hoadon_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                lbmahd.Text = dg_hoadon.Rows[dong].Cells[1].Value.ToString();
                dg_hoadon.Rows[dong].Selected = true;
            }
            catch
            { }
        }
        private bool checktim = false, checktimtennv = false;
        private void bttim_Click(object sender, EventArgs e)
        {
            checktim = true;
            HOADON_OLD_PUBLIC hd_old_publuc = new HOADON_OLD_PUBLIC();
            hd_old_publuc.Soban = "Bàn số: "+Soban.Value.ToString();          
            dg_hoadon.DataSource = hoadon_old_bul.load_timhd_old(hd_old_publuc);
            cbngay.DropDownStyle = ComboBoxStyle.DropDownList;
            cbngay.Enabled = false;
            cbthang.DropDownStyle = ComboBoxStyle.DropDownList;
            cbthang.Enabled = false;
            cbnam.DropDownStyle = ComboBoxStyle.DropDownList;
            cbnam.Enabled = false;
            rdNgay.Checked = false;
            rdThang.Checked = false;
            rdNam.Checked = false;
            cbngay.SelectedIndex = -1;
            cbthang.SelectedIndex = -1;
            cbnam.SelectedIndex = -1;           
        }

        internal void btlammoi_Click(object sender, EventArgs e)
        {
            ThongKeDoanhThu_Load(sender, e);
            rdNgay.Checked = false;
            rdThang.Checked = false;
            rdNam.Checked = false;
            cbngay.SelectedIndex = -1;
            cbthang.SelectedIndex = -1;
            cbnam.SelectedIndex = -1;
            checktim = false;
            Soban.Value = 1;
            txttennhanvien.Clear();
        }

        private void rdNgay_CheckedChanged(object sender, EventArgs e)
        {
            if (rdNgay.Checked == true)
            {
                cbngay.Enabled = true;
                cbthang.Enabled = false;
                cbnam.Enabled = false;
            }
        }

        private void rdThang_CheckedChanged(object sender, EventArgs e)
        {
            if (rdThang.Checked == true)
            {
                cbthang.Enabled = true;
                cbngay.Enabled = false;
                cbnam.Enabled = false;
            }
        }

        private void rdNam_CheckedChanged(object sender, EventArgs e)
        {
            if (rdNam.Checked == true)
            {
                cbnam.Enabled = true;
                cbthang.Enabled = false;
                cbngay.Enabled = false;
            }
        }
        private bool Bngay = false, Bthang = false, Bnam = false;

        private void bttimnhanvien_Click(object sender, EventArgs e)
        {
            checktimtennv = true;
            HOADON_OLD_PUBLIC hd_old_publuc = new HOADON_OLD_PUBLIC();
            hd_old_publuc.TENNV = txttennhanvien.Text;
            dg_hoadon.DataSource = hoadon_old_bul.load_timhd_old_TENNV(hd_old_publuc);
            cbngay.DropDownStyle = ComboBoxStyle.DropDownList;
            cbngay.Enabled = false;
            cbthang.DropDownStyle = ComboBoxStyle.DropDownList;
            cbthang.Enabled = false;
            cbnam.DropDownStyle = ComboBoxStyle.DropDownList;
            cbnam.Enabled = false;
            rdNgay.Checked = false;
            rdThang.Checked = false;
            rdNam.Checked = false;
            cbngay.SelectedIndex = -1;
            cbthang.SelectedIndex = -1;
            cbnam.SelectedIndex = -1;
        }

        private void btlammoi1_Click(object sender, EventArgs e)
        {
            ThongKeDoanhThu_Load(sender, e);
            rdNgay.Checked = false;
            rdThang.Checked = false;
            rdNam.Checked = false;
            cbngay.SelectedIndex = -1;
            cbthang.SelectedIndex = -1;
            cbnam.SelectedIndex = -1;
            checktim = false;
            Soban.Value = 1;
            txttennhanvien.Clear();
        }

        private void bttinhdt_Click(object sender, EventArgs e)
        {
            if (rdNgay.Checked == true)
            {
                if (cbngay.Text == "")
                {
                    MessageBox.Show("Chưa chọn ngày.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    TONGDOANHTHU tdt = new TONGDOANHTHU();
                    tdt.Ngay = int.Parse(cbngay.Text);
                    Bngay = true;
                    tdt.Bngay = this.Bngay;
                    tdt.FormClosing += new FormClosingEventHandler(tdt.TONGDOANHTHU_FormClosing);
                    tdt.ShowDialog();
                }
            }
            else if (rdThang.Checked == true)
            {
                if (cbthang.Text == "")
                {
                    MessageBox.Show("Chưa chọn tháng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    TONGDOANHTHU tdt = new TONGDOANHTHU();
                    tdt.Thang = int.Parse(cbthang.Text);
                    Bthang = true;
                    tdt.Bthang = this.Bthang;
                    tdt.FormClosing += new FormClosingEventHandler(tdt.TONGDOANHTHU_FormClosing);
                    tdt.ShowDialog();
                }
            }
            else if (rdNam.Checked == true)
            {
                if (cbnam.Text == "")
                {
                    MessageBox.Show("Chưa chọn năm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    TONGDOANHTHU tdt = new TONGDOANHTHU();
                    tdt.Nam = int.Parse(cbnam.Text);
                    Bnam = true;
                    tdt.Bnam = this.Bnam;
                    tdt.FormClosing += new FormClosingEventHandler(tdt.TONGDOANHTHU_FormClosing);
                    tdt.ShowDialog();
                }
            }
            else if (checktim == true)
            {
                TONGDOANHTHU tdt = new TONGDOANHTHU();
                tdt.Timcheck = true;
                tdt.Tenban = "Bàn số: " + Soban.Value.ToString();
                tdt.FormClosing += new FormClosingEventHandler(tdt.TONGDOANHTHU_FormClosing);
                tdt.ShowDialog();
                checktim = false;
            }
            else if (checktimtennv == true)
            {
                TONGDOANHTHU tdt = new TONGDOANHTHU();
                tdt.Checkten = true;
                tdt.Tenban = txttennhanvien.Text;
                tdt.FormClosing += new FormClosingEventHandler(tdt.TONGDOANHTHU_FormClosing);
                tdt.ShowDialog();
                checktimtennv = false;
            }
            else
            {
                // thực hiện tính tổng doanh thu của tất cả các hóa đơn
                TONGDOANHTHU tdt = new TONGDOANHTHU();
                tdt.FormClosing += new FormClosingEventHandler(tdt.TONGDOANHTHU_FormClosing);
                tdt.ShowDialog();
            }
        }
    }
}
