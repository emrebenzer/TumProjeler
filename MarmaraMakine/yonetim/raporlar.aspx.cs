using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace MarmaraMakine
{
    public partial class raporlar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                return;
            }
            TekParametreliRepeaterDoldurma(rptRaporlar, "sp_raporlar");
        }

        public void TekParametreliRepeaterDoldurma(Repeater rpt, string prosedurismi)
        {
            try
            {

           
            SqlConnection cnn = new SqlConnection(Baglanti.Connection);
            SqlDataAdapter adp = new SqlDataAdapter("exec " + prosedurismi, cnn);
            cnn.Open();

            DataTable dt = new DataTable();
            adp.Fill(dt);
            CollectionPager1.DataSource = dt.DefaultView;
            CollectionPager1.BindToControl = rpt;
            rpt.DataSource = CollectionPager1.DataSourcePaged;
            rpt.DataBind();

            cnn.Close();
            }
            catch
            {

            }

        }
    }
}