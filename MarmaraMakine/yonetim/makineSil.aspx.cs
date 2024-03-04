using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MarmaraMakine.yonetim
{
    public partial class makineSil : System.Web.UI.Page
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
                MkineSil();
            }
            else
            {
                pnlBsrl.Visible = false;
                pnlBsrsz.Visible = false;
                pnluy.Visible = true; }
                

        }

        private void MkineSil()
        {
            try
            {
                SqlConnection cnn = new SqlConnection(Baglanti.Connection);
                SqlCommand cmd = new SqlCommand("exec sp_makinesil " + Convert.ToInt32(listMkn.SelectedItem.Value), cnn);
                cnn.Open();
                int sayi = cmd.ExecuteNonQuery();
                if (sayi > 0)
                {
                    mtt.ParametresizListBoxDoldurma(listKtgr, "sp_KategorileriGetir", "KategoriID", "KategoriIsim");
                    pnlBsrsz.Visible = false;
                    pnluy.Visible = false;
                    pnlBsrl.Visible = true;
                }
                else
                {
                    pnlBsrl.Visible = false;
                    pnlBsrsz.Visible = true;
                    pnluy.Visible = false;
                }
                cnn.Close();


            }
            catch {
                pnlBsrl.Visible = false;
                pnlBsrsz.Visible = true;
                pnluy.Visible = false;
            }
        }
    }
}