using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MarmaraMakine.yonetim
{
    public partial class makineMultimedyaKatalog : System.Web.UI.Page
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
                        file.SaveAs(Server.MapPath("../resim/pdfler/" + resimadi));


                        //****************** Yeni boyutlara göre resim oluştur ***************/

                        // orjinal resim


                        KatalogKaydet(resimadi);


                    }
                }
            }
            catch
            {


            }
        }

        public void KatalogKaydet(string resimurl)
        {
            try
            {
                SqlConnection cnn = new SqlConnection(Baglanti.Connection);
                SqlCommand cmd = new SqlCommand("exec sp_katalogkaydet '" + resimurl + "'," + Convert.ToInt32(Request.QueryString["id"]), cnn);
                cnn.Open();
                int sayi = cmd.ExecuteNonQuery();
                if (sayi > 0)
                {

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
    }
}