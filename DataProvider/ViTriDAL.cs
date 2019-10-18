using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataProvider
{
    public class ViTriDAL
    {
        public List<VITRI> getlistVITRI()
        {
            using (NHAXEEntities dbs = new NHAXEEntities())
            {
                return dbs.VITRIs.ToList();
            }
        }
        
        public void insertVT(int MaViTri, string TenViTri)
        {
            using (NHAXEEntities dbs = new NHAXEEntities())
            {
                dbs.spInsertViTri(MaViTri, TenViTri);
            }
        }
        public void updateVT(int MaViTri, string TenViTri)
        {
            using (NHAXEEntities dbs = new NHAXEEntities())
            {
                dbs.spUpdateViTri(MaViTri, TenViTri);
            }
        }
        public void deleteVT(int MaViTri)
        {
            using (NHAXEEntities dbs = new NHAXEEntities())
            {
                dbs.spDeleTeViTri(MaViTri);
            }
        }
    }
}
