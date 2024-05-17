using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PUBLIC;
using System.Data;
namespace DAL
{
    public class HOADON_OLD_DAL
    {
        KETNOI ketnoi = new KETNOI();
        public DataTable load_hoadon_old()
        {
            string sql = "LOAD_HOADON_OLD";
            return ketnoi.Load_Data(sql);
        }
        public DataTable load_hoadon_old_NOTID()
        {
            string sql = "LOAD_HOADON_OLD_NOTID";
            return ketnoi.Load_Data(sql);
        }
        public int insert_hoadon_old(HOADON_OLD_PUBLIC hd_old)
        {
            int parameter = 6;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0]= "@IDHOADON";
            name[1]= "@IDBAN";
            name[2]= "@IDNV";
            name[3]= "@NGAYLAP";
            name[4]= "@TRANGTHAI";
            name[5]= "@TONGTIEN";
            values[0]=hd_old.IDHOADON;
            values[1]=hd_old.IDBAN;
            values[2]=hd_old.IDNV;
            values[3]=hd_old.NGAYLAP;
            values[4]=hd_old.TRANGTHAI;
            values[5]=hd_old.TONGTIEN;
            string sql = "INSERT_HOADON_OLD";
            return ketnoi.Excute_Data(sql, name, values, parameter);
        }
        public int delete_hoadon_old(HOADON_OLD_PUBLIC hd_old)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@IDHD_OLD";        
            values[0] = hd_old.IDHOADON;         
            string sql = "DELETE_HOADON_OLD";
            return ketnoi.Excute_Data(sql, name, values, parameter);
        }
        public DataTable load_timhd_old(HOADON_OLD_PUBLIC hd_old)
        {
            int paramater = 1;
            string[] name = new string[paramater];
            object[] values = new object[paramater];
            name[0] = "@TEMBAN";
            values[0] = hd_old.Soban;
            string sql = "TIM_HOADON_OLD";
            return ketnoi.LoadDataWithParameter(sql, name, values, paramater);
        }
        public DataTable load_timhd_old_TENNV(HOADON_OLD_PUBLIC hd_old)
        {
            int paramater = 1;
            string[] name = new string[paramater];
            object[] values = new object[paramater];
            name[0] = "@TENNV";
            values[0] = hd_old.TENNV;
            string sql = "TIM_HOADON_OLD_tennv";
            return ketnoi.LoadDataWithParameter(sql, name, values, paramater);
        }
        public DataTable load_hd_day(HOADON_OLD_PUBLIC hd_old)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@NGAY";
            values[0] = hd_old.NGAY;
            string sql = "LOAD_HD_DAY";
            return ketnoi.LoadDataWithParameter(sql, name, values, parameter);
        }
        public DataTable load_hd_month(HOADON_OLD_PUBLIC hd_old)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@THANG";
            values[0] = hd_old.THANG;
            string sql = "LOAD_HD_MONTH";
            return ketnoi.LoadDataWithParameter(sql, name, values, parameter);
        }
        public DataTable load_hd_year(HOADON_OLD_PUBLIC hd_old)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@NAM";
            values[0] = hd_old.NAM;
            string sql = "LOAD_HD_YEAR";
            return ketnoi.LoadDataWithParameter(sql, name, values, parameter);
        }
    }
}
