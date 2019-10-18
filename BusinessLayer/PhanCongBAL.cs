using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataProvider;
using Model;

namespace BusinessLayer
{
    public static class PhanCongBAL
    {
        static PhanCongDAL pc;
        static PhanCongBAL()
        {
            pc = new PhanCongDAL();
        }
        public static List<PHANCONG> getlistPHANCONG()
        {
            return pc.getlistPHANCONG();
        }

        public static void insertPC(string MaNV, DateTime NDi, string MaCXe)
        {
            pc.insertPC(MaNV, NDi, MaCXe);
        }
        
        public static void deletePC(string MaNV, DateTime NDi, string MaCXe)
        {
            pc.deletePC(MaNV, NDi, MaCXe);
        }
    }
}
