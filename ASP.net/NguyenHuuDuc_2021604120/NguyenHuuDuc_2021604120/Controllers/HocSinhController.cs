using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NguyenHuuDuc_2021604120.Models;

namespace NguyenHuuDuc_2021604120.Controllers
{
    public class HocSinhController : Controller
    {
        private HocSinhDB db = new HocSinhDB();

        // GET: HocSinh
        public ActionResult Xemdanhsach(string searchString)
        {
            var hocSinh = db.HocSinhs.Select(p => p);
            if (!String.IsNullOrEmpty(searchString))
            {
                hocSinh = hocSinh.Where(p => p.hoten.Contains(searchString) || p.sbd.Contains(searchString));

            }
            //var hocSinhs = db.HocSinhs.Include(h => h.LopHoc);
            return View(hocSinh.ToList());
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
            try
            {
                if (ModelState.IsValid)
                {
                    hocSinh.anhduthi = "";
                    var f = Request.Files["ImageFile"];
                    if (f != null && f.ContentLength > 0)
                    {
                        string FileName = System.IO.Path.GetFileName(f.FileName);
                        string UploadPath = Server.MapPath("~/wwwroot/Images/" + FileName);
                        f.SaveAs(UploadPath);
                        hocSinh.anhduthi = FileName;
                    }
                    db.HocSinhs.Add(hocSinh);
                    db.SaveChanges();
                }
                return RedirectToAction("Xemdanhsach");
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Lỗi nhập dữ liệu: " + ex.Message;
                ViewBag.malop = new SelectList(db.LopHocs, "malop", "tenlop", hocSinh.malop);
                return View(hocSinh);
            }
            
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
            HocSinh hocSinh = db.HocSinhs.Find(id);
            db.HocSinhs.Remove(hocSinh);
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
