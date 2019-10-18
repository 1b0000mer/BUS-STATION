using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataProvider
{
    public class DatChoDAL
    {
        public List<DATCHO> getlistDATCHO()
        {
            using (NHAXEEntities dbs = new NHAXEEntities())
            {
                return dbs.DATCHOes.ToList();
            }
        }
        public void insertDC(int MaKH, DateTime NDi, string MaCXe)
        {
            using (NHAXEEntities dbs = new NHAXEEntities())
            {
                dbs.spInsertDatCho(MaKH, NDi, MaCXe);
            }
        }

        public void updateDC(int MaKH, DateTime NDi, string MaCXe)
        {
            using (NHAXEEntities dbs = new NHAXEEntities())
            {
                dbs.spUpdateDatCho(MaKH, NDi, MaCXe);
            }
        }
        public void deteleDC(int MaKH, DateTime NDi, string MaCXe)
        {
            using (NHAXEEntities dbs = new NHAXEEntities())
            {
                dbs.spDeleteDatCho(MaKH, NDi, MaCXe);
            }            
        }
    }
}
