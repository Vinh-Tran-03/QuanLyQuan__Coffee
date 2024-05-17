using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PUBLIC
{
    public class DOUONG_PUBLIC
    {
        private int _IDDOUONG;
      
        public int IDDOUONG
        {
            get { return _IDDOUONG; }
            set { _IDDOUONG = value; }
        }
        private int _IDDM;

        public int IDDM
        {
            get { return _IDDM; }
            set { _IDDM = value; }
        }
        private string _TENDOUONG;

        public string TENDOUONG
        {
            get { return _TENDOUONG; }
            set { _TENDOUONG = value; }
        }
        private float _DONGIA;

        public float DONGIA
        {
            get { return _DONGIA; }
            set { _DONGIA = value; }
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

        private string _TEN;
    }
}
