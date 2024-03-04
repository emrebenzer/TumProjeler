using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MarmaraMakine
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }




        protected void LoginButton_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = UserName.Text;
            string Sifre = Password.Text;
            string sifreCoz = Encrypt(Sifre);
            VerilerDataContext veri = new VerilerDataContext();
            var kullanici = veri.Users.Where(a => a.KullaniciAdi == kullaniciAdi && a.Sifre == sifreCoz).FirstOrDefault();
            if (kullanici != null)
            {
                Session["User"] = kullanici;
                Response.Redirect("yonetim/Default.aspx");
            }
            else
            {
                FailureText.Text = "Bilgileri Kontrol Ediniz";
            }
        }
        public string hash = "EmreBenzerMarmara";
        public string Encrypt(string sifre)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(sifre);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    return Convert.ToBase64String(results, 0, results.Length);
                }
            }
        }

        public string Decrypt(string SifrelenmisDeger)
        {
            byte[] data = Convert.FromBase64String(SifrelenmisDeger);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    return UTF8Encoding.UTF8.GetString(results);
                }
            }
        }
    }
}