﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using kttx1.Models;
namespace kttx1.Controllers
{
    public class NhapDiemController : Controller
    {
        // GET: NhapDiem
        public ActionResult Index()
        {
            return View();
        }

        //-----------------------------------------------------------------------------------------
        //public ActionResult XuLy(SinhVien sv)
        //{
        //    //Lay du lieu tu View bang Request
        //    string Ma = Request["Id"];
        //    string Ten = Request["Name"];
        //    double Diem = Convert.ToDouble(Request["Marks"]);

        //    sv.Id = Ma;
        //    sv.Name = Ten;
        //    sv.Marks = Diem;

        //    return View(sv);
        //}

        //-----------------------------------------------------------------------------------------
        //public ActionResult XuLy(FormCollection data, SinhVien sv)
        //{
        //    //Lay du lieu tu View bang FormCollection
        //    string Ma = data["Id"];
        //    string Ten = data["Name"];
        //    double Diem = Convert.ToDouble( data["Marks"] );

        //    sv.Id = Ma;
        //    sv.Name = Ten;
        //    sv.Marks = Diem;

        //    return View(sv);
        //}


        //------------------------------------------------------------------------------------------
        //public ActionResult XuLy(SinhVien sv, string Id = "",string Name = "", double Marks = 0f)
        //{
        //    //Lay du lieu tu View bang Action Arguments
        //    sv.Id = Id;
        //    sv.Name = Name;
        //    sv.Marks = Marks;

        //    return View(sv);
        //}


        //------------------------------------------------------------------------------------------
        public ActionResult Save(SinhVien sv)
        {
            //Duong dan den file
            string path = Server.MapPath("~/StudentInfo.txt");
            //Khai bao 1 mang string
            string[] lines = {sv.Id, sv.Name, sv.Marks.ToString()};
            //ghi thong tin vao file
            System.IO.File.WriteAllLines(path, lines);
            ViewBag.HanhDong = "Da ghi vao file";

            return View("Index");
        }

        public ActionResult Open(SinhVien sv)
        {
            //Duong dan file
            string path = Server.MapPath("~/StudentInfo.txt");
            //Doc file vao 1 mang string
            string[] lines = System.IO.File.ReadAllLines(path);
            //Gan gia tri cho Models
            sv.Id = lines[0];
            sv.Name = lines[1];
            sv.Marks = Convert.ToDouble( lines[2] );
            //Thong tin
            ViewBag.HanhDong = "Da doc tu file";
            ViewBag.ThongTin = $"{sv.Id}  {sv.Name} {sv.Marks}";

            return View("Index",sv);
        }

    }
}