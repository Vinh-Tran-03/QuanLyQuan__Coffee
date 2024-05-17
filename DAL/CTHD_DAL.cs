using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PUBLIC;
namespace DAL
{
    public class CTHD_DAL
    {
        KETNOI ketnoi = new KETNOI();
        public DataTable load_cthd(CTHD_PUBLIC cthd_public)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@IDHOADON";
            values[0] = cthd_public.IDHOADON;
            string sql = "LOAD_CTHD";
            return ketnoi.LoadDataWithParameter(sql, name, values, parameter);
        }
        public DataTable load_cthd_thanhtoan(CTHD_PUBLIC cthd_public)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@IDHOADON";
            values[0] = cthd_public.IDHOADON;
            string sql = "LOAD_CTHD_thanhtoan";
            return ketnoi.LoadDataWithParameter(sql, name, values, parameter);
        }
        public int insert_cthd(CTHD_PUBLIC cthd_public)
        {
            int parameter = 3;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0]="@IDHOADON";
            name[1]="@IDDOUONG";
            name[2]="@SOLUONG";
            values[0]=cthd_public.IDHOADON;
            values[1]=cthd_public.IDDOUONG;
            values[2]=cthd_public.SOLUONG;
            string sql = "INSERT_CTHD";
            return ketnoi.Excute_Data(sql, name, values, parameter);
        }
        public int update_cthd(CTHD_PUBLIC cthd_public)
        {
            int parameter = 4;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@IDCTHD";
            name[1] = "@IDHOADON";
            name[2] = "@IDDOUONG";
            name[3] = "@SOLUONG";
            values[0] = cthd_public.IDCTHD;
            values[1] = cthd_public.IDHOADON;
            values[2] = cthd_public.IDDOUONG;
            values[3] = cthd_public.SOLUONG;
            string sql = "UPDATE_CTHD";
            return ketnoi.Excute_Data(sql, name, values, parameter);
        }
        public int delete_cthd(CTHD_PUBLIC cthd_public)
        {
            int parameter = 2;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@IDHOADON";
            name[1] = "@IDDOUONG";
            values[0] = cthd_public.IDHOADON;
            values[1] = cthd_public.IDDOUONG;
            string sql = "DELETE_CTHD";
            return ketnoi.Excute_Data(sql, name, values, parameter);
        }
    }
}
