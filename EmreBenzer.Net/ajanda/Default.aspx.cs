using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication16.postakodu
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                return;
            }

            using(VerilerDataContext ver=new VerilerDataContext())
            {

                drpsehirler.DataSource = from p in ver.Sehirlers
                                   orderby p.SehirAdi
                                   select new { p.SehirAdi, p.SehirId };
                drpsehirler.DataTextField = "SehirAdi";
                drpsehirler.DataValueField = "SehirId";
                drpsehirler.DataBind();
                drpsehirler.Items.Insert(0, new ListItem("Şehir Seçiniz", "0"));
            }

            using (VerilerDataContext ver = new VerilerDataContext())
            {

                sehir1.DataSource = from p in ver.Sehirlers
                                         orderby p.SehirAdi
                                         select new { p.SehirAdi, p.PlakaNo };
                sehir1.DataTextField = "SehirAdi";
                sehir1.DataValueField = "PlakaNo";
                sehir1.DataBind();
                sehir1.Items.Insert(0, new ListItem("Şehir Seçiniz", "0"));
            }

            using (VerilerDataContext ver = new VerilerDataContext())
            {

                sehir2.DataSource = from p in ver.Sehirlers
                                    orderby p.SehirAdi
                                    select new { p.SehirAdi, p.PlakaNo };
                sehir2.DataTextField = "SehirAdi";
                sehir2.DataValueField = "PlakaNo";
                sehir2.DataBind();
                sehir2.Items.Insert(0, new ListItem("Şehir Seçiniz", "0"));
            }

            
        }

        

        protected void drpsehirler_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (VerilerDataContext ver = new VerilerDataContext())
            {
                ilceler.DataSource = ver.Ilcelers.Where(p => p.SehirId == Convert.ToInt32(drpsehirler.SelectedValue)).ToList();
                ilceler.DataTextField = "IlceAdi";
                ilceler.DataValueField = "ilceId";
                ilceler.DataBind();
                ilceler.Items.Insert(0, new ListItem("İlçe Seçiniz", "0"));
            }

            lblPlakaBilgi.Visible = true;
            lblTelefonBilgi.Visible = true;

            using (VerilerDataContext ver = new VerilerDataContext())
            {
                var liste = ver.Sehirlers.Where(a => a.SehirId == Convert.ToInt32(drpsehirler.SelectedValue)).ToList();

                foreach (var item in liste)
                {
                    telefon.Text = item.TelefonKodu.ToString();
                    plaka.Text = item.PlakaNo.ToString();
                }

            }
        }

        protected void ilceler_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (VerilerDataContext ver = new VerilerDataContext())
            {
                mahalle.DataSource = ver.SemtMahs.Where(p => p.ilceId == Convert.ToInt32(ilceler.SelectedValue)).OrderBy(a=> a.MahalleAdi).ToList();
                mahalle.DataTextField = "MahalleAdi";
                mahalle.DataValueField = "SemtMahId";
                mahalle.DataBind();
                mahalle.Items.Insert(0, new ListItem("Mahalle Seçiniz", "0"));
            }
        }

        protected void mahalle_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (VerilerDataContext ver = new VerilerDataContext())
            {
                var liste = ver.SemtMahs.Where(a => a.SemtMahId == Convert.ToInt32(mahalle.SelectedValue)).ToList();

                foreach (var item in liste)
                {
                    posta.Text = item.PostaKodu.ToString();
                }
            
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            lblMesafe.Text = "";
            using (VerilerDataContext ver = new VerilerDataContext())
            {
                var liste = ver.ILMESAFESIs.Where(a => (a.ilid1 == Convert.ToInt32(sehir1.SelectedValue) || a.ilid1 == Convert.ToInt32(sehir2.SelectedValue)) && (a.ilid2 == Convert.ToInt32(sehir2.SelectedValue) || a.ilid2 == Convert.ToInt32(sehir1.SelectedValue))).ToList();

                foreach (var item in liste)
                {
                    lblMesafe.Text = item.mesafe.ToString();
                }

            }
        }
    }
}