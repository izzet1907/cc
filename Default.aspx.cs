using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace WebApplication1
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private double Euro = 0.0;
        private double Dolar = 0.0;
        private DataSet dsDovizKur;
       

        protected void Button1_Click(object sender, EventArgs e)
        {
            dsDovizKur = new DataSet();
            dsDovizKur.ReadXml(@"http://www.tcmb.gov.tr/kurlar/today.xml");
            DataRow dr = dsDovizKur.Tables[1].Rows[0];
            Dolar = Convert.ToDouble(dr[4].ToString().Replace('.', ','));
            dr = dsDovizKur.Tables[1].Rows[11];
            Euro = Convert.ToDouble(dr[4].ToString().Replace('.', ','));


            UsdKur.Text = Dolar.ToString();
            EurKur.Text = Euro.ToString();

        }
    }
}
