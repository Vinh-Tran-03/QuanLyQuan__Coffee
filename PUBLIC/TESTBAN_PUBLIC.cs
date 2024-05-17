using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace PUBLIC
{
    public class TESTBAN_PUBLIC
    {
        private int _IDBAN;
        private string _TEN;
        private string _TRANGTHAI;
        private int _ODER;

        public TESTBAN_PUBLIC(DataRow dong)
        {
            this.IDBAN = int.Parse(dong["IDBAN"].ToString());
            this.TEN = dong["TEN"].ToString();
            this.TRANGTHAI = dong["TRANGTHAI"].ToString();
            this.ODER = int.Parse(dong["ODER"].ToString());
        }

        public int IDBAN
        {
            get
            {
                return _IDBAN;
            }

            set
            {
                _IDBAN = value;
            }
        }

        public string TEN
        {
            get
            {
                return _TEN;
            }

            set
            {
                _TEN = value;
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
    }
}
