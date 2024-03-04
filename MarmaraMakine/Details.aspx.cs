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
    public partial class Details : System.Web.UI.Page
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
            MakineBilgiler();
            mtt.TekParametreliRepeaterDoldurma(rptTeknikOzellikler, "sp_OzellikGetir", Convert.ToInt32(Request.QueryString["id"]));
            ResimDoldur(rptResimler, "sp_MakineResimCek", Convert.ToInt32(Request.QueryString["id"]));
            mtt.Yaz(Convert.ToInt32(Request.QueryString["id"]));

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

        public static bool resimVarMi = false;
        public static bool videoVarMi = false;
        public static bool katalogVarMi = false;
        public static string videoAdres = "";
        public static string katalogAdres = "";
        public void MakineBilgiler()
        {
            try
            {


                SqlConnection cnn = new SqlConnection(Baglanti.Connection);
                SqlCommand cmd = new SqlCommand("exec sp_MakineTumGetir " + Convert.ToInt32(Request.QueryString["id"]), cnn);
                cnn.Open();

                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    if (Request.QueryString["lang"] == "EN")
                    {

                        lblMakineBaslik.Text = rdr[2].ToString();
                        lblMakineIcerik.Text = rdr[4].ToString();
                        imageAnaResim.ImageUrl = "resim/makine-resim/" + rdr[5].ToString();
                        if (rdr[8].ToString() == "yok")
                        {
                            videoVarMi = false;
                        }
                        else
                        {
                            videoVarMi = true;
                            videoAdres = rdr[8].ToString();


                        }

                        if (rdr[7].ToString() == "yok")
                        {
                            katalogVarMi = false;
                        }
                        else
                        {
                            katalogVarMi = true;
                            katalogAdres = rdr[7].ToString();


                        }
                    }
                    else
                    {

                        lblMakineBaslik.Text = rdr[1].ToString();
                        lblMakineIcerik.Text = rdr[3].ToString();
                        imageAnaResim.ImageUrl = "resim/makine-resim/" + rdr[5].ToString();
                        if (rdr[8].ToString() == "yok")
                        {
                            videoVarMi = false;
                        }
                        else
                        {
                            videoVarMi = true;
                            videoAdres = rdr[8].ToString();


                        }
                        if (rdr[6].ToString() == "yok")
                        {
                            katalogVarMi = false;
                        }
                        else
                        {
                            katalogVarMi = true;
                            katalogAdres = rdr[6].ToString();


                        }
                    }



                }


                rdr.Close();
                cnn.Close();
            }
            catch
            {


            }

        }

        public void ResimDoldur(Repeater rpt, string prosedurismi, int kategoriid)
        {
            SqlConnection cnn = new SqlConnection(Baglanti.Connection);
            SqlDataAdapter adp = new SqlDataAdapter("exec " + prosedurismi + " " + kategoriid, cnn);
            SqlCommand cmd = new SqlCommand("exec " + prosedurismi + " " + kategoriid, cnn);
            cnn.Open();
            int sayi = Convert.ToInt32(cmd.ExecuteScalar());

            if (sayi > 0)
                resimVarMi = true;
            DataTable dt = new DataTable();
            adp.Fill(dt);

            rpt.DataSource = dt;
            rpt.DataBind();

            cnn.Close();

        }



    }
}