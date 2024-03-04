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
    public partial class slaytlar : System.Web.UI.Page
    {
        Metotlar mtt = new Metotlar();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                return;
            }

            
            mtt.TekParametreliRepeaterDoldurma(rptResimListele, "sp_ResimleriGoster", 1);
            mtt.TekParametreliListboxDoldurma(listListele, "sp_ResimleriGoster", "SlaytID", "SlaytIsim");
        }

        protected void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cnn = new SqlConnection(Baglanti.Connection);
                SqlCommand cmd = new SqlCommand("delete from Slaytlar where SlaytID=" + Convert.ToInt32(listListele.SelectedItem.Value), cnn);
                cnn.Open();
                int sayi = cmd.ExecuteNonQuery();
                if (sayi > 0)
                {
                    panelBasarisiz.Visible = false;
                    panelBasarili.Visible = true;
                    mtt.TekParametreliListboxDoldurma(listListele, "sp_ResimleriGoster", "SlaytID", "SlaytIsim");
                    mtt.TekParametreliRepeaterDoldurma(rptResimListele, "sp_ResimleriGoster", 1);
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

        protected void button2_Click(object sender, EventArgs e)
        {


            ResimleriAl();




            
        }

        public void ResimKaydet(string resimurl)
        {
            try
            {
                SqlConnection cnn = new SqlConnection(Baglanti.Connection);
                SqlCommand cmd = new SqlCommand("exec sp_SlaytKaydet '" + resimurl +"','"+txtSlaytIsmi.Text+"'" , cnn);
                cnn.Open();
                int sayi = cmd.ExecuteNonQuery();
                if (sayi > 0)
                {
                    panelBasarisiz.Visible = false;
                    panelBasarili.Visible = true;
                    mtt.TekParametreliListboxDoldurma(listListele, "sp_ResimleriGoster", "SlaytID", "SlaytIsim");
                    mtt.TekParametreliRepeaterDoldurma(rptResimListele, "sp_ResimleriGoster", 1);

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

        string resimadi;
        string uzanti;

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

                    Bitmap resim = new Bitmap(Server.MapPath("../resim/temp/" + resimadi));
                    Size ydeger = new Size(780, 331);
                    Bitmap yresim = new Bitmap(resim, ydeger);
                    yresim.Save(Server.MapPath("../resim/" + resimadi));
                    ResimKaydet(resimadi);



                }
            }
            }
            catch (Exception)
            {

                throw;
            }
        }


        
    }
}