using BenzerYazilimPanel.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
            ViewBag.User = ((User)System.Web.HttpContext.Current.Session["User"]).UserName;
            return View();
        }

        public ActionResult NewOrder()
        {
            ViewBag.Title = "Yeni Sipariş";
            return View();
        }

        public ActionResult GetCategories()
        {
            DatasDataContext db = new DatasDataContext();
            var liste = db.Categories.Where(a => a.Active == true).ToList();
            List<DropList> list = new List<DropList>();
            foreach (Category item in liste)
            {
                DropList drp = new DropList();
                drp.ID = item.ID;
                drp.Text = item.Name;
                list.Add(drp);
            }

            return Json(list, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetSahislar()
        {
            DatasDataContext db = new DatasDataContext();
            var liste = db.Users.Where(a => a.Active == true).ToList();
            List<DropList> list = new List<DropList>();
            foreach (User item in liste)
            {
                DropList drp = new DropList();
                drp.ID = item.ID;
                drp.Text = item.UserName;
                list.Add(drp);
            }

            return Json(list, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetSahislarHepsi()
        {
            DatasDataContext db = new DatasDataContext();
            var liste = db.Users.ToList();
            List<DropList> list = new List<DropList>();
            foreach (User item in liste)
            {
                DropList drp = new DropList();
                drp.ID = item.ID;
                drp.Text = item.UserName;
                list.Add(drp);
            }

            return Json(list, JsonRequestBehavior.AllowGet);
        }

        public ActionResult LogOff()
        {
            System.Web.HttpContext.Current.Session["User"] = null;
            return RedirectToAction("Index", "Login", new { returnUrl = "" });
        }

        [HttpPost]
        public ActionResult URUN_EKLE(string inputName, string inputDescription, string inputPrice, string inputStock, int inputCategories, int hiddenUrunID)
        {
            string dosyaIsmi = "";
            HttpPostedFileBase Dosya = Session["PRODUCT_FILE"] == null ? null : (HttpPostedFileBase)Session["PRODUCT_FILE"];
            if (Dosya != null)
            {
                dosyaIsmi = ResimleriAlBuyuk(TurkceTemizle(inputName) + "_" + TurkceTemizle(DateTime.Now.ToShortDateString()), Dosya);
            }
            else
            {

            }

            int ProductID = hiddenUrunID;
            DatasDataContext db = new DatasDataContext();
            if (ProductID == 0)//insert
            {

                Product pr = new Product();
                pr.Name = inputName;
                pr.Description = inputDescription;
                pr.Price = Convert.ToDecimal(inputPrice);
                pr.Stok = Convert.ToInt32(inputStock);
                pr.CategoryID = inputCategories;
                pr.Active = true;
                pr.Image = dosyaIsmi;

                try
                {
                    db.Products.InsertOnSubmit(pr);
                    db.SubmitChanges();
                    return Json(true, JsonRequestBehavior.AllowGet);
                }
                catch
                {
                    return Json(false, JsonRequestBehavior.AllowGet);
                }
            }
            else//update
            {
                Product pr = db.Products.Where(a => a.ID == ProductID).First();
                pr.Name = inputName;
                pr.Description = inputDescription;
                pr.Price = Convert.ToDecimal(inputPrice);
                pr.Stok = Convert.ToInt32(inputStock);
                pr.CategoryID = inputCategories;
                if (dosyaIsmi != "")
                {
                    pr.Image = dosyaIsmi;
                }

                try
                {
                    db.SubmitChanges();
                    return Json(true, JsonRequestBehavior.AllowGet);
                }
                catch
                {
                    return Json(false, JsonRequestBehavior.AllowGet);
                }
            }
        }

        [HttpPost]
        public ActionResult SAHIS_EKLE(string inputName, string inputDescription, string inputPassword, string inputIskonto, int inputYetki, int inputAktif, int hiddenUserID)
        {

            int UserID = hiddenUserID;
            DatasDataContext db = new DatasDataContext();
            if (UserID == 0)//insert
            {
                User pr = new User();
                pr.UserName = inputName;
                pr.Description = inputDescription;
                pr.Password = inputPassword;
                pr.Active = inputAktif == 1 ? true : false;
                pr.Admin = inputYetki == 1 ? true : false;
                pr.Iskonto = Convert.ToDouble(inputIskonto.Replace(".", ","));

                try
                {
                    db.Users.InsertOnSubmit(pr);
                    db.SubmitChanges();
                    return Json(true, JsonRequestBehavior.AllowGet);
                }
                catch
                {
                    return Json(false, JsonRequestBehavior.AllowGet);
                }
            }
            else//update
            {
                User pr = db.Users.Where(a => a.ID == UserID).First();
                pr.UserName = inputName;
                pr.Description = inputDescription;
                pr.Password = inputPassword;
                pr.Active = inputAktif == 1 ? true : false;
                pr.Admin = inputYetki == 1 ? true : false;
                pr.Iskonto = Convert.ToDouble(inputIskonto.Replace(".", ","));
                try
                {

                    db.SubmitChanges();
                    return Json(true, JsonRequestBehavior.AllowGet);
                }
                catch
                {
                    return Json(false, JsonRequestBehavior.AllowGet);
                }
            }
        }

        public static string TurkceTemizle(string Metin)
        {
            string deger = Metin;
            deger = deger.Replace("'", "");
            deger = deger.Replace(" ", "_");
            deger = deger.Replace("<", "");
            deger = deger.Replace(">", "");
            deger = deger.Replace("&", "");
            deger = deger.Replace("[", "");
            deger = deger.Replace("]", "");
            deger = deger.Replace("ı", "i");
            deger = deger.Replace("ö", "o");
            deger = deger.Replace("ü", "u");
            deger = deger.Replace("ş", "s");
            deger = deger.Replace("ç", "c");
            deger = deger.Replace("ğ", "g");
            deger = deger.Replace("İ", "i");
            deger = deger.Replace("Ö", "o");
            deger = deger.Replace("Ü", "u");
            deger = deger.Replace("Ş", "s");
            deger = deger.Replace("Ç", "c");
            deger = deger.Replace("Ğ", "g");

            return deger;
        }

        [HttpPost]
        public ActionResult UrunSil(int ID)
        {
            DatasDataContext db = new DatasDataContext();
            Product pr = db.Products.Where(a => a.ID == ID).First();
            try
            {
                db.Products.DeleteOnSubmit(pr);
                db.SubmitChanges();
                return Json(true, JsonRequestBehavior.AllowGet);
            }
            catch
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }

        }

        [HttpPost]
        public ActionResult SiparisSil(int id)
        {
            DatasDataContext db = new DatasDataContext();
            Order pr = db.Orders.Where(a => a.ID == id).First();
            try
            {
                db.Orders.DeleteOnSubmit(pr);
                db.OrderRelations.DeleteAllOnSubmit(db.OrderRelations.Where(a => a.OrderID == id));
                db.SubmitChanges();
                return Json(true, JsonRequestBehavior.AllowGet);
            }
            catch
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }

        }

        [HttpPost]
        public ActionResult KategoriSil(int ID)
        {
            DatasDataContext db = new DatasDataContext();
            Category pr = db.Categories.Where(a => a.ID == ID).First();
            try
            {
                db.Categories.DeleteOnSubmit(pr);
                //db.SubmitChanges();

                var liste = db.Products.Where(a => a.CategoryID == ID).ToList();
                db.Products.DeleteAllOnSubmit(liste);
                db.SubmitChanges();


                return Json(true, JsonRequestBehavior.AllowGet);
            }
            catch
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }

        }

        [HttpPost]
        public ActionResult SahisSil(int ID)
        {
            DatasDataContext db = new DatasDataContext();
            User pr = db.Users.Where(a => a.ID == ID).First();
            try
            {
                db.Users.DeleteOnSubmit(pr);
                db.SubmitChanges();
                return Json(true, JsonRequestBehavior.AllowGet);
            }
            catch
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }

        }

        [HttpPost]
        public ActionResult KategoriEkle(string isim)
        {
            DatasDataContext db = new DatasDataContext();
            Category pr = new Category();
            pr.Active = true;
            pr.Name = isim;
            try
            {
                db.Categories.InsertOnSubmit(pr);
                db.SubmitChanges();
                return Json(true, JsonRequestBehavior.AllowGet);
            }
            catch
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }

        }

        [HttpPost]
        public ActionResult SMTP_GUNCELLE(string inputUserName, string inputPassword, string inputServer, int inputPort)
        {
            DatasDataContext db = new DatasDataContext();
            SMTP_Setting pr = db.SMTP_Settings.Where(a => a.id == 1).First();
            pr.SMTPUser = inputUserName;
            pr.SMTPServer = inputServer;
            pr.SMTPPort = inputPort;
            pr.SMTPPassword = inputPassword;
            try
            {
                db.SubmitChanges();
                return Json(true, JsonRequestBehavior.AllowGet);
            }
            catch
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }

        }

        public bool MailGonder2(string mail, string icerik)
        {
            string smtpp = "";
            string giden = "";
            string sifree = "";
            string gonderilecek = "";
            int port = 587;

            DatasDataContext db = new DatasDataContext();
            SMTP_Setting pr = db.SMTP_Settings.Where(a => a.id == 1).First();

            smtpp = pr.SMTPServer;
            giden = pr.SMTPUser;
            sifree = pr.SMTPPassword;
            gonderilecek = mail;
            try
            {
                port = Convert.ToInt32(pr.SMTPPort);
            }
            catch
            {
                port = 587;
            }


            System.Net.Mail.MailMessage m = new System.Net.Mail.MailMessage();


            MailAddress gonderen = new MailAddress(giden, "Sipariş Sistemi");
            MailAddress alan = new MailAddress(gonderilecek, "Admin");
            MailMessage eposta = new MailMessage(gonderen, alan);


            //if (doc.HasFile)
            //{
            //    System.Net.Mail.Attachment a = new Attachment(doc.FileContent, doc.FileName);
            //    eposta.Attachments.Add(a);
            //}
            eposta.IsBodyHtml = true;
            eposta.Subject = "Sipariş Bilgisi";
            eposta.Body = icerik;


            eposta.To.Add(gonderilecek);

            NetworkCredential auth = new NetworkCredential(giden, sifree);
            SmtpClient SMTP = new System.Net.Mail.SmtpClient();
            SMTP.Host = smtpp;
            SMTP.UseDefaultCredentials = false;
            SMTP.Credentials = auth;
            SMTP.EnableSsl = false;
            SMTP.Port = port;
            SMTP.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;


            try
            {
                SMTP.Send(eposta);
                return true;
            }
            catch (Exception ex)
            {
                string a = ex.ToString();
                return false;
            }
        }


        [HttpPost]
        [ValidateInput(false)]
        public ActionResult MailGonder(string mail, string icerik)
        {
            DatasDataContext db = new DatasDataContext();
            SMTP_Setting pr = db.SMTP_Settings.Where(a => a.id == 1).First();

            string[] mailler = mail.Split(',');
            int sayi = mailler.Count();
            int say = 0;
            foreach (string item in mailler)
            {
                bool sonuc = MailGonder2(item, icerik);
                if (sonuc == true)
                {
                    say++;
                }

            }
            try
            {
                if (say == sayi)
                {
                    return Json(true, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(false, JsonRequestBehavior.AllowGet);
                }

            }
            catch
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }

        }


        string uzanti2 = "";

        public string ResimleriAlBuyuk(string dosyaismi, HttpPostedFileBase FileUpload2)
        {

            try
            {

                //resimin adı
                string fileName = Path.GetFileName(FileUpload2.FileName);

                //resim uzantısı
                uzanti2 = Path.GetExtension(FileUpload2.FileName);

                //resime atanacak yeni ad


                // Orjinal resmi kaydet
                FileUpload2.SaveAs(Server.MapPath("../Images/Temp/" + dosyaismi + uzanti2));

                //****************** Yeni boyutlara göre resim oluştur ***************/

                Bitmap resim = new Bitmap(Server.MapPath("../Images/Temp/" + dosyaismi + uzanti2));
                // 800px genişlikte yeni resim oluştur
                resim = this.ResimBoyutlandirOrjinal(resim, 800);
                // oluşturulan resmi kaydet
                resim.Save(Server.MapPath("../Images/" + dosyaismi + uzanti2));



                return dosyaismi + uzanti2;
            }
            catch
            {
                return "";
            }
        }

        public Bitmap ResimBoyutlandirOrjinal(Bitmap resim, int boyut)
        {
            Bitmap sresim = resim;
            try
            {
                using (Bitmap OrjinalResim = resim)
                {
                    double yukseklik = OrjinalResim.Height;
                    double genislik = OrjinalResim.Width;
                    double oran = 0;

                    if (genislik >= boyut || genislik <= boyut)
                    {
                        if (genislik >= yukseklik)
                        {
                            oran = genislik / yukseklik;
                            genislik = boyut;
                            yukseklik = genislik / oran;
                        }
                        else if (yukseklik >= genislik)
                        {
                            oran = yukseklik / genislik;
                            yukseklik = boyut - 300;
                            genislik = yukseklik / oran;
                        }

                        Size ydeger = new Size(460, 250);
                        Bitmap yresim = new Bitmap(OrjinalResim, ydeger);

                        sresim = yresim;
                    }
                }
                return sresim;
            }
            catch
            {
                return sresim;
            }
        }

        public ActionResult GetProducts(int katid, int pageLimit, int page, string q)
        {
            DatasDataContext db = new DatasDataContext();

            return Json(new { results = db.Products.Where(a => a.Active == true && a.CategoryID == katid && a.Name.Contains(q)).Skip(pageLimit * (page - 1)).Take(pageLimit).Select(a => new { a.ID, a.CategoryID, a.Description, a.Stok, a.Name, Price = string.Format("{0:N2}", a.Price), a.Image }), total = db.Products.Where(a => a.Active == true && a.CategoryID == katid && a.Name.Contains(q)).Count() }, JsonRequestBehavior.AllowGet);

        }

        public ActionResult SAHIS_BILGISI(int id)
        {
            DatasDataContext db = new DatasDataContext();

            User user = db.Users.Where(a => a.ID == id).First();

            return Json(user, JsonRequestBehavior.AllowGet);

        }

        public ActionResult SMTP_BILGISI()
        {
            DatasDataContext db = new DatasDataContext();

            SMTP_Setting smtp = db.SMTP_Settings.Where(a => a.id == 1).First();

            return Json(smtp, JsonRequestBehavior.AllowGet);

        }

        public ActionResult GetOrderProducts(int ID)
        {
            DatasDataContext db = new DatasDataContext();

            var liste = db.OrderRelations.Where(a => a.OrderID == ID).Select(a => new { ID = a.ID, Name = a.ProductName, Price = string.Format("{0:N2}", a.Price), a.Adet, a.Not, a.ProductID, GenelToplam = string.Format("{0:N2}", a.Price * a.Adet) });

            var order = db.Orders.Where(a => a.ID == ID).Select(a => new { a.ID, a.Adet, a.KomisyonOran, Vergi = string.Format("{0:N2}", a.Vergi), AraToplam = string.Format("{0:N2}", a.AraToplam), Komisyon = string.Format("{0:N2}", a.Komisyon), GenelToplam = string.Format("{0:N2}", a.GenelToplam), VergiDahil = string.Format("{0:N2}", (a.AraToplam + Convert.ToDecimal(a.Vergi))) }).First();

            return Json(new { urunler = liste, GenelBilgiler = order }, JsonRequestBehavior.AllowGet);

        }


        public ActionResult GetOrders(int pageLimit, int page, int cari)
        {

            DatasDataContext db = new DatasDataContext();
            if (cari == 0)
            {
                return Json(new { results = db.Orders.Where(a => a.UserID == ((User)System.Web.HttpContext.Current.Session["User"]).ID).OrderByDescending(b => b.Date).Skip(pageLimit * (page - 1)).Take(pageLimit).Select(a => new { a.ID, a.Name, Price = string.Format("{0:N2} €", a.GenelToplam), Tarih = (Convert.ToDateTime(a.Date)).ToShortDateString(), a.Adet, Cari = db.Users.Where(b => b.ID == a.UserID).Select(c => c.UserName), Komisyon = string.Format("{0:N2} €", a.Komisyon) }), total = db.Orders.Where(a => a.UserID == ((User)System.Web.HttpContext.Current.Session["User"]).ID).Count() }, JsonRequestBehavior.AllowGet);
            }
            else if (cari == -1)
            {
                return Json(new { results = db.Orders.OrderByDescending(b => b.Date).Skip(pageLimit * (page - 1)).Take(pageLimit).Select(a => new { a.ID, a.Name, Price = string.Format("{0:N2} €", a.GenelToplam), Tarih = (Convert.ToDateTime(a.Date)).ToShortDateString(), a.Adet, Cari = db.Users.Where(b => b.ID == a.UserID).Select(c => c.UserName), Komisyon = string.Format("{0:N2} €", a.Komisyon) }), total = db.Orders.Count() }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { results = db.Orders.Where(a => a.UserID == cari).OrderByDescending(b => b.Date).Skip(pageLimit * (page - 1)).Take(pageLimit).Select(a => new { a.ID, a.Name, Price = string.Format("{0:N2} €", a.GenelToplam), Tarih = (Convert.ToDateTime(a.Date)).ToShortDateString(), a.Adet, Cari = db.Users.Where(b => b.ID == a.UserID).Select(c => c.UserName), Komisyon = string.Format("{0:N2} €", a.Komisyon) }), total = db.Orders.Where(a => a.UserID == cari).Count() }, JsonRequestBehavior.AllowGet);
            }


        }



        public ActionResult UpdateOrder(List<ProductVeri> Urunler, int adet, string AraToplam, string Vergi, string Komisyon, string GenelToplam, string KomisyonOran)
        {
            int userID = ((User)System.Web.HttpContext.Current.Session["User"]).ID;
            //bool ilkIslem = false;
            DatasDataContext db = new DatasDataContext();
            bool ilkIslem = false;
            int ilkUrunID = Urunler[0].id;
            int orderID = db.OrderRelations.Where(a => a.ID == (ilkUrunID)).Select(a => a.OrderID ?? 0).First();
            Order order = db.Orders.Where(a => a.ID == orderID).First();
            order.Adet = adet;
            order.AraToplam = Convert.ToDecimal(AraToplam);
            order.Vergi = Convert.ToDouble(Vergi);
            order.Komisyon = Convert.ToDouble(Komisyon);
            order.GenelToplam = Convert.ToDecimal(GenelToplam);
            order.KomisyonOran = Convert.ToDouble(KomisyonOran);
            int Donenid = 0;
            try
            {
                db.SubmitChanges();
                ilkIslem = true;
            }
            catch
            {
                ilkIslem = false;
            }

            //int id = order.ID;

            if (ilkIslem == true)
            {
                try
                {
                    try
                    {
                        db.OrderRelations.DeleteAllOnSubmit(db.OrderRelations.Where(a => a.OrderID == orderID));
                        db.SubmitChanges();
                        foreach (ProductVeri item in Urunler)
                        {
                            OrderRelation relation = new OrderRelation();
                            relation.Adet = item.adet;
                            relation.Price = item.ucret;
                            relation.ProductID = item.productid;
                            relation.ProductName = db.Products.Where(a => a.ID == item.productid).Select(a => a.Name).First();
                            relation.OrderID = orderID;
                            relation.Not = item.not;
                            db.OrderRelations.InsertOnSubmit(relation);
                            db.SubmitChanges();
                        }
                    }
                    catch
                    {

                    }
                    return Json(new { status = true, deger = Donenid }, JsonRequestBehavior.AllowGet);
                }
                catch
                {

                    return Json(new { status = false, deger = Donenid }, JsonRequestBehavior.AllowGet);
                }

            }
            else
            {
                return Json(new { status = false, deger = Donenid }, JsonRequestBehavior.AllowGet);
            }

        }


        public ActionResult SaveOrder(List<ProductVeri> Urunler, int adet, string AraToplam, string Vergi, string Komisyon, string GenelToplam)
        {
            int userID = ((User)System.Web.HttpContext.Current.Session["User"]).ID;
            bool ilkIslem = false;
            DatasDataContext db = new DatasDataContext();
            Order order = new Order();
            order.Name = "";
            order.Date = DateTime.Now;
            order.UserID = userID;
            order.Adet = adet;
            order.AraToplam = Convert.ToDecimal(AraToplam);
            order.Vergi = Convert.ToDouble(Vergi);
            order.Komisyon = Convert.ToDouble(Komisyon);
            order.GenelToplam = Convert.ToDecimal(GenelToplam);
            order.KomisyonOran = Convert.ToDouble(((User)System.Web.HttpContext.Current.Session["User"]).Iskonto ?? 0);
            int Donenid = 0;
            try
            {
                db.Orders.InsertOnSubmit(order);
                db.SubmitChanges();
                Donenid = order.ID;
                ilkIslem = true;
            }
            catch
            {
                ilkIslem = false;
            }

            int id = order.ID;

            if (ilkIslem == true)
            {
                try
                {
                    foreach (ProductVeri item in Urunler)
                    {
                        OrderRelation relation = new OrderRelation();
                        relation.Adet = item.adet;
                        relation.Price = item.ucret;
                        relation.ProductID = item.id;
                        relation.ProductName = db.Products.Where(a => a.ID == item.id).Select(a => a.Name).First();
                        relation.OrderID = id;
                        relation.Not = item.not;
                        db.OrderRelations.InsertOnSubmit(relation);
                        db.SubmitChanges();
                    }
                    return Json(new { status = true, deger = Donenid }, JsonRequestBehavior.AllowGet);
                }
                catch
                {

                    return Json(new { status = false, deger = Donenid }, JsonRequestBehavior.AllowGet);
                }

            }
            else
            {
                return Json(new { status = false, deger = Donenid }, JsonRequestBehavior.AllowGet);
            }

        }

        public ActionResult OldOrders()
        {
            ViewBag.Title = "Siparişler";
            return View();
        }

        public ActionResult Products()
        {
            ViewBag.Title = "Ürünler";
            return View();
        }

        public ActionResult Orders()
        {
            ViewBag.Title = "Siparişler";
            return View();
        }

        public ActionResult Personel()
        {
            ViewBag.Title = "Şahıs/Bayi";
            return View("Personel");
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

        public ActionResult Print(int id)
        {
            ViewBag.ID = id;
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

        [HttpPost]
        public ActionResult UploadFileWithAjax(HttpPostedFileBase file)
        {
            Session["PRODUCT_FILE"] = file;
            return Content("");
        }



    }
}