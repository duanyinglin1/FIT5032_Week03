using Studio03.Models.HelloWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Studio03.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
           //ViewBag.Message = "Your application description page.";

            // Instance of Hello object
            Hello hello = new Hello();
            ViewBag.Message = hello.GetHello();

            ExampleDictionary exampleDictionary = new ExampleDictionary();
            exampleDictionary.Example();

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


    }
}