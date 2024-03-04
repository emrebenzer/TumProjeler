using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BenzerYazilimPanel.Controllers
{
    [_SessionController]
    [InternationalizationAttribute]
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            ViewBag.Title = "Admin Paneli";
            return View();
        }

        public ActionResult Products()
        {
            ViewBag.Title = "Ürünler";
            return View();
        }

        public ActionResult Services()
        {
            ViewBag.Title = "Hizmetler";
            return View();
        }

        public ActionResult Galeries()
        {
            ViewBag.Title = "Slaytlar";
            return View();
        }

        public ActionResult Slides()
        {
            ViewBag.Title = "Slaytlar";
            return View();
        }

        public ActionResult SiteImages()
        {
            ViewBag.Title = "Site Görselleri";
            return View();
        }

        public ActionResult ImageSettings()
        {
            ViewBag.Title = "Resim Ayarları";
            return View();
        }

        public ActionResult Pages()
        {
            ViewBag.Title = "Bilgi Sayfaları";
            return View();
        }

        public ActionResult Links()
        {
            ViewBag.Title = "Bağlantılar";
            return View();
        }

        public ActionResult SeoSettings()
        {
            ViewBag.Title = "Seo Ayarları";
            return View();
        }

        public ActionResult SmtpSettings()
        {
            ViewBag.Title = "Smtp Ayarları";
            return View();
        }

        public ActionResult DbSettings()
        {
            ViewBag.Title = "Database Ayarları";
            return View();
        }

        public ActionResult MailBox()
        {
            ViewBag.Title = "Gelen Mesajlar";
            return View();
        }

        public ActionResult GroupMail()
        {
            ViewBag.Title = "Toplu Mail";
            return View();
        }

        public ActionResult GroupSms()
        {
            ViewBag.Title = "Toplu Sms";
            return View();
        }

        public ActionResult SystemUsers()
        {
            ViewBag.Title = "Sistem Kullanıcıları";
            return View();
        }

        public ActionResult SystemAuthority()
        {
            ViewBag.Title = "Sistem Yetkileri";
            return View();
        }

        public ActionResult NormalUsers()
        {
            ViewBag.Title = "Normal Kullanıcılar";
            return View();
        }

        public ActionResult UserMembership()
        {
            ViewBag.Title = "Üyelik Formu";
            return View();
        }

        public ActionResult MembershipAgreement()
        {
            ViewBag.Title = "Üyelik Koşulları";
            return View();
        }



    }
}