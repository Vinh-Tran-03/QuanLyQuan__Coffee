using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PUBLIC;
namespace DAL
{
    public class BAN_DAL
    {
        KETNOI ketnoi = new KETNOI();
        public DataTable load_ban()
        {
            string sql="LOAD_BAN";
            return ketnoi.Load_Data(sql);
        }
        public DataTable load_ban_trong()
        {
            string sql = "LOAD_BAN_TRONG";
            return ketnoi.Load_Data(sql);
        }
        public DataTable load_ban_conguoi()
        {
            string sql = "LOAD_BAN_CONGUOI";
            return ketnoi.Load_Data(sql);
        }
        public int insert_ban(BAN_PUBLIC ban_public)
        {
            int parameter = 3;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0]="@TEN";
            name[1]="@TRANGTHAI";
            name[2] = "@ODER";
            values[0]=ban_public.TEN;
            values[1]=ban_public.TRANGTHAI;
            values[2] = ban_public.ODER;
            string sql = "INSERT_BAN";
            return ketnoi.Excute_Data(sql, name, values, parameter);
        }
        public int update_ban(BAN_PUBLIC ban_public)
        {
            int parameter = 3;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@IDBAN";
            name[1] = "@TEN";
            name[2] = "@TRANGTHAI";
            values[0] = ban_public.IDBAN;
            values[1] = ban_public.TEN;
            values[2] = ban_public.TRANGTHAI;
            string sql = "UPDATE_BAN";
            return ketnoi.Excute_Data(sql, name, values, parameter);
        }
        public int delete_ban(BAN_PUBLIC ban_public)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@IDBAN";           
            values[0] = ban_public.IDBAN;          
            string sql = "DELETE_BAN";
            return ketnoi.Excute_Data(sql, name, values, parameter);
        }
        public List<BAN_PUBLIC> Loaddsban()
        {
            List<BAN_PUBLIC> dsban = new List<BAN_PUBLIC>();
            DataTable dt = new DataTable();
            dt = load_ban();
            foreach (DataRow dong in dt.Rows)
            {
                BAN_PUBLIC table = new BAN_PUBLIC(dong);
                dsban.Add(table);
            }
            return dsban;
        }
        public int update_trangthaiban(BAN_PUBLIC ban_public)
        {
            int parameter = 2;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@IDBAN";           
            name[1] = "@TRANGTHAI";
            values[0] = ban_public.IDBAN;           
            values[1] = ban_public.TRANGTHAI;
            string sql = "UPDATE_trangthaiban";
            return ketnoi.Excute_Data(sql, name, values, parameter);
        }
    }
}
