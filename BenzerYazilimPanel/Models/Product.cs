using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BenzerYazilimPanel.Models
{
    public class ProductVeri
    {
        public int id { get; set; }
        public string name { get; set; }
        public int adet { get; set; }
        public decimal ucret { get; set; }
        public decimal toplam { get; set; }
        public int productid { get; set; }

        public string not { get; set; }
    }
}