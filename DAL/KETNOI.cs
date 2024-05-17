using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using PUBLIC;
namespace DAL
{
    public class KETNOI
    {
        private static string tensv = "VINHTRAN\\VINHTRAN";
        private static string tencsdl = "QuanLyQuanCaPhe";        
        public KETNOI(string tengan,string tencsdlgan)
        {           
            Tensv = tengan;
            Tencsdl = tencsdlgan;
        }
        SqlConnection connect = new SqlConnection(@"Data Source="+Tensv+";Initial Catalog="+Tencsdl+";Integrated Security=True");
        //SqlConnection connect = new SqlConnection(@"Data Source=VINHTRAN\VINHTRAN;Initial Catalog=QuanLyQuanCaPhe;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        public static string Tensv
        {
            get
            {
                return tensv;
            }

            set
            {
                tensv = value;
            }
        }

        public static string Tencsdl
        {
            get
            {
                return tencsdl;
            }

            set
            {
                tencsdl = value;
            }
        }

        public KETNOI()
        {           
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
        }
        public DataTable Load_Data(string sql)
        {            
            SqlCommand cmd = new SqlCommand(sql, connect);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public DataTable LoadDataWithParameter(string sql, string[] name, object[] values, int parameter)
        {           
            SqlCommand cmd = new SqlCommand(sql, connect);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < parameter; i++)
            {
                cmd.Parameters.AddWithValue(name[i], values[i]);
            }
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public int Excute_Data(string sql, string[] name, object[] values, int parameter)
        {           
            SqlCommand cmd = new SqlCommand(sql, connect);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < parameter; i++)
            {
                cmd.Parameters.AddWithValue(name[i], values[i]);
            }
            return cmd.ExecuteNonQuery();
        }
        public int ReturnValueInt(string sql)
        {          
            SqlCommand cmd = new SqlCommand(sql, connect);
            cmd.CommandType = CommandType.StoredProcedure;
            return int.Parse(cmd.ExecuteScalar().ToString());
        }
        public int ReturnValueIntWithParameter(string sql, string[] name, object[] values, int parameter)
        {            
            SqlCommand cmd = new SqlCommand(sql, connect);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < parameter; i++)
            {
                cmd.Parameters.AddWithValue(name[i], values[i]);
            }
            return int.Parse(cmd.ExecuteScalar().ToString());
        }
        public string ReturnValueString(string sql)
        {           
            SqlCommand cmd = new SqlCommand(sql, connect);
            cmd.CommandType = CommandType.StoredProcedure;
            return cmd.ExecuteScalar().ToString();
        }
    }
}
