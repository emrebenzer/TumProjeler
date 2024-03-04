using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BenzerYazilimPanel.Controllers
{
    class _SessionController : ActionFilterAttribute
    {
        // GET: _Session
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (HttpContext.Current.Session["user"] == null)
            {

                filterContext.Result = new RedirectToRouteResult(new System.Web.Routing.RouteValueDictionary { { "action", "Index" }, { "controller", "Login" }, { "returnUrl", filterContext.HttpContext.Request.RawUrl } });
                base.OnActionExecuting(filterContext);
            }
            //if (System.Web.HttpContext.Current.Session["User"] == null)
            //{
            //    if (!HttpContext.Current.Response.IsRequestBeingRedirected)
            //        filterContext.Result = new RedirectToRouteResult(new System.Web.Routing.RouteValueDictionary { { "action", "LoginPage" }, { "controller", "Login" } });

            //    base.OnActionExecuting(filterContext);
            //}
        }
    }
}