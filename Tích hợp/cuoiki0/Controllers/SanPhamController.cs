using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using cuoiki0.Models;

namespace cuoiki0.Controllers
{
    public class SanPhamController : ApiController
    {
        CSDLTestEntities db = new CSDLTestEntities();

        [HttpGet] //Lay du lieu
        public List<SanPham> LaySp()
        {
            return db.SanPham.ToList();
        }
        [HttpGet]
        public List<SanPham> TimSPTheoDanhMuc(int madm)
        {
            return db.SanPham.Where(x => x.MaDanhMuc == madm).ToList();
        }
        [HttpGet]
        public SanPham TimSPTheoMa(int ma)
        {
            return db.SanPham.FirstOrDefault(x => x.Ma == ma);
        }

        [HttpPost] //Them du lieu
        public bool ThemMoi(int ma, string ten, int gia, int madm) 
        {
            SanPham sp = db.SanPham.FirstOrDefault(x => x.Ma == ma);
            if (sp == null)
            {
                SanPham sp1 = new SanPham();
                sp1.Ma = ma;
                sp1.Ten = ten;
                sp1.DonGia = gia;
                sp1.MaDanhMuc = madm;
                db.SanPham.Add(sp1);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        [HttpPut] //Them du lieu
        public bool CapNhat(int ma, string ten, int gia, int madm)
        {
            SanPham sp1 = db.SanPham.FirstOrDefault(x => x.Ma == ma);
            if (sp1 != null)
            {
                sp1.Ma = ma;
                sp1.Ten = ten;
                sp1.DonGia = gia;
                sp1.MaDanhMuc = madm;
                db.SaveChanges();
                return true;
            }
            return false;
        }


        [HttpDelete] // Xoa du lieu
        public bool Xoa(int ma)
        {
            SanPham sp = db.SanPham.FirstOrDefault(x => x.Ma == ma);
            if(sp == null)
                return false;
            else
            {
                db.SanPham.Remove(sp);
                db.SaveChanges();
                return true;
            }
        }


    }
}
