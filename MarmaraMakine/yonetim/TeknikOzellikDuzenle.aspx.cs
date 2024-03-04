using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MarmaraMakine.yonetim
{
    public partial class TeknikOzellikDuzenle : System.Web.UI.Page
    {
        Metotlar mtt = new Metotlar();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                return;
            }
            mtt.ParametresizListBoxDoldurma(listOzellikler, "sp_MevcutOzellikGetir", "OzellikID", "OzellikIsmiTR");
        }

        protected void listOzellikler_SelectedIndexChanged(object sender, EventArgs e)
        {
            OzellikleriGetir();
        }

        public void OzellikleriGetir()
        {
            try
            {


                SqlConnection cnn = new SqlConnection(Baglanti.Connection);
                SqlCommand cmd = new SqlCommand("exec sp_teknikozellikListele " + Convert.ToInt16(listOzellikler.SelectedItem.Value), cnn);
                cnn.Open();

                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    txtOzellikTR.Text = rdr[0].ToString();
                    txtOzellikEN.Text = rdr[1].ToString();


                }


                rdr.Close();
                cnn.Close();

            }
            catch
            {

            }

        }

        protected void btnOzelligiEkle_Click(object sender, EventArgs e)
        {
            OzellikGuncelle();
        }

        public void OzellikGuncelle()
        {
            try
            {

                if (listOzellikler.SelectedIndex >= 0)
                {
                    SqlConnection cnn = new SqlConnection(Baglanti.Connection);
                    SqlCommand cmd = new SqlCommand("exec sp_ozellikguncelle " + Convert.ToInt16(listOzellikler.SelectedItem.Value) + ",'" + txtOzellikTR.Text + "','" + txtOzellikEN.Text + "'", cnn);
                    cnn.Open();
                    int sayi = cmd.ExecuteNonQuery();
                    if (sayi > 0)
                    {
                        txtOzellikEN.Text = "";
                        txtOzellikTR.Text = "";
                        panelBsr1.Visible = true;
                        panelBsr2.Visible = false;
                        pnlSecim.Visible = false;
                        mtt.ParametresizListBoxDoldurma(listOzellikler, "sp_MevcutOzellikGetir", "OzellikID", "OzellikIsmiTR");
                    }
                    else
                    {
                        pnlSecim.Visible = false;
                        panelBsr1.Visible = false;
                        panelBsr2.Visible = true;
                    }
                    cnn.Close();
                }
                else {
                    panelBsr1.Visible = false;
                    panelBsr2.Visible = false;
                    pnlSecim.Visible = true;
                }
                    

            


            
            }
            catch
            {
                pnlSecim.Visible = false;
                panelBsr1.Visible = false;
                panelBsr2.Visible = true;

            }
        }
    }
}