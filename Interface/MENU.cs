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
using System.Data.SqlClient;
using System.Threading;
using Word = Microsoft.Office.Interop.Word;
using System.Globalization;

namespace Interface
{
    public partial class MENU : Form
    {
        public static MENU formmenu;
        public MENU()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            formmenu = this;
        }
        private void xulybuttion(bool b)
        {
            btThem.Enabled = dg_monan.Enabled = bttim.Enabled = btlammoi.Enabled = txttim.Enabled = btSua.Enabled = btXoa.Enabled = btToi.Enabled = btLui.Enabled = btinds.Enabled = b;
            btLuu.Enabled = btHuy.Enabled = !b;
        }
        private bool nutThem = false, nutSua = false;
        private void dinhdangluoi()
        {
            string dinhdangso = "###,###,##0";
            dg_monan.ReadOnly = true;
            dg_monan.Columns[0].HeaderText = "Mã sản phẩm";           
            dg_monan.Columns[1].Visible = false;
            dg_monan.Columns[2].HeaderText = "Danh muc";
            dg_monan.Columns[3].HeaderText = "Tên";
            dg_monan.Columns[4].HeaderText = "Đơn giá (VNĐ)";
            dg_monan.Columns[4].DefaultCellStyle.Format = dinhdangso;           
        }
        private void dinhdangluoi_inds()
        {
            string dinhdangso = "###,###,##0";
            dg_indanhsach.ReadOnly = true;
            dg_indanhsach.Columns[0].HeaderText = "Tên thực đơn";
            dg_indanhsach.Columns[1].HeaderText = "Đơn giá";
            dg_indanhsach.Columns[1].DefaultCellStyle.Format=dinhdangso;          
        }
        public void XuatRaFileWord(DataGridView DGV, string filename)
        {
            if (DGV.Rows.Count != 0)
            {
                int RowCount = DGV.Rows.Count;
                int ColumnCount = DGV.Columns.Count;
                Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

                //add rows
                int r = 0;
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    for (r = 0; r <= RowCount - 1; r++)
                    {
                        DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
                    } //end row loop
                } //end column loop

                Word.Document oDoc = new Word.Document();
                oDoc.Application.Visible = true;

                //page orintation
                oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;


                dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                for (r = 0; r <= RowCount - 1; r++)
                {
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        oTemp = oTemp + DataArray[r, c] + "\t";

                    }
                }

                //table format
                oRange.Text = oTemp;

                object Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBorders = true;
                object AutoFit = true;
                object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;

                oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                                      Type.Missing, Type.Missing, ref ApplyBorders,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);

                oRange.Select();

                oDoc.Application.Selection.Tables[1].Select();
                oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.InsertRowsAbove(1);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();

                //header row style
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Tahoma";
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;

                //add header row manually
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
                }

                //table style                        
                oDoc.Application.Selection.Tables[1].set_Style("Table Grid 3");
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                //header text
                foreach (Word.Section section in oDoc.Application.ActiveDocument.Sections)
                {
                    Word.Range headerRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
                    headerRange.Text = "Menu";
                    headerRange.Font.Size = 16;
                    headerRange.Font.Bold = 1;
                    headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }

                //save the file
                oDoc.SaveAs(filename);
            }
        }
        internal void MENU_Load(object sender, EventArgs e)
        {
            load_dsdouong();
            dinhdangluoi();
            dinhdangluoi_inds();
            xulybuttion(true);
            DataTable dt = new DataTable();
            dt = dmdouong_bul.load_dmdouong();
            cbiddm.DataSource = dt;
            cbiddm.DisplayMember = "IDDM";
            cbtendm.DataSource = dt;
            cbtendm.DisplayMember = "TENDM";
            tat();
            txtma.ReadOnly = true;
            cbiddm.Hide();
            dg_indanhsach.Hide();
            
        }
        private void tat()
        {
            txtma.Show();
            lbmasanpham.Show();
            txttendouong.ReadOnly = true;
            txtdongia.ReadOnly = true;
            cbtendm.Enabled = false;
        }
        private void mo()
        {
            txtma.Hide();
            lbmasanpham.Hide();
            txttendouong.ReadOnly = false;
            txtdongia.ReadOnly = false;
            cbtendm.Enabled = true;
        }
        private void load_dsdouong()
        {
            bindingSource1.DataSource = douong_bul.load_douong();
            dg_monan.DataSource = bindingSource1;
            dg_indanhsach.DataSource = douong_bul.load_indsdouong();
        }    
        private void MNTDANHMUC_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.5;
            DANHMUC dm = new DANHMUC();
            dm.FormClosing += new FormClosingEventHandler(dm.DANHMUC_FormClosing);           
            dm.ShowDialog();            
        }
        DMDOUONG_BUL dmdouong_bul = new DMDOUONG_BUL();
        DOUONG_BUL douong_bul = new DOUONG_BUL();
        private void insert()
        {
            DOUONG_PUBLIC douong_public = new DOUONG_PUBLIC();
            douong_public.IDDM = int.Parse(cbiddm.Text);
            douong_public.TENDOUONG = txttendouong.Text;
            douong_public.DONGIA = float.Parse(txtdongia.Text);
            douong_bul.insert_douong(douong_public);
        }
        private void update()
        {
            DOUONG_PUBLIC douong_public = new DOUONG_PUBLIC();
            douong_public.IDDOUONG = int.Parse(txtma.Text);
            douong_public.IDDM = int.Parse(cbiddm.Text);
            douong_public.TENDOUONG = txttendouong.Text;
            douong_public.DONGIA = float.Parse(txtdongia.Text);
            douong_bul.update_douong(douong_public);
        }
        private void delete()
        {
            DOUONG_PUBLIC douong_public = new DOUONG_PUBLIC();
            douong_public.IDDOUONG = int.Parse(txtma.Text);
            douong_bul.delete_douong(douong_public);
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

        private void btThem_Click(object sender, EventArgs e)
        {
            mo();
            nutThem = true;          
            xulybuttion(false);
            txttendouong.Clear();
            txtdongia.Text = "0";
            cbtendm.SelectedIndex = -1;            
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            mo();
            nutSua = true;         
            xulybuttion(false);
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if (nutThem == true)
            {
                if (txttendouong.TextLength == 0)
                {
                    lbtrangthai.ForeColor = Color.DarkRed;
                    lbtrangthai.Text = "Chưa điền tên.";
                }
                else if (txtdongia.TextLength == 0)
                {
                    lbtrangthai.ForeColor = Color.DarkRed;
                    lbtrangthai.Text = "Chưa điền đơn giá.";
                }
                else if (cbtendm.Text == "")
                {
                    lbtrangthai.ForeColor = Color.DarkRed;
                    lbtrangthai.Text = "Chưa chọn danh mục.";
                }
                else
                {                  
                        insert();
                        nutThem = false;
                        xulybuttion(true);
                        tat();
                        load_dsdouong();                             
                }              
            }
            else if (nutSua == true)
            {
                if (txttendouong.TextLength == 0)
                {
                    lbtrangthai.ForeColor = Color.DarkRed;
                    lbtrangthai.Text = "Chưa điền tên.";
                }
                else if (txtdongia.TextLength == 0)
                {
                    lbtrangthai.ForeColor = Color.DarkRed;
                    lbtrangthai.Text = "Chưa điền đơn giá.";
                }
                else if (cbtendm.Text == "")
                {
                    lbtrangthai.ForeColor = Color.DarkRed;
                    lbtrangthai.Text = "Chưa chọn danh mục.";
                }
                else
                {                 
                        update();
                        nutSua = false;
                        xulybuttion(true);
                        tat();
                        load_dsdouong();                   
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
                load_dsdouong();
            }
            else if (nutSua == true)
            {
                nutSua = false;
                xulybuttion(true);
                tat();
            }
        }

      
        private void dg_monan_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dg_monan_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                txtma.Text = dg_monan.Rows[dong].Cells[0].Value.ToString();
                txttendouong.Text = dg_monan.Rows[dong].Cells[3].Value.ToString();
                txtdongia.Text = dg_monan.Rows[dong].Cells[4].Value.ToString();
                cbiddm.Text = dg_monan.Rows[dong].Cells[1].Value.ToString();
                cbtendm.Text = dg_monan.Rows[dong].Cells[2].Value.ToString();
            }
            catch
            { }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dg_monan.Rows.Count == 1)
            { }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("Muốn xóa một món ăn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    delete();
                    load_dsdouong();
                }
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
        private void txtdongia_KeyPress(object sender, KeyPressEventArgs e)
        {
            ChiDuocNhapSo(sender, e);                
        }

        private void btLui_Click(object sender, EventArgs e)
        {

            try
            {
                int lui = dg_monan.CurrentRow.Index - 1;
                if (lui != dg_monan.Rows.Count + 1)
                {
                    dg_monan.CurrentCell = dg_monan.Rows[lui].Cells[dg_monan.CurrentCell.ColumnIndex];
                    dg_monan.Rows[lui].Selected = true;
                }
            }
            catch
            { }
        }

        private void btToi_Click(object sender, EventArgs e)
        {
            try
            {
                int toi = dg_monan.CurrentRow.Index + 1;
                if (toi != dg_monan.Rows.Count - 1)
                {
                    dg_monan.CurrentCell = dg_monan.Rows[toi].Cells[dg_monan.CurrentCell.ColumnIndex];
                    dg_monan.Rows[toi].Selected = true;
                }
            }
            catch
            { }
        }

        private void bttim_Click(object sender, EventArgs e)
        {
            if (txttim.TextLength == 0)
            {
                lbtrangthai.ForeColor = Color.DarkRed;
                lbtrangthai.Text = "Chưa điền tên cần tìm.";
            }
            else
            {
                DOUONG_PUBLIC douong_public = new DOUONG_PUBLIC();
                douong_public.TEN = txttim.Text;
                dg_monan.DataSource=douong_bul.TIM_DOUONG(douong_public);
            }
        }

        private void btlammoi_Click(object sender, EventArgs e)
        {
            dg_monan.DataSource = douong_bul.load_douong();
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btinds_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Word Documents (*.docx)|*.docx";
            save.FileName = save.FileName;
            if (save.ShowDialog() == DialogResult.OK)
            {
                XuatRaFileWord(dg_indanhsach, save.FileName);
            }
        }

        private void btthoat_MouseMove_1(object sender, MouseEventArgs e)
        {
            btthoat.BackColor = Color.Chocolate;
            btthoat.ForeColor = Color.Yellow;
        }

        private void btthoat_MouseLeave_1(object sender, EventArgs e)
        {
            btthoat.BackColor = Color.Transparent;
            btthoat.ForeColor = SystemColors.ControlText;
        }
                                                                                                                                  
        private void btinds_MouseMove(object sender, MouseEventArgs e)
        {
            btinds.BackColor = Color.Chocolate;
            btinds.ForeColor = Color.Yellow;
        }

        private void btinds_MouseLeave(object sender, EventArgs e)
        {
            btinds.BackColor = Color.Transparent;
            btinds.ForeColor = SystemColors.ControlText;
        }

        private void cbtendm_Click(object sender, EventArgs e)
        {
            if (cbtendm.DataSource == null)
            {
                lbtrangthai.ForeColor = Color.DarkRed;
                lbtrangthai.Text = "Danh mục menu trống.";
            }
        }     
        private void btlammoi_MouseLeave(object sender, EventArgs e)
        {
            btlammoi.BackColor = Color.Transparent;
        }       

        private void txtdongia_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double a = 0;
                a = double.Parse(txtdongia.Text);
                txtdongia.Text = a.ToString("###,###,##0");
            }
            catch
            { }       
        }      
    }
}
