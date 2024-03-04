using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MarmaraMakine.yonetim
{
    public partial class makineMultimedya : System.Web.UI.Page
    {
        Metotlar mtt = new Metotlar();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                return;
            }
            mtt.ParametresizListBoxDoldurma(listKtgr, "sp_KategorileriGetir", "KategoriID", "KategoriIsim");
        }

        protected void listKtgr_SelectedIndexChanged(object sender, EventArgs e)
        {
            mtt.ParametreliListboxDoldurma(listMkn, "sp_MakineCek", "MakineID", "MakineIsimTR", Convert.ToInt32(listKtgr.SelectedItem.Value));
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (listMkn.SelectedIndex >= 0)
            {
                Response.Redirect("makineMultimedyaSecim.aspx?id=" + listMkn.SelectedItem.Value.ToString());
            }
            else
            {

                pnluy.Visible = true;
            }


        }
    }
}