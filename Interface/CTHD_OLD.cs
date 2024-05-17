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
using Word = Microsoft.Office.Interop.Word;
namespace Interface
{
    public partial class CTHD_OLD : Form
    {
        public CTHD_OLD()
        {
            InitializeComponent();
        }
        CTHD_OLD_BUL cthd_old_bul = new CTHD_OLD_BUL();
        private int mahoadon_old;

        public int Mahoadon_old
        {
            get
            {
                return mahoadon_old;
            }

            set
            {
                mahoadon_old = value;
            }
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
                    headerRange.Text = "Chi tiết của mã hóa đơn: " + mahoadon_old.ToString(); 
                    headerRange.Font.Size = 16;
                    headerRange.Font.Bold = 1;
                    headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }
                // thêm một dòng vào file word
                Word.Paragraph p = oDoc.Paragraphs.Add();
                Word.Range tongtien = p.Range;
                tongtien.Text = "Tổng tiền: " + rttongtien.Text + " VNĐ";
                // thai đổi lề of chữ
                tongtien.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
                tongtien.InsertParagraphAfter();
                // thêm giờ vào file word
                Word.Paragraph p1 = oDoc.Paragraphs.Add();
                Word.Range thoigianlap = p1.Range;
                thoigianlap.Text = DateTime.Now.ToString();
                thoigianlap.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
                thoigianlap.InsertParagraphAfter();
                //save the file
                oDoc.SaveAs(filename);
            }
        }
        private void CTHD_OLD_Load(object sender, EventArgs e)
        {
            groupBox1.Text = "Chi tiết của mã hóa đơn: " + mahoadon_old.ToString();
            CTHD_OLD_PUBLIC cthd_old_public = new CTHD_OLD_PUBLIC();
            cthd_old_public.IDHOADON_OLD = mahoadon_old;
            dg_chtd_old.DataSource = cthd_old_bul.load_cthd_old_printer(cthd_old_public);
            dinhdangluoi();
            rttongtien.ReadOnly = true;
            tinhtongtien();
        }
        private void tinhtongtien()
        {
            double tongtien = 0;
            for (int i = 0; i < dg_chtd_old.Rows.Count - 1; ++i)
            {
                tongtien += Convert.ToDouble(dg_chtd_old.Rows[i].Cells[3].Value.ToString());
            }
            rttongtien.Text = tongtien.ToString("###,###,##0");
        }
        private void dinhdangluoi()
        {
            dg_chtd_old.ReadOnly = true;
            string dinhdangso = "###,###,##0";            
            dg_chtd_old.Columns[0].HeaderText = "Tên món";
            dg_chtd_old.Columns[1].HeaderText = "Số lượng";
            dg_chtd_old.Columns[2].HeaderText = "Đơn giá (VNĐ)";
            dg_chtd_old.Columns[2].DefaultCellStyle.Format = dinhdangso;
            dg_chtd_old.Columns[3].HeaderText = "Thành tiền (VNĐ)";
            dg_chtd_old.Columns[3].DefaultCellStyle.Format = dinhdangso;           
        }

        private void inChiTiếtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Word Documents (*.docx)|*.docx";
            save.FileName = save.FileName;
            if (save.ShowDialog() == DialogResult.OK)
            {
                XuatRaFileWord(dg_chtd_old, save.FileName);
            }
        }
    }
}
