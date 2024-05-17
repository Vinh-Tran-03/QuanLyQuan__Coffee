using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using PUBLIC;
using System.Data;
namespace DAL
{
    public class TAIKHOAN_DAL
    {
        KETNOI ketnoi = new KETNOI();
        public DataTable load_taikhoan()
        {
            string sql = "LOAD_TAIKHOAN";
            return ketnoi.Load_Data(sql);
        }
        public DataTable get_tenvaquyen_taikhoan(TAIKHOAN_PUBLIC taikhoan_public)
        {
            int parameter = 2;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@TENTK";
            name[1] = "@MATKHAU";
            values[0] = taikhoan_public.TENTK;
            values[1] = taikhoan_public.MATKHAU;
            string sql = "GET_TENVAQUYEN_TAIKHOAN";
            return ketnoi.LoadDataWithParameter(sql, name, values, parameter);
        }
        public int insert_taikhoan(TAIKHOAN_PUBLIC taikhoan_public)
        {
            int parameter = 4;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0]="@TENTK";
            name[1]="@MATKHAU";
            name[2]="@QUYEN";
            name[3]="@IDNV";
            values[0]=taikhoan_public.TENTK;
            values[1]=taikhoan_public.MATKHAU;
            values[2]=taikhoan_public.QUYEN;
            values[3]=taikhoan_public.IDNV;
            string sql = "INSERT_TAIKHOAN";
            return ketnoi.Excute_Data(sql, name, values, parameter);
        }
        public int update_taikhoan(TAIKHOAN_PUBLIC taikhoan_public)
        {
            int parameter = 4;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@TENTK";
            name[1] = "@MATKHAU";
            name[2] = "@QUYEN";
            name[3] = "@IDNV";
            values[0] = taikhoan_public.TENTK;
            values[1] = taikhoan_public.MATKHAU;
            values[2] = taikhoan_public.QUYEN;
            values[3] = taikhoan_public.IDNV;
            string sql = "UPDATE_TAIKHOAN";
            return ketnoi.Excute_Data(sql, name, values, parameter);
        }
        public int delete_taikhoan(TAIKHOAN_PUBLIC taikhoan_public)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@TENTK";           
            values[0] = taikhoan_public.TENTK;          
            string sql = "DELETE_TAIKHOAN";
            return ketnoi.Excute_Data(sql, name, values, parameter);
        }
        public int check_taikhoan(TAIKHOAN_PUBLIC taikhoan_public)
        {
            int parameter = 2;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0]= "@TENTK";
            name[1] = "@MATKHAU";
            values[0] = taikhoan_public.TENTK;
            values[1] = taikhoan_public.MATKHAU;
            string sql = "CHECK_TAIKHOAN";
            return ketnoi.ReturnValueIntWithParameter(sql, name, values, parameter);
        }
    }
}
