using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataProvider;
using Model;

namespace BusinessLayer
{
    public class XeKhachBAL
    {       
        static XeKhachDAL xk;
        static XeKhachBAL()   
        {
            xk = new XeKhachDAL();
        }
        public static List<XEKHACH> getlistXEKHACH()
        {
            return xk.getlistXEKHACH();
        }
        public static void insertXK(string SoHieuXe, int SoGhe)
        {
            xk.insertXK(SoHieuXe, SoGhe);
        }
        public static void updateXK(string SoHieuXe, int SoGhe)
        {
            xk.updateXK(SoHieuXe, SoGhe);
        }
        public static void deleteXK(string SoHieuXe)
        {
            xk.deleteXK(SoHieuXe);
        }
    }
}
