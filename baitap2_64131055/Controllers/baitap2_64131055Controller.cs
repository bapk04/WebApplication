using baitap2_64131055.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace baitap2_64131055.Controllers
{
    public class baitap2_64131055Controller : Controller
    {
        // GET: baitap2_64131055

        //su dung formcollection
        public ActionResult Index2()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register2(FormCollection field)
        {
            ViewBag.Id = field["studentId"];
            ViewBag.Name = field["fullName"];
            ViewBag.Marks = field["score"];
            return View();
        }


        //su dung request
        public ActionResult Index3()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register3()
        {
            ViewBag.Id = Request["studentId"];
            ViewBag.Name = Request["fullName"];
            ViewBag.Marks = Request["score"];
            return View();

        }




        //su dung doiso

        public ActionResult Index4()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register4(string Id, string Name, double Marks)
        {
            ViewBag.Id = Id;
            ViewBag.Name = Name;
            ViewBag.Marks = Marks;
            return View();

        }






        //su dung MVC
        public ActionResult Index5()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register5(register_64131055 rg)
        {
            ViewBag.Id = rg.Id;
            ViewBag.Name = rg.Name;
            ViewBag.Marks = rg.Marks;
            return View();


        }
    }
}