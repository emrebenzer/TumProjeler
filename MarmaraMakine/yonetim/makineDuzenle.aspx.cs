using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MarmaraMakine.yonetim
{
    public partial class makineDuzenle : System.Web.UI.Page
    {
        Metotlar mtt = new Metotlar();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                return;
            }

            mtt.ParametresizListBoxDoldurma(listKategoriler, "sp_KategorileriGetir", "KategoriID", "KategoriIsim");
        }

        protected void btnDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect("makineDuzenle2.aspx?id=" + listMakineler.SelectedItem.Value);
            }
            catch
            {
                lblSonuc.Text = "Lütfen makine seçiniz.";
            }
            
        }

        protected void listKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            mtt.ParametreliListboxDoldurma(listMakineler, "sp_MakineCek", "MakineID", "MakineIsimTR", Convert.ToInt32(listKategoriler.SelectedItem.Value));
        }
    }
}