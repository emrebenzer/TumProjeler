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
    public partial class makineEkle2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                return;
            }
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            ResimleriAl();
        }

        string resimadi = "";
        string uzanti = "";

        public void ResimleriAl()
        {
            try
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
            catch 
            {

               
            }
        }

        public Bitmap ResimBoyutlandir(Bitmap resim, int boyut)
        {

            Bitmap sresim = resim;
            try
            {

           

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
            catch 
            {
                return sresim;
            }
            

        }

        public void ResimKaydet(string resimurl)
        {
            try
            {
                SqlConnection cnn = new SqlConnection(Baglanti.Connection);
                SqlCommand cmd = new SqlCommand("exec sp_anaresimkaydet '" + resimurl + "'," + Convert.ToInt32(Request.QueryString["id"]), cnn);
                cnn.Open();
                int sayi = cmd.ExecuteNonQuery();
                if (sayi > 0)
                {
                    
                    panelResimBasarili.Visible = true;
                    panelResimBasarisiz.Visible = false;
                    Response.Redirect("makineEkle3.aspx?id=" + Request.QueryString["id"].ToString());

                }
                else
                {
                    panelResimBasarili.Visible = false;
                    panelResimBasarisiz.Visible = true;
                }


            }
            catch
            {
                panelResimBasarili.Visible = false;
                panelResimBasarisiz.Visible = true;
            }

        }


    }
}