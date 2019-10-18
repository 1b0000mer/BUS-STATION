using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataProvider
{
    public class KhachHangDAL
    {
        public List<KHACHHANG> getlistKHACHHANG()
        {
            using (NHAXEEntities dbs = new NHAXEEntities())
            {
                return dbs.KHACHHANGs.ToList();
            }
        }
        public List<spGetCustomerCalendar_Result> getlistKHACHHANGCAL(DateTime NDI, string MaCXe)
        {
            using (NHAXEEntities dbs = new NHAXEEntities())
            {
                return dbs.spGetCustomerCalendar(NDI, MaCXe).ToList();
            }
        }
        public void insertKH(string HoVaTen, DateTime NSinh, string DThoai, string CMND, string DChi)
        {
            using (NHAXEEntities dbs = new NHAXEEntities())
            {
                dbs.spInsertCustomer(HoVaTen, NSinh, DThoai, CMND, DChi);
            }
        }
        public void updateKH(string HoVaTen, DateTime NSinh, int MaKH,string DThoai, string CMND, string DChi)
        {
            using (NHAXEEntities dbs = new NHAXEEntities())
            {
                dbs.spUpdateCustomer(HoVaTen, NSinh, MaKH, DThoai, CMND, DChi);
            }
        }
        public void deleteKH(int MaKH)
        {
            using (NHAXEEntities dbs = new NHAXEEntities())
            {
                dbs.spDeleteCustomer(MaKH);
            }
        }
    }
}
