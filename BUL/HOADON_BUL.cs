using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using PUBLIC;
using System.Data;
namespace BUL
{
    public class HOADON_BUL
    {
        HOADON_DAL hoadon_dal = new HOADON_DAL();
        public DataTable load_hoadon()
        {
            return hoadon_dal.load_hoadon();
        }
        public int insert_hoadon(HOADON_PUBLIC hoadon_public)
        {
            return hoadon_dal.insert_hoadon(hoadon_public);
        }
        public int update_hoadon(HOADON_PUBLIC hoadon_public)
        {
            return hoadon_dal.update_hoadon(hoadon_public);
        }
        public int delete_hoadon(HOADON_PUBLIC hoadon_public)
        {
            return hoadon_dal.delete_hoadon(hoadon_public);
        }
        public int count_hoadon_ban(HOADON_PUBLIC hoadon_public)
        {
            return hoadon_dal.count_hoadon_ban(hoadon_public);
        }
        public int delete_hoadon_with_idban(HOADON_PUBLIC hoadon_public)
        {
            return hoadon_dal.delete_hoadon_with_idban(hoadon_public);
        }
        public int load_IDHD_WITH_IDBAN(HOADON_PUBLIC hd_public)
        {
            return hoadon_dal.load_IDHD_WITH_IDBAN(hd_public);
        }
        public int update_hoadon_doiban(HOADON_PUBLIC hoadon_public)
        {
            return hoadon_dal.update_hoadon_doiban(hoadon_public);
        }
    }
}
