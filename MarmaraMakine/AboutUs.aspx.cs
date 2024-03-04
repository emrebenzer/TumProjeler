using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.UI.HtmlControls;

namespace MarmaraMakine
{
    public partial class AboutUs : System.Web.UI.Page
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

            Page.Title = "Marmara Makina Kalıp - Hakkımızda ";

            HtmlMeta metaDescription = new HtmlMeta();
            metaDescription.Name = "description";
            metaDescription.Content = "Marmara Makina Kalıp Mühendislik ve Mümessillik Sanayi Ticaret A.Ş. - Teneke Kutu Üretimi, Kavanoz Kapağı Üretimi, Pet ve Plastik Şişe Üretimi ve Mühendislik Hizmetleri.";
            Page.Header.Controls.Add(metaDescription);
            HtmlMeta metaKeywords = new HtmlMeta();
            metaKeywords.Name = "keywords";
            metaKeywords.Content = "marmara,makina,makine,marmara makina,marmara makine, mühendislik hizmetleri, kalıp, cnc pres, contalama, pet, plastik, üretim,kavanoz kapağı,yedek parça, torna,servo,teneke kutu,balya,silivri,semizkumlar,sarıbekir,saribekir";
            Page.Header.Controls.Add(metaKeywords);

            dil = Request.QueryString["lang"];
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
                        lblHakkimizdaBaslik.Text = rdr[2].ToString();
                        lblHakkimizdaIcerik.Text = rdr[4].ToString();
                        lblAdres.Text = rdr[8].ToString();
                    }
                    else
                    {
                        lblHakkimizdaBaslik.Text = rdr[1].ToString();
                        lblHakkimizdaIcerik.Text = rdr[3].ToString();
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
    }
}