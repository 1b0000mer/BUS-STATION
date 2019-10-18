using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataProvider
{
    public class PhanCongDAL
    {
        public List<PHANCONG> getlistPHANCONG()
        {
            using (NHAXEEntities dbs = new NHAXEEntities())
            {
                return dbs.PHANCONGs.ToList();
            }
        }

        public void insertPC(string MaNV, DateTime NDi, string MaCXe)
        {
            using (NHAXEEntities dbs = new NHAXEEntities())
            {
                dbs.spInsertPhanCong(MaNV, NDi, MaCXe);
            }
        }
        
        public void deletePC(string MaNV, DateTime NDi, string MaCXe)
        {
            using (NHAXEEntities dbs = new NHAXEEntities())
            {
                dbs.spDeletePhanCong(MaNV, NDi, MaCXe);
            }
        }
    }
}
