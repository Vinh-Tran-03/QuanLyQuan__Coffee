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
    public partial class GopBan : Form
    {
        public GopBan()
        {
            InitializeComponent();
        }
        BAN_BUL ban_bul = new BAN_BUL();
        HOADON_BUL hd_bul = new HOADON_BUL();
        CTHD_BUL cthd_bul = new CTHD_BUL();
        private void GopBan_Load(object sender, EventArgs e)
        {
            dg_cthd.Hide();
            DataTable dt = new DataTable();
            dt = ban_bul.load_ban_conguoi();
            cbbanconguoi.DataSource = dt;
            cbbanconguoi.DisplayMember = "TEN";
            cbmabanconguoi.DataSource = dt;
            cbmabanconguoi.DisplayMember = "IDBAN";
            cbmabanconguoi.Hide();
            DataTable dt1 = new DataTable();
            dt1 = ban_bul.load_ban_conguoi();
            cbbanconguoi1.DataSource = dt1;
            cbbanconguoi1.DisplayMember = "TEN";
            cbmabanconguoi1.DataSource = dt1;
            cbmabanconguoi1.DisplayMember = "IDBAN";
            cbmabanconguoi1.Hide();
        }

        private void btgop_Click(object sender, EventArgs e)
        {
            if (cbbanconguoi.Text == cbbanconguoi1.Text)
            {
                MessageBox.Show("Không thể gộp 2 bàn giống nhau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                HOADON_PUBLIC hd_public = new HOADON_PUBLIC();
                hd_public.IDBAN = int.Parse(cbmabanconguoi.Text);
                int idhoadon = hd_bul.load_IDHD_WITH_IDBAN(hd_public);
                CTHD_PUBLIC cthd_public = new CTHD_PUBLIC();
                cthd_public.IDHOADON = idhoadon;
                dg_cthd.DataSource = cthd_bul.load_cthd(cthd_public);
                hd_public.IDBAN = int.Parse(cbmabanconguoi1.Text);
                int idhoadon1 = hd_bul.load_IDHD_WITH_IDBAN(hd_public);
                cthd_public.IDHOADON = idhoadon1;
                for (int i = 0; i < dg_cthd.Rows.Count - 1; i++)
                {
                    cthd_public.IDDOUONG = int.Parse(dg_cthd["IDDOUONG", i].Value.ToString());
                    cthd_public.SOLUONG = int.Parse(dg_cthd["SOLUONG", i].Value.ToString());
                    cthd_bul.insert_cthd(cthd_public); // insert cthd vào bạn nhận
                }
                cthd_public.IDHOADON = idhoadon;// set lại mã hóa đơn cũ
                for (int j = 0; j < dg_cthd.Rows.Count - 1; j++)
                {
                    cthd_public.IDDOUONG = int.Parse(dg_cthd["IDDOUONG", j].Value.ToString());
                    cthd_bul.delete_cthd(cthd_public);
                }
                hd_public.IDBAN = int.Parse(cbmabanconguoi.Text);
                hd_bul.delete_hoadon_with_idban(hd_public);
                BAN_PUBLIC ban_public = new BAN_PUBLIC();
                ban_public.IDBAN= int.Parse(cbmabanconguoi.Text);
                ban_public.TRANGTHAI = "Trống";
                ban_bul.update_trangthaiban(ban_public);
                this.Close();
            }
        }

        public void GopBan_FormClosing(object sender, FormClosingEventArgs e)
        {
            BANAN.formbanan.BANAN_Load(sender, e);
        }
    }
}
