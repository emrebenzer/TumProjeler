using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace BenzerYazilimPanel.Controllers
{
    public class InternationalizationAttribute : ActionFilterAttribute
    {
        // GET: InternationalizationAttribute
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string language = (string)filterContext.RouteData.Values["language"] ?? "tr";
            string culture = (string)filterContext.RouteData.Values["culture"] ?? "TR";
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo(string.Format("{0}-{1}", language, culture));
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(string.Format("{0}-{1}", language, culture));

        }
    }
}