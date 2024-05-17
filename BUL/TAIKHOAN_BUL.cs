using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using PUBLIC;
using System.Data;
namespace BUL
{
    public class TAIKHOAN_BUL
    {
        TAIKHOAN_DAL taikhoan_dal = new TAIKHOAN_DAL();
        public DataTable load_taikhoan()
        {
            return taikhoan_dal.load_taikhoan();
        }
        public int insert_taikhoan(TAIKHOAN_PUBLIC taikhoan_public)
        {
            return taikhoan_dal.insert_taikhoan(taikhoan_public);
        }
        public int update_taikhoan(TAIKHOAN_PUBLIC taikhoan_public)
        {
            return taikhoan_dal.update_taikhoan(taikhoan_public);
        }
        public int delete_taikhoan(TAIKHOAN_PUBLIC taikhoan_public)
        {
            return taikhoan_dal.delete_taikhoan(taikhoan_public);
        }
        public int check_taikhoan(TAIKHOAN_PUBLIC taikhoan_public)
        {
            return taikhoan_dal.check_taikhoan(taikhoan_public);
        }
        public DataTable get_tenvaquyen_taikhoan(TAIKHOAN_PUBLIC taikhoan_public)
        {
            return taikhoan_dal.get_tenvaquyen_taikhoan(taikhoan_public);
        }
    }
}
