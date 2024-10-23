using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Second.Models;

namespace Second.Controllers
{
    public class QuanLyNhanVienController : Controller
    {
        private static List<NhanVien> danhsach;

        public QuanLyNhanVienController() {
            if (danhsach == null) {
                danhsach = new List<NhanVien>();
                danhsach.Add(new NhanVien("nv01", "Nguyen a", 16000, 1000));
                danhsach.Add(new NhanVien("nv02", "Nguyen b", 22000, 2000));
                danhsach.Add(new NhanVien("nv03", "Nguyen c", 21000, 2000));
                danhsach.Add(new NhanVien("nv04", "Nguyen d", 19000, 1000));
                danhsach.Add(new NhanVien("nv05", "Nguyen e", 12000, 2000));
                danhsach.Add(new NhanVien("nv06", "Nguyen f", 29000, 1000));
                danhsach.Add(new NhanVien("nv07", "Nguyen g", 28000, 2000));
            }
        }

        public ActionResult TongKet()
        {
            List<NhanVien> danhsachTongKet = new List<NhanVien>();
            for(int i=0; i<danhsach.Count; i++)
            {
                if (danhsach[i].TongThuNhap() >= 23000)
                {
                    danhsachTongKet.Add(danhsach[i]);
                }
            }

            return View(danhsachTongKet);
        }

        public ActionResult XuatSac()
        {
            List<NhanVien> danhsachXuatSac = new List<NhanVien>();
            for (int i = 0; i < danhsach.Count; i++)
            {
                if (danhsach[i].luong >= 22000)
                {
                    danhsachXuatSac.Add(danhsach[i]);
                }
            }

            return View(danhsachXuatSac);
        }

        [HttpGet]
        public ActionResult NhapThongTin() {
            return View();
        }

        [HttpPost]
        public ActionResult NhapThongTin(string manv, string hoten, double luong, double thuong) 
        {
            for (int i = 0; i < danhsach.Count; i++)
            {
                if(manv == danhsach[i].manv)
                    return View();
            }
            NhanVien nhanVienMoi = new NhanVien(manv,hoten,luong,thuong);
            danhsach.Add(nhanVienMoi);
            return RedirectToAction("Index", "QuanLyNhanVien");
        }


        public ActionResult Index()
        {
            return View(danhsach);
        }


        public ActionResult Back()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}