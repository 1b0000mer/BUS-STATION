using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataProvider;
using Model;

namespace BusinessLayer
{
    public static class DatChoBAL
    {
        static DatChoDAL dc;
        static DatChoBAL()
        {
            dc = new DatChoDAL();
        }

        public static List<DATCHO> getlistDATCHO()
        {
            return dc.getlistDATCHO();
        }

        public static void insertDC(int MaKH, DateTime NDi, string MaCXe)
        {
            dc.insertDC(MaKH, NDi, MaCXe);
        }

        public static void updateDC(int MaKH, DateTime NDi, string MaCXe)
        {
            dc.updateDC(MaKH, NDi, MaCXe);
        }

        public static void deleteDC(int MaKH, DateTime NDi, string MaCXe)
        {
            dc.deteleDC(MaKH, NDi, MaCXe);
        }
        public static bool querryMaKH(int MaKH)
        {
            using (NHAXEEntities dbs = new NHAXEEntities())
            {
                var prolist = from p in dbs.KHACHHANGs
                              where p.MaKH == Convert.ToInt32(MaKH)
                              select p;
                if (prolist.Count() == 0)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
