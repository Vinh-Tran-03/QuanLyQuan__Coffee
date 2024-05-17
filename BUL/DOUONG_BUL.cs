using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;
using PUBLIC;
namespace BUL
{
    public class DOUONG_BUL
    {
        DOUONG_DAL douong_dal = new DOUONG_DAL();
        public DataTable load_douong()
        {
            return douong_dal.load_douong();
        }
        public int insert_douong(DOUONG_PUBLIC douong_public)
        {
            return douong_dal.insert_douong(douong_public);
        }
        public int update_douong(DOUONG_PUBLIC douong_public)
        {
            return douong_dal.update_douong(douong_public);
        }
        public int delete_douong(DOUONG_PUBLIC douong_public)
        {
            return douong_dal.delete_douong(douong_public);
        }
        public DataTable foodfind(int iddm)
        {
            return douong_dal.foodfind(iddm);
        }
        public DataTable TIM_DOUONG(DOUONG_PUBLIC douong_public)
        {
            return douong_dal.TIM_DOUONG(douong_public);
        }
        public DataTable load_indsdouong()
        {
            return douong_dal.load_indsdouong();
        }
        public DataTable load_douongvoi_where(DOUONG_PUBLIC douong_public)
        {
            return douong_dal.load_douongvoi_where(douong_public);
        }
    }
}
