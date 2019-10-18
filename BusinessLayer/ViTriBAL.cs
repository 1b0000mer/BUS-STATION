using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataProvider;
using Model;

namespace BusinessLayer
{
    public static class ViTriBAL
    {
        static ViTriDAL vt;
        static ViTriBAL()
        {
            vt = new ViTriDAL();
        }
        public static List<VITRI> getlistVITRI()
        {
            return vt.getlistVITRI();
        }
        
        public static void insertVT(int MaViTri, string TenViTri)
        {
            vt.insertVT(MaViTri, TenViTri);
        }
        public static void updateVT(int MaViTri, string TenViTri)
        {
            vt.updateVT(MaViTri, TenViTri);
        }
        public static void deleteVT(int MaViTri)
        {
            vt.deleteVT(MaViTri);
        }
    }
}
