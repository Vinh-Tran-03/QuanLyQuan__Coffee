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
using Word = Microsoft.Office.Interop.Word;
namespace Interface
{
    public partial class ThanhToan : Form
    {
        public static ThanhToan thanhtoan;
        public ThanhToan()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            thanhtoan = this;
        }
        private int idban;

        public int Idban
        {
            get
            {
                return idban;
            }

            set
            {
                idban = value;
            }
        }

        public string Tenban
        {
            get
            {
                return tenban;
            }

            set
            {
                tenban = value;
            }
        }

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

        private string tenban;
        int idhoadon = 0;
        HOADON_BUL hd_bul = new HOADON_BUL();
        CTHD_BUL cthd_bul = new CTHD_BUL();
        BAN_BUL ban_bul = new BAN_BUL();
        private void ThanhToan_Load(object sender, EventArgs e)
        {
            txttongtien.ReadOnly = true;
            groupBoxhd.Text = "Hóa đơn " + Tenban;
            HOADON_PUBLIC hd_public = new HOADON_PUBLIC();
            hd_public.IDBAN = Idban;
            idhoadon = hd_bul.load_IDHD_WITH_IDBAN(hd_public);
            Load_CTHD(idhoadon);
            tinhtongtien();           
        }
        private void Load_CTHD(int mahoadon)
        {
            CTHD_PUBLIC cthd_public = new CTHD_PUBLIC();
            cthd_public.IDHOADON = mahoadon;
            bindingSource1.DataSource = cthd_bul.load_cthd_thanhtoan(cthd_public);
            dg_monan_ofban.DataSource = bindingSource1;
            dinhdangluoi();
        }
        private void dinhdangluoi()
        {
            dg_monan_ofban.ReadOnly = true;
            string dinhdangso = "###,###,##0";
            dg_monan_ofban.Columns[0].HeaderText = "Mã đồ uống";
            dg_monan_ofban.Columns[1].HeaderText = "Tên món";
            dg_monan_ofban.Columns[2].HeaderText = "Số lượng";
            dg_monan_ofban.Columns[3].HeaderText = "Đơn giá (VNĐ)";
            dg_monan_ofban.Columns[3].DefaultCellStyle.Format = dinhdangso;
            dg_monan_ofban.Columns[4].HeaderText = "Thành tiền (VNĐ)";
            dg_monan_ofban.Columns[4].DefaultCellStyle.Format = dinhdangso;
            dg_monan_ofban.Columns[5].Visible = false;
            dg_monan_ofban.Columns[5].HeaderText = "Danh mục";
        }
        private void tinhtongtien()
        {          
                double tongtien = 0;
                for (int i = 0; i < dg_monan_ofban.Rows.Count-1; ++i)
                {
                    tongtien += Convert.ToDouble(dg_monan_ofban.Rows[i].Cells[4].Value.ToString());
                }
                txttongtien.Text = tongtien.ToString("###,###,##0");          
        }

        private void txttongtien_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btthanhtoan_MouseMove(object sender, MouseEventArgs e)
        {
            btthanhtoan.BackColor = Color.Chocolate;
        }

        private void btthanhtoan_MouseLeave(object sender, EventArgs e)
        {
            btthanhtoan.BackColor = Color.Transparent;
        }
        HOADON_OLD_BUL hd_old_bul = new HOADON_OLD_BUL();
        CTHD_OLD_BUL cthd_old_bul = new CTHD_OLD_BUL();
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
                    headerRange.Text = "Tổng tiền của " + Tenban;
                    headerRange.Font.Size = 16;
                    headerRange.Font.Bold = 1;
                    headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }
                // insert a line text into word
                Word.Paragraph p = oDoc.Paragraphs.Add();
                Word.Range tongtien = p.Range;
                tongtien.Text = "Tổng tiền: " + txttongtien.Text + " VNĐ";
                // change align of text 
                tongtien.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
                tongtien.InsertParagraphAfter();
                // insert datetime
                Word.Paragraph p1 = oDoc.Paragraphs.Add();
                Word.Range thoigianlap = p1.Range;
                thoigianlap.Text = DateTime.Now.ToString();
                thoigianlap.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
                thoigianlap.InsertParagraphAfter();
                //save the file
                oDoc.SaveAs(filename);
            }
        }
        private void inhoadon()
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Word Documents (*.docx)|*.docx";
            save.FileName = save.FileName;
            if (save.ShowDialog() == DialogResult.OK)
            {
                XuatRaFileWord(dg_monan_ofban, save.FileName);
            }
        }
        private string idnv;       
        private void btthanhtoan_Click(object sender, EventArgs e)
        {
            HOADON_OLD_PUBLIC hd_old_public = new HOADON_OLD_PUBLIC();
            hd_old_public.IDHOADON =idhoadon;
            hd_old_public.IDBAN =Idban;
            hd_old_public.IDNV =Idnv;
            hd_old_public.NGAYLAP =DateTime.Now;
            hd_old_public.TRANGTHAI="Rồi";
            hd_old_public.TONGTIEN =double.Parse(txttongtien.Text);
            hd_old_bul.insert_hoadon_old(hd_old_public);           
            CTHD_OLD_PUBLIC cthd_old_public = new CTHD_OLD_PUBLIC();
            for (int i = 0; i < dg_monan_ofban.Rows.Count - 1; i++)
            {
                cthd_old_public.IDHOADON_OLD = idhoadon;
                cthd_old_public.IDDOUONG = int.Parse(dg_monan_ofban[0, i].Value.ToString());
                cthd_old_public.SOLUONG = int.Parse(dg_monan_ofban[2, i].Value.ToString());
                cthd_old_bul.insert_cthd_old(cthd_old_public);
            }
            // delete CTHD 
            CTHD_PUBLIC cthd_public = new CTHD_PUBLIC();
            for (int j = 0; j < dg_monan_ofban.Rows.Count - 1; j++)
            {
                cthd_public.IDHOADON = idhoadon;
                cthd_public.IDDOUONG= int.Parse(dg_monan_ofban[0, j].Value.ToString());
                cthd_bul.delete_cthd(cthd_public);
            }
            HOADON_PUBLIC hd_public = new HOADON_PUBLIC();
            hd_public.IDHOADON = idhoadon;
            hd_bul.delete_hoadon(hd_public);
            // update trạng thái bàn
            BAN_PUBLIC ban_public = new BAN_PUBLIC();
            ban_public.IDBAN = idban;
            ban_public.TRANGTHAI = "Trống";
            ban_bul.update_trangthaiban(ban_public);
            inhoadon();
            this.Close();
        }
        private void dongform()
        {
            this.Close();
        }
        public void ThanhToan_FormClosing(object sender, FormClosingEventArgs e)
        {
            BANAN.formbanan.Load_CTHD(idhoadon);
            BANAN.formbanan.taobanan();
            BANAN.formbanan.dg_monan_ofban.DataSource = 0;
            BANAN.formbanan.DSMON.Text = "Danh sách món ăn của bàn:";
        }
    }
}
