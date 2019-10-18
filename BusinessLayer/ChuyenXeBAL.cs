using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataProvider;
using Model;

namespace BusinessLayer
{
    public static class ChuyenXeBAL
    {
        static ChuyenXeDAL cx;
        static ChuyenXeBAL()
        {
            cx = new ChuyenXeDAL();
        }

        public static List<CHUYENXE> getlistCHUYENXE()
        {
            return cx.getlistCHUYENXE();
        }
        public static List<spGetChuyenXeDetail_Result> getlistCHUYENXEDETAIL(string MaCXe)
        {
            return cx.getlistCHUYENXEDETAIL(MaCXe);
        }

        public static void insertCX(string MaCXe, string MaTuyen, TimeSpan GDi, TimeSpan GDen)
        {
            cx.insertCX(MaCXe, MaTuyen, GDi, GDen);
        }
        public static void updateCX(string MaCXe, string MaTuyen, TimeSpan GDi, TimeSpan GDen)
        {
            cx.updateCX(MaCXe, MaTuyen, GDi, GDen);
        }
        public static void deleteCX(string MaCXe)
        {
            cx.deleteCX(MaCXe);
        }
    }
}
