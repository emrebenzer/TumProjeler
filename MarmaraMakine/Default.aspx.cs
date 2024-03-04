using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.UI.HtmlControls;
using System.Web.Security;

namespace MarmaraMakine
{
    public partial class HomePage : System.Web.UI.Page
    {
        public static string dil = "";
        Metotlar mtt = new Metotlar();

        //public string dil = "";
        public string browser = "";

        protected void Page_Load(object sender, EventArgs e)
        {

            if (IsPostBack)
            {
                return;
            }

            //MembershipCreateStatus createStatus;
            //MembershipUser newUser = Membership.CreateUser("MarmaraMakinaAdmin", "Marmara123", "website@marmaramakina.com", "deneme", "deneme3", true, out createStatus);

            //var mu = Membership.GetAllUsers();


            //MembershipUser mu = Membership.GetUser("MarmaraMakina");
            //string newPassword = mu.ResetPassword();

            browser = (Request.Browser.Type.ToLower().Contains("firefox") ? "FF" : "CH");


            Page.Title = "Marmara Makina Kalıp Mühendislik ve Mümessillik Sanayi Ticaret A.Ş.";

            HtmlMeta metaDescription = new HtmlMeta();
            metaDescription.Name = "description";
            metaDescription.Content = "Marmara Makina Kalıp Mühendislik ve Mümessillik Sanayi Ticaret A.Ş. - Teneke Kutu Üretimi, Kavanoz Kapağı Üretimi, Pet ve Plastik Şişe Üretimi ve Mühendislik Hizmetleri.";
            Page.Header.Controls.Add(metaDescription);
            HtmlMeta metaKeywords = new HtmlMeta();
            metaKeywords.Name = "keywords";
            metaKeywords.Content = "marmara,makina,makine,marmara makina,marmara makine, mühendislik hizmetleri, kalıp, cnc pres, contalama, pet, plastik, üretim,kavanoz kapağı,yedek parça, torna,servo,teneke kutu,balya,silivri,semizkumlar,sarıbekir,saribekir";
            Page.Header.Controls.Add(metaKeywords);



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
            mtt.ParametresizRepeaterDoldurma(rptSlayt, "sp_Slaytlar");
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
                        lblHakkimizdaBaslik.Text = rdr[2].ToString();
                        lblHakkimizdaIcerik.Text = rdr[4].ToString().Substring(0, 675) + "...";
                        lblAdres.Text = rdr[8].ToString();
                    }
                    else
                    {
                        lblHakkimizdaBaslik.Text = rdr[1].ToString();
                        lblHakkimizdaIcerik.Text = rdr[3].ToString().Substring(0, 600) + "...";
                        lblAdres.Text = rdr[7].ToString();
                    }

                    lblTelefon.Text = rdr[5].ToString();
                    lblFax.Text = rdr[6].ToString();

                }


                rdr.Close();
                cnn.Close();
            }
            catch
            {


            }

        }

        protected void btnAra_Click(object sender, EventArgs e)
        {
            Response.Redirect("Search.aspx?lang=" + dil + "&&kelime=" + txtArama.Text);
        }
    }
}