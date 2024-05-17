using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PUBLIC;
using System.Data;
namespace DAL
{
    public class HOADON_DAL
    {
        KETNOI ketnoi = new KETNOI();
        public DataTable load_hoadon()
        {
            string sql = "LOAD_HOADON";
            return ketnoi.Load_Data(sql);
        }
        public int insert_hoadon(HOADON_PUBLIC hoadon_public)
        {
            int parameter = 4;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0]="@IDBAN";
            name[1]="@IDNV";
            name[2]="@NGAYLAP";
            name[3]="@TRANGTHAI";
            values[0]=hoadon_public.IDBAN;
            values[1]=hoadon_public.IDNV;
            values[2]=hoadon_public.NGAYLAP;
            values[3]=hoadon_public.TRANGTHAI;
            string sql = "INSERT_HOADON";
            return ketnoi.Excute_Data(sql,name,values,parameter);
        }
        public int update_hoadon(HOADON_PUBLIC hoadon_public)
        {
            int parameter = 5;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@IDHOADON";
            name[1] = "@IDBAN";
            name[2] = "@IDNV";
            name[3] = "@NGAYLAP";
            name[4] = "@TRANGTHAI";
            values[0] = hoadon_public.IDHOADON;
            values[1] = hoadon_public.IDBAN;
            values[2] = hoadon_public.IDNV;
            values[3] = hoadon_public.NGAYLAP;
            values[4] = hoadon_public.TRANGTHAI;
            string sql = "UPDATE_HOADON";
            return ketnoi.Excute_Data(sql, name, values, parameter);
        }
        public int delete_hoadon(HOADON_PUBLIC hoadon_public)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@IDHOADON";          
            values[0] = hoadon_public.IDHOADON;           
            string sql = "DELETE_HOADON";
            return ketnoi.Excute_Data(sql, name, values, parameter);
        }
        public int count_hoadon_ban(HOADON_PUBLIC hoadon_public)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@IDBAN";
            values[0] = hoadon_public.IDBAN;
            string sql = "DEMSOHD_OFBAN";
            return ketnoi.ReturnValueIntWithParameter(sql, name, values, parameter);
        }
        public int delete_hoadon_with_idban(HOADON_PUBLIC hoadon_public)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@IDBAN";
            values[0] = hoadon_public.IDBAN;
            string sql = "DELETE_HOADON_with_IDBAN";
            return ketnoi.Excute_Data(sql, name, values, parameter);
        }
        public int load_IDHD_WITH_IDBAN(HOADON_PUBLIC hd_public)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@IDBAN";
            values[0] = hd_public.IDBAN;
            string sql = "LOAD_HOADON_WITH_IDBAN";
            return ketnoi.ReturnValueIntWithParameter(sql, name, values, parameter);
        }
        public int update_hoadon_doiban(HOADON_PUBLIC hoadon_public)
        {
            int parameter = 2;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@IDHOADON";
            name[1] = "@IDBAN";           
            values[0] = hoadon_public.IDHOADON;
            values[1] = hoadon_public.IDBAN;          
            string sql = "UPDATE_HOADON_doiban";
            return ketnoi.Excute_Data(sql, name, values, parameter);
        }
    }
}
