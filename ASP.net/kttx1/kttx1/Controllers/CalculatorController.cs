using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using kttx1.Models;

namespace kttx1.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Calculate(Operation op, FormCollection data)
        {
            if (data["operation"] == null || data["numberA"] == null || data["numberB"] == null)
            {
                op.result = "vui long nhap";
                return View(op);
            }
            double result;
            if (data["operation"] == "cong")
            {
                result = Convert.ToDouble(data["numberA"]) + Convert.ToDouble(data["numberB"]);
                op.result = result.ToString();
            }
            else if (data["operation"] == "tru")
            {
                result = Convert.ToDouble(data["numberA"]) - Convert.ToDouble(data["numberB"]);
                op.result = result.ToString();
            }

            else if (data["operation"] == "nhan")
            {
                result = Convert.ToDouble(data["numberA"]) * Convert.ToDouble(data["numberB"]);
                op.result = result.ToString();
            }

            else if (data["operation"] == "chia" && Convert.ToDouble(data["numberB"]) != 0)
            {
                result = Convert.ToDouble(data["numberA"]) / Convert.ToDouble(data["numberB"]);
                op.result = result.ToString();
            }
            else
                op.result = "ko hop le";

            return View(op);
        }
    }
}