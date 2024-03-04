using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MarmaraMakine.yonetim
{
    public partial class makineEkle : System.Web.UI.Page
    {
        Metotlar mtt = new Metotlar();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                return;
            }

            mtt.ParametresizDropDownListDoldurma(ddlKategori, "sp_KategorileriGetir", "KategoriID", "KategoriIsim");

        }


        public void MakineKaydet()
        {
            try
            {
                SqlConnection cnn = new SqlConnection(Baglanti.Connection);
                SqlCommand cmd = new SqlCommand("insert into Makineler (MakineIsimTR,MakineIsimEN,MakineIcerikTR,MakineIcerikEN,KategoriID) values (@makisimtr,@makisimen,@makiceriktr,@makiceriken,@Kategoriid) SET @ID=SCOPE_IDENTITY()", cnn);
                cmd.Parameters.AddWithValue("@makisimtr",txtTurkceIsim.Text);
                cmd.Parameters.AddWithValue("@makisimen",txtEnglishIsim.Text);
                cmd.Parameters.AddWithValue("@makiceriktr",ckTurkceDetay.Text);
                cmd.Parameters.AddWithValue("@makiceriken",ckEnglishDetails.Text);
                cmd.Parameters.AddWithValue("@Kategoriid", ddlKategori.SelectedItem.Value.ToString());
                 cmd.Parameters.AddWithValue("@ID", SqlDbType.Int).Direction = ParameterDirection.Output;
                cnn.Open();
                int sayi = cmd.ExecuteNonQuery();
                if (sayi > 0)
                {
                    
                    Response.Redirect("makineEkle2.aspx?id="+cmd.Parameters["@ID"].Value);
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

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
           
                MakineKaydet();
            
            
        }


        protected void ddlKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}