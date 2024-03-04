using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;

namespace MarmaraMakine.yonetim
{
    public partial class makineDuzenle2 : System.Web.UI.Page
    {
        Metotlar mtt = new Metotlar();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                return;
            }


            MakineBilgiler();
           
            mtt.ParametreliListboxDoldurma(listOzellikler, "sp_OzellikGetirParametreli", "TID", "TISIM", Convert.ToInt32(Request.QueryString["id"]));
            mtt.ParametresizDropDownListDoldurma(ddlMevcutOzellik, "sp_MevcutOzellikGetir", "OzellikID", "OzellikIsmiTR");
        }


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
                txtTurkceIsim.Text = rdr[1].ToString();
                txtEnglishIsim.Text = rdr[2].ToString();
                ckTurkceDetay.Text = rdr[3].ToString();
                ckEnglishDetails.Text = rdr[4].ToString();
                imageAnaResim.ImageUrl = "../resim/makine-resim/" + rdr[5].ToString();

            }


            rdr.Close();
            cnn.Close();

            }
            catch 
            {

            }

        }

        public void IsimDuzenle()
        {
            try
            {

          
            SqlConnection cnn = new SqlConnection(Baglanti.Connection);
            SqlCommand cmd = new SqlCommand("exec sp_MakineDuzenleIsimIcerik " + Convert.ToInt32(Request.QueryString["id"]) + ",'" + txtTurkceIsim.Text + "','" + txtEnglishIsim.Text + "','" + ckTurkceDetay.Text + "','" + ckEnglishDetails.Text + "'", cnn);
            cnn.Open();
            int sayi = cmd.ExecuteNonQuery();
            if (sayi > 0)
            {
                pnl3.Visible = false;
                panelOzellikEkleBasarili.Visible = false;
                panelOzellikEkleBasarisiz.Visible = false;
                panelResimBasarili.Visible = false;
                panelResimBasarisiz.Visible = false;
                panelSil1.Visible = false;
                panelSil2.Visible = false;
                panelYeniOzellikBasarili.Visible = false;
                panelYeniOzellikBasarisiz.Visible = false;



                panelBsr2.Visible = false;
                panelBsr1.Visible = true;
            }
            else
            {
                pnl3.Visible = false;
                panelOzellikEkleBasarili.Visible = false;
                panelOzellikEkleBasarisiz.Visible = false;
                panelResimBasarili.Visible = false;
                panelResimBasarisiz.Visible = false;
                panelSil1.Visible = false;
                panelSil2.Visible = false;
                panelYeniOzellikBasarili.Visible = false;
                panelYeniOzellikBasarisiz.Visible = false;


                panelBsr1.Visible = false;
                panelBsr2.Visible = true;
            }


            cnn.Close();
            }
            catch 
            {
                pnl3.Visible = false;
                panelOzellikEkleBasarili.Visible = false;
                panelOzellikEkleBasarisiz.Visible = false;
                panelResimBasarili.Visible = false;
                panelResimBasarisiz.Visible = false;
                panelSil1.Visible = false;
                panelSil2.Visible = false;
                panelYeniOzellikBasarili.Visible = false;
                panelYeniOzellikBasarisiz.Visible = false;
                panelBsr2.Visible = false;
                panelBsr1.Visible = false;

                panelBsr1.Visible = false;
                panelBsr2.Visible = true;
                
            }
        }

        private void OzellikSil()
        {
            try
            {

           
            SqlConnection cnn = new SqlConnection(Baglanti.Connection);
            SqlCommand cmd = new SqlCommand("exec sp_TeknikOzellikSil " + listOzellikler.SelectedItem.Value, cnn);
            cnn.Open();
            int sayi = cmd.ExecuteNonQuery();
            if (sayi > 0)
            {
                pnl3.Visible = false;
                panelOzellikEkleBasarili.Visible = false;
                panelOzellikEkleBasarisiz.Visible = false;
                panelResimBasarili.Visible = false;
                panelResimBasarisiz.Visible = false;
                panelSil1.Visible = false;
                panelSil2.Visible = false;
                panelYeniOzellikBasarili.Visible = false;
                panelYeniOzellikBasarisiz.Visible = false;
                panelBsr2.Visible = false;
                panelBsr1.Visible = false;

                panelSil2.Visible = false;
                panelSil1.Visible = true;
                mtt.ParametreliListboxDoldurma(listOzellikler, "sp_OzellikGetirParametreli", "TID", "TISIM", Convert.ToInt32(Request.QueryString["id"]));
            }
            else
            {
                pnl3.Visible = false;
                panelOzellikEkleBasarili.Visible = false;
                panelOzellikEkleBasarisiz.Visible = false;
                panelResimBasarili.Visible = false;
                panelResimBasarisiz.Visible = false;
                panelSil1.Visible = false;
                panelSil2.Visible = false;
                panelYeniOzellikBasarili.Visible = false;
                panelYeniOzellikBasarisiz.Visible = false;
                panelBsr2.Visible = false;
                panelBsr1.Visible = false;

                panelSil1.Visible = false;
                panelSil2.Visible = true;
            }


            cnn.Close();
            }
            catch 
            {
                pnl3.Visible = false;
                panelOzellikEkleBasarili.Visible = false;
                panelOzellikEkleBasarisiz.Visible = false;
                panelResimBasarili.Visible = false;
                panelResimBasarisiz.Visible = false;
                panelSil1.Visible = false;
                panelSil2.Visible = false;
                panelYeniOzellikBasarili.Visible = false;
                panelYeniOzellikBasarisiz.Visible = false;
                panelBsr2.Visible = false;
                panelBsr1.Visible = false;

                panelSil1.Visible = false;
                panelSil2.Visible = true;
            }
        }


        private void TeknikOzellikEkle()
        {

            try
            {
                
                    seciliMi = false;
                    SqlConnection cnn = new SqlConnection(Baglanti.Connection);
                    SqlCommand cmd = new SqlCommand("exec sp_TeknikOzellikEkle " + Convert.ToInt32(Request.QueryString["id"]) + "," + ddlMevcutOzellik.SelectedItem.Value + ",'" + txtValueTR.Text + "','" + txtValueEN.Text + "'", cnn);
                    cnn.Open();
                    int sayi = cmd.ExecuteNonQuery();
                    if (sayi > 0)
                    {
                        pnl3.Visible = false;
                        panelOzellikEkleBasarili.Visible = false;
                        panelOzellikEkleBasarisiz.Visible = false;
                        panelResimBasarili.Visible = false;
                        panelResimBasarisiz.Visible = false;
                        panelSil1.Visible = false;
                        panelSil2.Visible = false;
                        panelYeniOzellikBasarili.Visible = false;
                        panelYeniOzellikBasarisiz.Visible = false;
                        panelBsr2.Visible = false;
                        panelBsr1.Visible = false;
                        mtt.ParametreliListboxDoldurma(listOzellikler, "sp_OzellikGetirParametreli", "TID", "TISIM", Convert.ToInt32(Request.QueryString["id"]));

                        panelYeniOzellikBasarili.Visible = true;
                        panelYeniOzellikBasarisiz.Visible = false;

                        
                    }
                    else
                    {

                        pnl3.Visible = false;
                        panelOzellikEkleBasarili.Visible = false;
                        panelOzellikEkleBasarisiz.Visible = false;
                        panelResimBasarili.Visible = false;
                        panelResimBasarisiz.Visible = false;
                        panelSil1.Visible = false;
                        panelSil2.Visible = false;
                        panelYeniOzellikBasarili.Visible = false;
                        panelYeniOzellikBasarisiz.Visible = false;
                        panelBsr2.Visible = false;
                        panelBsr1.Visible = false;
                        panelYeniOzellikBasarili.Visible = false;
                        panelYeniOzellikBasarisiz.Visible = true;

                    }
                    cnn.Close();
               

                
                
            }
            catch 
            {

                pnl3.Visible = false;
                panelOzellikEkleBasarili.Visible = false;
                panelOzellikEkleBasarisiz.Visible = false;
                panelResimBasarili.Visible = false;
                panelResimBasarisiz.Visible = false;
                panelSil1.Visible = false;
                panelSil2.Visible = false;
                panelYeniOzellikBasarili.Visible = false;
                panelYeniOzellikBasarisiz.Visible = false;
                panelBsr2.Visible = false;
                panelBsr1.Visible = false;
                panelYeniOzellikBasarili.Visible = false;
                panelYeniOzellikBasarisiz.Visible = true;
            }

            


            
        }

        private void OzellikEkle()
        {
            try
            {

          
            SqlConnection cnn = new SqlConnection(Baglanti.Connection);
            SqlCommand cmd = new SqlCommand("exec sp_OzellikEkle '" +txtOzellikTR.Text+"','"+txtOzellikEN.Text+"'" , cnn);
            cnn.Open();
            int sayi = cmd.ExecuteNonQuery();
            if (sayi > 0)
            {

                pnl3.Visible = false;
                panelOzellikEkleBasarili.Visible = false;
                panelOzellikEkleBasarisiz.Visible = false;
                panelResimBasarili.Visible = false;
                panelResimBasarisiz.Visible = false;
                panelSil1.Visible = false;
                panelSil2.Visible = false;
                panelYeniOzellikBasarili.Visible = false;
                panelYeniOzellikBasarisiz.Visible = false;
                panelBsr2.Visible = false;
                panelBsr1.Visible = false;

                panelOzellikEkleBasarisiz.Visible = false;
                panelOzellikEkleBasarili.Visible = true;

                btnOzelligiEkle.Visible = false;
                panelYeniOzellik1.Visible = false;
                panelYeniOzellik2.Visible = false;
                mtt.ParametresizDropDownListDoldurma(ddlMevcutOzellik, "sp_MevcutOzellikGetir", "OzellikID", "OzellikIsmiTR");
                txtValueEN.Text = "";
                txtValueTR.Text = "";

            }
            else
            {

                pnl3.Visible = false;
                panelOzellikEkleBasarili.Visible = false;
                panelOzellikEkleBasarisiz.Visible = false;
                panelResimBasarili.Visible = false;
                panelResimBasarisiz.Visible = false;
                panelSil1.Visible = false;
                panelSil2.Visible = false;
                panelYeniOzellikBasarili.Visible = false;
                panelYeniOzellikBasarisiz.Visible = false;
                panelBsr2.Visible = false;
                panelBsr1.Visible = false;
                panelOzellikEkleBasarili.Visible = false;
                panelOzellikEkleBasarisiz.Visible = true;

            }


            cnn.Close();
            }
            catch 
            {

                pnl3.Visible = false;
                panelOzellikEkleBasarili.Visible = false;
                panelOzellikEkleBasarisiz.Visible = false;
                panelResimBasarili.Visible = false;
                panelResimBasarisiz.Visible = false;
                panelSil1.Visible = false;
                panelSil2.Visible = false;
                panelYeniOzellikBasarili.Visible = false;
                panelYeniOzellikBasarisiz.Visible = false;
                panelBsr2.Visible = false;
                panelBsr1.Visible = false;
                panelOzellikEkleBasarili.Visible = false;
                panelOzellikEkleBasarisiz.Visible = true;
            }

        }



        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            IsimDuzenle();
        }

        int anaresim = 0;
        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            if (anaresim == 0)
            {
                panelAnaResim.Visible = true;
                anaresim = 1;
            }
            else
            {
                panelAnaResim.Visible = false;
                anaresim = 0;
            }

        }


        public void ResimKaydet(string resimurl)
        {
            try
            {
                SqlConnection cnn = new SqlConnection(Baglanti.Connection);
                SqlCommand cmd = new SqlCommand("exec sp_anaresimkaydet '" + resimurl + "',"+Convert.ToInt32(Request.QueryString["id"]), cnn);
                cnn.Open();
                int sayi = cmd.ExecuteNonQuery();
                if (sayi > 0)
                {
                    MakineBilgiler();
                    pnl3.Visible = false;
                    panelOzellikEkleBasarili.Visible = false;
                    panelOzellikEkleBasarisiz.Visible = false;
                    panelResimBasarili.Visible = false;
                    panelResimBasarisiz.Visible = false;
                    panelSil1.Visible = false;
                    panelSil2.Visible = false;
                    panelYeniOzellikBasarili.Visible = false;
                    panelYeniOzellikBasarisiz.Visible = false;
                    panelBsr2.Visible = false;
                    panelBsr1.Visible = false;
                    panelResimBasarili.Visible = true;
                    panelResimBasarisiz.Visible = false;

                }
                else
                {
                    pnl3.Visible = false;
                    panelOzellikEkleBasarili.Visible = false;
                    panelOzellikEkleBasarisiz.Visible = false;
                    panelResimBasarili.Visible = false;
                    panelResimBasarisiz.Visible = false;
                    panelSil1.Visible = false;
                    panelSil2.Visible = false;
                    panelYeniOzellikBasarili.Visible = false;
                    panelYeniOzellikBasarisiz.Visible = false;
                    panelBsr2.Visible = false;
                    panelBsr1.Visible = false;
                    panelResimBasarili.Visible = false;
                    panelResimBasarisiz.Visible = true;
                }


            }
            catch
            {
                pnl3.Visible = false;
                panelOzellikEkleBasarili.Visible = false;
                panelOzellikEkleBasarisiz.Visible = false;
                panelResimBasarili.Visible = false;
                panelResimBasarisiz.Visible = false;
                panelSil1.Visible = false;
                panelSil2.Visible = false;
                panelYeniOzellikBasarili.Visible = false;
                panelYeniOzellikBasarisiz.Visible = false;
                panelBsr2.Visible = false;
                panelBsr1.Visible = false;
                panelResimBasarili.Visible = false;
                panelResimBasarisiz.Visible = true;
            }

        }

        protected void Unnamed3_Click(object sender, EventArgs e)
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
                    resim = this.ResimBoyutlandir(resim, 420);
                    // oluşturulan resmi kaydet
                    resim.Save(Server.MapPath("../resim/makine-resim/" + resimadi));
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

        protected void Unnamed4_Click(object sender, EventArgs e)
        {
            OzellikSil();
        }


        protected void btnYeniOzellikAc_Click(object sender, EventArgs e)
        {

            btnOzelligiEkle.Visible = true;
            panelYeniOzellik1.Visible = true;
            panelYeniOzellik2.Visible = true;


        }

        protected void btnOzelligiEkle_Click(object sender, EventArgs e)
        {


            OzellikEkle();



        }

        protected void Unnamed3_Click1(object sender, EventArgs e)
        {
            TeknikOzellikEkle();
        }

        bool seciliMi = false;
        protected void ddlMevcutOzellik_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}