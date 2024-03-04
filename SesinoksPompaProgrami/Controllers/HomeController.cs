using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SesinoksPompaProgrami.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public class Sonuc
        {
            public int PompaID { get; set; }

            public string PompaIsim { get; set; }

            public string NPSH { get; set; }

            public string Power { get; set; }

            public string Speed { get; set; }

            public bool SorunsuzMu { get; set; }
        }


        public ActionResult HesapYap(string flowDegeri, string plessureDegeri, string viscosityDegeri)
        {
            List<Sonuc> SonDegerler = new List<Sonuc>();
            SesinoksPompaProgrami.Models.VerilerEntities db = new Models.VerilerEntities();
            var pompalar = db.POMPALAR.ToList();
            decimal flow = Convert.ToDecimal(flowDegeri.Replace(".",","));
            decimal plessure = Convert.ToDecimal(plessureDegeri.Replace(".", ","));
            decimal viscosity = Convert.ToDecimal(viscosityDegeri.Replace(".", ","));


            foreach (var pompa in pompalar)
            {
                decimal Sonuc_NPSH = 0;
                decimal Sonuc_Power = 0;
                decimal Sonuc_Speed = 0;
                var pompaEgrileri = db.GRAFIK_EGRI_DEGERLERI.Where(a => a.POMPA_ID == pompa.ID).ToList();
                #region ql grafiği işlemleri
                decimal qlDegeriValue = 0;

                var viscositilerQL = pompaEgrileri.Where(a => a.GRAFIK_ID == 2).GroupBy(a => a.EGRI_TIPI).OrderBy(a => a.Key).ToList();
                bool viscositeEslestiMiQL = (viscositilerQL.Where(a => a.Key == viscosity).Count() > 0);

                var kucukKontrolQL = viscositilerQL.Where(a => a.Key < viscosity).OrderByDescending(a => a.Key).Select(a => a.Key).FirstOrDefault();
                var buyukKontrolQL = viscositilerQL.Where(a => a.Key > viscosity).OrderBy(a => a.Key).Select(a => a.Key).FirstOrDefault();
                if (viscositeEslestiMiQL == false && (kucukKontrolQL != null && buyukKontrolQL != null))
                {
                    int kucukViscosityDegeri = 0;
                    int buyukViscosityDegeri = 0;

                    decimal KucukViscositySonuc = 0;
                    decimal BuyukViscositySonuc = 0;
                    decimal OrtalamaSonuc = 0;

                    var kucuk = viscositilerQL.Where(a => a.Key < viscosity).OrderByDescending(a => a.Key).Select(a => a.Key).FirstOrDefault();
                    if (kucuk == null)//demekkki en küçük değer direk viscosityi bu kabul edilir.
                    {
                        kucukViscosityDegeri = INT_CONTROL(viscositilerQL.Select(a => a.Key).FirstOrDefault());
                    }
                    else
                    {
                        kucukViscosityDegeri = INT_CONTROL(kucuk);
                    }

                    var buyuk = viscositilerQL.Where(a => a.Key > viscosity).OrderBy(a => a.Key).Select(a => a.Key).FirstOrDefault();
                    if (buyuk == null)//demekkki en büyük değer
                    {
                        buyukViscosityDegeri = INT_CONTROL(viscositilerQL.Select(a => a.Key).LastOrDefault());
                    }
                    else
                    {
                        buyukViscosityDegeri = INT_CONTROL(buyuk);
                    }

                    //viscositiy ortalama hesabı
                    OrtalamaSonuc = (kucukViscosityDegeri + buyukViscosityDegeri) / viscosity;

                    //hesap bitti

                    //önce küçük olanın işlemi
                    var QL_Grafik_Sonucu = pompaEgrileri.Where(a => a.GRAFIK_ID == 2 && a.DEGER_1 == plessure && a.EGRI_TIPI == kucukViscosityDegeri).FirstOrDefault();
                    if (QL_Grafik_Sonucu != null)//tam bir kayıt eşleşti
                    {
                        KucukViscositySonuc = QL_Grafik_Sonucu.DEGER_2 ?? 0;
                    }
                    else
                    {
                        var QL_Grafik_Sonucu_Otelemeli = pompaEgrileri.Where(a => a.GRAFIK_ID == 2 && a.EGRI_TIPI == kucukViscosityDegeri && a.DEGER_1 > plessure).OrderBy(a => a.DEGER_1).FirstOrDefault();
                        if (QL_Grafik_Sonucu_Otelemeli==null)
                        {
                            Sonuc snc = new Sonuc();
                            snc.NPSH = "too high";
                            snc.PompaID = pompa.ID;
                            snc.PompaIsim = pompa.POMPA_ADI;
                            snc.Power = "too high";
                            snc.Speed = "too high";
                            snc.SorunsuzMu = false;
                            SonDegerler.Add(snc);
                            continue;
                        }
                        else
                        {
                            KucukViscositySonuc = QL_Grafik_Sonucu_Otelemeli.DEGER_2 ?? 0;
                        }
                        
                    }
                    //işlem bitti

                    //büyük olanın işlemi
                    var QL_Grafik_SonucuBuyuk = pompaEgrileri.Where(a => a.GRAFIK_ID == 2 && a.DEGER_1 == plessure && a.EGRI_TIPI == buyukViscosityDegeri).FirstOrDefault();
                    if (QL_Grafik_SonucuBuyuk != null)//tam bir kayıt eşleşti
                    {
                        BuyukViscositySonuc = QL_Grafik_SonucuBuyuk.DEGER_2 ?? 0;
                    }
                    else
                    {
                        var QL_Grafik_Sonucu_OtelemeliBuyuk = pompaEgrileri.Where(a => a.GRAFIK_ID == 2 && a.EGRI_TIPI == buyukViscosityDegeri && a.DEGER_1 > plessure).OrderBy(a => a.DEGER_1).FirstOrDefault();
                        if (QL_Grafik_Sonucu_OtelemeliBuyuk == null)
                        {
                            Sonuc snc = new Sonuc();
                            snc.NPSH = "too high";
                            snc.PompaID = pompa.ID;
                            snc.PompaIsim = pompa.POMPA_ADI;
                            snc.Power = "too high";
                            snc.Speed = "too high";
                            snc.SorunsuzMu = false;
                            SonDegerler.Add(snc);
                            continue;
                        }
                        else
                        {
                            BuyukViscositySonuc = QL_Grafik_Sonucu_OtelemeliBuyuk.DEGER_2 ?? 0;
                        }
                    }
                    //işlem bitti

                    qlDegeriValue = (BuyukViscositySonuc + KucukViscositySonuc) / OrtalamaSonuc;
                }
                else if (viscositeEslestiMiQL == false && (kucukKontrolQL != null || buyukKontrolQL != null))
                {
                    if (kucukKontrolQL == null)//demekki en küçük değer
                    {

                        int yeniViscosity = viscositilerQL.OrderBy(a => a.Key).Select(a => a.Key).FirstOrDefault() ?? 0;
                        var QL_Grafik_Sonucu = pompaEgrileri.Where(a => a.GRAFIK_ID == 2 && a.DEGER_1 == plessure && a.EGRI_TIPI == yeniViscosity).FirstOrDefault();
                        if (QL_Grafik_Sonucu != null)//tam bir kayıt eşleşti
                        {
                            qlDegeriValue = QL_Grafik_Sonucu.DEGER_2 ?? 0;
                        }
                        else
                        {
                            var QL_Grafik_Sonucu_Otelemeli = pompaEgrileri.Where(a => a.GRAFIK_ID == 2 && a.EGRI_TIPI == yeniViscosity && a.DEGER_1 > plessure).OrderBy(a => a.DEGER_1).FirstOrDefault();
                            if (QL_Grafik_Sonucu_Otelemeli == null)//demekki en büyük
                            {
                                qlDegeriValue = QL_Grafik_Sonucu_Otelemeli.DEGER_2 ?? 0;
                            }
                            else
                            {
                                qlDegeriValue = (pompaEgrileri.Where(a => a.GRAFIK_ID == 2 && a.EGRI_TIPI == yeniViscosity).OrderBy(a => a.DEGER_1).Select(a => a.DEGER_2).LastOrDefault()) ?? 0;
                            }

                        }
                    }
                    else
                    {
                        int yeniViscosity = viscositilerQL.OrderByDescending(a => a.Key).Select(a => a.Key).FirstOrDefault() ?? 0;
                        var QL_Grafik_Sonucu = pompaEgrileri.Where(a => a.GRAFIK_ID == 2 && a.DEGER_1 == plessure && a.EGRI_TIPI == yeniViscosity).FirstOrDefault();
                        if (QL_Grafik_Sonucu != null)//tam bir kayıt eşleşti
                        {
                            qlDegeriValue = QL_Grafik_Sonucu.DEGER_2 ?? 0;
                        }
                        else
                        {
                            var QL_Grafik_Sonucu_Otelemeli = pompaEgrileri.Where(a => a.GRAFIK_ID == 2 && a.EGRI_TIPI == yeniViscosity && a.DEGER_1 > plessure).OrderBy(a => a.DEGER_1).FirstOrDefault();
                            if (QL_Grafik_Sonucu_Otelemeli == null)//demekki en büyük
                            {
                                qlDegeriValue = QL_Grafik_Sonucu_Otelemeli.DEGER_2 ?? 0;
                            }
                            else
                            {
                                qlDegeriValue = (pompaEgrileri.Where(a => a.GRAFIK_ID == 2 && a.EGRI_TIPI == yeniViscosity).OrderBy(a => a.DEGER_1).Select(a => a.DEGER_2).LastOrDefault()) ?? 0;
                            }

                        }
                    }
                }
                else
                {
                    var QL_Grafik_Sonucu = pompaEgrileri.Where(a => a.GRAFIK_ID == 2 && a.DEGER_1 == plessure && a.EGRI_TIPI == viscosity).FirstOrDefault();
                    if (QL_Grafik_Sonucu != null)//tam bir kayıt eşleşti
                    {
                        qlDegeriValue = QL_Grafik_Sonucu.DEGER_2 ?? 0;
                    }
                    else
                    {
                        var QL_Grafik_Sonucu_Otelemeli = pompaEgrileri.Where(a => a.GRAFIK_ID == 2 && a.EGRI_TIPI == viscosity && a.DEGER_1 > plessure).OrderBy(a => a.DEGER_1).FirstOrDefault();
                        if (QL_Grafik_Sonucu_Otelemeli == null)//demekki en büyük
                        {
                            qlDegeriValue = QL_Grafik_Sonucu_Otelemeli.DEGER_2 ?? 0;
                        }
                        else
                        {
                            qlDegeriValue = (pompaEgrileri.Where(a => a.GRAFIK_ID == 2 && a.DEGER_1 > plessure && a.EGRI_TIPI == viscosity).OrderBy(a => a.DEGER_1).Select(a => a.DEGER_2).LastOrDefault()) ?? 0;
                        }

                    }
                }

                #endregion
                decimal qth_Debi = qlDegeriValue + flow;

                if (pompa.MAX_Q<qth_Debi)
                {
                    Sonuc snc = new Sonuc();
                    snc.NPSH = "too high";
                    snc.PompaID = pompa.ID;
                    snc.PompaIsim = pompa.POMPA_ADI;
                    snc.Power = "too high";
                    snc.Speed = "too high";
                    snc.SorunsuzMu = false;
                    SonDegerler.Add(snc);
                    continue;
                }

                #region qTH grafiği işlemleri
                decimal n_hiz = 0;
                var QTH_Grafik_Sonucu = pompaEgrileri.Where(a => a.GRAFIK_ID == 1 && a.DEGER_2 == qth_Debi).FirstOrDefault();
                if (QTH_Grafik_Sonucu != null)//tam bir kayıt eşleşti
                {
                    n_hiz = QTH_Grafik_Sonucu.DEGER_1 ?? 0;
                }
                else
                {
                    var QTH_Grafik_Sonucu_Otelemeli = pompaEgrileri.Where(a => a.GRAFIK_ID == 1 && a.DEGER_2 > qth_Debi).OrderBy(a => a.DEGER_2).FirstOrDefault();
                    if (QTH_Grafik_Sonucu_Otelemeli != null)//demekki en büyük
                    {
                        n_hiz = QTH_Grafik_Sonucu_Otelemeli.DEGER_1 ?? 0;
                    }
                    else
                    {
                        n_hiz = (pompaEgrileri.Where(a => a.GRAFIK_ID == 1).OrderBy(a => a.DEGER_2).Select(a => a.DEGER_1).LastOrDefault()) ?? 0;
                    }



                }
                Sonuc_Speed = n_hiz;
                #endregion

                if (Sonuc_Speed > 999)
                {
                    Sonuc_NPSH = 0;
                    Sonuc_Power = 0;
                }
                else
                {

                    #region NPSH grafiği işlemleri
                    decimal npsh_ = 0;

                    var viscositilerNPSH = pompaEgrileri.Where(a => a.GRAFIK_ID == 5).GroupBy(a => a.EGRI_TIPI).OrderBy(a => a.Key).ToList();
                    bool viscositeEslestiMiNPSH = (viscositilerNPSH.Where(a => a.Key == viscosity).Count() > 0);
                    var kucukKontrolNPSH = viscositilerNPSH.Where(a => a.Key < viscosity).OrderByDescending(a => a.Key).Select(a => a.Key).FirstOrDefault();
                    var buyukKontrolNPSH = viscositilerNPSH.Where(a => a.Key > viscosity).OrderBy(a => a.Key).Select(a => a.Key).FirstOrDefault();

                    if (viscositeEslestiMiNPSH == false && (kucukKontrolNPSH != null && buyukKontrolNPSH != null))
                    {
                        int kucukViscosityDegeri = 0;
                        int buyukViscosityDegeri = 0;

                        decimal KucukViscositySonuc = 0;
                        decimal BuyukViscositySonuc = 0;
                        decimal OrtalamaSonuc = 0;

                        var kucuk = viscositilerNPSH.Where(a => a.Key < viscosity).OrderByDescending(a => a.Key).Select(a => a.Key).FirstOrDefault();
                        if (kucuk == null)//demekkki en küçük değer
                        {
                            kucukViscosityDegeri = INT_CONTROL(viscositilerNPSH.Select(a => a.Key).FirstOrDefault());
                        }
                        else
                        {
                            kucukViscosityDegeri = INT_CONTROL(kucuk);
                        }

                        var buyuk = viscositilerNPSH.Where(a => a.Key > viscosity).OrderBy(a => a.Key).Select(a => a.Key).FirstOrDefault();
                        if (buyuk == null)//demekkki en büyük değer
                        {
                            buyukViscosityDegeri = INT_CONTROL(viscositilerNPSH.Select(a => a.Key).LastOrDefault());
                        }
                        else
                        {
                            buyukViscosityDegeri = INT_CONTROL(kucuk);
                        }

                        //viscositiy ortalama hesabı
                        OrtalamaSonuc = (kucukViscosityDegeri + buyukViscosityDegeri) / viscosity;

                        //hesap bitti

                        //önce küçük olanın işlemi
                        var NPSH_Grafik_Sonucu = pompaEgrileri.Where(a => a.GRAFIK_ID == 5 && a.DEGER_1 == Sonuc_Speed && a.EGRI_TIPI == kucukViscosityDegeri).FirstOrDefault();
                        if (NPSH_Grafik_Sonucu != null)//tam bir kayıt eşleşti
                        {
                            KucukViscositySonuc = NPSH_Grafik_Sonucu.DEGER_2 ?? 0;
                        }
                        else
                        {
                            var NPSH_Grafik_Sonucu_Otelemeli = pompaEgrileri.Where(a => a.GRAFIK_ID == 5 && a.EGRI_TIPI == kucukViscosityDegeri && a.DEGER_1 > Sonuc_Speed).OrderBy(a => a.DEGER_1).FirstOrDefault();
                            if (NPSH_Grafik_Sonucu_Otelemeli==null)
                            {
                                Sonuc snc = new Sonuc();
                                snc.NPSH = "too high";
                                snc.PompaID = pompa.ID;
                                snc.PompaIsim = pompa.POMPA_ADI;
                                snc.Power = "too high";
                                snc.Speed = "too high";
                                snc.SorunsuzMu = false;
                                SonDegerler.Add(snc);
                                continue;
                            }
                            else
                            {
                                KucukViscositySonuc = NPSH_Grafik_Sonucu_Otelemeli.DEGER_2 ?? 0;
                            }
                            
                        }
                        //işlem bitti

                        //büyük olanın işlemi
                        var NPSH_Grafik_SonucuBuyuk = pompaEgrileri.Where(a => a.GRAFIK_ID == 5 && a.DEGER_1 == Sonuc_Speed && a.EGRI_TIPI == buyukViscosityDegeri).FirstOrDefault();
                        if (NPSH_Grafik_SonucuBuyuk != null)//tam bir kayıt eşleşti
                        {
                            BuyukViscositySonuc = NPSH_Grafik_SonucuBuyuk.DEGER_2 ?? 0;
                        }
                        else
                        {
                            var NPSH_Grafik_Sonucu_OtelemeliBuyuk = pompaEgrileri.Where(a => a.GRAFIK_ID == 5 && a.EGRI_TIPI == buyukViscosityDegeri && a.DEGER_1 > Sonuc_Speed).OrderBy(a => a.DEGER_1).FirstOrDefault();
                            if (NPSH_Grafik_Sonucu_OtelemeliBuyuk == null)
                            {
                                Sonuc snc = new Sonuc();
                                snc.NPSH = "too high";
                                snc.PompaID = pompa.ID;
                                snc.PompaIsim = pompa.POMPA_ADI;
                                snc.Power = "too high";
                                snc.Speed = "too high";
                                snc.SorunsuzMu = false;
                                SonDegerler.Add(snc);
                                continue;
                            }
                            else
                            {
                                BuyukViscositySonuc = NPSH_Grafik_Sonucu_OtelemeliBuyuk.DEGER_2 ?? 0;
                            }
                        }
                        //işlem bitti

                        npsh_ = (BuyukViscositySonuc + KucukViscositySonuc) / OrtalamaSonuc;
                    }
                    else if (viscositeEslestiMiNPSH == false && (kucukKontrolNPSH != null || buyukKontrolNPSH != null))
                    {
                        if (kucukKontrolNPSH == null)
                        {
                            int yeniViscosity = viscositilerNPSH.OrderBy(a => a.Key).Select(a => a.Key).FirstOrDefault() ?? 0;
                            var NPSH_Grafik_Sonucu = pompaEgrileri.Where(a => a.GRAFIK_ID == 5 && a.DEGER_1 == Sonuc_Speed && a.EGRI_TIPI == yeniViscosity).FirstOrDefault();
                            if (NPSH_Grafik_Sonucu != null)//tam bir kayıt eşleşti
                            {
                                npsh_ = NPSH_Grafik_Sonucu.DEGER_2 ?? 0;
                            }
                            else
                            {
                                var NPSH_Grafik_Sonucu_Otelemeli = pompaEgrileri.Where(a => a.GRAFIK_ID == 5 && a.EGRI_TIPI == yeniViscosity && a.DEGER_1 > Sonuc_Speed).OrderBy(a => a.DEGER_2).FirstOrDefault();
                                if (NPSH_Grafik_Sonucu_Otelemeli == null)//demekki en büyük
                                {
                                    npsh_ = NPSH_Grafik_Sonucu_Otelemeli.DEGER_2 ?? 0;
                                }
                                else
                                {
                                    npsh_ = (pompaEgrileri.Where(a => a.GRAFIK_ID == 2 && a.EGRI_TIPI == yeniViscosity).OrderBy(a => a.DEGER_1).Select(a => a.DEGER_2).LastOrDefault()) ?? 0;
                                }

                            }
                        }
                        else
                        {
                            int yeniViscosity = viscositilerNPSH.OrderByDescending(a => a.Key).Select(a => a.Key).FirstOrDefault() ?? 0;
                            var NPSH_Grafik_Sonucu = pompaEgrileri.Where(a => a.GRAFIK_ID == 5 && a.DEGER_1 == Sonuc_Speed && a.EGRI_TIPI == yeniViscosity).FirstOrDefault();
                            if (NPSH_Grafik_Sonucu != null)//tam bir kayıt eşleşti
                            {
                                npsh_ = NPSH_Grafik_Sonucu.DEGER_2 ?? 0;
                            }
                            else
                            {
                                var NPSH_Grafik_Sonucu_Otelemeli = pompaEgrileri.Where(a => a.GRAFIK_ID == 5 && a.EGRI_TIPI == yeniViscosity && a.DEGER_1 > Sonuc_Speed).OrderBy(a => a.DEGER_2).FirstOrDefault();
                                if (NPSH_Grafik_Sonucu_Otelemeli == null)//demekki en büyük
                                {
                                    npsh_ = NPSH_Grafik_Sonucu_Otelemeli.DEGER_2 ?? 0;
                                }
                                else
                                {
                                    npsh_ = (pompaEgrileri.Where(a => a.GRAFIK_ID == 2 && a.EGRI_TIPI == yeniViscosity).OrderBy(a => a.DEGER_1).Select(a => a.DEGER_2).LastOrDefault()) ?? 0;
                                }

                            }
                        }
                    }
                    else
                    {
                        var NPSH_Grafik_Sonucu = pompaEgrileri.Where(a => a.GRAFIK_ID == 5 && a.DEGER_1 == Sonuc_Speed && a.EGRI_TIPI == viscosity).FirstOrDefault();
                        if (NPSH_Grafik_Sonucu != null)//tam bir kayıt eşleşti
                        {
                            npsh_ = NPSH_Grafik_Sonucu.DEGER_2 ?? 0;
                        }
                        else
                        {
                            var NPSH_Grafik_Sonucu_Otelemeli = pompaEgrileri.Where(a => a.GRAFIK_ID == 5 && a.EGRI_TIPI == viscosity & a.DEGER_1 > Sonuc_Speed).OrderBy(a => a.DEGER_1).FirstOrDefault();
                            if (NPSH_Grafik_Sonucu_Otelemeli != null)//demekki en büyük
                            {
                                npsh_ = NPSH_Grafik_Sonucu_Otelemeli.DEGER_2 ?? 0;
                            }
                            else
                            {
                                npsh_ = pompaEgrileri.Where(a => a.GRAFIK_ID == 5 && a.EGRI_TIPI == viscosity).OrderByDescending(a => a.DEGER_1).Select(a => a.DEGER_2).LastOrDefault() ?? 0;
                            }

                        }
                    }


                    Sonuc_NPSH = npsh_;
                    #endregion

                    #region PTH grafiği işlemleri
                    decimal pth_ = 0;
                    var PTH_Grafik_Sonucu = pompaEgrileri.Where(a => a.GRAFIK_ID == 4 && a.DEGER_1 == Sonuc_Speed && a.EGRI_TIPI == plessure).FirstOrDefault();
                    if (PTH_Grafik_Sonucu != null)//tam bir kayıt eşleşti
                    {
                        pth_ = PTH_Grafik_Sonucu.DEGER_2 ?? 0;
                    }
                    else
                    {
                        var PTH_Grafik_Sonucu_Otelemeli = pompaEgrileri.Where(a => a.GRAFIK_ID == 4 && a.EGRI_TIPI == plessure & a.DEGER_1 > Sonuc_Speed).OrderBy(a => a.DEGER_1).FirstOrDefault();
                        if (PTH_Grafik_Sonucu_Otelemeli != null)
                        {
                            pth_ = PTH_Grafik_Sonucu_Otelemeli.DEGER_2 ?? 0;
                        }
                        else
                        {
                            pth_ = pompaEgrileri.Where(a => a.GRAFIK_ID == 4 && a.EGRI_TIPI == plessure).OrderBy(a => a.DEGER_1).Select(a => a.DEGER_2).LastOrDefault() ?? 0;
                        }

                    }
                    #endregion

                    #region PV grafiği işlemleri
                    decimal pv_ = 0;

                    var viscositilerPV = pompaEgrileri.Where(a => a.GRAFIK_ID == 3).GroupBy(a => a.EGRI_TIPI).OrderBy(a => a.Key).ToList();
                    bool viscositeEslestiMiPV = (viscositilerPV.Where(a => a.Key == viscosity).Count() > 0);

                    var kucukKontrolPV = viscositilerPV.Where(a => a.Key < viscosity).OrderByDescending(a => a.Key).Select(a => a.Key).FirstOrDefault();
                    var buyukKontrolPV = viscositilerPV.Where(a => a.Key > viscosity).OrderBy(a => a.Key).Select(a => a.Key).FirstOrDefault();


                    if (viscositeEslestiMiPV == false && (kucukKontrolPV != null && buyukKontrolPV != null))
                    {
                        int kucukViscosityDegeri = 0;
                        int buyukViscosityDegeri = 0;

                        decimal KucukViscositySonuc = 0;
                        decimal BuyukViscositySonuc = 0;
                        decimal OrtalamaSonuc = 0;


                        var kucuk = viscositilerPV.Where(a => a.Key < viscosity).OrderByDescending(a => a.Key).Select(a => a.Key).FirstOrDefault();
                        if (kucuk == null)//demekkki en küçük değer
                        {
                            kucukViscosityDegeri = INT_CONTROL(viscositilerPV.Select(a => a.Key).FirstOrDefault());
                        }
                        else
                        {
                            kucukViscosityDegeri = INT_CONTROL(kucuk);
                        }

                        var buyuk = viscositilerPV.Where(a => a.Key > viscosity).OrderBy(a => a.Key).Select(a => a.Key).LastOrDefault();
                        if (buyuk == null)//demekkki en büyük değer
                        {
                            buyukViscosityDegeri = INT_CONTROL(viscositilerPV.Select(a => a.Key).LastOrDefault());
                        }
                        else
                        {
                            buyukViscosityDegeri = INT_CONTROL(kucuk);
                        }

                        //viscositiy ortalama hesabı
                        OrtalamaSonuc = (kucukViscosityDegeri + buyukViscosityDegeri) / viscosity;

                        var PV_Grafik_Sonucu = pompaEgrileri.Where(a => a.GRAFIK_ID == 3 && a.DEGER_1 == Sonuc_Speed && a.EGRI_TIPI == kucukViscosityDegeri).FirstOrDefault();
                        if (PV_Grafik_Sonucu != null)//tam bir kayıt eşleşti
                        {
                            KucukViscositySonuc = PV_Grafik_Sonucu.DEGER_2 ?? 0;
                        }
                        else
                        {
                            var PV_Grafik_Sonucu_Otelemeli = pompaEgrileri.Where(a => a.GRAFIK_ID == 3 && a.EGRI_TIPI == kucukViscosityDegeri && a.DEGER_1 > Sonuc_Speed).OrderBy(a => a.DEGER_1).FirstOrDefault();
                            if (PV_Grafik_Sonucu_Otelemeli == null)
                            {
                                Sonuc snc = new Sonuc();
                                snc.NPSH = "too high";
                                snc.PompaID = pompa.ID;
                                snc.PompaIsim = pompa.POMPA_ADI;
                                snc.Power = "too high";
                                snc.Speed = "too high";
                                snc.SorunsuzMu = false;
                                SonDegerler.Add(snc);
                                continue;
                            }
                            else
                            {
                                KucukViscositySonuc = PV_Grafik_Sonucu_Otelemeli.DEGER_2 ?? 0;
                            }
                        }
                        //işlem bitti

                        //büyük olanın işlemi
                        var PV_Grafik_SonucuBuyuk = pompaEgrileri.Where(a => a.GRAFIK_ID == 3 && a.DEGER_1 == Sonuc_Speed && a.EGRI_TIPI == buyukViscosityDegeri).FirstOrDefault();
                        if (PV_Grafik_SonucuBuyuk != null)//tam bir kayıt eşleşti
                        {
                            BuyukViscositySonuc = PV_Grafik_SonucuBuyuk.DEGER_2 ?? 0;
                        }
                        else
                        {
                            var PV_Grafik_Sonucu_OtelemeliBuyuk = pompaEgrileri.Where(a => a.GRAFIK_ID == 3 && a.EGRI_TIPI == buyukViscosityDegeri && a.DEGER_1 > Sonuc_Speed).OrderBy(a => a.DEGER_1).FirstOrDefault();
                            if (PV_Grafik_Sonucu_OtelemeliBuyuk == null)
                            {
                                Sonuc snc = new Sonuc();
                                snc.NPSH = "too high";
                                snc.PompaID = pompa.ID;
                                snc.PompaIsim = pompa.POMPA_ADI;
                                snc.Power = "too high";
                                snc.Speed = "too high";
                                snc.SorunsuzMu = false;
                                SonDegerler.Add(snc);
                                continue;
                            }
                            else
                            {
                                BuyukViscositySonuc = PV_Grafik_Sonucu_OtelemeliBuyuk.DEGER_2 ?? 0;
                            }
                        }

                        pv_ = (BuyukViscositySonuc + KucukViscositySonuc) / OrtalamaSonuc;
                    }
                    else if (viscositeEslestiMiPV == false && (kucukKontrolPV != null || buyukKontrolPV != null))
                    {
                        if (kucukKontrolPV == null)//demekki en küçük değer
                        {
                            int yeniViscosity = viscositilerPV.OrderBy(a => a.Key).Select(a => a.Key).FirstOrDefault() ?? 0;
                            var PV_Grafik_Sonucu = pompaEgrileri.Where(a => a.GRAFIK_ID == 3 && a.DEGER_1 == Sonuc_Speed && a.EGRI_TIPI == yeniViscosity).FirstOrDefault();
                            if (PV_Grafik_Sonucu != null)//tam bir kayıt eşleşti
                            {
                                pv_ = PV_Grafik_Sonucu.DEGER_2 ?? 0;
                            }
                            else
                            {
                                var PV_Grafik_Sonucu_Otelemeli = pompaEgrileri.Where(a => a.GRAFIK_ID == 3 && a.EGRI_TIPI == yeniViscosity && a.DEGER_1 > Sonuc_Speed).OrderBy(a => a.DEGER_1).FirstOrDefault();
                                if (PV_Grafik_Sonucu_Otelemeli == null)//demekki en büyük
                                {
                                    pv_ = PV_Grafik_Sonucu_Otelemeli.DEGER_2 ?? 0;
                                }
                                else
                                {
                                    pv_ = (pompaEgrileri.Where(a => a.GRAFIK_ID == 3 && a.EGRI_TIPI == yeniViscosity).OrderBy(a => a.DEGER_1).Select(a => a.DEGER_2).LastOrDefault()) ?? 0;
                                }

                            }
                        }
                        else
                        {
                            int yeniViscosity = viscositilerPV.OrderByDescending(a => a.Key).Select(a => a.Key).FirstOrDefault() ?? 0;
                            var PV_Grafik_Sonucu = pompaEgrileri.Where(a => a.GRAFIK_ID == 3 && a.DEGER_1 == Sonuc_Speed && a.EGRI_TIPI == yeniViscosity).FirstOrDefault();
                            if (PV_Grafik_Sonucu != null)//tam bir kayıt eşleşti
                            {
                                pv_ = PV_Grafik_Sonucu.DEGER_2 ?? 0;
                            }
                            else
                            {
                                var PV_Grafik_Sonucu_Otelemeli = pompaEgrileri.Where(a => a.GRAFIK_ID == 3 && a.EGRI_TIPI == yeniViscosity && a.DEGER_1 > Sonuc_Speed).OrderBy(a => a.DEGER_1).FirstOrDefault();
                                if (PV_Grafik_Sonucu_Otelemeli == null)//demekki en büyük
                                {
                                    pv_ = PV_Grafik_Sonucu_Otelemeli.DEGER_2 ?? 0;
                                }
                                else
                                {
                                    pv_ = (pompaEgrileri.Where(a => a.GRAFIK_ID == 3 && a.EGRI_TIPI == yeniViscosity).OrderBy(a => a.DEGER_1).Select(a => a.DEGER_2).LastOrDefault()) ?? 0;
                                }

                            }
                        }
                    }
                    else
                    {
                        var PV_Grafik_Sonucu = pompaEgrileri.Where(a => a.GRAFIK_ID == 3 && a.DEGER_1 == Sonuc_Speed && a.EGRI_TIPI == viscosity).FirstOrDefault();
                        if (PV_Grafik_Sonucu != null)//tam bir kayıt eşleşti
                        {
                            pv_ = PV_Grafik_Sonucu.DEGER_2 ?? 0;
                        }
                        else
                        {
                            var PV_Grafik_Sonucu_Otelemeli = pompaEgrileri.Where(a => a.GRAFIK_ID == 3 && a.EGRI_TIPI == viscosity & a.DEGER_1 > Sonuc_Speed).OrderBy(a => a.DEGER_1).FirstOrDefault();
                            if (PV_Grafik_Sonucu != null)
                            {
                                pv_ = PV_Grafik_Sonucu_Otelemeli.DEGER_2 ?? 0;
                            }
                            else
                            {
                                pv_ = pompaEgrileri.Where(a => a.GRAFIK_ID == 3 && a.EGRI_TIPI == viscosity).OrderBy(a => a.DEGER_1).Select(a => a.DEGER_2).LastOrDefault() ?? 0;
                            }

                        }
                    }


                    Sonuc_Power = pv_ + pth_;
                    #endregion
                }





                if (Sonuc_Speed>999)
                {
                    Sonuc snc = new Sonuc();
                    snc.NPSH = "too high";
                    snc.PompaID = pompa.ID;
                    snc.PompaIsim = pompa.POMPA_ADI;
                    snc.Power = "too high";
                    snc.Speed = "too high";
                    snc.SorunsuzMu = false;
                    SonDegerler.Add(snc);
                }
                else
                {
                    Sonuc snc = new Sonuc();
                    snc.NPSH = DecimalCevir(Sonuc_NPSH);
                    snc.PompaID = pompa.ID;
                    snc.PompaIsim = pompa.POMPA_ADI;
                    snc.Power = DecimalCevir(Sonuc_Power);
                    snc.Speed = DecimalCevir(Sonuc_Speed);
                    snc.SorunsuzMu = true;
                    SonDegerler.Add(snc);
                }

                
            }

            return Json(SonDegerler, JsonRequestBehavior.AllowGet);


        }

        public string DecimalCevir(decimal deger)
        {
            string sonuc = "";
            if (deger.ToString().Contains(","))
            {
                var liste = deger.ToString().Split(',');
                sonuc = liste[0] +","+ liste[1].Substring(0, 2);
            }

            return sonuc.Replace(",00", String.Empty);


        }

        public static int INT_CONTROL(object get)
        {
            int RETURN = 0;
            try
            {
                if (get != null)
                {
                    RETURN = Int32.Parse(get.ToString());
                }
                else
                {
                    RETURN = 0;
                }
            }
            catch (Exception)
            {
                RETURN = 0;
            }
            return RETURN;
        }
    }
}