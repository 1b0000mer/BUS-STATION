using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataProvider
{
    public class LichKHDAL
    {
        public List<LICHKH> getlistLICHKH()
        {
            using (NHAXEEntities dbs = new NHAXEEntities())
            {
                return dbs.LICHKHs.ToList();
            }               
        }
        public void insertLich(DateTime NDi, string MaCXe, string SoHieuXe)
        {
            using (NHAXEEntities dbs = new NHAXEEntities())
            {
                dbs.spInsertLichKH(NDi, MaCXe, SoHieuXe);
            }             
        }
        public void updateLich(DateTime NDi, string MaCXe, string SoHieuXe)
        {
            using (NHAXEEntities dbs = new NHAXEEntities())
            {
                dbs.spUpdateLichKH(NDi, MaCXe, SoHieuXe);
            }               
        }
        public void deleteKH(DateTime NDi, string MaCXe)
        {
            using (NHAXEEntities dbs = new NHAXEEntities())
            {
                dbs.spDeleteLichKH(NDi, MaCXe);
            }             
        }
    }
}

