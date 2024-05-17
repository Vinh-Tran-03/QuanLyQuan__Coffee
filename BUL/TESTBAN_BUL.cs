using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using PUBLIC;
namespace BUL
{
    public class TESTBAN_BUL
    {
        TESTBAN_DAL testban_dal = new TESTBAN_DAL();
        public List<TESTBAN_PUBLIC> load_dsban()
        {
            return testban_dal.load_ds_ban();
        }
    }
}
