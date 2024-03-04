using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace MarmaraMakine.yonetim
{
    public partial class mailBilgileri : System.Web.UI.Page
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

        int sifreuzunlugu = 0;
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
                    sifreuzunlugu = rdr[12].ToString().Length;
                    txtSMTPMailAdresi.Text = rdr[10].ToString();
                    txtSMTPKullaniciAdi.Text = rdr[11].ToString();

                    txtSMTPSifre.Text = rdr[12].ToString();
                    txtGidenKutusu.Text = rdr[13].ToString();
                    txtGonderilecekMail.Text = rdr[14].ToString();

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
                SqlCommand adp = new SqlCommand("exec sp_mailbilgisiguncelle '" + txtSMTPMailAdresi.Text + "','" + txtSMTPKullaniciAdi.Text + "','" + txtSMTPSifre.Text + "','" + txtGidenKutusu.Text + "','" + txtGonderilecekMail.Text + "'", cnn);
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