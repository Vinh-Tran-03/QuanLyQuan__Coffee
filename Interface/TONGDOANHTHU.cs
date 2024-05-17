using BUL;
using PUBLIC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
namespace Interface
{
    public partial class TONGDOANHTHU : Form
    {
        public TONGDOANHTHU()
        {
            InitializeComponent();
        }

        private void bttin_MouseMove(object sender, MouseEventArgs e)
        {
            bttin.BackColor = Color.Chocolate;
        }

        private void bttin_MouseLeave(object sender, EventArgs e)
        {
            bttin.BackColor = Color.Transparent;
        }
        private int ngay;
        private int thang;
        private int nam;
        private bool bngay;
        private bool bthang;
        private bool bnam;
        public int Ngay
        {
            get
            {
                return ngay;
            }

            set
            {
                ngay = value;
            }
        }

        public int Thang
        {
            get
            {
                return thang;
            }

            set
            {
                thang = value;
            }
        }

        public int Nam
        {
            get
            {
                return nam;
            }

            set
            {
                nam = value;
            }
        }

        public bool Bngay
        {
            get
            {
                return bngay;
            }

            set
            {
                bngay = value;
            }
        }

        public bool Bthang
        {
            get
            {
                return bthang;
            }

            set
            {
                bthang = value;
            }
        }

        public bool Bnam
        {
            get
            {
                return bnam;
            }

            set
            {
                bnam = value;
            }
        }

