using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace PUBLIC
{
    public class BAN_PUBLIC
    {
        public BAN_PUBLIC(int id, string ten, string sst)
        {
            this.IDBAN = id;
            this._TEN = ten;
            this.TRANGTHAI = sst;
        }
        public BAN_PUBLIC(DataRow rows)
        {
            this.IDBAN = (int)rows["IDBAN"];
            this.TEN = rows["TEN"].ToString();
            this.TRANGTHAI = rows["TRANGTHAI"].ToString();
        }
        public BAN_PUBLIC()
        {
        }
        private int _IDBAN;

        public int IDBAN
        {
            get { return _IDBAN; }
            set { _IDBAN = value; }
        }
        private string _TEN;

        public string TEN
        {
            get { return _TEN; }
            set { _TEN = value; }
        }

        public string TRANGTHAI
        {
            get
            {
                return _TRANGTHAI;
            }

            set
            {
                _TRANGTHAI = value;
            }
        }

        public int ODER
        {
            get
            {
                return _ODER;
            }

            set
            {
                _ODER = value;
            }
        }

        private string _TRANGTHAI;
        private int _ODER;
    }
}
