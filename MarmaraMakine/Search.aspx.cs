using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI.HtmlControls;

namespace MarmaraMakine
{
    public partial class Search : System.Web.UI.Page
    {
        public static string kelime = "";
        public string browser = "";
        public static string dil = "";

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
            kelime = Request.QueryString["kelime"];

            Page.Title = "Marmara Makina Kalıp Mühendislik ve Mümessillik Sanayi Ticaret A.Ş.";

            HtmlMeta metaDescription = new HtmlMeta();
            metaDescription.Name = "description";
            metaDescription.Content = "Marmara Makina Kalıp Mühendislik ve Mümessillik Sanayi Ticaret A.Ş. - Teneke Kutu Üretimi, Kavanoz Kapağı Üretimi, Pet ve Plastik Şişe Üretimi ve Mühendislik Hizmetleri.";
            Page.Header.Controls.Add(metaDescription);
            HtmlMeta metaKeywords = new HtmlMeta();
            metaKeywords.Name = "keywords";
            metaKeywords.Content = "marmara,makina,makine,marmara makina,marmara makine, mühendislik hizmetleri, kalıp, cnc pres, contalama, pet, plastik, üretim,kavanoz kapağı,yedek parça, torna,servo,teneke kutu,balya,silivri,semizkumlar,sarıbekir,saribekir";
            Page.Header.Controls.Add(metaKeywords);

            try
            {
                AramaListele(rptAramaSonuc, "sp_Arama", Request.QueryString["kelime"].Replace("%20", " "), dil);
            }
            catch
            {

            }




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
                    }
                    else
                    {

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

        public void AramaListele(Repeater rpt, string prosedurismi, string kelime, string dil)
        {
            try
            {
                SqlConnection cnn = new SqlConnection(Baglanti.Connection);
                SqlDataAdapter adp = new SqlDataAdapter("exec " + prosedurismi + " " + kelime + "," + dil, cnn);
                cnn.Open();

                DataTable dt = new DataTable();
                adp.Fill(dt);
                if (dt.Rows.Count < 1)
                {
                    if (dil == "EN")
                    {
                        lblBos.Text = "\"" + Request.QueryString["kelime"] + "\" is not found.";
                    }
                    else
                    {

                        lblBos.Text = "\"" + Request.QueryString["kelime"] + "\" kelimesine ait uygun bir sonuç bulunamadı.";
                    }

                }
                rpt.DataSource = dt;
                rpt.DataBind();

                cnn.Close();
            }
            catch
            {
                if (dil == "EN")
                {
                    lblBos.Text = "Not found.";
                }
                else
                {

                    lblBos.Text = "Uygun bir sonuç bulunamadı.";
                }
            }

        }
    }
}