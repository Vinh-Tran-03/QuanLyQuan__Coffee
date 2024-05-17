using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PUBLIC
{
    public class HOADON_PUBLIC
    {
        private int _IDHOADON;

        public int IDHOADON
        {
            get { return _IDHOADON; }
            set { _IDHOADON = value; }
        }
        private int _IDBAN;

        public int IDBAN
        {
            get { return _IDBAN; }
            set { _IDBAN = value; }
        }
        private string _IDNV;

       
        private DateTime _NGAYLAP;

        public DateTime NGAYLAP
        {
            get { return _NGAYLAP; }
            set { _NGAYLAP = value; }
        }
        private string _TRANGTHAI;

       
        public string IDNV
        {
            get
            {
                return _IDNV;
            }

            set
            {
                _IDNV = value;
            }
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
    }
}
