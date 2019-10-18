using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataProvider;
using Model;

namespace BusinessLayer
{
    public static class NhanVienBAL
    {
        static NhanVienDAL nv;
        static NhanVienBAL()
        {
            nv = new NhanVienDAL();
        }
        public static List<NHANVIEN> getlistNHANVIEN()
        {
            return nv.getlistNHANVIEN();
        }
        public static List<spGetWorkerCalendar_Result> getlistNHANVIENCAL(DateTime NDi, string MaCXe)
        {
            return nv.getlistNHANVIENCAL(NDi, MaCXe);
        }
        public static void insertNV(string HoVaTen, DateTime NSinh, string MaNV, string DThoai, string CMND, string DChi, int MaViTri)
        {
            nv.insertNV(HoVaTen, NSinh, MaNV, DThoai, CMND, DChi, MaViTri);
        }
        public static void updateNV(string HoVaTen, DateTime NSinh, string MaNV, string DThoai, string CMND, string DChi, int MaViTri)
        {
            nv.updateNV(HoVaTen, NSinh, MaNV, DThoai, CMND, DChi, MaViTri);
        }
        public static void deleteNV(string MaNV)
        {
            nv.deleteNV(MaNV);
        }
    }
}

