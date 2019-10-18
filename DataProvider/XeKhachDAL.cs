using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataProvider
{
    public class XeKhachDAL
    {
        public List<XEKHACH> getlistXEKHACH()
        {
            using (NHAXEEntities dbs = new NHAXEEntities())
            {
               return dbs.XEKHACHes.ToList();
            }
        }
        public void insertXK(string SoHieuXe, int SoGhe)
        {
            using (NHAXEEntities dbs = new NHAXEEntities())
            {
                dbs.spInsertXeKhach(SoHieuXe, SoGhe);
            }
        }
        public void updateXK(string SoHieuXe, int SoGhe)
        {
            using (NHAXEEntities dbs = new NHAXEEntities())
            {
                dbs.spUpdateXeKhach(SoHieuXe, SoGhe);
            }
        }
        public void deleteXK(string SoHieuXe)
        {
            using (NHAXEEntities dbs = new NHAXEEntities())
            {
                dbs.spDeleteXeKhach(SoHieuXe);
            }
        }
    }
}
