using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MarmaraMakine.yonetim
{
    public partial class Video : System.Web.UI.Page
    {
        public static string adres = "";
        Metotlar mtt = new Metotlar();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                return;
            }
           // mtt.TekParametreliRepeaterDoldurma(rptVideo,"sp_video",1
            VideoGetir(Convert.ToInt16(Request.QueryString["id"]));
            
        }
        
        public static void VideoGetir(int id)
        {
            try
            {
                SqlConnection cnn = new SqlConnection(Baglanti.Connection);
                SqlCommand cmd = new SqlCommand("exec sp_video "+id, cnn);
                cnn.Open();

                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {


                    adres = rdr[0].ToString();

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