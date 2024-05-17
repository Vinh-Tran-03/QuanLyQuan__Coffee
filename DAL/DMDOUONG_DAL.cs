using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PUBLIC;
namespace DAL
{
    public class DMDOUONG_DAL
    {
        KETNOI ketnoi = new KETNOI();
        public DataTable load_dmdouong()
        {
            string sql = "LOAD_DANHMUC";
            return ketnoi.Load_Data(sql);
        }
        public int insert_dmdouong(DMDOUONG_PUBLIC dmdouong_public)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@TENDM";
            values[0] = dmdouong_public.TENDM;
            string sql = "INSERT_DANHMUC";
            return ketnoi.Excute_Data(sql, name, values, parameter);
        }
        public int update_dmdouong(DMDOUONG_PUBLIC dmdouong_public)
        {
            int parameter = 2;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@IDDM";
            name[1] = "@TENDM";
            values[0] = dmdouong_public.IDDM;
            values[1] = dmdouong_public.TENDM;
            string sql = "UPDATE_DANHMUC";
            return ketnoi.Excute_Data(sql, name, values, parameter);
        }
        public int delete_dmdouong(DMDOUONG_PUBLIC dmdouong_public)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@IDDM";           
            values[0] = dmdouong_public.IDDM;          
            string sql = "DELETE_DANHMUC";
            return ketnoi.Excute_Data(sql, name, values, parameter);
        }
    }
}
