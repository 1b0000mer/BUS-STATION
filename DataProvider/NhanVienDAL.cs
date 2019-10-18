using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataProvider
{
    public class NhanVienDAL
    {
        public List<NHANVIEN> getlistNHANVIEN()
        {
            using (NHAXEEntities dbs = new NHAXEEntities())
            {
                return dbs.NHANVIENs.ToList();
            }
        }
        public List<spGetWorkerCalendar_Result> getlistNHANVIENCAL(DateTime NDI, string MaCXe)
        {
            using (NHAXEEntities dbs = new NHAXEEntities())
            {
                return dbs.spGetWorkerCalendar(NDI, MaCXe).ToList();
            }
        }
        public void insertNV(string HoVaTen, DateTime NSinh, string MaNV, string DThoai, string CMND, string DChi, int MaViTri)
        {
            using (NHAXEEntities dbs = new NHAXEEntities())
            {
                dbs.spInsertWorker(HoVaTen, NSinh, MaNV, DThoai, CMND, DChi, MaViTri);
            }
        }
        public void updateNV(string HoVaTen, DateTime NSinh, string MaNV, string DThoai, string CMND, string DChi, int MaViTri)
        {
            using (NHAXEEntities dbs = new NHAXEEntities())
            {
                dbs.spUpdateWorker(HoVaTen, NSinh, MaNV, DThoai, CMND, DChi, MaViTri);
            }
        }
        public void deleteNV(string MaNV)
        {
            using (NHAXEEntities dbs = new NHAXEEntities())
            {
                dbs.spDeleteWorker(MaNV);
            }
        }


    }
}
