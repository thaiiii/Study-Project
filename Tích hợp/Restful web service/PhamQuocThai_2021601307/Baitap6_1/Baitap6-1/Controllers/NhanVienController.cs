using Baitap6_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Baitap6_1.Controllers
{
    public class NhanVienController : ApiController
    {
        QLLuongEntities1 db = new QLLuongEntities1();

        [HttpGet]
        public List<NhanVien> LayNhanVien()
        {
            return db.NhanViens.ToList();
        }
        [HttpGet]
        public List<NhanVien> TimNhanVienTheoGioiTinh(string GioiTinh)
        {
            return db.NhanViens.Where(x => x.GioiTinh == GioiTinh).ToList();
        }
        [HttpGet]
        public NhanVien TimNhanVienTheoMaNhanVien(int MaNV)
        {
            return db.NhanViens.FirstOrDefault(x => x.MaNV == MaNV);
        }

        [HttpPost]
        public bool ThemNhanVien(int MaNV, string HoTen, string GioiTinh, float Hsluong, int MaDonVi)
        {
            NhanVien nv = db.NhanViens.FirstOrDefault(x => x.MaNV == MaNV);
            if(nv == null)
            {
                NhanVien nvTemp = new NhanVien();
                nvTemp.MaNV = MaNV;
                nvTemp.HoTen = HoTen;
                nvTemp.GioiTinh = GioiTinh;
                nvTemp.Hsluong = Hsluong;
                nvTemp.MaDonVi = MaDonVi;
                db.NhanViens.Add(nvTemp);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        [HttpPut]
        public bool SuaNhanVien(int MaNV, string HoTen, string GioiTinh, float Hsluong, int MaDonVi)
        {
            NhanVien nv = db.NhanViens.FirstOrDefault(x => x.MaNV == MaNV);
            if (nv != null)
            {
                nv.MaNV = MaNV;
                nv.HoTen = HoTen;
                nv.GioiTinh = GioiTinh;
                nv.Hsluong = Hsluong;
                nv.MaDonVi = MaDonVi;
                db.SaveChanges();
                return true;
            }
            return false;
        }

        [HttpDelete]
        public bool XoaNhanVien(int MaNV)
        {
            NhanVien nv = db.NhanViens.FirstOrDefault(x => x.MaNV == MaNV);
            if (nv != null)
            {
                db.NhanViens.Remove(nv);
                db.SaveChanges();
                return true;
            }
            return false;
        }


    }
}
