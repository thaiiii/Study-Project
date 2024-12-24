using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using cuoiky0.Models;

namespace cuoiky0.Controllers
{
    public class nvController : Controller
    {
        private DB db = new DB();

        // GET: nv
        public ActionResult Index()
        {
            var nhanVien = db.NhanVien.Include(n => n.Phong);
            return View(nhanVien.ToList());
        }

        // GET: nv/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhanVien nhanVien = db.NhanVien.Find(id);
            if (nhanVien == null)
            {
                return HttpNotFound();
            }
            return View(nhanVien);
        }

        // GET: nv/Create
        public ActionResult Create()
        {
            ViewBag.Maphong = new SelectList(db.Phong, "Maphong", "Tenphong");
            return View();
        }

        // POST: nv/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Create(/*[Bind(Include = "Manv,Hoten,Tuoi,Diachi,Luong,Maphong")]*/ NhanVien emp)
        {
            //if (ModelState.IsValid)
            //{
            try
            {
                db.NhanVien.Add(emp);
                db.SaveChanges();
                return Json(new { a = true, JsonRequestBehavior.AllowGet });
            }
            catch (Exception ex)
            {
                return Json(new { a = false, error = ex.Message });
            }
            
            
            //    return RedirectToAction("Index");
            //}

            //ViewBag.Maphong = new SelectList(db.Phong, "Maphong", "Tenphong", nhanVien.Maphong);
            //return View(nhanVien);
        }

        // GET: nv/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhanVien nhanVien = db.NhanVien.Find(id);
            if (nhanVien == null)
            {
                return HttpNotFound();
            }
            ViewBag.Maphong = new SelectList(db.Phong, "Maphong", "Tenphong", nhanVien.Maphong);
            return View(nhanVien);
        }

        // POST: nv/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Manv,Hoten,Tuoi,Diachi,Luong,Maphong")] NhanVien nhanVien)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nhanVien).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Maphong = new SelectList(db.Phong, "Maphong", "Tenphong", nhanVien.Maphong);
            return View(nhanVien);
        }

        // GET: nv/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhanVien nhanVien = db.NhanVien.Find(id);
            if (nhanVien == null)
            {
                return HttpNotFound();
            }
            return View(nhanVien);
        }

        // POST: nv/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NhanVien nhanVien = db.NhanVien.Find(id);
            db.NhanVien.Remove(nhanVien);
            db.SaveChanges();
            return RedirectToAction("Index");
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
