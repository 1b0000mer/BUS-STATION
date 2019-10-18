﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class NHAXEEntities : DbContext
    {
        public NHAXEEntities()
            : base("name=NHAXEEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<CHUYENXE> CHUYENXEs { get; set; }
        public DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public DbSet<LICHKH> LICHKHs { get; set; }
        public DbSet<NHANVIEN> NHANVIENs { get; set; }
        public DbSet<TUYENXE> TUYENXEs { get; set; }
        public DbSet<VITRI> VITRIs { get; set; }
        public DbSet<XEKHACH> XEKHACHes { get; set; }
        public DbSet<PHANCONG> PHANCONGs { get; set; }
        public DbSet<DATCHO> DATCHOes { get; set; }
    
        public virtual int spDeleteChuyenXe(string maCXe)
        {
            var maCXeParameter = maCXe != null ?
                new ObjectParameter("MaCXe", maCXe) :
                new ObjectParameter("MaCXe", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spDeleteChuyenXe", maCXeParameter);
        }
    
        public virtual int spDeleteCustomer(Nullable<int> maKH)
        {
            var maKHParameter = maKH.HasValue ?
                new ObjectParameter("MaKH", maKH) :
                new ObjectParameter("MaKH", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spDeleteCustomer", maKHParameter);
        }
    
        public virtual int spDeleteDatCho(Nullable<int> maKH, Nullable<System.DateTime> ngayDi, string maCXe)
        {
            var maKHParameter = maKH.HasValue ?
                new ObjectParameter("MaKH", maKH) :
                new ObjectParameter("MaKH", typeof(int));
    
            var ngayDiParameter = ngayDi.HasValue ?
                new ObjectParameter("NgayDi", ngayDi) :
                new ObjectParameter("NgayDi", typeof(System.DateTime));
    
            var maCXeParameter = maCXe != null ?
                new ObjectParameter("MaCXe", maCXe) :
                new ObjectParameter("MaCXe", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spDeleteDatCho", maKHParameter, ngayDiParameter, maCXeParameter);
        }
    
        public virtual int spDeleteLichKH(Nullable<System.DateTime> ngayDi, string maCXe)
        {
            var ngayDiParameter = ngayDi.HasValue ?
                new ObjectParameter("NgayDi", ngayDi) :
                new ObjectParameter("NgayDi", typeof(System.DateTime));
    
            var maCXeParameter = maCXe != null ?
                new ObjectParameter("MaCXe", maCXe) :
                new ObjectParameter("MaCXe", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spDeleteLichKH", ngayDiParameter, maCXeParameter);
        }
    
        public virtual int spDeletePhanCong(string maNV, Nullable<System.DateTime> ngayDi, string maCXe)
        {
            var maNVParameter = maNV != null ?
                new ObjectParameter("MaNV", maNV) :
                new ObjectParameter("MaNV", typeof(string));
    
            var ngayDiParameter = ngayDi.HasValue ?
                new ObjectParameter("NgayDi", ngayDi) :
                new ObjectParameter("NgayDi", typeof(System.DateTime));
    
            var maCXeParameter = maCXe != null ?
                new ObjectParameter("MaCXe", maCXe) :
                new ObjectParameter("MaCXe", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spDeletePhanCong", maNVParameter, ngayDiParameter, maCXeParameter);
        }
    
        public virtual int spDeleteTuyenXe(string maTuyen)
        {
            var maTuyenParameter = maTuyen != null ?
                new ObjectParameter("MaTuyen", maTuyen) :
                new ObjectParameter("MaTuyen", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spDeleteTuyenXe", maTuyenParameter);
        }
    
        public virtual int spDeleTeViTri(Nullable<int> maViTri)
        {
            var maViTriParameter = maViTri.HasValue ?
                new ObjectParameter("MaViTri", maViTri) :
                new ObjectParameter("MaViTri", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spDeleTeViTri", maViTriParameter);
        }
    
        public virtual int spDeleteWorker(string maNV)
        {
            var maNVParameter = maNV != null ?
                new ObjectParameter("MaNV", maNV) :
                new ObjectParameter("MaNV", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spDeleteWorker", maNVParameter);
        }
    
        public virtual int spDeleteXeKhach(string soHieuXe)
        {
            var soHieuXeParameter = soHieuXe != null ?
                new ObjectParameter("SoHieuXe", soHieuXe) :
                new ObjectParameter("SoHieuXe", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spDeleteXeKhach", soHieuXeParameter);
        }
    
        public virtual ObjectResult<spGetChuyenXe_Result> spGetChuyenXe()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetChuyenXe_Result>("spGetChuyenXe");
        }
    
        public virtual ObjectResult<spGetChuyenXeDetail_Result> spGetChuyenXeDetail(string maCXe)
        {
            var maCXeParameter = maCXe != null ?
                new ObjectParameter("MaCXe", maCXe) :
                new ObjectParameter("MaCXe", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetChuyenXeDetail_Result>("spGetChuyenXeDetail", maCXeParameter);
        }
    
        public virtual ObjectResult<spGetCustomer_Result> spGetCustomer()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetCustomer_Result>("spGetCustomer");
        }
    
        public virtual ObjectResult<spGetCustomerCalendar_Result> spGetCustomerCalendar(Nullable<System.DateTime> ngayDi, string maCXe)
        {
            var ngayDiParameter = ngayDi.HasValue ?
                new ObjectParameter("NgayDi", ngayDi) :
                new ObjectParameter("NgayDi", typeof(System.DateTime));
    
            var maCXeParameter = maCXe != null ?
                new ObjectParameter("MaCXe", maCXe) :
                new ObjectParameter("MaCXe", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetCustomerCalendar_Result>("spGetCustomerCalendar", ngayDiParameter, maCXeParameter);
        }
    
        public virtual ObjectResult<spGetDatCho_Result> spGetDatCho()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetDatCho_Result>("spGetDatCho");
        }
    
        public virtual ObjectResult<spGetLichKH_Result> spGetLichKH()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetLichKH_Result>("spGetLichKH");
        }
    
        public virtual ObjectResult<spGetPhanCong_Result> spGetPhanCong()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetPhanCong_Result>("spGetPhanCong");
        }
    
        public virtual ObjectResult<spGetTuyenXe_Result> spGetTuyenXe()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetTuyenXe_Result>("spGetTuyenXe");
        }
    
        public virtual ObjectResult<spGetViTri_Result> spGetViTri()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetViTri_Result>("spGetViTri");
        }
    
        public virtual ObjectResult<spGetWorker_Result> spGetWorker()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetWorker_Result>("spGetWorker");
        }
    
        public virtual ObjectResult<spGetWorkerCalendar_Result> spGetWorkerCalendar(Nullable<System.DateTime> ngayDi, string maCXe)
        {
            var ngayDiParameter = ngayDi.HasValue ?
                new ObjectParameter("NgayDi", ngayDi) :
                new ObjectParameter("NgayDi", typeof(System.DateTime));
    
            var maCXeParameter = maCXe != null ?
                new ObjectParameter("MaCXe", maCXe) :
                new ObjectParameter("MaCXe", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetWorkerCalendar_Result>("spGetWorkerCalendar", ngayDiParameter, maCXeParameter);
        }
    
        public virtual ObjectResult<spGetXeKhach_Result> spGetXeKhach()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetXeKhach_Result>("spGetXeKhach");
        }
    
        public virtual int spInsertChuyenXe(string maCXe, string maTuyen, Nullable<System.TimeSpan> gioDi, Nullable<System.TimeSpan> gioDen)
        {
            var maCXeParameter = maCXe != null ?
                new ObjectParameter("MaCXe", maCXe) :
                new ObjectParameter("MaCXe", typeof(string));
    
            var maTuyenParameter = maTuyen != null ?
                new ObjectParameter("MaTuyen", maTuyen) :
                new ObjectParameter("MaTuyen", typeof(string));
    
            var gioDiParameter = gioDi.HasValue ?
                new ObjectParameter("GioDi", gioDi) :
                new ObjectParameter("GioDi", typeof(System.TimeSpan));
    
            var gioDenParameter = gioDen.HasValue ?
                new ObjectParameter("GioDen", gioDen) :
                new ObjectParameter("GioDen", typeof(System.TimeSpan));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spInsertChuyenXe", maCXeParameter, maTuyenParameter, gioDiParameter, gioDenParameter);
        }
    
        public virtual int spInsertCustomer(string hoVaTen, Nullable<System.DateTime> nSinh, string dThoai, string cMND, string dChi)
        {
            var hoVaTenParameter = hoVaTen != null ?
                new ObjectParameter("HoVaTen", hoVaTen) :
                new ObjectParameter("HoVaTen", typeof(string));
    
            var nSinhParameter = nSinh.HasValue ?
                new ObjectParameter("NSinh", nSinh) :
                new ObjectParameter("NSinh", typeof(System.DateTime));
    
            var dThoaiParameter = dThoai != null ?
                new ObjectParameter("DThoai", dThoai) :
                new ObjectParameter("DThoai", typeof(string));
    
            var cMNDParameter = cMND != null ?
                new ObjectParameter("CMND", cMND) :
                new ObjectParameter("CMND", typeof(string));
    
            var dChiParameter = dChi != null ?
                new ObjectParameter("DChi", dChi) :
                new ObjectParameter("DChi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spInsertCustomer", hoVaTenParameter, nSinhParameter, dThoaiParameter, cMNDParameter, dChiParameter);
        }
    
        public virtual int spInsertDatCho(Nullable<int> maKH, Nullable<System.DateTime> ngayDi, string maCXe)
        {
            var maKHParameter = maKH.HasValue ?
                new ObjectParameter("MaKH", maKH) :
                new ObjectParameter("MaKH", typeof(int));
    
            var ngayDiParameter = ngayDi.HasValue ?
                new ObjectParameter("NgayDi", ngayDi) :
                new ObjectParameter("NgayDi", typeof(System.DateTime));
    
            var maCXeParameter = maCXe != null ?
                new ObjectParameter("MaCXe", maCXe) :
                new ObjectParameter("MaCXe", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spInsertDatCho", maKHParameter, ngayDiParameter, maCXeParameter);
        }
    
        public virtual int spInsertLichKH(Nullable<System.DateTime> ngayDi, string maCXe, string soHieuXe)
        {
            var ngayDiParameter = ngayDi.HasValue ?
                new ObjectParameter("NgayDi", ngayDi) :
                new ObjectParameter("NgayDi", typeof(System.DateTime));
    
            var maCXeParameter = maCXe != null ?
                new ObjectParameter("MaCXe", maCXe) :
                new ObjectParameter("MaCXe", typeof(string));
    
            var soHieuXeParameter = soHieuXe != null ?
                new ObjectParameter("SoHieuXe", soHieuXe) :
                new ObjectParameter("SoHieuXe", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spInsertLichKH", ngayDiParameter, maCXeParameter, soHieuXeParameter);
        }
    
        public virtual int spInsertPhanCong(string maNV, Nullable<System.DateTime> ngayDi, string maCXe)
        {
            var maNVParameter = maNV != null ?
                new ObjectParameter("MaNV", maNV) :
                new ObjectParameter("MaNV", typeof(string));
    
            var ngayDiParameter = ngayDi.HasValue ?
                new ObjectParameter("NgayDi", ngayDi) :
                new ObjectParameter("NgayDi", typeof(System.DateTime));
    
            var maCXeParameter = maCXe != null ?
                new ObjectParameter("MaCXe", maCXe) :
                new ObjectParameter("MaCXe", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spInsertPhanCong", maNVParameter, ngayDiParameter, maCXeParameter);
        }
    
        public virtual int spInsertTuyenXe(string maTuyen, string dDi, string dDen)
        {
            var maTuyenParameter = maTuyen != null ?
                new ObjectParameter("MaTuyen", maTuyen) :
                new ObjectParameter("MaTuyen", typeof(string));
    
            var dDiParameter = dDi != null ?
                new ObjectParameter("DDi", dDi) :
                new ObjectParameter("DDi", typeof(string));
    
            var dDenParameter = dDen != null ?
                new ObjectParameter("DDen", dDen) :
                new ObjectParameter("DDen", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spInsertTuyenXe", maTuyenParameter, dDiParameter, dDenParameter);
        }
    
        public virtual int spInsertViTri(Nullable<int> maViTri, string tenViTri)
        {
            var maViTriParameter = maViTri.HasValue ?
                new ObjectParameter("MaViTri", maViTri) :
                new ObjectParameter("MaViTri", typeof(int));
    
            var tenViTriParameter = tenViTri != null ?
                new ObjectParameter("TenViTri", tenViTri) :
                new ObjectParameter("TenViTri", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spInsertViTri", maViTriParameter, tenViTriParameter);
        }
    
        public virtual int spInsertWorker(string hoVaTen, Nullable<System.DateTime> nSinh, string maNV, string dThoai, string cMND, string dChi, Nullable<int> maViTri)
        {
            var hoVaTenParameter = hoVaTen != null ?
                new ObjectParameter("HoVaTen", hoVaTen) :
                new ObjectParameter("HoVaTen", typeof(string));
    
            var nSinhParameter = nSinh.HasValue ?
                new ObjectParameter("NSinh", nSinh) :
                new ObjectParameter("NSinh", typeof(System.DateTime));
    
            var maNVParameter = maNV != null ?
                new ObjectParameter("MaNV", maNV) :
                new ObjectParameter("MaNV", typeof(string));
    
            var dThoaiParameter = dThoai != null ?
                new ObjectParameter("DThoai", dThoai) :
                new ObjectParameter("DThoai", typeof(string));
    
            var cMNDParameter = cMND != null ?
                new ObjectParameter("CMND", cMND) :
                new ObjectParameter("CMND", typeof(string));
    
            var dChiParameter = dChi != null ?
                new ObjectParameter("DChi", dChi) :
                new ObjectParameter("DChi", typeof(string));
    
            var maViTriParameter = maViTri.HasValue ?
                new ObjectParameter("MaViTri", maViTri) :
                new ObjectParameter("MaViTri", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spInsertWorker", hoVaTenParameter, nSinhParameter, maNVParameter, dThoaiParameter, cMNDParameter, dChiParameter, maViTriParameter);
        }
    
        public virtual int spInsertXeKhach(string soHieuXe, Nullable<int> soGhe)
        {
            var soHieuXeParameter = soHieuXe != null ?
                new ObjectParameter("SoHieuXe", soHieuXe) :
                new ObjectParameter("SoHieuXe", typeof(string));
    
            var soGheParameter = soGhe.HasValue ?
                new ObjectParameter("SoGhe", soGhe) :
                new ObjectParameter("SoGhe", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spInsertXeKhach", soHieuXeParameter, soGheParameter);
        }
    
        public virtual int spUpdateChuyenXe(string maCXe, string maTuyen, Nullable<System.TimeSpan> gioDi, Nullable<System.TimeSpan> gioDen)
        {
            var maCXeParameter = maCXe != null ?
                new ObjectParameter("MaCXe", maCXe) :
                new ObjectParameter("MaCXe", typeof(string));
    
            var maTuyenParameter = maTuyen != null ?
                new ObjectParameter("MaTuyen", maTuyen) :
                new ObjectParameter("MaTuyen", typeof(string));
    
            var gioDiParameter = gioDi.HasValue ?
                new ObjectParameter("GioDi", gioDi) :
                new ObjectParameter("GioDi", typeof(System.TimeSpan));
    
            var gioDenParameter = gioDen.HasValue ?
                new ObjectParameter("GioDen", gioDen) :
                new ObjectParameter("GioDen", typeof(System.TimeSpan));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spUpdateChuyenXe", maCXeParameter, maTuyenParameter, gioDiParameter, gioDenParameter);
        }
    
        public virtual int spUpdateCustomer(string hoVaTen, Nullable<System.DateTime> nSinh, Nullable<int> maKH, string dThoai, string cMND, string dChi)
        {
            var hoVaTenParameter = hoVaTen != null ?
                new ObjectParameter("HoVaTen", hoVaTen) :
                new ObjectParameter("HoVaTen", typeof(string));
    
            var nSinhParameter = nSinh.HasValue ?
                new ObjectParameter("NSinh", nSinh) :
                new ObjectParameter("NSinh", typeof(System.DateTime));
    
            var maKHParameter = maKH.HasValue ?
                new ObjectParameter("MaKH", maKH) :
                new ObjectParameter("MaKH", typeof(int));
    
            var dThoaiParameter = dThoai != null ?
                new ObjectParameter("DThoai", dThoai) :
                new ObjectParameter("DThoai", typeof(string));
    
            var cMNDParameter = cMND != null ?
                new ObjectParameter("CMND", cMND) :
                new ObjectParameter("CMND", typeof(string));
    
            var dChiParameter = dChi != null ?
                new ObjectParameter("DChi", dChi) :
                new ObjectParameter("DChi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spUpdateCustomer", hoVaTenParameter, nSinhParameter, maKHParameter, dThoaiParameter, cMNDParameter, dChiParameter);
        }
    
        public virtual int spUpdateDatCho(Nullable<int> maKH, Nullable<System.DateTime> ngayDi, string maCXe)
        {
            var maKHParameter = maKH.HasValue ?
                new ObjectParameter("MaKH", maKH) :
                new ObjectParameter("MaKH", typeof(int));
    
            var ngayDiParameter = ngayDi.HasValue ?
                new ObjectParameter("NgayDi", ngayDi) :
                new ObjectParameter("NgayDi", typeof(System.DateTime));
    
            var maCXeParameter = maCXe != null ?
                new ObjectParameter("MaCXe", maCXe) :
                new ObjectParameter("MaCXe", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spUpdateDatCho", maKHParameter, ngayDiParameter, maCXeParameter);
        }
    
        public virtual int spUpdateLichKH(Nullable<System.DateTime> ngayDi, string maCXe, string soHieuXe)
        {
            var ngayDiParameter = ngayDi.HasValue ?
                new ObjectParameter("NgayDi", ngayDi) :
                new ObjectParameter("NgayDi", typeof(System.DateTime));
    
            var maCXeParameter = maCXe != null ?
                new ObjectParameter("MaCXe", maCXe) :
                new ObjectParameter("MaCXe", typeof(string));
    
            var soHieuXeParameter = soHieuXe != null ?
                new ObjectParameter("SoHieuXe", soHieuXe) :
                new ObjectParameter("SoHieuXe", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spUpdateLichKH", ngayDiParameter, maCXeParameter, soHieuXeParameter);
        }
    
        public virtual int spUpdatePhanCong(string maNV, Nullable<System.DateTime> ngayDi, string maCXe)
        {
            var maNVParameter = maNV != null ?
                new ObjectParameter("MaNV", maNV) :
                new ObjectParameter("MaNV", typeof(string));
    
            var ngayDiParameter = ngayDi.HasValue ?
                new ObjectParameter("NgayDi", ngayDi) :
                new ObjectParameter("NgayDi", typeof(System.DateTime));
    
            var maCXeParameter = maCXe != null ?
                new ObjectParameter("MaCXe", maCXe) :
                new ObjectParameter("MaCXe", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spUpdatePhanCong", maNVParameter, ngayDiParameter, maCXeParameter);
        }
    
        public virtual int spUpdateTuyenXe(string maTuyen, string dDi, string dDen)
        {
            var maTuyenParameter = maTuyen != null ?
                new ObjectParameter("MaTuyen", maTuyen) :
                new ObjectParameter("MaTuyen", typeof(string));
    
            var dDiParameter = dDi != null ?
                new ObjectParameter("DDi", dDi) :
                new ObjectParameter("DDi", typeof(string));
    
            var dDenParameter = dDen != null ?
                new ObjectParameter("DDen", dDen) :
                new ObjectParameter("DDen", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spUpdateTuyenXe", maTuyenParameter, dDiParameter, dDenParameter);
        }
    
        public virtual int spUpdateViTri(Nullable<int> maViTri, string tenViTri)
        {
            var maViTriParameter = maViTri.HasValue ?
                new ObjectParameter("MaViTri", maViTri) :
                new ObjectParameter("MaViTri", typeof(int));
    
            var tenViTriParameter = tenViTri != null ?
                new ObjectParameter("TenViTri", tenViTri) :
                new ObjectParameter("TenViTri", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spUpdateViTri", maViTriParameter, tenViTriParameter);
        }
    
        public virtual int spUpdateWorker(string hoVaTen, Nullable<System.DateTime> nSinh, string maNV, string dThoai, string cMND, string dChi, Nullable<int> maViTri)
        {
            var hoVaTenParameter = hoVaTen != null ?
                new ObjectParameter("HoVaTen", hoVaTen) :
                new ObjectParameter("HoVaTen", typeof(string));
    
            var nSinhParameter = nSinh.HasValue ?
                new ObjectParameter("NSinh", nSinh) :
                new ObjectParameter("NSinh", typeof(System.DateTime));
    
            var maNVParameter = maNV != null ?
                new ObjectParameter("MaNV", maNV) :
                new ObjectParameter("MaNV", typeof(string));
    
            var dThoaiParameter = dThoai != null ?
                new ObjectParameter("DThoai", dThoai) :
                new ObjectParameter("DThoai", typeof(string));
    
            var cMNDParameter = cMND != null ?
                new ObjectParameter("CMND", cMND) :
                new ObjectParameter("CMND", typeof(string));
    
            var dChiParameter = dChi != null ?
                new ObjectParameter("DChi", dChi) :
                new ObjectParameter("DChi", typeof(string));
    
            var maViTriParameter = maViTri.HasValue ?
                new ObjectParameter("MaViTri", maViTri) :
                new ObjectParameter("MaViTri", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spUpdateWorker", hoVaTenParameter, nSinhParameter, maNVParameter, dThoaiParameter, cMNDParameter, dChiParameter, maViTriParameter);
        }
    
        public virtual int spUpdateXeKhach(string soHieuXe, Nullable<int> soGhe)
        {
            var soHieuXeParameter = soHieuXe != null ?
                new ObjectParameter("SoHieuXe", soHieuXe) :
                new ObjectParameter("SoHieuXe", typeof(string));
    
            var soGheParameter = soGhe.HasValue ?
                new ObjectParameter("SoGhe", soGhe) :
                new ObjectParameter("SoGhe", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spUpdateXeKhach", soHieuXeParameter, soGheParameter);
        }
    }
}