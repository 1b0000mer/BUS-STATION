using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataProvider;
using Model;

namespace BusinessLayer
{
    public static class LichKHBAL
    {
        static LichKHDAL kh;
        static LichKHBAL()
        {
            kh = new LichKHDAL();
        }
        public static List<LICHKH> getlistLICHKH()
        {
            return kh.getlistLICHKH();
        }
        public static void insertLich(DateTime NDi, string MaCXe, string SoHieuXe)
        {
            kh.insertLich(NDi, MaCXe, SoHieuXe);
        }
        public static void updateLich(DateTime NDi, string MaCXe, string SoHieuXe)
        {
            kh.updateLich(NDi, MaCXe, SoHieuXe);
        }
        public static void deleteKH(DateTime NDi, string MaCXe)
        {
            kh.deleteKH(NDi, MaCXe);
        }
    }
}