        public bool Timcheck
        {
            get
            {
                return timcheck;
            }

            set
            {
                timcheck = value;
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

        public bool Checkten
        {
            get
            {
                return checkten;
            }

            set
            {
                checkten = value;
            }
        }

        HOADON_OLD_BUL hd_old_bul = new HOADON_OLD_BUL();
        private void load_dshd_ngay()
        {
            HOADON_OLD_PUBLIC hd_old_public = new HOADON_OLD_PUBLIC();
            hd_old_public.NGAY = Ngay;
            dg_dshd.DataSource = hd_old_bul.load_hd_day(hd_old_public);
        }
        private void load_dshd_thang()
        {
            HOADON_OLD_PUBLIC hd_old_public = new HOADON_OLD_PUBLIC();
            hd_old_public.THANG = Thang;
            dg_dshd.DataSource = hd_old_bul.load_hd_month(hd_old_public);
        }
        private void load_dshd_nam()
        {
            HOADON_OLD_PUBLIC hd_old_public = new HOADON_OLD_PUBLIC();
            hd_old_public.NAM = Nam;
            dg_dshd.DataSource = hd_old_bul.load_hd_year(hd_old_public);
        }
        private void dinhdangluoi()
        {
            dg_dshd.ReadOnly = true;
            string dinhdangso = "###,###,##0";
            dg_dshd.Columns[0].HeaderText = "Mã hóa đơn";
            dg_dshd.Columns[1].HeaderText = "Tên";
            dg_dshd.Columns[2].HeaderText = "Tên nhân viên";            
            dg_dshd.Columns[3].HeaderText = "Ngày lập hóa đơn";
            dg_dshd.Columns[4].HeaderText = "Thanh toán";
            dg_dshd.Columns[5].HeaderText = "Tổng tiền";
            dg_dshd.Columns[5].DefaultCellStyle.Format = dinhdangso;
        }
        private bool timcheck;
        private bool checkten;  
        private string tenban;
        private void TONGDOANHTHU_Load(object sender, EventArgs e)
        {
            txttongtien.ReadOnly = true;
            groupBox2.Text = "Tổng doanh thu(VNĐ)";
            if (Bngay == true)
            {
                trangthai = "Ngày";
                load_dshd_ngay();
                dinhdangluoi();
                groupBoxTONGDOANHTHU.Text = "Danh sách hóa đơn theo Ngày: " + Ngay.ToString();
                tinhtongtien(5);
            }
            else if (Bthang == true)
            {
                trangthai = "Tháng";
                load_dshd_thang();
                dinhdangluoi();
                groupBoxTONGDOANHTHU.Text = "Danh sách hóa đơn theo Tháng: " + Thang.ToString();
                tinhtongtien(5);
            }
            else if (Bnam == true)
            {
                trangthai = "Năm";
                load_dshd_nam();
                dinhdangluoi();
                groupBoxTONGDOANHTHU.Text = "Danh sách hóa đơn theo Năm: " + Nam.ToString();
                tinhtongtien(5);
            }
            else if (Timcheck == true)
            {
                trangthai = Tenban;
                HOADON_OLD_PUBLIC hd_old_public = new HOADON_OLD_PUBLIC();
                hd_old_public.Soban = Tenban;
                dg_dshd.DataSource = hd_old_bul.load_timhd_old(hd_old_public);
                dinhdangluoi_hd_ban();
                groupBoxTONGDOANHTHU.Text = "Danh sách hóa đơn theo " + Tenban;
                tinhtongtien(5);
            }
            else if (Checkten == true)
            {
                trangthai = Tenban;
                HOADON_OLD_PUBLIC hd_old_public = new HOADON_OLD_PUBLIC();
                hd_old_public.TENNV = Tenban;
                dg_dshd.DataSource = hd_old_bul.load_timhd_old_TENNV(hd_old_public);
                dinhdangluoi_hd_ban();
                groupBoxTONGDOANHTHU.Text = "Danh sách hóa đơn của nhân viên: " + Tenban;
                tinhtongtien(5);
            }
            else
            {
                trangthai = "Tất cả các hóa đơn";
                dg_dshd.DataSource = hd_old_bul.load_hoadon_old_NOTID();
                dinhdangluoi();
                groupBoxTONGDOANHTHU.Text = "Danh sách tất cả các hóa đơn";
                tinhtongtien(5);
            }
        }     
        private void dinhdangluoi_hd_ban()
        {
            string dinhdangso = "###,###,##0";
            dg_dshd.ReadOnly = true;            
            dg_dshd.Columns[0].HeaderText = "Mã hóa đơn";
            dg_dshd.Columns[1].HeaderText = "Tên bàn";
            dg_dshd.Columns[2].HeaderText = "Tên nhân viên";
            dg_dshd.Columns[3].HeaderText = "Ngày lập hóa đơn";
            dg_dshd.Columns[4].HeaderText = "Thanh toán";
            dg_dshd.Columns[5].HeaderText = "Tổng tiền(VNĐ)";
            dg_dshd.Columns[5].DefaultCellStyle.Format = dinhdangso;
        }
        private void tinhtongtien(int vitri)
        {
            double tongtien = 0;
            for (int i = 0; i < dg_dshd.Rows.Count - 1; ++i)
            {
                tongtien += Convert.ToDouble(dg_dshd.Rows[i].Cells[vitri].Value.ToString());
            }
            txttongtien.Text = tongtien.ToString("###,###,##0");
        }

        internal void TONGDOANHTHU_FormClosing(object sender, FormClosingEventArgs e)
        {
            ThongKeDoanhThu.tkdt.btlammoi_Click(sender, e);
        }

        private void bttin_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Word Documents (*.docx)|*.docx";
            save.FileName = save.FileName;
            if (save.ShowDialog() == DialogResult.OK)
            {
                XuatRaFileWord(dg_dshd, save.FileName);
            }
        }
        string trangthai = "";
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
                    headerRange.Text = "Tổng doanh thu theo: "+ trangthai;
                    headerRange.Font.Size = 16;
                    headerRange.Font.Bold = 1;
                    headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }
                // thêm một dòng vào file word
                Word.Paragraph p = oDoc.Paragraphs.Add();
                Word.Range tongtien = p.Range;
                tongtien.Text = "Tổng doang thu: "+txttongtien.Text+" VNĐ";
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
    }
}
