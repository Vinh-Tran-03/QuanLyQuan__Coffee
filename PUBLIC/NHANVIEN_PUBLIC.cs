using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PUBLIC
{
    public class NHANVIEN_PUBLIC
    {
        private string _IDNV;

        public string IDNV
        {
            get { return _IDNV; }
            set { _IDNV = value; }
        }
        private string _TENNV;

        public string TENNV
        {
            get { return _TENNV; }
            set { _TENNV = value; }
        }
        private DateTime _NGAYSINH;

        public DateTime NGAYSINH
        {
            get { return _NGAYSINH; }
            set { _NGAYSINH = value; }
        }
        private string _SDT;

        public string SDT
        {
            get { return _SDT; }
            set { _SDT = value; }
        }
        private string _GIOITINH;

        public string GIOITINH
        {
            get { return _GIOITINH; }
            set { _GIOITINH = value; }
        }
        private string _TIMTEN;

        public string TIMTEN
        {
            get { return _TIMTEN; }
            set { _TIMTEN = value; }
        }
    }
}
