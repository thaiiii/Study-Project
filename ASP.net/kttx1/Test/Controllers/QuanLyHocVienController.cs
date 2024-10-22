using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using Test.Models;

namespace Test.Controllers
{
    public class QuanLyHocVienController : Controller
    {
        // GET: QuanLyHocVien
        

        //Biến thành viên List<HocVien>
        public static List<HocVien> danhsach;

        //Khoi tao 0 tham so
        public QuanLyHocVienController()
        {
            //Khoi tao danh sach thanh vien
            if(danhsach == null)
            {
                danhsach = new List<HocVien>()
                {
                    new HocVien("haui01", "Nguyễn Văn A", 16, 1),
                    new HocVien("haui02", "Trần Văn B", 22, 2),
                    new HocVien("haui03", "Ngô Thị C", 21, 2),
                    new HocVien("haui04", "Vũ Thị D", 19, 1),
                    new HocVien("haui05", "Trương Văn E", 12, 2),
                    new HocVien("haui06", "Lê Thị F", 29, 1),
                    new HocVien("haui07", "Trần Thị G", 28, 2)
                };
            } 
        }

        //Method hien thi danh sach
        public ActionResult TongKet()
        {
            //Loc nhuwng nguoi tong ket >=23
            List<HocVien> danhsachTongket = new List<HocVien>();
            for (int i = 0; i < danhsach.Count; i++)
            {
                if (danhsach[i].TongDiem() >= 23) 
                    danhsachTongket.Add(danhsach[i]);
            }

            return View(danhsachTongket);
        }

        public ActionResult ThiDat()
        {
            //Loc nhuwng nguoi diem thi >=22
            List<HocVien> danhsachThidat = new List<HocVien>();
            for (int i = 0; i < danhsach.Count; i++)
            {
                if (danhsach[i].diemthi >= 22)
                    danhsachThidat.Add(danhsach[i]);
            }

            return View(danhsachThidat);
        }

        [HttpGet]
        public ActionResult NhapHocVien() 
        { 
            return View();
        }

        // POST: Nhập học viên mới
        [HttpPost]
        public ActionResult NhapHocVien(string mahv, string hoten, float diemthi, float uutien)
        {
            // Kiểm tra mã học viên đã tồn tại chưa
            if (danhsach.Exists(hv => hv.mahv == mahv))
            {
                ViewBag.Message = "Mã học viên đã tồn tại!";
                return View();
            }

            // Thêm học viên mới vào danh sách
            HocVien hocVienMoi = new HocVien(mahv, hoten, diemthi, uutien);
            danhsach.Add(hocVienMoi);

            // Chuyển hướng đến action Index để hiển thị danh sách học viên
            return RedirectToAction("Index","QuanLyHocVien");
        }

        // Action hiển thị danh sách học viên
        public ActionResult Index()
        {
            return View(danhsach); // Truyền danh sách học viên cho view
        }

        public ActionResult Back()
        {
            return RedirectToAction("Index","Home");
        }








    }
}