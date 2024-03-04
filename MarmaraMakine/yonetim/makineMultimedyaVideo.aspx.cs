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
    public partial class makineMultimedyaVideo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                return;
            }

            
        }


        public string ResimleriUzanti()
        {
            try
            {

                string uzanti = "";
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


                    }
                }

                return uzantii;
            }
            catch
            {
                return "";
                panelBsr2.Visible = true;

            }
        }
        //int sayi=0;
        public void VideoKaydet(string resimurl)
        {
            try
            {
                SqlConnection cnn = new SqlConnection(Baglanti.Connection);
                SqlCommand cmd = new SqlCommand("exec sp_videokaydet '" + resimurl + "'," + Convert.ToInt32(Request.QueryString["id"]), cnn);
                cnn.Open();
                int sayi = cmd.ExecuteNonQuery();
                if (sayi > 0)
                {

                   

                    panelBsr2.Visible = false;
                    

                }
                else
                {

                    panelBsr2.Visible = true;
                }


            }
            catch
            {

                panelBsr2.Visible = true;
            }

        }



        string resimadii = "";
        string uzantii = "";

        protected void AsyncFileUpload1_UploadedComplete(object sender, AjaxControlToolkit.AsyncFileUploadEventArgs e)
        {
            uzantii = Path.GetExtension(AsyncFileUpload1.FileName);

            if (AsyncFileUpload1.HasFile && AsyncFileUpload1.FileName.Substring(AsyncFileUpload1.FileName.Length - 4) == ".MOV")
            {
                resimadii = DateTime.Now.Day.ToString() + DateTime.Now.Month +
    DateTime.Now.Year + DateTime.Now.Hour + DateTime.Now.Second +
    DateTime.Now.Minute + DateTime.Now.Millisecond + uzantii;
                string strPath = MapPath("~/videolar/") + Path.GetFileName(resimadii);
                AsyncFileUpload1.SaveAs(strPath);
                VideoKaydet(resimadii);

            }
            else
            {
                
                
                panelBsr2.Visible = true;
            }

        }

    }
}