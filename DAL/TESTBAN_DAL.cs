using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PUBLIC;
using System.Data;

namespace DAL
{
    public class TESTBAN_DAL
    {
        KETNOI kn = new KETNOI();
        public DataTable loadban()
        {
            string sql = "LOAD_BAN";
            return kn.Load_Data(sql);
        }
        // tao ham load ban an 
        public List<TESTBAN_PUBLIC> load_ds_ban()
        {
            List<TESTBAN_PUBLIC> dsban = new List<TESTBAN_PUBLIC>();
            DataTable dt = new DataTable();
            dt = loadban();
            foreach (DataRow dong in dt.Rows)
            {
                TESTBAN_PUBLIC taoban = new TESTBAN_PUBLIC(dong);
                dsban.Add(taoban);
            }
            return dsban;
        }
    }
}
