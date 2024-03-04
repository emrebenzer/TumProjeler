using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace MarmaraMakine
{
    public class Baglanti
    {
        public static string Connection
        {
            get { return ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString; }
        }
    }
}