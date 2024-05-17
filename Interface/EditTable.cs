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
using System.Data.SqlClient;
namespace Interface
{
    public partial class EditTable : Form
    {
        public EditTable()
        {
            InitializeComponent();
        }
        BAN_BUL ban_bul = new BAN_BUL();
        int tongsoban = 0;
        private void xulybuttion(bool b)
        {
            btThem.Enabled= btSua.Enabled = btXoa.Enabled = btThoat.Enabled = b;
            btLuu.Enabled = btHuy.Enabled = !b;
        }
        private bool nutThem = false, nutSua = false;
        private void hienthitreeds()
        {
            DataTable dt = new DataTable();
            dt = ban_bul.load_ban();
            TreeNode treenode = new TreeNode("Danh sách bàn");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                treenode.Nodes.Add(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString());
                treenode.Nodes[i].Nodes.Add(dt.Rows[i][2].ToString());
                treenode.Nodes[i].Nodes[0].ForeColor = Color.Black;
            }
            treedsban.Nodes.Add(treenode);
            try
            {
                treedsban.SelectedNode = treedsban.Nodes[0].Nodes[0];
            }
            catch
            { }
            
            tongsoban = treenode.Nodes.Count;                      
        }
        private void EditTable_Load(object sender, EventArgs e)
        {
            hienthitreeds();
            xulybuttion(true);
            txtmaban.ReadOnly = true;
            tat();            
        }
        private void tat()
        {
            txtmaban.Show();
            lbmaban.Show();
            txtten.ReadOnly = true;
            txttrangthai.ReadOnly = true;
        }
        private void mo()
        {
            txtmaban.Hide();
            lbmaban.Hide();
            txtten.ReadOnly = false;
            txttrangthai.ReadOnly = false;
        }
        private void treedsban_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                TreeNode TN = treedsban.SelectedNode;
                txtmaban.Text = TN.Name;
                txtten.Text = TN.Text;
                txttrangthai.Text = TN.Nodes[0].Text;                      
            }
            catch
            {
                
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
            btThem.ForeColor = Color.Black;
        }

        private void btSua_MouseMove(object sender, MouseEventArgs e)
        {
            btSua.BackColor = Color.Chocolate;
            btSua.ForeColor = Color.Yellow;
        }

        private void btSua_MouseLeave(object sender, EventArgs e)
        {
            btSua.BackColor = Color.Transparent;
            btSua.ForeColor = Color.Black;
        }

        private void btXoa_MouseMove(object sender, MouseEventArgs e)
        {
            btXoa.BackColor = Color.Chocolate;
            btXoa.ForeColor = Color.Yellow;
        }

        private void btXoa_MouseLeave(object sender, EventArgs e)
        {
            btXoa.BackColor = Color.Transparent;
            btXoa.ForeColor = Color.Black;
        }

        private void btLuu_MouseMove(object sender, MouseEventArgs e)
        {
            btLuu.BackColor = Color.Chocolate;
            btLuu.ForeColor = Color.Yellow;
        }

        private void btLuu_MouseLeave(object sender, EventArgs e)
        {
            btLuu.BackColor = Color.Transparent;
            btLuu.ForeColor = Color.Black;
        }

        private void btHuy_MouseMove(object sender, MouseEventArgs e)
        {
            btHuy.BackColor = Color.Chocolate;
            btHuy.ForeColor = Color.Yellow;
        }

        private void btHuy_MouseLeave(object sender, EventArgs e)
        {
            btHuy.BackColor = Color.Transparent;
            btHuy.ForeColor = Color.Black;
        }

        private void btThoat_MouseMove(object sender, MouseEventArgs e)
        {
            btThoat.BackColor = Color.Chocolate;
            btThoat.ForeColor = Color.Yellow;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            nutThem = true;
            xulybuttion(false);
            mo();
            txtten.Focus();
            tongsoban = tongsoban + 1;
            txtten.Text = "Bàn số: " + tongsoban;
            txttrangthai.Text = "Trống";
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            nutSua = true;
            xulybuttion(false);
            mo();
        }
        private void insert()
        {
            BAN_PUBLIC ban_public = new BAN_PUBLIC();
            ban_public.TEN = txtten.Text;
            ban_public.TRANGTHAI = txttrangthai.Text;
            ban_public.ODER = tongsoban;
            ban_bul.insert_ban(ban_public);
        }
        private void update()
        {
            BAN_PUBLIC ban_public = new BAN_PUBLIC();
            ban_public.IDBAN = int.Parse(txtmaban.Text);
            ban_public.TEN = txtten.Text;
            ban_public.TRANGTHAI = txttrangthai.Text;
            ban_bul.update_ban(ban_public);
        }
        private void delete()
        {
            BAN_PUBLIC ban_public = new BAN_PUBLIC();
            HOADON_PUBLIC hd_public = new HOADON_PUBLIC();
            hd_public.IDBAN = int.Parse(txtmaban.Text);
            ban_public.IDBAN = int.Parse(txtmaban.Text);
            hd_bul.delete_hoadon_with_idban(hd_public);
            ban_bul.delete_ban(ban_public);           
        }
        private void btLuu_Click(object sender, EventArgs e)
        {
            if (nutThem == true)
            {
                try
                {
                    insert();
                    xulybuttion(true);
                    nutThem = false;
                    tat();
                    treedsban.Nodes.Clear();
                    hienthitreeds();
                }
                catch
                {
                    MessageBox.Show("Trạng thái của bàn là Trống hoặc Có người");
                }
             
            }
            else if (nutSua == true)
            {
                try
                {
                    update();
                    xulybuttion(true);
                    nutSua = false;
                    tat();
                    treedsban.Nodes.Clear();
                    hienthitreeds();
                }
                catch
                {
                    MessageBox.Show("Trạng thái của bàn là Trống hoặc Có người");
                }
            }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {

            if (nutThem == true)
            {
                xulybuttion(true);
                nutThem = false;
                treedsban.Nodes.Clear();
                hienthitreeds();
                tat();
            }
            else if (nutSua == true)
            {
                xulybuttion(true);
                nutSua = false;
                tat();
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();         
        }

        private void treedsban_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (Color.Black == e.Node.ForeColor)
            {
                e.Cancel = true;
            }
        }
        HOADON_BUL hd_bul = new HOADON_BUL();
        private void btXoa_Click(object sender, EventArgs e)
        {
            if (txttrangthai.Text == "Có người")
            {
                MessageBox.Show("Bạn hiện tại đang có người, không thể xóa.","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("Muốn xóa một bàn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    delete();
                    treedsban.Nodes.Clear();
                    hienthitreeds();
                }
            }
        }

        public void EditTable_FormClosing(object sender, FormClosingEventArgs e)
        {
            BANAN.formbanan.taobanan();
            BANAN.formbanan.HideShow_ThemBan();
        }

        private void btThoat_MouseLeave(object sender, EventArgs e)
        {
            btThoat.BackColor = Color.Transparent;
            btThoat.ForeColor = Color.Black;
        }
    }
}
