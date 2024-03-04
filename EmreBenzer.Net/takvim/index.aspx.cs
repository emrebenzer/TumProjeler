using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication16.takvim
{
    public partial class Dafault : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int hafta = GetWeekNumber(DateTime.Now);

            lblHafta.Text = hafta.ToString();
            lblYil.Text = DateTime.Now.Year.ToString();

            TimeSpan sayi=Convert.ToDateTime(DateTime.Now.ToShortDateString())-new DateTime(2000,01,01);
            lblMilenyum.Text = sayi.TotalDays.ToString();

            for (int i = 31; i > 0; i--)
            {
                drpGun.Items.Insert(0, new ListItem(i.ToString(), i.ToString()));
            }

            for (int i = 12; i > 0; i--)
            {
                drpAy.Items.Insert(0, new ListItem(i.ToString(), i.ToString()));
            }

            for (int i = 2008; i > 1921; i--)
            {
                drpYil.Items.Insert(0, new ListItem(i.ToString(), i.ToString()));
            }

        }

        public int GetWeekNumber(DateTime dtPassed)
        {
            CultureInfo ciCurr = CultureInfo.CurrentCulture;
            int weekNum = ciCurr.Calendar.GetWeekOfYear(dtPassed, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            return weekNum;

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            lblGunAciklama.Text = "Toplam Gün:";


            DateTime dtm = new DateTime(Convert.ToInt32(drpYil.SelectedValue), Convert.ToInt32(drpAy.SelectedValue), Convert.ToInt32(drpGun.SelectedValue));
            TimeSpan tms = Convert.ToDateTime(DateTime.Now.ToShortDateString()) - dtm;
            lblDogumGun.Text = tms.TotalDays.ToString();
        }
    }
}