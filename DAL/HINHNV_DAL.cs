using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PUBLIC;
namespace DAL
{
    public class HINHNV_DAL
    {
        KETNOI ketnoi = new KETNOI();
        public DataTable load_hinhnv()
        {
            string sql = "LOAD_HINHNV";
            return ketnoi.Load_Data(sql);
        }
        public int insert_hinhnv(HINHNV_PUBLIC hinhnv_public)
        {
            int parameter = 2;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@HINH";
            name[1] = "@IDNV";
            values[0] = hinhnv_public.HINH;
            values[1] = hinhnv_public.IDNV;
            string sql = "INSERT_HINHNV";
            return ketnoi.Excute_Data(sql, name, values, parameter);
        }       
        public int update_hinhnv(HINHNV_PUBLIC hinhnv_public)
        {
            int parameter = 2;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@IDHINH";
            name[1] = "@HINH";        
            values[0] = hinhnv_public.IDHINH;
            values[1] = hinhnv_public.HINH;
            string sql = "UPDATE_HINHNV";
            return ketnoi.Excute_Data(sql, name, values, parameter);
        }
        public int delete_hinhnv(HINHNV_PUBLIC hinhnv_public)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@IDHINH";           
            values[0] = hinhnv_public.IDHINH;           
            string sql = "DELETE_HINHNV";
            return ketnoi.Excute_Data(sql, name, values, parameter);
        }
    }
}
