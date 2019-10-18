using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataProvider;
using Model;

namespace BusinessLayer
{
    public static class TuyenXeBAL
    {
        static TuyenXeDAL tx;
        static TuyenXeBAL()
        {
            tx = new TuyenXeDAL();
        }
        public static List<TUYENXE> getlistTUYENXE()
        {
            return tx.getlistTUYENXE();
        }
        public static void insertTX(string MaTuyen, string DDi, string DDen)
        {
            tx.insertTX(MaTuyen, DDi, DDen);
        }
        public static void updateTX(string MaTuyen, string DDi, string DDen)
        {
            tx.updateTX(MaTuyen, DDi, DDen);
        }
        public static void deleteTX(string MaTuyen)
        {
            tx.deleteTX(MaTuyen);
        }
    }
}
