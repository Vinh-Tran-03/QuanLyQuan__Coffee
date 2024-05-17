using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using PUBLIC;
using System.Data;
namespace BUL
{
    public class NHANVIEN_BUL
    {
        NHANVIEN_DAL nhanvien_dal = new NHANVIEN_DAL();
        public DataTable load_nhanvien()
        {
            return nhanvien_dal.load_nhanvien();
        }
        public int insert_nhanvien(NHANVIEN_PUBLIC nhanvien_public)
        {
            return nhanvien_dal.insert_nhanvien(nhanvien_public);
        }
        public int update_nhanvien(NHANVIEN_PUBLIC nhanvien_public)
        {
            return nhanvien_dal.update_nhanvien(nhanvien_public);
        }
        public int delete_nhanvien(NHANVIEN_PUBLIC nhanvien_public)
        {
            return nhanvien_dal.delete_nhanvien(nhanvien_public);
        }
        public int count_nhanvien()
        {
            return nhanvien_dal.count_nhanvien();
        }
        public DataTable Tim_nv(NHANVIEN_PUBLIC nhanvien_public)
        {
            return nhanvien_dal.Tim_nv(nhanvien_public);
        }
    }
}
