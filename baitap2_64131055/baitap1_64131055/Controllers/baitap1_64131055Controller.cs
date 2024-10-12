using baitap1_64131055.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace baitap1_64131055.Controllers
{
    public class baitap1_64131055Controller : Controller
    {
        // GET: baitap1_64131055


        //su dung doi so
        public ActionResult UseArguments()
        {
            return View();
        }
        [HttpPost]

             public ActionResult UseArguments(double a, double b, string pt = "+")
        {
            switch (pt)
            {
                case "+": ViewBag.KQ = a + b; break;
                case "-": ViewBag.KQ = a - b; break;
                case "*": ViewBag.KQ = a * b; break;
                case "/":
                    if (b == 0) ViewBag.KQ = "Không chia được cho 0";
                    else ViewBag.KQ = a / b; break;
            }
            return View();
        }

        //su dung request

        public ActionResult UseRequest()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UseRequest(string pt)
        {
            double a = double.Parse(Request["a"]);//Chuyển đổi chuỗi sang số thực
            double b = double.Parse(Request["b"]);
            pt = Request["pt"].ToString();
            switch (pt)
            {
                case "+": ViewBag.KQ = a + b; break;
                case "-": ViewBag.KQ = a - b; break;
                case "*": ViewBag.KQ = a * b; break;
                case "/":
                    if (b == 0) ViewBag.KQ = "Không chia được cho 0";
                    else ViewBag.KQ = a / b; break;
            }
            return View();
        }

        //su dung formcollection
        public ActionResult UseFormCollection()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UseFormCollection(FormCollection f)
        {
            double a = double.Parse(f["a"]);//Chuyển đổi chuỗi sang số thực
            double b = double.Parse(f["b"]);
            string pt = f["pt"].ToString();
            switch (pt)
            {
                case "+": ViewBag.KQ = a + b; break;
                case "-": ViewBag.KQ = a - b; break;
                case "*": ViewBag.KQ = a * b; break;
                case "/":
                    if (b == 0) ViewBag.KQ = "Không chia được cho 0";
                    else ViewBag.KQ = a / b; break;
            }
            return View();
        }


        //su dung MVC
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(CalModels_64131055 cal)

             {
             switch (cal.pt)
             {
             case "+": ViewBag.KQ = cal.a + cal.b; break;
             case "-": ViewBag.KQ = cal.a - cal.b; break;
             case "*": ViewBag.KQ = cal.a* cal.b; break;
             case "/":
             if (cal.b == 0) ViewBag.KQ = "Không chia được cho 0";
             else ViewBag.KQ = cal.a / cal.b; break;
             }
             return View();
            }

    }
}