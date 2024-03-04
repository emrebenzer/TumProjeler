using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace MarmaraMakine.yonetim
{
    public partial class bilgi_sayfalari : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                return;
            }

            SirketBilgileriGetir();

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

                txtBaslikEnglish.Text = rdr[2].ToString();
                ckEditorEN.Text = rdr[4].ToString();

                txtBaslikTurkce.Text = rdr[1].ToString();
                ckEditorTR.Text = rdr[3].ToString();

            }
            rdr.Close();
            cnn.Close();
            }
            catch 
            {

                
            }

        }




        private void Kaydet()
        {

            try
            {

        
            SqlConnection cnn = new SqlConnection(Baglanti.Connection);
            SqlCommand adp = new SqlCommand("exec sp_HakkimizdaGuncelle '"+txtBaslikTurkce.Text+"','"+txtBaslikEnglish.Text+"','"+ckEditorTR.Text+"','"+ckEditorEN.Text+"'", cnn);
            cnn.Open();

            int sayi = adp.ExecuteNonQuery();

            if (sayi > 0)
            {
                panelBasarili.Visible = true;

            }
            else
                panelBasarisiz.Visible = true;

            cnn.Close();
            }
            catch 
            {

            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Kaydet();
        }

       
    }
}