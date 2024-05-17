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
namespace Interface
{
    public partial class DANHMUC : Form
    {
        public DANHMUC()
        {
            InitializeComponent();
        }

        private void DANHMUC_Load(object sender, EventArgs e)
        {
            tat();
            load_treeview_DM();
            xulybuttion(true);           
        }
        private void tat()
        {
            
            txtmadm.ReadOnly = true;
            txttendm.ReadOnly = true;
            lbmadm.Show();
            txtmadm.Show();
        }
        private void mo()
        {
            txtmadm.ReadOnly = false;
            txttendm.ReadOnly = false;
            lbmadm.Hide();
            txtmadm.Hide();
        }
        private void xulybuttion(bool b)
        {
            btThem.Enabled  = btSua.Enabled = btXoa.Enabled = btThoat.Enabled = b;
            btLuu.Enabled = btHuy.Enabled = !b;
        }
        DMDOUONG_BUL dm_bul = new DMDOUONG_BUL();
        DOUONG_BUL douong_bul = new DOUONG_BUL();           
        private void load_treeview_DM()
        {
            try
            {
                DataTable dt1 = new DataTable();
                DataTable dt2 = new DataTable();
                dt1 = dm_bul.load_dmdouong();

                TreeNode Danhmuc = new TreeNode("Danh mục đồ ăn và đồ uống");

                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    Danhmuc.Nodes.Add(dt1.Rows[i][0].ToString(), dt1.Rows[i][1].ToString());
                    dt2 = douong_bul.foodfind(int.Parse(dt1.Rows[i][0].ToString()));
                    for (int j = 0; j < dt2.Rows.Count; j++)
                    {
                        Danhmuc.Nodes[i].Nodes.Add(dt2.Rows[j][0].ToString() + ": " + dt2.Rows[j][1].ToString() + " VNĐ");
                    }
                }
                TV_DANHMUC.Nodes.Add(Danhmuc);
                TV_DANHMUC.SelectedNode = TV_DANHMUC.Nodes[0].Nodes[0];
            }
            catch
            { }
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

        private void btThoat_MouseLeave(object sender, EventArgs e)
        {
            btThoat.BackColor = Color.Transparent;
            btThoat.ForeColor = Color.Black;
        }

       

       
       


        private void TV_DANHMUC_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = TV_DANHMUC.SelectedNode;
            txtmadm.Text = node.Name;
            txttendm.Text = node.Text;
        }
        private bool nutThem = false, nutSua = false;
        private void btThem_Click(object sender, EventArgs e)
        {
            nutThem = true;
            txttendm.Text = "";
            xulybuttion(false);
            mo();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            nutSua = true;           
            xulybuttion(false);
            mo();
        }
        private void insert()
        {
            DMDOUONG_PUBLIC danhmuc_public = new DMDOUONG_PUBLIC();
            danhmuc_public.TENDM = txttendm.Text;
            dm_bul.insert_dmdouong(danhmuc_public);
        }
        private void update()       
        {
            DMDOUONG_PUBLIC danhmuc_public = new DMDOUONG_PUBLIC();
            danhmuc_public.TENDM = txttendm.Text;
            danhmuc_public.IDDM = int.Parse(txtmadm.Text);
            dm_bul.update_dmdouong(danhmuc_public);
        }
        private void delete()
        {
            DMDOUONG_PUBLIC danhmuc_public = new DMDOUONG_PUBLIC();         
            danhmuc_public.IDDM = int.Parse(txtmadm.Text);
            dm_bul.delete_dmdouong(danhmuc_public);
        }
        private void btLuu_Click(object sender, EventArgs e)
        {
            if (nutThem == true)
            {
                if (txttendm.TextLength == 0)
                {
                    MessageBox.Show("Chưa điền tên danh mục.","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }               
                else
                {
                    insert();
                    TV_DANHMUC.Nodes.Clear();
                    load_treeview_DM();
                    nutThem = false;
                    xulybuttion(true);
                    tat();
                }                
            }
            else if (nutSua == true)
            {
                if (txttendm.TextLength == 0)
                {
                    MessageBox.Show("Chưa điền tên danh mục.","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else if (txtmadm.TextLength == 0)
                {
                    MessageBox.Show("Nhấn vào tên danh mục để thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    update();
                    TV_DANHMUC.Nodes.Clear();
                    load_treeview_DM();
                    nutSua = false;
                    xulybuttion(true);
                    tat();
                }              
            }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            if (nutThem == true)
            {
                nutThem = false;
                xulybuttion(true);
                tat();
                TV_DANHMUC.Nodes.Clear();
                load_treeview_DM();
            }
            else if (nutSua == true)
            {
                nutSua = false;
                xulybuttion(true);
                tat();
                TV_DANHMUC.Nodes.Clear();
                load_treeview_DM();
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {           
            this.Close();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Muốn xóa một danh mục?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (txtmadm.TextLength == 0)
                {
                    MessageBox.Show("Nhấn vào tên danh mục để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    delete();
                    TV_DANHMUC.Nodes.Clear();
                    load_treeview_DM();
                }
            }
        }
       
        public void DANHMUC_FormClosing(object sender, FormClosingEventArgs e)
        {
            MENU.formmenu.Opacity = 1;
            MENU.formmenu.MENU_Load(sender, e);
        }

        private void btlammoi_Click(object sender, EventArgs e)
        {
            load_treeview_DM();
        }
    }
}
