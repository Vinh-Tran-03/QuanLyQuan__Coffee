using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PUBLIC;
namespace DAL
{
    public class CTHD_OLD_DAL
    {
        KETNOI ketnoi = new KETNOI();
        public DataTable load_cthd_old(CTHD_OLD_PUBLIC cthd_old)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@IDHD_OLD";
            values[0] = cthd_old.IDHOADON_OLD;
            string sql = "LOAD_CTHD_OLD";
            return ketnoi.LoadDataWithParameter(sql, name, values, parameter);
        }
        public DataTable load_cthd_old_printer(CTHD_OLD_PUBLIC cthd_old)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@IDHD_OLD";
            values[0] = cthd_old.IDHOADON_OLD;
            string sql = "LOAD_CTHD_OLD_PRINTER";
            return ketnoi.LoadDataWithParameter(sql, name, values, parameter);
        }
        public int insert_cthd_old(CTHD_OLD_PUBLIC cthd_old)
        {
            int parameter = 3;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0]= "@IDHD_OLD";
            name[1]= "@IDDOUONG";
            name[2]= "@SOLUONG";
            values[0]=cthd_old.IDHOADON_OLD;
            values[1]=cthd_old.IDDOUONG;
            values[2]=cthd_old.SOLUONG;
            string sql = "INSERT_CTHD_OLD";
            return ketnoi.Excute_Data(sql, name, values, parameter);
        }
        public int delete_cthd_old(CTHD_OLD_PUBLIC cthd_old)
        {
            int parameter = 2;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@IDHD_OLD";           
            values[0] = cthd_old.IDHOADON_OLD;           
            string sql = "DELETE_CTHD_OLD";
            return ketnoi.Excute_Data(sql, name, values, parameter);
        }
    }
}
