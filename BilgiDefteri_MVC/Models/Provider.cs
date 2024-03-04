using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BilgiDefteri_MVC.Models
{
    public class Provider
    {
        
        public static List<BilgiDefteri> BilgileriGetir(int type)
        {

            AVP_BILGI_DEFTERIEntities db = new AVP_BILGI_DEFTERIEntities();
            
            List<BilgiDefteri> liste = db.BilgiDefteri.Where(p => p.Type == type).OrderBy(p=>p.Ad).ToList();

            return liste;
        
        }


        public static bool Duzenle(string ad, string icerik, int id)
        {

            AVP_BILGI_DEFTERIEntities db = new AVP_BILGI_DEFTERIEntities();

            BilgiDefteri bilgi = db.BilgiDefteri.First(p=>p.Id==id);

            bilgi.Ad = ad;
            bilgi.Icerik = icerik;
            bilgi.FirmaAdi = "";


            try
            {

                db.SaveChanges();
                return true;
            }
            catch
            {

                return false;
            }

        }







        public static bool Kaydet(string ad,string icerik,int type)
        {

            AVP_BILGI_DEFTERIEntities db = new AVP_BILGI_DEFTERIEntities();

            BilgiDefteri bilgi = new BilgiDefteri();

            bilgi.Ad = ad;
            bilgi.Icerik = icerik;
            bilgi.Type = type;
            bilgi.FirmaAdi = "";

            
            try
            {
                db.BilgiDefteri.Add(bilgi);
                db.SaveChanges();
                return true;
            }
            catch 
            {

                return false;
            }
        
        }

        public static List<kullanici> GetUser()
        {
            using (AVP_BILGI_DEFTERIEntities cnn = new AVP_BILGI_DEFTERIEntities())
            {
                List<kullanici> liste = cnn.kullanici.ToList();
                return liste;
            }
        }

        public static BilgiDefteri BilgiAyrintiGetir(int id)
        {
            AVP_BILGI_DEFTERIEntities db = new AVP_BILGI_DEFTERIEntities();
            BilgiDefteri blg = db.BilgiDefteri.First(p=> p.Id==id);

            return blg;
        
        }

        public static bool BilgiSil(int id)
        {
            AVP_BILGI_DEFTERIEntities db = new AVP_BILGI_DEFTERIEntities();
            BilgiDefteri blg = db.BilgiDefteri.First(p => p.Id == id);
            try
            {
                db.BilgiDefteri.Remove(blg);
                db.SaveChanges();
                return true;
            }
            catch
            {

                return false;
            }
            
            

        }

        public static List<BilgiDefteri> BilgileriSuz(string kelime,int type)
        {
            AVP_BILGI_DEFTERIEntities db = new AVP_BILGI_DEFTERIEntities();

            List<BilgiDefteri> liste = db.BilgiDefteri.Where(p => p.Type == type && p.Ad.Contains(kelime)).OrderBy(p => p.Ad).ToList();

            return liste;
        
        }




    }
}