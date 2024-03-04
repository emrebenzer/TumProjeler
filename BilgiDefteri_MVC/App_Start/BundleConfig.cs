using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace BilgiDefteri_MVC.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("../css/").Include(
                     "../css/bootstrap.css",
                     "../css/font-awesome.css",
                     "../Content/css/site.css"
                   ));

            bundles.Add(new StyleBundle("~/css/summernote").Include(
                "~/css/summernote.css"
                ));

            bundles.Add(new ScriptBundle("~/js/bootstrap").Include(
               "~/js/jquery-1.11.3.min.js",
                "~/js/bootstrap.js",
                "~/js/bootstrap.min.js"
               ));

            bundles.Add(new ScriptBundle("~/bundle/summernote").Include(
               "~/js/summernote.js"
               ));
        }
    }
}