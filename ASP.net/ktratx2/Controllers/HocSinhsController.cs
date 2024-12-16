using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ktratx2.Models;
using Microsoft.SqlServer.Server;

namespace ktratx2.Controllers
{
    public class HocSinhsController : Controller
    {
        private HocSinhDB db = new HocSinhDB();

        // GET: HocSinhs
        public ActionResult Xemdanhsach(string searchString)
        {
            var hocSinh = db.HocSinh.Include(h => h.LopHoc);
            if(!String.IsNullOrEmpty(searchString))
            {
                hocSinh = hocSinh.Where(h => h.hoten.Contains(searchString) || h.sbd.Contains(searchString));   
            }
            
            return View(hocSinh.ToList());
        }

        // GET: HocSinhs/Details/5
        public ActionResult Chitiet(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HocSinh hocSinh = db.HocSinh.Find(id);
            if (hocSinh == null)
            {
                return HttpNotFound();
            }
            return View(hocSinh);
        }

        // GET: HocSinhs/Create
        public ActionResult Themdulieu()
        {
            ViewBag.malop = new SelectList(db.LopHoc, "malop", "tenlop");
            return View();
        }

        // POST: HocSinhs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Themdulieu([Bind(Include = "sbd,hoten,anhduthi,malop,diemthi")] HocSinh hocSinh)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    hocSinh.anhduthi = "";
                    var f = Request.Files["ImageFile"];
                    if (f != null && f.ContentLength > 0) 
                    {
                        string fileName = System.IO.Path.GetFileName(f.FileName);
                        string uploadPath = Server.MapPath("~/Images/" + fileName);
                        f.SaveAs(uploadPath);
                        hocSinh.anhduthi = fileName;
                    }

                    db.HocSinh.Add(hocSinh);
                    db.SaveChanges();
                }
                return RedirectToAction("Xemdanhsach");
            }
            catch (Exception ex) 
            {
                ViewBag.Error = "Loi nhap du lieu: " + ex.Message;
                ViewBag.malop = new SelectList(db.LopHoc, "malop", "tenlop", hocSinh.malop);
                return View(hocSinh);
            }
        }

        // GET: HocSinhs/Edit/5
        public ActionResult Chinhsua(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HocSinh hocSinh = db.HocSinh.Find(id);
            if (hocSinh == null)
            {
                return HttpNotFound();
            }
            ViewBag.malop = new SelectList(db.LopHoc, "malop", "tenlop", hocSinh.malop);
            return View(hocSinh);
        }

        // POST: HocSinhs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Chinhsua([Bind(Include = "sbd,hoten,anhduthi,malop,diemthi")] HocSinh hocSinh)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    hocSinh.anhduthi = "";
                    var f = Request.Files["ImageFile"];
                    if (f != null && f.ContentLength > 0)
                    {
                        string fileName = System.IO.Path.GetFileName(f.FileName);
                        string uploadPath = Server.MapPath("~/Images" + fileName);
                        f.SaveAs(uploadPath);
                        hocSinh.anhduthi = fileName;
                    }    

                    db.Entry(hocSinh).State = EntityState.Modified;
                    db.SaveChanges();
                }
                return RedirectToAction("Xemdanhsach");
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Lỗi nhập dữ liệu " + ex.Message;
                ViewBag.malop = new SelectList(db.LopHoc, "malop", "tenlop", hocSinh.malop);
                return View(hocSinh);
            }

        }

        // GET: HocSinhs/Delete/5
        public ActionResult Xoadulieu(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HocSinh hocSinh = db.HocSinh.Find(id);
            if (hocSinh == null)
            {
                return HttpNotFound();
            }
            return View(hocSinh);
        }

        // POST: HocSinhs/Delete/5
        [HttpPost, ActionName("Xoadulieu")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            HocSinh hocSinh = db.HocSinh.Find(id);
            db.HocSinh.Remove(hocSinh);
            db.SaveChanges();
            return RedirectToAction("Xemdanhsach");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
