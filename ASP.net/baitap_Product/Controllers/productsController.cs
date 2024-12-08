using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using baitap_Product.Models;

namespace baitap_Product.Controllers
{
    public class productsController : Controller
    {
        private Shop2DB db = new Shop2DB();

        // GET: products
        public ActionResult Index()
        {
            var products = db.products.Include(p => p.category);
            return View(products.ToList());
        }

        // GET: products/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            product product = db.products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // GET: products/Create
        public ActionResult Create()
        {
            ViewBag.catid = new SelectList(db.categories, "catid", "catname");
            return View();
        }

        // POST: products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "proid,proname,price,stock,image,description,catid")] product product)
        {
            //if (ModelState.IsValid)
            //{
            //    db.products.Add(product);
            //    db.SaveChanges();
            //    return RedirectToAction("Index");
            //}

            //ViewBag.catid = new SelectList(db.categories, "catid", "catname", product.catid);
            //return View(product);

            try
            {
                if (ModelState.IsValid)
                {
                    //Thêm bẫy lỗi
                    product.image = "";
                    var f = Request.Files["ImageFile"];
                    if (f != null && f.ContentLength > 0)
                    {
                        //Use Namespace called: System.IO
                        string FileName = System.IO.Path.GetFileName(f.FileName);
                        //Lấy tên file upload
                        string UploadPath = Server.MapPath("~/wwwroot/ProductImages/" + FileName);
                        //Copy và lưu file vào server
                        f.SaveAs(UploadPath);
                        //Lưu tên file vào trường Image
                        product.image = FileName;
                    }

                    db.products.Add(product);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");

            }
            catch (Exception e)
            {
                ViewBag.Error = "Lỗi nhập dữ liệu! " + e.Message;
                ViewBag.CatalogyID = new SelectList(db.categories, "catid", "catname", product.catid);
                return View(product);

            }
        }

        // GET: products/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            product product = db.products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            ViewBag.catid = new SelectList(db.categories, "catid", "catname", product.catid);
            return View(product);
        }

        // POST: products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "proid,proname,price,stock,image,description,catid")] product product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var f = Request.Files["ImageFile"];
                    if (f != null && f.ContentLength > 0) 
                    {
                        string FileName = System.IO.Path.GetFileName(f.FileName);
                        string UploadPath = Server.MapPath("~/wwwroot/ProductImages/" + FileName);
                        f.SaveAs(UploadPath);
                        product.image = FileName;
                    }

                    db.Entry(product).State = EntityState.Modified;
                    db.SaveChanges();
                }
                return RedirectToAction("Index");

            }
            catch (Exception e)
            {
                ViewBag.Error = "Lỗi nhập dữ liệu! " + e.Message;
                ViewBag.catid = new SelectList(db.categories, "catid", "catname", product.catid);
                return View(product);
            }




        }

        // GET: products/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            product product = db.products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            product product = db.products.Find(id);
            db.products.Remove(product);
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
