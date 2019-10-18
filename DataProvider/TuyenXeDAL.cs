using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataProvider
{
    public class TuyenXeDAL
    {
        public  List<TUYENXE> getlistTUYENXE()
        {
            using (NHAXEEntities dbs = new NHAXEEntities())
            {
               return dbs.TUYENXEs.ToList();
            }
        }
        public void insertTX(string MaTuyen, string DDi, string DDen)
        {
            using (NHAXEEntities dbs = new NHAXEEntities())
            {
                dbs.spInsertTuyenXe(MaTuyen, DDi, DDen);
            }
        }
        public void updateTX(string MaTuyen, string DDi, string DDen)
        {
            using (NHAXEEntities dbs = new NHAXEEntities())
            {
                dbs.spUpdateTuyenXe(MaTuyen, DDi, DDen);
            }
        }
        public void deleteTX(string MaTuyen)
        {
            using (NHAXEEntities dbs = new NHAXEEntities())
            {
                dbs.spDeleteTuyenXe(MaTuyen);
            }
        }
    }
}
