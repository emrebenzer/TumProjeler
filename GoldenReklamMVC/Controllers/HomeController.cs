using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;

namespace GoldenReklamMVC.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public ActionResult Index()
        {
            ViewBag.Title = "Golden Reklam";
            return View();
        }

        [Route("hizmetlerimiz")]
        public ActionResult hizmetlerimiz()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [Route("iletisim")]
        public ActionResult iletisim()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Route("baski-teknikleri")]
        public ActionResult baski_teknikleri()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Route("hakkimizda")]
        public ActionResult hakkimizda()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //hizmetler
        [Route("tisort-baski")]
        public ActionResult tisort_baski()
        {
            ViewBag.Message = "";

            return View();
        }

        [Route("semsiye-baski")]
        public ActionResult semsiye_baski()
        {
            ViewBag.Message = "";

            return View();
        }

        [Route("tente-baski")]
        public ActionResult tente_baski()
        {
            ViewBag.Message = "";

            return View();
        }

        [Route("minder-baski")]
        public ActionResult minder_baski()
        {
            ViewBag.Message = "";

            return View();
        }

        [Route("sapka-baski")]
        public ActionResult sapka_baski()
        {
            ViewBag.Message = "";

            return View();
        }

        [Route("canta-baski")]
        public ActionResult canta_baski()
        {
            ViewBag.Message = "";

            return View();
        }

        [Route("is-elbiseleri-baski")]
        public ActionResult is_elbiseleri_baski()
        {
            ViewBag.Message = "";

            return View();
        }

        [Route("promosyon-ajanda-baski")]
        public ActionResult promosyon_ajanda_baski()
        {
            ViewBag.Message = "";

            return View();
        }

        [Route("cardak-cadir-gazebo-baski")]
        public ActionResult cardak_cadir_gazebo_baski()
        {
            ViewBag.Message = "";

            return View();
        }

        [Route("diger-baski")]
        public ActionResult diger_baski()
        {
            ViewBag.Message = "";

            return View();
        }

    }
}