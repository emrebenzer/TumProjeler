using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace WebApplication16
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public double dolar_alis, dolar_satis,dolar_efektifalis, dolar_efektifsatis;
        public double euro_alis, euro_satis,euro_efektifalis,euro_efektifsatis;
        public double parite;
        protected void Page_Load(object sender, EventArgs e)
        {
            piyasa(); //bilgileri alan metot

            // Değerleri kontrollere yazdırıyoruz.
            lblDolarAlis.Text = dolar_alis.ToString();
            lblDolarSatis.Text = dolar_satis.ToString();
            lblEuroAlis.Text = euro_alis.ToString();
            lblEuroSatis.Text = euro_satis.ToString();

            lblDolarEfektifAlis.Text = dolar_efektifalis.ToString();
            lblDolarEfektifSatis.Text = dolar_efektifsatis.ToString();

            lblEfektifEuroAlis.Text = euro_efektifalis.ToString();
            lblEfektifEuroSatis.Text = euro_efektifsatis.ToString();

            


        }

        public void piyasa()
        {
            XmlTextReader okuyucu = new XmlTextReader("http://www.tcmb.gov.tr/kurlar/today.xml");
            XmlDocument dokuman = new XmlDocument();
            dokuman.Load(okuyucu);
            XmlNode dolar = dokuman.SelectSingleNode("/Tarih_Date/Currency[CurrencyName='US DOLLAR']");
            XmlNode euro = dokuman.SelectSingleNode("/Tarih_Date/Currency[CurrencyName='EURO']");
            //XmlNode parseOlay = dokuman.SelectSingleNode("/Tarih_Date/Currency[CurrencyName='EUR/USD']");
            dolar_alis = double.Parse(dolar.ChildNodes[3].InnerText.Replace(".",","));
            dolar_satis = double.Parse(dolar.ChildNodes[4].InnerText.Replace(".", ","));
            dolar_efektifalis = double.Parse(dolar.ChildNodes[5].InnerText.Replace(".", ","));
            dolar_efektifsatis = double.Parse(dolar.ChildNodes[6].InnerText.Replace(".", ","));

            euro_alis = double.Parse(euro.ChildNodes[3].InnerText.Replace(".", ","));
            euro_satis = double.Parse(euro.ChildNodes[4].InnerText.Replace(".", ","));
            euro_efektifalis = double.Parse(euro.ChildNodes[5].InnerText.Replace(".", ","));
            euro_efektifsatis = double.Parse(euro.ChildNodes[6].InnerText.Replace(".", ","));
            //parite = double.Parse(parseOlay.ChildNodes[3].InnerText.Replace(".", ","));
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                double deger=0;

                if (drpDolarSecim.SelectedValue=="1")
                {
                    deger = Convert.ToDouble(dolar_satis) * Convert.ToDouble(txtDeger.Text);
                }
                else if(drpDolarSecim.SelectedValue=="2")
                {
                    deger = Convert.ToDouble(dolar_alis) * Convert.ToDouble(txtDeger.Text);
                }
                else if (drpDolarSecim.SelectedValue=="3")
                {
                    deger = Convert.ToDouble(dolar_efektifsatis) * Convert.ToDouble(txtDeger.Text);
                }
                else
                {
                    deger = Convert.ToDouble(dolar_efektifalis) * Convert.ToDouble(txtDeger.Text);
                }









                lblSonuc.Text = deger.ToString()+" TL";
            }
            catch 
            {
                mesaj("Yanlış dolar değeri girdiniz. Lütfen doğru bir değer giriniz.");
            }
            
        }

        private void mesaj(string mesaj)
        {

            ScriptManager.RegisterStartupScript(this, GetType(), "alert", "alert('" + mesaj + "');", true);

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                double deger2 = 0;

                if (drpEuroSecim.SelectedValue=="1")
                {
                    deger2 = Convert.ToDouble(euro_satis) * Convert.ToDouble(txtDegerEuro.Text);
                }
                else if (drpEuroSecim.SelectedValue=="2")
                {
                    deger2 = Convert.ToDouble(euro_alis) * Convert.ToDouble(txtDegerEuro.Text);
                }
                else if (drpEuroSecim.SelectedValue=="3")
                {
                    deger2 = Convert.ToDouble(euro_efektifsatis) * Convert.ToDouble(txtDegerEuro.Text);
                }
                else
                {
                    deger2 = Convert.ToDouble(euro_efektifalis) * Convert.ToDouble(txtDegerEuro.Text);
                }

                

                lblSonuc0.Text = deger2.ToString() + " TL";
            }
            catch
            {
                mesaj("Yanlış euro değeri girdiniz. Lütfen doğru bir değer giriniz.");
            }
        }
    }
}