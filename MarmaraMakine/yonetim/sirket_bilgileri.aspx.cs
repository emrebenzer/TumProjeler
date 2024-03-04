using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace MarmaraMakine.yonetim
{
    public partial class sirket_bilgileri : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                return;
            }

            SirketBilgileriGetir();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Kaydet();
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

                    txtTelefon.Text = rdr[5].ToString();
                    txtFax.Text = rdr[6].ToString();

                    txtAdresTR.Text = rdr[7].ToString();
                    txtAdresEN.Text = rdr[8].ToString();
                    txtIletisimEMail.Text = rdr[9].ToString();

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
                SqlCommand adp = new SqlCommand("exec sp_sirketbilgisiguncelle '" + txtTelefon.Text + "','" + txtFax.Text + "','" + txtAdresTR.Text + "','" + txtAdresEN.Text + "','" + txtIletisimEMail.Text + "'", cnn);
                cnn.Open();

                int sayi = adp.ExecuteNonQuery();

                if (sayi > 0)
                {
                    panelBasarisiz.Visible = false;
                    panelBasarili.Visible = true;

                }
                else
                {
                    panelBasarili.Visible = false;
                    panelBasarisiz.Visible = true;
                }

                cnn.Close();
            }
            catch 
            {
                panelBasarili.Visible = false;
                panelBasarisiz.Visible = true;
            }
            


        }
    }
}