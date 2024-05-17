using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using PUBLIC;
using System.Data;
namespace BUL
{
    public class BAN_BUL
    {
        BAN_DAL ban_dal = new BAN_DAL();
        public DataTable load_ban()
        {
            return ban_dal.load_ban();
        }
        public int insert_ban(BAN_PUBLIC ban_public)
        {
            return ban_dal.insert_ban(ban_public);
        }
        public int update_ban(BAN_PUBLIC ban_public)
        {
            return ban_dal.update_ban(ban_public);
        }
        public int delete_ban(BAN_PUBLIC ban_public)
        {
            return ban_dal.delete_ban(ban_public);
        }
        public List<BAN_PUBLIC> Loaddsban()
        {
            return ban_dal.Loaddsban();
        }
        public int update_trangthaiban(BAN_PUBLIC ban_public)
        {
            return ban_dal.update_trangthaiban(ban_public);
        }
        public DataTable load_ban_trong()
        {
            return ban_dal.load_ban_trong();
        }
        public DataTable load_ban_conguoi()
        {
            return ban_dal.load_ban_conguoi();
        }
    }
}
