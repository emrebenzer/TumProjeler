using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmreBenzerMVC.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Master()
        {
            return View();
        }

        public ActionResult AboutMe()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}