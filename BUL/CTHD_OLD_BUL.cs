using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PUBLIC;
using DAL;
using System.Data;
namespace BUL
{
    public class CTHD_OLD_BUL
    {
        CTHD_OLD_DAL cthd_old_dal = new CTHD_OLD_DAL();
        public DataTable load_cthd_old(CTHD_OLD_PUBLIC cthd_old)
        {
            return cthd_old_dal.load_cthd_old(cthd_old);
        }
        public DataTable load_cthd_old_printer(CTHD_OLD_PUBLIC cthd_old)
        {
            return cthd_old_dal.load_cthd_old_printer(cthd_old);
        }
        public int insert_cthd_old(CTHD_OLD_PUBLIC cthd_old)
        {
            return cthd_old_dal.insert_cthd_old(cthd_old);
        }
        public int delete_cthd_old(CTHD_OLD_PUBLIC cthd_old)
        {
            return cthd_old_dal.delete_cthd_old(cthd_old);
        }
    }
}
