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
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }
        TESTBAN_BUL testbanbul = new TESTBAN_BUL();
        private void taosdban()
        {
            flowLayoutPanel1.Controls.Clear();
            List<TESTBAN_PUBLIC> dsban = testbanbul.load_dsban();
            foreach (TESTBAN_PUBLIC obj in dsban)
            {
                Button bt = new Button();
                bt.Tag = obj;// Tag để xác định từng item trong đối tượng
                bt.Click += bt_click;
                flowLayoutPanel1.Controls.Add(bt);
                bt.Height = 60;
                bt.Width = 60;
                bt.Text = obj.TEN;
            }
        }
        private void bt_click(object sender, EventArgs e)
        {
            //((sender as Button).Tag as ĐỐI TƯỢNG).Item lấy từng item trong đối tượng
            MessageBox.Show(((sender as Button).Tag as TESTBAN_PUBLIC).TEN);
        }
        private void Test_Load(object sender, EventArgs e)
        {
            taosdban();
        }
    }
}
