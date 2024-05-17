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
    public partial class CHUYENBAN : Form
    {
        public CHUYENBAN()
        {
            InitializeComponent();
        }
        BAN_BUL ban_bul = new BAN_BUL();
        private void CHUYENBAN_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = ban_bul.load_ban_trong();
            cbtenban.DataSource = dt;
            cbtenban.DisplayMember = "TEN";
            cbmabantrong.DataSource = dt;
            cbmabantrong.DisplayMember = "IDBAN";
            DataTable dt1 = new DataTable();
            dt1 = ban_bul.load_ban_conguoi();
            cbbanconguoi.DataSource = dt1;
            cbbanconguoi.DisplayMember = "TEN";
            cbmabanconguoi.DataSource = dt1;
            cbmabanconguoi.DisplayMember = "IDBAN";
            cbmabanconguoi.Hide();
            cbmabantrong.Hide();
        }
        HOADON_BUL hd_bul = new HOADON_BUL();
        private void btchuyen_Click(object sender, EventArgs e)
        {
            if (cbbanconguoi.Text == "")
            {
                MessageBox.Show("Không có bàn nào để chuyển.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                HOADON_PUBLIC hd_public = new HOADON_PUBLIC();
                BAN_PUBLIC ban_public = new BAN_PUBLIC();
                hd_public.IDBAN = int.Parse(cbmabanconguoi.Text);
                int mahoadon_banconguoi = hd_bul.load_IDHD_WITH_IDBAN(hd_public);
                hd_public.IDHOADON = mahoadon_banconguoi;
                hd_public.IDBAN = int.Parse(cbmabantrong.Text);// mã bàn mới
                hd_bul.update_hoadon_doiban(hd_public);
                ban_public.IDBAN = int.Parse(cbmabanconguoi.Text);//update thành Trống
                ban_public.TRANGTHAI = "Trống";
                ban_bul.update_trangthaiban(ban_public);
                ban_public.IDBAN = int.Parse(cbmabantrong.Text);//update thành Có người
                ban_public.TRANGTHAI = "Có người";
                ban_bul.update_trangthaiban(ban_public);
                CHUYENBAN_Load(sender, e);
                this.Close();
            }
        }

        private void CHUYENBAN_FormClosing(object sender, FormClosingEventArgs e)
        {
            BANAN.formbanan.BANAN_Load(sender, e);
        }      
    }
}
