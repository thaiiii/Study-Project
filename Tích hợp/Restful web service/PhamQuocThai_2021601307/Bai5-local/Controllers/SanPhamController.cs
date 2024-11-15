using Bai5_local.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Bai5_local.Controllers
{
    public class SanPhamController : ApiController
    {
        CSDLTestEntities db = new CSDLTestEntities();

        [HttpGet]//Lấy dữ liệu 
        public List<SanPham> LaySP()
        {
            return db.SanPhams.ToList();
        }
        [HttpGet]
        public List<SanPham> TimSPTheoDanhMuc(int madm)
        {
            return db.SanPhams.Where(x => x.MaDanhMuc == madm).ToList();
        }
        [HttpGet]
        public SanPham TimSPTheoMa(int ma)
        {
            return db.SanPhams.FirstOrDefault(x => x.Ma == ma);
        }
        [HttpPost]//Thêm dữ liệu 
        public bool ThemMoi(int ma, string ten, int gia, int madm)
        {
            SanPham sp = db.SanPhams.FirstOrDefault(x => x.Ma == ma);
            if (sp == null)
            {
                SanPham sp1 = new SanPham();
                sp1.Ma = ma;
                sp1.Ten = ten;
                sp1.DonGia = gia;
                sp1.MaDanhMuc = madm;
                db.SanPhams.Add(sp1);
                db.SaveChanges();
                return true;
            }
            return false;
        }
        [HttpPut]//Sửa dữ liệu 
        public bool CapNhat(int ma, string ten, int gia, int madm)
        {
            SanPham sp = db.SanPhams.FirstOrDefault(x => x.Ma == ma);
            if (sp != null)
            {
                sp.Ma = ma;
                sp.Ten = ten;
                sp.DonGia = gia;
                sp.MaDanhMuc = madm;
                db.SaveChanges();
                return true;
            }
            return false;
        }
        [HttpDelete]//Xóa dữ liệu 
        public bool xoa(int ma)
        {
            SanPham sp = db.SanPhams.FirstOrDefault(x => x.Ma == ma);
            


            if (sp != null)
            {
                db.SanPhams.Remove(sp);
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
