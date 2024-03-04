using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MarmaraMakine.yonetim
{
    public partial class makineEkle3 : System.Web.UI.Page
    {
        Metotlar mtt = new Metotlar();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                return;
            }
            mtt.ParametresizDropDownListDoldurma(ddlMevcutOzellik, "sp_MevcutOzellikGetir", "OzellikID", "OzellikIsmiTR");
 
           
        }

        protected void Unnamed4_Click(object sender, EventArgs e)
        {
            OzellikSil();
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

                        mtt.ParametreliListboxDoldurma(listOzellikler, "sp_OzellikGetirParametreli", "TID", "TISIM", Convert.ToInt32(Request.QueryString["id"]));

                        panelYeniOzellikBasarili.Visible = true;
                        panelYeniOzellikBasarisiz.Visible = false;


                    }
                    else
                    {
                        panelYeniOzellikBasarili.Visible = false;
                        panelYeniOzellikBasarisiz.Visible = true;

                    }
                    cnn.Close();
            }
            catch
            {
                panelYeniOzellikBasarili.Visible = false;
                panelYeniOzellikBasarisiz.Visible = true;
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
                panelSil2.Visible = false;
                panelSil1.Visible = true;
                mtt.ParametreliListboxDoldurma(listOzellikler, "sp_OzellikGetirParametreli", "TID", "TISIM", Convert.ToInt32(Request.QueryString["id"]));
            }
            else
            {
                panelSil1.Visible = false;
                panelSil2.Visible = true;
            }


            cnn.Close();
            }
            catch 
            {
                panelSil1.Visible = false;
                panelSil2.Visible = true;
               
            }
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

        private void OzellikEkle()
        {
            try
            {
                SqlConnection cnn = new SqlConnection(Baglanti.Connection);
                SqlCommand cmd = new SqlCommand("exec sp_OzellikEkle '" + txtOzellikTR.Text + "','" + txtOzellikEN.Text + "'", cnn);
                cnn.Open();
                int sayi = cmd.ExecuteNonQuery();
                if (sayi > 0)
                {
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
                    panelOzellikEkleBasarili.Visible = false;
                    panelOzellikEkleBasarisiz.Visible = true;

                }


                cnn.Close();
            }
            catch 
            {
                panelOzellikEkleBasarili.Visible = false;
                panelOzellikEkleBasarisiz.Visible = true;
            }
            
        }

        bool seciliMi = false;
        protected void ddlMevcutOzellik_SelectedIndexChanged(object sender, EventArgs e)
        {
            seciliMi = true;
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Basarili.aspx");
        }

        protected void Unnamed3_Click1(object sender, EventArgs e)
        {
            TeknikOzellikEkle();
        }
    }
}