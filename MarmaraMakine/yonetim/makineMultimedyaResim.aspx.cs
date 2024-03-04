using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MarmaraMakine.yonetim
{
    public partial class makineMultimedyaResim : System.Web.UI.Page
    {
        Metotlar mtt = new Metotlar();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            { return; }
            mtt.ParametreliListboxDoldurma(listMevcut, "sp_MakineResimCek", "ResimlerID", "ResimUrl", Convert.ToInt32(Request.QueryString["id"]));
            listMevcut.SelectedIndex = 0;
            SecilenResmiGetir();
        }


        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            ResimleriAl();
        }


        string resimadi = "";
        string uzanti = "";

        public void ResimleriAl()
        {
            HttpFileCollection files = Request.Files;

            for (int i = 0; i < files.Count; i++)
            {
                HttpPostedFile file = files[i];
                if (file.ContentLength > 0)
                {
                    //resimin adı
                    string fileName = Path.GetFileName(file.FileName);

                    //resim uzantısı
                    uzanti = Path.GetExtension(file.FileName);

                    //resime atanacak yeni ad
                    resimadi = DateTime.Now.Day.ToString() + DateTime.Now.Month +
                        DateTime.Now.Year + DateTime.Now.Hour + DateTime.Now.Second +
                        DateTime.Now.Minute + DateTime.Now.Millisecond + uzanti;

                    // Orjinal resmi kaydet
                    file.SaveAs(Server.MapPath("../resim/temp/" + resimadi));


                    //****************** Yeni boyutlara göre resim oluştur ***************/

                    // orjinal resim


                    Bitmap resim = new Bitmap(Server.MapPath("../resim/temp/" + resimadi));
                    // 150px genişlikte yeni resim oluştur
                    resim = this.ResimBoyutlandir(resim, 203);
                    // oluşturulan resmi kaydet
                    resim.Save(Server.MapPath("../resim/makine-resim/kucuk/" + resimadi));

                    Bitmap resim2 = new Bitmap(Server.MapPath("../resim/temp/" + resimadi));
                    // 150px genişlikte yeni resim oluştur
                    resim2 = this.ResimBoyutlandir(resim2, 700);
                    // oluşturulan resmi kaydet
                    resim2.Save(Server.MapPath("../resim/makine-resim/buyuk/" + resimadi));

                    ResimKaydet(resimadi);



                }
            }
        }

        public Bitmap ResimBoyutlandir(Bitmap resim, int boyut)
        {
            Bitmap sresim = resim;

            using (Bitmap OrjinalResim = resim)
            {
                double yukseklik = OrjinalResim.Height;
                double genislik = OrjinalResim.Width;
                double oran = 0;

                if (genislik >= boyut || genislik <= boyut)
                {
                    oran = genislik / yukseklik;
                    genislik = boyut;
                    yukseklik = genislik / oran;

                    Size ydeger = new Size(Convert.ToInt32(genislik), Convert.ToInt32(yukseklik));
                    Bitmap yresim = new Bitmap(OrjinalResim, ydeger);

                    sresim = yresim;
                }
            }

            return sresim;
        }


        public void ResimKaydet(string resimurl)
        {
            try
            {
                SqlConnection cnn = new SqlConnection(Baglanti.Connection);
                SqlCommand cmd = new SqlCommand("exec sp_resimKaydet '" + resimurl + "'," + Convert.ToInt32(Request.QueryString["id"]), cnn);
                cnn.Open();
                int sayi = cmd.ExecuteNonQuery();
                if (sayi > 0)
                {
                    mtt.ParametreliListboxDoldurma(listMevcut, "sp_MakineResimCek", "ResimlerID", "ResimUrl", Convert.ToInt32(Request.QueryString["id"]));
                    listMevcut.SelectedIndex = 0;
                    SecilenResmiGetir();
                    panelBsr1.Visible = true;
                    panelBsr2.Visible = false;

                }
                else
                {
                    panelBsr1.Visible = false;
                    panelBsr2.Visible = true;
                }


            }
            catch
            {
                panelBsr1.Visible = false;
                panelBsr2.Visible = true;
            }

        }

        protected void Unnamed1_Click1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cnn = new SqlConnection(Baglanti.Connection);
                SqlCommand cmd = new SqlCommand("delete from Resimler where ResimlerID=" + Convert.ToInt32(listMevcut.SelectedItem.Value), cnn);
                cnn.Open();
                int sayi = cmd.ExecuteNonQuery();
                if (sayi > 0)
                {
                    panelBasarili.Visible = true;
                    panelBasarisiz.Visible = false;

                    // mtt.TekParametreliListboxDoldurma(listListele, "sp_ResimleriGoster", "SlaytID", "SlaytIsim");
                    mtt.ParametreliListboxDoldurma(listMevcut, "sp_MakineResimCek", "ResimlerID", "ResimUrl", Convert.ToInt32(Request.QueryString["id"]));
                    try
                    {
                        listMevcut.SelectedIndex = 0;
                    }
                    catch
                    {

                    }

                    SecilenResmiGetir();
                }
                else
                {
                    panelBasarili.Visible = false;
                    panelBasarisiz.Visible = true;
                }


            }
            catch
            {
                panelBasarili.Visible = false;
                panelBasarisiz.Visible = true;
            }
        }

        protected void listMevcut_SelectedIndexChanged(object sender, EventArgs e)
        {
            SecilenResmiGetir();
        }

        public void SecilenResmiGetir()
        {
            try
            {


                SqlConnection cnn = new SqlConnection(Baglanti.Connection);
                SqlCommand cmd = new SqlCommand("exec sp_MakineResimGoster " + Convert.ToInt16(listMevcut.SelectedItem.Value), cnn);
                cnn.Open();

                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    imageMevcut.ImageUrl = "../resim/makine-resim/kucuk/" + rdr[0].ToString();

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