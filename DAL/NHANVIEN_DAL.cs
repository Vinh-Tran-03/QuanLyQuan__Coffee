using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PUBLIC;
namespace DAL
{
    public class NHANVIEN_DAL
    {
        KETNOI ketnoi = new KETNOI();      
        public DataTable load_nhanvien()
        {
            string sql = "LOAD_NHANVIEN";
            return ketnoi.Load_Data(sql);
        }
        public int insert_nhanvien(NHANVIEN_PUBLIC nhanvien_public)
        {
            int parameter = 5;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@IDNV";
            name[1] = "@TENNV";
            name[2] = "@NGAYSINH";
            name[3] = "@SDT";
            name[4] = "@GIOITINH";
            values[0] = nhanvien_public.IDNV;
            values[1] = nhanvien_public.TENNV;
            values[2] = nhanvien_public.NGAYSINH;
            values[3] = nhanvien_public.SDT;
            values[4] = nhanvien_public.GIOITINH;
            string sql = "INSERT_NHANVIEN";
            return ketnoi.Excute_Data(sql, name, values, parameter);
        }
        public int update_nhanvien(NHANVIEN_PUBLIC nhanvien_public)
        {
            int parameter = 5;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@IDNV";
            name[1] = "@TENNV";
            name[2] = "@NGAYSINH";
            name[3] = "@SDT";
            name[4] = "@GIOITINH";
            values[0] = nhanvien_public.IDNV;
            values[1] = nhanvien_public.TENNV;
            values[2] = nhanvien_public.NGAYSINH;
            values[3] = nhanvien_public.SDT;
            values[4] = nhanvien_public.GIOITINH;
            string sql = "UPDATE_NHANVIEN";
            return ketnoi.Excute_Data(sql, name, values, parameter);
        }
        public int delete_nhanvien(NHANVIEN_PUBLIC nhanvien_public)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@IDNV";           
            values[0] = nhanvien_public.IDNV;          
            string sql = "DELETE_NHANVIEN";
            return ketnoi.Excute_Data(sql, name, values, parameter);
        }
        public int count_nhanvien()
        {
            string sql = "COUNT_NHANVIEN";
            return ketnoi.ReturnValueInt(sql);
        }
        public DataTable Tim_nv(NHANVIEN_PUBLIC nhanvien_public)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@TEN";
            values[0] = nhanvien_public.TIMTEN;
            string sql = "TIM_TENNV";
            return ketnoi.LoadDataWithParameter(sql, name, values, parameter);
        }
    }
}
