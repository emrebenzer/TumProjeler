using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BenzerYazilimPanel.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index(int? Pageid, string returnUrl)
        {
            ViewBag.reUrl = returnUrl;
            return View();
        }

        public ActionResult Login(string Name, string Passwrd, string RETURN_ADRES)
        {

            if (Name=="emre" && Passwrd=="123")
            {
                System.Web.HttpContext.Current.Session["User"] = "emre";
                if (RETURN_ADRES == "/" || RETURN_ADRES == null || RETURN_ADRES == "")
                {
                    
                    return RedirectToAction("Index", "Admin");
                }
                else
                {

                    return Redirect(RETURN_ADRES);
                }
            }
            else
            {
                return Content("<script language='javascript' type='text/javascript'>alert('Bilgiler hatalı...');window.location.href = '/Login/';</script>");
            }

        }
    }
}