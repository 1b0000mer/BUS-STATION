using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataProvider
{
    public class ChuyenXeDAL
    {
        public List<CHUYENXE> getlistCHUYENXE()
        {
            using (NHAXEEntities dbs = new NHAXEEntities())
            {
                return dbs.CHUYENXEs.ToList();
            }            
        }
        public List<spGetChuyenXeDetail_Result> getlistCHUYENXEDETAIL(string MaCXe)
        {
            using (NHAXEEntities dbs = new NHAXEEntities())
            {
                return dbs.spGetChuyenXeDetail(MaCXe).ToList();
            }
        }
        public void insertCX(string MaCXe, string MaTuyen, TimeSpan GDi, TimeSpan GDen)
        {
            using (NHAXEEntities dbs = new NHAXEEntities())
            {
                dbs.spInsertChuyenXe(MaCXe, MaTuyen, GDi, GDen);
            }           
        }
        public void updateCX(string MaCXe, string MaTuyen, TimeSpan GDi, TimeSpan GDen)
        {
            using (NHAXEEntities dbs = new NHAXEEntities())
            {
                dbs.spUpdateChuyenXe(MaCXe, MaTuyen, GDi, GDen);
            }
        }
        public void deleteCX(string MaCXe)
        {
            using (NHAXEEntities dbs = new NHAXEEntities())
            {
                dbs.spDeleteChuyenXe(MaCXe);
            }
        }
    }
}
