using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Web.UI.HtmlControls;

namespace MarmaraMakine
{
    public partial class Information : System.Web.UI.Page
    {
        public static string dil = "";
        public string browser = "";
        Metotlar mtt = new Metotlar();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                return;
            }

            browser = (Request.Browser.Type.ToLower().Contains("firefox") ? "FF" : "CH");
            dil = Request.QueryString["lang"] ?? "TR";
            if (dil == "EN")
            {
                txtArama.Text = "Search";
            }
            else
                txtArama.Text = "Ara";

            SirketBilgileriGetir();
            mtt.TekParametreliRepeaterDoldurma(rptGovdeUretim, "sp_MakineCek", 1);
            mtt.TekParametreliRepeaterDoldurma(rptKapatmaHatti, "sp_MakineCek", 2);
            mtt.TekParametreliRepeaterDoldurma(rptKavanozKapagiKapatma, "sp_MakineCek", 3);
            mtt.TekParametreliRepeaterDoldurma(rptPetPlastik, "sp_MakineCek", 4);
            mtt.TekParametreliRepeaterDoldurma(rptMuhendislik, "sp_MakineCek", 5);
            Page.Title = "Marmara Makina Kalıp Mühendislik ve Mümessillik Sanayi Ticaret A.Ş.";

            HtmlMeta metaDescription = new HtmlMeta();
            metaDescription.Name = "description";
            metaDescription.Content = "Marmara Makina Kalıp Mühendislik ve Mümessillik Sanayi Ticaret A.Ş. - Teneke Kutu Üretimi, Kavanoz Kapağı Üretimi, Pet ve Plastik Şişe Üretimi ve Mühendislik Hizmetleri.";
            Page.Header.Controls.Add(metaDescription);
            HtmlMeta metaKeywords = new HtmlMeta();
            metaKeywords.Name = "keywords";
            metaKeywords.Content = "marmara,makina,makine,marmara makina,marmara makine, mühendislik hizmetleri, kalıp, cnc pres, contalama, pet, plastik, üretim,kavanoz kapağı,yedek parça, torna,servo,teneke kutu,balya,silivri,semizkumlar,sarıbekir,saribekir";
            Page.Header.Controls.Add(metaKeywords);


        }

        protected void btnAra_Click(object sender, EventArgs e)
        {
            Response.Redirect("Search.aspx?lang=" + dil + "&&kelime=" + txtArama.Text);
        }

        public void SirketBilgileriGetir()
        {
            try
            {


                SqlConnection cnn = new SqlConnection(Baglanti.Connection);
                SqlCommand cmd = new SqlCommand("exec sp_SirketBilgileri", cnn);
                cnn.Open();

                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    if (Request.QueryString["lang"] == "EN")
                    {

                        lblAdres.Text = rdr[8].ToString();
                        lblAdres2.Text = rdr[8].ToString();
                        btnGonder.Text = "Send";

                    }
                    else
                    {
                        btnGonder.Text = "Gönder";
                        lblAdres.Text = rdr[7].ToString();
                        lblAdres2.Text = rdr[7].ToString();
                    }

                    lblTelefon.Text = rdr[5].ToString();
                    lblTelefon2.Text = rdr[5].ToString();
                    lblFax.Text = rdr[6].ToString();
                    lblFax2.Text = rdr[6].ToString();
                    hyper1.Text = rdr[9].ToString();
                    hyper1.NavigateUrl = "mailto:" + rdr[9].ToString();

                }

                rdr.Close();
                cnn.Close();

            }
            catch
            {


            }

        }

        protected void btnGonder_Click(object sender, EventArgs e)
        {
            EmailFormu(txtAdSoyad.Text, txtEmail.Text, txtTelefon.Text, txtFirma.Text, txtKonu.Text, txtMesaj.Text);

        }

        private void EmailFormu(string isim, string email, string telefon, string firma, string konu, string mesaj)
        {
            try
            {

                if (txtAdSoyad.Text.Length > 2 && txtMesaj.Text.Length > 10)
                {
                    SqlConnection cnn = new SqlConnection(Baglanti.Connection);
                    SqlCommand cmd = new SqlCommand("insert into Mesajlar Values (@isim,@email,@firma,@telefon,@konu,@mesaj,GETDATE())", cnn);
                    cmd.Parameters.AddWithValue("@isim", isim);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@firma", firma);
                    cmd.Parameters.AddWithValue("@telefon", telefon);
                    cmd.Parameters.AddWithValue("@konu", konu);
                    cmd.Parameters.AddWithValue("@mesaj", mesaj);

                    cnn.Open();
                    MailGonder();
                    int sayi = cmd.ExecuteNonQuery();
                    if (sayi > 0)
                    {
                        if (dil == "EN")
                        {
                            lblSonuc.Text = "Your message has ben send. Thank you.";
                        }
                        else
                        {
                            lblSonuc.Text = "Mesajınız bize ulaşmıştır.";
                        }

                        txtAdSoyad.Text = "";
                        txtEmail.Text = "";
                        txtFirma.Text = "";
                        txtKonu.Text = "";
                        txtMesaj.Text = "";
                        txtTelefon.Text = "";
                    }
                    else
                    {
                        if (dil == "EN")
                        {
                            lblSonuc.Text = "An error occured.Please try again later.";
                        }
                        else
                        {
                            lblSonuc.Text = "Bir sorun oluştu lütfen bir süre sonra tekrar deneyiniz.";
                        }

                    }
                    cnn.Close();
                }
                else
                {
                    lblSonuc.Text = "İsim ve mesaj kısmı boş geçilemez..Mesaj en az 10 karakter olmalıdır.";
                }



            }
            catch
            {
                if (dil == "EN")
                {
                    lblSonuc.Text = "An error occured.Please try again later.";
                }
                else
                {
                    lblSonuc.Text = "Bir sorun oluştu lütfen bir süre sonra tekrar deneyiniz.";
                }

            }

        }


        string SmtpPort;
        string SmtpSunucu;
        string SmtpMail;
        string KullaniciAdi;
        string Sifre;
        string GonderilecekMail;

        private void MailGonder()
        {
            try
            {
                SqlConnection cnn = new SqlConnection(Baglanti.Connection);
                SqlCommand cmd = new SqlCommand("exec sp_SirketBilgileri", cnn);
                cnn.Open();

                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    SmtpMail = rdr[10].ToString();
                    SmtpSunucu = rdr[13].ToString();
                    KullaniciAdi = rdr[11].ToString();
                    Sifre = rdr[12].ToString();
                    GonderilecekMail = rdr[14].ToString();
                    SmtpPort = "587";



                    MailMessage ePosta = new MailMessage();
                    ePosta.From = new MailAddress(SmtpMail, "Marmara Makina Web Sitesi");
                    ePosta.To.Add(GonderilecekMail);
                    ePosta.Subject = "MarmaraMakina.com'dan Mail";
                    ePosta.Body = "<b>Gonderen İsim: </b>" + txtAdSoyad.Text + "<br><br><b>Gönderen Mail: </b>" + txtEmail.Text + "<br><br><b>Firma: </b>" + txtFirma.Text + "<br><br><b>Telefon: </b>" + txtTelefon.Text + "<br><br><b>Konu: </b>" + txtKonu.Text + "<br><br><b>Mesaj: </b>" + txtMesaj.Text;

                    ePosta.IsBodyHtml = true;
                    SmtpClient smtp = new SmtpClient();
                    smtp.Credentials = new System.Net.NetworkCredential(KullaniciAdi, Sifre);
                    smtp.Port = Convert.ToInt32(SmtpPort);
                    smtp.Host = SmtpSunucu;
                    smtp.EnableSsl = true;
                    try
                    {
                        // smtp.SendAsync(ePosta, (object)ePosta);

                        smtp.Send(ePosta);


                    }
                    catch (Exception ex)
                    {

                    }

                }
                cnn.Close();
            }
            catch
            {


            }

        }
    }
}