using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PUBLIC
{
    public class HINHNV_PUBLIC
    {
        private int _IDHINH;

        public int IDHINH
        {
            get { return _IDHINH; }
            set { _IDHINH = value; }
        }
        private byte[] _HINH;

        public byte[] HINH
        {
            get { return _HINH; }
            set { _HINH = value; }
        }
        private string _IDNV;

        public string IDNV
        {
            get { return _IDNV; }
            set { _IDNV = value; }
        }
    }
}
