using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PUBLIC;
using DAL;
namespace BUL
{
    public class HOADON_OLD_BUL
    {
        HOADON_OLD_DAL hd_dal_old = new HOADON_OLD_DAL();
        public DataTable load_hoadon_old()
        {
            return hd_dal_old.load_hoadon_old();
        }
        public int insert_hoadon_old(HOADON_OLD_PUBLIC hd_old)
        {
            return hd_dal_old.insert_hoadon_old(hd_old);
        }
        public int delete_hoadon_old(HOADON_OLD_PUBLIC hd_old)
        {
            return hd_dal_old.delete_hoadon_old(hd_old);
        }
        public DataTable load_timhd_old(HOADON_OLD_PUBLIC hd_old)
        {
            return hd_dal_old.load_timhd_old(hd_old);
        }
        public DataTable load_hd_day(HOADON_OLD_PUBLIC hd_old)
        {
            return hd_dal_old.load_hd_day(hd_old);
        }
        public DataTable load_hd_month(HOADON_OLD_PUBLIC hd_old)
        {
            return hd_dal_old.load_hd_month(hd_old);
        }
        public DataTable load_hd_year(HOADON_OLD_PUBLIC hd_old)
        {
            return hd_dal_old.load_hd_year(hd_old);
        }
        public DataTable load_hoadon_old_NOTID()
        {
            return hd_dal_old.load_hoadon_old_NOTID();
        }
        public DataTable load_timhd_old_TENNV(HOADON_OLD_PUBLIC hd_old)
        {
            return hd_dal_old.load_timhd_old_TENNV(hd_old);
        }
    }
}
