using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using cuoiky2.Models;

namespace cuoiky2.Controllers
{
    public class SanPhamController : ApiController
    {
        CSDLTestEntities db = new CSDLTestEntities();
        [HttpGet]
        public List<SanPham> LaySP()
        {
            return db.SanPham.ToList();
        }
        [HttpGet]
        public List<SanPham> LaySPTheoMaDM(int madm)
        {
            return db.SanPham.Where(x => x.MaDanhMuc == madm).ToList();
        }
        [HttpGet]
        public SanPham LaySPTheoMa(int ma)
        {
            return db.SanPham.FirstOrDefault(x=>x.Ma ==ma);
        }
        [HttpPost]
        public bool ThemSP(int ma, string ten, int gia, int madm)
        {
            SanPham sanPham = db.SanPham.FirstOrDefault(x => x.Ma == ma);
            if (sanPham != null)
            {
                return false;
            }
            else
            {
                SanPham sp = new SanPham();
                sp.Ma = ma;
                sp.Ten = ten;
                sp.DonGia = gia;
                sp.MaDanhMuc = madm;
                db.SanPham.Add(sp);
                db.SaveChanges();
                return true;
            }
        }

        [HttpPut]
        public bool SuaSP(int ma, string ten, int gia, int madm)
        {
            SanPham sp = db.SanPham.FirstOrDefault(x => x.Ma == ma);
            if (sp == null)
            {
                return false;
            }
            else
            {
                sp.Ma = ma;
                sp.Ten = ten;
                sp.DonGia = gia;
                sp.MaDanhMuc = madm;
                db.SaveChanges();
                return true;
            }
        }

        [HttpDelete]
        public bool XoaSP(int ma)
        {
            SanPham sp = db.SanPham.FirstOrDefault(x => x.Ma == ma);
            if (sp == null)
            {
                return false;
            }
            else
            {
                db.SanPham.Remove(sp);
                db.SaveChanges();
                return true;
            }
        }

    }
}
