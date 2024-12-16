using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _2021604440_HoangXuanQuy_OntapTuan13.Models;

namespace _2021604440_HoangXuanQuy_OntapTuan13.Controllers
{
    public class HocSinhController : Controller
    {
        private Model1 db = new Model1();

        // GET: HocSinh
        public ActionResult Xemdanhsach(string keyword)
        {
            //var hocSinhs = db.HocSinhs.Include(h => h.LopHoc);
            var hocSinhs = db.HocSinhs.Select(h => h);
            if (!String.IsNullOrEmpty(keyword))
            {
                hocSinhs = hocSinhs.Where(x => (x.sbd.Equals(keyword) || x.hoten.Contains(keyword)));
            }
            return View(hocSinhs.ToList());
        }

        // GET: HocSinh/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HocSinh hocSinh = db.HocSinhs.Find(id);
            if (hocSinh == null)
            {
                return HttpNotFound();
            }
            return View(hocSinh);
        }

        // GET: HocSinh/Create
        public ActionResult Themdulieu()
        {
            ViewBag.malop = new SelectList(db.LopHocs, "malop", "tenlop");
            return View();
        }

        // POST: HocSinh/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Themdulieu([Bind(Include = "sbd,hoten,anhduthi,malop,diemthi")] HocSinh hocSinh)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var f = Request.Files["FileName"];
                    if (f.ContentLength > 0)
                    {
                        var filename = Path.GetFileName(f.FileName);
                        var path = Path.Combine(Server.MapPath("~/Images/"), filename);
                        f.SaveAs(path);
                        hocSinh.anhduthi = filename;
                    }
                    db.HocSinhs.Add(hocSinh);
                    db.SaveChanges();
                    return RedirectToAction("Xemdanhsach");
                }
                catch (Exception e)
                {
                    ViewBag.err = "Lỗi! Liên hệ admin để được xử lý! " + e.Message;
                }
            }

            ViewBag.malop = new SelectList(db.LopHocs, "malop", "tenlop", hocSinh.malop);
            return View(hocSinh);
        }

        // GET: HocSinh/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HocSinh hocSinh = db.HocSinhs.Find(id);
            if (hocSinh == null)
            {
                return HttpNotFound();
            }
            ViewBag.malop = new SelectList(db.LopHocs, "malop", "tenlop", hocSinh.malop);
            return View(hocSinh);
        }

        // POST: HocSinh/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "sbd,hoten,anhduthi,malop,diemthi")] HocSinh hocSinh)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var f = Request.Files["FileName"];
                    if (f.ContentLength > 0)
                    {
                        var filename = Path.GetFileName(f.FileName);
                        var path = Path.Combine(Server.MapPath("~/Images/"), filename);
                        f.SaveAs(path);
                        hocSinh.anhduthi = filename;
                    }
                    db.Entry(hocSinh).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Xemdanhsach");
                }
                catch (Exception e)
                {
                    ViewBag.err = e.Message;
                }
            }
            ViewBag.malop = new SelectList(db.LopHocs, "malop", "tenlop", hocSinh.malop);
            return View(hocSinh);
        }

        // GET: HocSinh/Delete/5
        public ActionResult Xoadulieu(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HocSinh hocSinh = db.HocSinhs.Find(id);
            if (hocSinh == null)
            {
                return HttpNotFound();
            }
            return View(hocSinh);
        }

        // POST: HocSinh/Delete/5
        [HttpPost, ActionName("Xoadulieu")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            try
            {
                HocSinh hocSinh = db.HocSinhs.Find(id);
                db.HocSinhs.Remove(hocSinh);
                db.SaveChanges();
                TempData["DeleteSuccess"] = "Đã xóa thành công!";

                return RedirectToAction("Xemdanhsach");
                //return RedirectToAction("DeleteSuccess");
            }
            catch (Exception e)
            {
                ViewBag.errX = "Lỗi không xóa được! " + e.Message;
                return View();
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public ActionResult DeleteSuccess (){
            return View();
            }
    }
}
