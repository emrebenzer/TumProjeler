using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace MarmaraMakine
{
    public class Metotlar
    {
        private int deger;

        public int getDeger()
        {   
            return deger;
        }
        public void setDeger(int sayi)
        {
            deger = sayi;
        }

        public void TekParametreliRepeaterDoldurma(Repeater rpt, string prosedurismi, int kategoriid)
        {
            try
            {

          
            SqlConnection cnn = new SqlConnection(Baglanti.Connection);
            SqlDataAdapter adp= new SqlDataAdapter("exec "+prosedurismi+" "+kategoriid, cnn);
            cnn.Open();

            DataTable dt=new DataTable();
            adp.Fill(dt);

            rpt.DataSource = dt;
            rpt.DataBind();

            cnn.Close();
            }
            catch
            {

            }

        }

        public void TekParametreliListboxDoldurma(ListBox list, string prosedurismi,string aklindadeger,string yazacakdeger)
        {
            try
            {

         
            SqlConnection cnn = new SqlConnection(Baglanti.Connection);
            SqlDataAdapter adp = new SqlDataAdapter("exec " + prosedurismi+" 1", cnn);
            cnn.Open();

            DataTable dt = new DataTable();
            adp.Fill(dt);

            list.DataSource = dt;
            list.DataValueField = aklindadeger;
            list.DataTextField = yazacakdeger;
            list.DataBind();

            cnn.Close();
            }
            catch 
            {

            }

        }

        public void ParametresizDropDownListDoldurma(DropDownList list, string prosedurismi, string aklindadeger, string yazacakdeger)
        {
            try
            {

           
            SqlConnection cnn = new SqlConnection(Baglanti.Connection);
            SqlDataAdapter adp = new SqlDataAdapter("exec " + prosedurismi, cnn);
            cnn.Open();

            DataTable dt = new DataTable();
            adp.Fill(dt);

            list.DataSource = dt;
            list.DataValueField = aklindadeger;
            list.DataTextField = yazacakdeger;
            list.DataBind();

            cnn.Close();
            }
            catch 
            {

            }

        }

        public void ParametresizListBoxDoldurma(ListBox list, string prosedurismi, string aklindadeger, string yazacakdeger)
        {
            try
            {

           
            SqlConnection cnn = new SqlConnection(Baglanti.Connection);
            SqlDataAdapter adp = new SqlDataAdapter("exec " + prosedurismi, cnn);
            cnn.Open();

            DataTable dt = new DataTable();
            adp.Fill(dt);

            list.DataSource = dt;
            list.DataValueField = aklindadeger;
            list.DataTextField = yazacakdeger;
            list.DataBind();

            cnn.Close();
            }
            catch
            {

            }

        }

        public void ParametreliListboxDoldurma(ListBox list, string prosedurismi, string aklindadeger, string yazacakdeger,int id)
        {
            try
            {

          
            SqlConnection cnn = new SqlConnection(Baglanti.Connection);
            SqlDataAdapter adp = new SqlDataAdapter("exec " + prosedurismi + " "+id, cnn);
            cnn.Open();

            DataTable dt = new DataTable();
            adp.Fill(dt);

            list.DataSource = dt;
            list.DataValueField = aklindadeger;
            list.DataTextField = yazacakdeger;
            list.DataBind();

            cnn.Close();
            }
            catch
            {

            }

        }

        public void Yaz(int uid)
        {
            try
            {

          
            SqlConnection cnn = new SqlConnection(Baglanti.Connection);
            SqlCommand sql = new SqlCommand("exec sp_raporyaz " + uid, cnn);

            cnn.Open();
            int sayi = sql.ExecuteNonQuery();
            if (sayi > 0)
            {

            }
            cnn.Close();
            }
            catch
            {

            }
        }

        public void ParametresizRepeaterDoldurma(Repeater rpt, string prosedurismi)
        {
            try
            {

          
            SqlConnection cnn = new SqlConnection(Baglanti.Connection);
            SqlDataAdapter adp = new SqlDataAdapter("exec " + prosedurismi, cnn);
            cnn.Open();

            DataTable dt = new DataTable();
            adp.Fill(dt);

            rpt.DataSource = dt;
            rpt.DataBind();

            cnn.Close();
            }
            catch 
            {

            }

        }
    }
}