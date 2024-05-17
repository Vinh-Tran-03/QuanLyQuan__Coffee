using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;
using PUBLIC;
namespace BUL
{
    public class HINHNV_BUL
    {
        HINHNV_DAL hinhnv_dal = new HINHNV_DAL();
        public DataTable load_hinhnv()
        {
            return hinhnv_dal.load_hinhnv();
        }
        public int insert_hinhnv(HINHNV_PUBLIC hinhnv_public)
        {
            return hinhnv_dal.insert_hinhnv(hinhnv_public);
        }
        public int update_hinhnv(HINHNV_PUBLIC hinhnv_public)
        {
            return hinhnv_dal.update_hinhnv(hinhnv_public);
        }
        public int delete_hinhnv(HINHNV_PUBLIC hinhnv_public)
        {
            return hinhnv_dal.delete_hinhnv(hinhnv_public);
        }      
    }
}
