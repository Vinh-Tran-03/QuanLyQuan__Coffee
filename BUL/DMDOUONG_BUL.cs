using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PUBLIC;
using DAL;
namespace BUL
{
    public class DMDOUONG_BUL
    {
        DMDOUONG_DAL dmdouong_dal = new DMDOUONG_DAL();
        public DataTable load_dmdouong()
        {
            return dmdouong_dal.load_dmdouong();
        }
        public int insert_dmdouong(DMDOUONG_PUBLIC dmdouong_public)
        {
            return dmdouong_dal.insert_dmdouong(dmdouong_public);
        }
        public int update_dmdouong(DMDOUONG_PUBLIC dmdouong_public)
        {
            return dmdouong_dal.update_dmdouong(dmdouong_public);
        }
        public int delete_dmdouong(DMDOUONG_PUBLIC dmdouong_public)
        {
            return dmdouong_dal.delete_dmdouong(dmdouong_public);
        }
    }
}
