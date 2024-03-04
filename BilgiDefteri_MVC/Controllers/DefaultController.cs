using BilgiDefteri_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BilgiDefteri_MVC.Controllers
{
    public class DefaultController : Controller
    {
        //
        // GET: /Default/

        public ActionResult Index()
        {
            
            if (Session["giris"]=="ok")
            {
                //ViewBag.Liste = Provider.BilgileriGetir(Convert.ToInt32(Session["type"]));
            }
            else
            {
                Response.Redirect("/Default/Login");
            }

            return View();

            
        }

        [HttpGet]
        public ActionResult BilgileriGetir()
        {
           
            var liste = Provider.BilgileriGetir(Convert.ToInt32(Session["type"]));
            return Json(liste, JsonRequestBehavior.AllowGet);


        }


        [HttpGet]
        public ActionResult BilgiGetir(int id)
        {
            if (Session["giris"] == "ok")
            {
                //ViewBag.Liste = Provider.BilgileriGetir(Convert.ToInt32(Session["type"]));
            }
            else
            {
                Response.Redirect("/Default/Login");
            }
            var liste = Provider.BilgiAyrintiGetir(Convert.ToInt32(id));
            return Json(liste, JsonRequestBehavior.AllowGet);
            

        }

        [HttpGet]
        public ActionResult BilgiSil(int id)
        {
            if (Session["giris"] == "ok")
            {
                //ViewBag.Liste = Provider.BilgileriGetir(Convert.ToInt32(Session["type"]));
            }
            else
            {
                Response.Redirect("/Default/Login");
            }



            bool sonuc = Provider.BilgiSil(id);
            return Json(sonuc, JsonRequestBehavior.AllowGet);


        }

        [HttpGet][ValidateInput(false)]
        public JsonResult KaydetDuzenle(string baslik, string icerik,int durum,int id)
        {
            if (Session["giris"] == "ok")
            {
                //ViewBag.Liste = Provider.BilgileriGetir(Convert.ToInt32(Session["type"]));
            }
            else
            {
                Response.Redirect("/Default/Login");
            }
            if (durum==1)//kaydet
            {
                bool dr = Provider.Kaydet(baslik, icerik, Convert.ToInt32(Session["type"]));
                if (dr==true)
                {
                    return Json(true, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(false, JsonRequestBehavior.AllowGet);
                }
            }
            else if (durum==2)//düzenle
            {
                bool dr = Provider.Duzenle(baslik, icerik, id);
                if (dr==true)
                {
                    return Json(true, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(false, JsonRequestBehavior.AllowGet);
                }
                
            }
            else
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            



           
        }

        [HttpGet]
        public ActionResult BilgileriSuz(string id)
        {
            if (Session["giris"] == "ok")
            {
                //ViewBag.Liste = Provider.BilgileriGetir(Convert.ToInt32(Session["type"]));
            }
            else
            {
                Response.Redirect("/Default/Login");
            }
            if (id==null)
            {
                id = "";
            }
            var liste = Provider.BilgileriSuz(id,Convert.ToInt32(Session["type"]));
            return Json(liste, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult CikisYap()
        {
            Session["giris"] = "ex";
            Session["type"] = null;
            Response.Redirect("Login");
            return View();
        }

        [HttpGet]
        public JsonResult Kullanici(string username, string password)
        {

            var liste=Provider.GetUser().Where(p => p.kullanici1 == username && p.sifre == password).ToList();
            int sayi = liste.Count();
            if (sayi>0)
            {
                Session["giris"] = "ok";
                Session["type"] = liste[0].type.ToString();
                return Json(true,JsonRequestBehavior.AllowGet);
            }
            else
            {
                Session["giris"] = "ex";
                Session["type"] = null;
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }


    }
}
