﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using baitap_WineStore.Models;

namespace baitap_WineStore.Controllers
{
    public class ProductsController : Controller
    {
        private WineStoreDB db = new WineStoreDB();

        // GET: Products
        public ActionResult Index()
        {
            var products = db.Products.Include(p => p.Catalogy);
            return View(products.ToList());
        }

        // GET: Products/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            ViewBag.CatalogyID = new SelectList(db.Catalogies, "CatalogyID", "CatalogyName");
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProductID,ProductName,Description,PurchasePrice,Price,Quantity,Vintage,CatalogyID,Image,Region")] Product product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    //Thêm bẫy lỗi
                    product.Image = "";
                    var f = Request.Files["ImageFile"];
                    if (f != null && f.ContentLength > 0)
                    {
                        //Use Namespace called: System.IO
                        string FileName = System.IO.Path.GetFileName(f.FileName);
                        //Lấy tên file upload
                        string UploadPath = Server.MapPath("~/wwwroot/WineImages/" + FileName);
                        //Copy và lưu file vào server
                        f.SaveAs(UploadPath);
                        //Lưu tên file vào trường Image
                        product.Image = FileName;
                    }

                    db.Products.Add(product);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");

            }
            catch (Exception e)
            {
                ViewBag.Error = "Lỗi nhập dữ liệu! " + e.Message;
                ViewBag.CatalogyID = new SelectList(db.Catalogies, "CatalogyID", "CatalogyName", product.CatalogyID);
                return View(product);

            }

            

        }

        // GET: Products/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            ViewBag.CatalogyID = new SelectList(db.Catalogies, "CatalogyID", "CatalogyName", product.CatalogyID);
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProductID,ProductName,Description,PurchasePrice,Price,Quantity,Vintage,CatalogyID,Image,Region")] Product product)
        {
            try 
            {
                if (ModelState.IsValid)
                {
                    var f = Request.Files["ImageFile"];
                    if(f != null && f.ContentLength > 0)
                    {
                        string FileName = System.IO.Path.GetFileName(f.FileName);
                        string UploadPath = Server.MapPath("~/wwwroot/WineImages/" + FileName);
                        f.SaveAs(UploadPath);
                        product.Image = FileName;
                    }

                    db.Entry(product).State = EntityState.Modified;
                    db.SaveChanges();
                 }
                return RedirectToAction("Index");

            }
            catch (Exception e)
            {
                ViewBag.Error = "Lỗi nhập dữ liệu! " + e.Message;
                ViewBag.CatalogyID = new SelectList(db.Catalogies, "CatalogyID", "CatalogyName", product.CatalogyID);
                return View(product);

            }

        }

        // GET: Products/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Product product = db.Products.Find(id);
            db.Products.Remove(product);
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
