using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PUBLIC;
namespace DAL
{
    public class DOUONG_DAL
    {
        KETNOI ketnoi = new KETNOI();
        public DataTable load_douong()
        {
            string sql = "LOAD_DOUONG";
            return ketnoi.Load_Data(sql);
        }
        public DataTable load_indsdouong()
        {
            string sql = "LOAD_INDSDOUONG";
            return ketnoi.Load_Data(sql);
        }
        public DataTable load_douongvoi_where(DOUONG_PUBLIC douong_public)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MADM";
            values[0] = douong_public.IDDM;
            string sql = "LOAD_DOUONG_WITH_WHERE";
            return ketnoi.LoadDataWithParameter(sql, name, values, parameter);
        }
        public DataTable foodfind(int iddm)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@IDDM";
            values[0] = iddm;
            string sql = "LOAD_DOUONG_ID";
            return ketnoi.LoadDataWithParameter(sql, name, values, parameter);
        }
        public DataTable TIM_DOUONG(DOUONG_PUBLIC douong_public)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@TEN";
            values[0] = douong_public.TEN;     
            string sql = "TIM_TENDOUONG";
            return ketnoi.LoadDataWithParameter(sql, name, values, parameter);
        }
        public int insert_douong(DOUONG_PUBLIC douong_public)
        {
            int parameter = 3;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0]="@IDDM";
            name[1]="@TENDOUONG";
            name[2]="@DONGIA";
            values[0]=douong_public.IDDM;
            values[1]=douong_public.TENDOUONG;
            values[2]=douong_public.DONGIA;
            string sql = "INSERT_DOUONG";
            return ketnoi.Excute_Data(sql,name,values,parameter);
        }
        public int update_douong(DOUONG_PUBLIC douong_public)
        {
            int parameter = 4;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@IDDOUONG";
            name[1] = "@IDDM";
            name[2] = "@TENDOUONG";
            name[3] = "@DONGIA";
            values[0] = douong_public.IDDOUONG;
            values[1] = douong_public.IDDM;
            values[2] = douong_public.TENDOUONG;
            values[3] = douong_public.DONGIA;
            string sql = "UPDATE_DOUONG";
            return ketnoi.Excute_Data(sql, name, values, parameter);
        }
        public int delete_douong(DOUONG_PUBLIC douong_public)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@IDDOUONG";
            values[0] = douong_public.IDDOUONG;
            string sql = "DELETE_DOUONG";
            return ketnoi.Excute_Data(sql, name, values, parameter);
        }
    }
}
