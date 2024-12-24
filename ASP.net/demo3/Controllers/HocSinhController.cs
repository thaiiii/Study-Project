using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using demo3.Models;

namespace demo3.Controllers
{
    public class HocSinhController : Controller
    {
        private HocSinhDB db = new HocSinhDB();

        // GET: HocSinh
        public ActionResult Xemdanhsach(string SearchString)
        {
            var hocSinh = db.HocSinh.Include(h => h.LopHoc);
            if(!String.IsNullOrEmpty(SearchString))
            {
               hocSinh= hocSinh.Where(h => h.hoten.Contains(SearchString) || h.sbd.Contains(SearchString));
            }
            return View(hocSinh.ToList());
        }

        // GET: HocSinh/Details/5
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

        // GET: HocSinh/Create
        public ActionResult Themdulieu()
        {
            ViewBag.malop = new SelectList(db.LopHoc, "malop", "tenlop");
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
                hocSinh.anhduthi = "";
                var f = Request.Files["ImageFile"];
                if (f != null && f.ContentLength > 0)
                {
                    string FileName = System.IO.Path.GetFileName(f.FileName);
                    string uploadPath = Server.MapPath("~/Images/" +  FileName);
                    f.SaveAs(uploadPath);
                    hocSinh.anhduthi = FileName;
                }

                db.HocSinh.Add(hocSinh);
                db.SaveChanges();
                return RedirectToAction("Xemdanhsach");
            }

            ViewBag.malop = new SelectList(db.LopHoc, "malop", "tenlop", hocSinh.malop);
            return View(hocSinh);
        }

        // GET: HocSinh/Edit/5
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

        // POST: HocSinh/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Chinhsua([Bind(Include = "sbd,hoten,anhduthi,malop,diemthi")] HocSinh hocSinh)
        {
            if (ModelState.IsValid)
            {
                hocSinh.anhduthi = "";
                var f = Request.Files["ImageFile"];
                if (f != null && f.ContentLength>0)
                {
                    string FileName = System.IO.Path.GetFileName(f.FileName);   
                    string uploadPath = Server.MapPath("~/Images/" +  FileName);    
                    f.SaveAs(uploadPath);
                    hocSinh.anhduthi = FileName;
                }

                db.Entry(hocSinh).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Xemdanhsach");
            }
            ViewBag.malop = new SelectList(db.LopHoc, "malop", "tenlop", hocSinh.malop);
            return View(hocSinh);
        }

        // GET: HocSinh/Delete/5
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

        // POST: HocSinh/Delete/5
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
