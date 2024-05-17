using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using PUBLIC;
using System.Data;
namespace BUL
{
    public class CTHD_BUL
    {
        CTHD_DAL cthd_dal = new CTHD_DAL();
        public DataTable load_cthd(CTHD_PUBLIC cthd_public)
        {
            return cthd_dal.load_cthd(cthd_public);
        }
        public int insert_cthd(CTHD_PUBLIC cthd_public)
        {
            return cthd_dal.insert_cthd(cthd_public);
        }
        public int update_cthd(CTHD_PUBLIC cthd_public)
        {
            return cthd_dal.update_cthd(cthd_public);
        }
        public int delete_cthd(CTHD_PUBLIC cthd_public)
        {
            return cthd_dal.delete_cthd(cthd_public);
        }
        public DataTable load_cthd_thanhtoan(CTHD_PUBLIC cthd_public)
        {
            return cthd_dal.load_cthd_thanhtoan(cthd_public);
        }
    }
}
