using System;
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
        public ActionResult XuLy(SinhVien sv)
        {
            //Lay du lieu tu View bang Action Arguments
            

            return View(sv);
        }

    }
}