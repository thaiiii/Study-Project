using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace kttx1.Controllers
{
    public class TienDienController : Controller
    {
        // GET: TienDien
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Tinh(string chuho ="", double firstIndex = 0f, double lastIndex = 0f, bool uutien = false, string loaidien ="")
        {
            double sodien = lastIndex - firstIndex;
            double tiendien;
            if (sodien <= 100)
                tiendien = sodien * 2000;
            else if (sodien <= 150)
                tiendien = 100 * 2000 + (sodien - 100) * 2500;
            else if (sodien <= 200)
                tiendien = 100 * 2000 + 50 * 2500 + (sodien - 150) * 3000;
            else
                tiendien = 100 * 2000 + 50 * 2500 + 50 * 3000 + (sodien - 200) * 4000;

            if (loaidien == "Kinh doanh")
                tiendien *= 1.2f;
            else if (loaidien == "San xuat")
                tiendien *= 1.3f;

            if (uutien == true)
                tiendien *= 0.9f;

            ViewBag.ChuHo = chuho;
            ViewBag.SoDien = sodien;
            ViewBag.TienDien = Math.Round(tiendien,0);
            return View();
        }

    }
}