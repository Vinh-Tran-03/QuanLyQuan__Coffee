using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using PUBLIC;
using BUL;
namespace Interface
{
    public partial class DANGNHAP : Form
    {
        public DANGNHAP()
        {
            InitializeComponent();
        }      
        TAIKHOAN_BUL taikhoan_pul = new TAIKHOAN_BUL();
        string quyen = "", ten = "", idnv = "";
        private void btdangnhap_Click(object sender, EventArgs e)
        {
            TAIKHOAN_PUBLIC taikhoan_public = new TAIKHOAN_PUBLIC();
            taikhoan_public.TENTK = txttendangnhap.Text;
            taikhoan_public.MATKHAU = txtmatkhau.Text;
            int checkpass = taikhoan_pul.check_taikhoan(taikhoan_public);
            if (checkpass == 0)
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttendangnhap.Focus();
            }
            else if (checkpass == 1)
            {                
                DataTable dt_quyenvaten = taikhoan_pul.get_tenvaquyen_taikhoan(taikhoan_public);
                quyen = dt_quyenvaten.Rows[0][0].ToString();
                ten = dt_quyenvaten.Rows[0][1].ToString();
                idnv = dt_quyenvaten.Rows[0][2].ToString();
                this.Close();
            }
        }
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
        private void DANGNHAP_Load(object sender, EventArgs e)
        {
            txttendangnhap.Focus();
            AcceptButton = btdangnhap;        
        }

        private void btdangnhap_MouseMove(object sender, MouseEventArgs e)
        {
            btdangnhap.BackColor = Color.Chocolate;
            btdangnhap.ForeColor = Color.Yellow;
        }

        private void btdangnhap_MouseLeave(object sender, EventArgs e)
        {
            btdangnhap.BackColor = Color.Transparent;
            btdangnhap.ForeColor = SystemColors.ControlText;
        }

        private void btthoat_MouseMove(object sender, MouseEventArgs e)
        {
            btthoat.BackColor = Color.Chocolate;
            btthoat.ForeColor = Color.Yellow;
        }

        private void btthoat_MouseLeave(object sender, EventArgs e)
        {
            btthoat.BackColor = Color.Transparent;
            btthoat.ForeColor = SystemColors.ControlText;
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        internal void DANGNHAP_FormClosing(object sender, FormClosingEventArgs e)
        {          
                Home.trangchu.EnableQuyen(quyen, ten, idnv);       
        }
    }
}
