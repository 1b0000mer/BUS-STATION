using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataProvider;
using Model;

namespace BusinessLayer
{
    public static class KhachHangBAL
    {
        static KhachHangDAL kh;
        static KhachHangBAL()
        {
            kh = new KhachHangDAL();
        }
        public static List<KHACHHANG> getlistKHACHHANG()
        {
            return kh.getlistKHACHHANG();
        }
        public static List<spGetCustomerCalendar_Result> getlistKHACHHANGCAL(DateTime NDi, string MaCXe)
        {
            return kh.getlistKHACHHANGCAL(NDi, MaCXe);
        }
        public static void insertKH(string HoVaTen, DateTime NSinh, string DThoai, string CMND, string DChi)
        {
            kh.insertKH(HoVaTen, NSinh, DThoai, CMND, DChi);
        }
        public static void updateKH(string HoVaTen, DateTime NSinh, int MaKH, string DThoai, string CMND, string DChi)
        {
            kh.updateKH(HoVaTen, NSinh, MaKH, DThoai, CMND, DChi);
        }
        public static void deleteKH(int MaKH)
        {
            kh.deleteKH(MaKH);
        }
    }
}
