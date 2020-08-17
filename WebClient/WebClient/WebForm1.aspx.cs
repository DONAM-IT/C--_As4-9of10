using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        //private ServiceReference1.WebService1SoapClient serv = new ServiceReference1.WebService1SoapClient();
        private string[] ForeginName = { "AUST.DOLLAR", "EURO", "BRITISPOUND", "HONGKONG DOLLAR", "JAPANESE YEN", "SINGAPORE DOLLAR", "THAI BAHT", "US DOLLAR", "VIETNAM" };
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                foreach (string item in ForeginName)
                {
                    from.Items.Add(item);
                    to.Items.Add(item);
                }
            }

        }

        protected void convert_Click(object sender, EventArgs e)
        {
            double result = 0;
            try
            {
                string origin, target;
                double inValue;
                origin = from.SelectedValue;
                target = to.SelectedValue;
                inValue = double.Parse(money.Text.Trim());
                WebClient.ServiceReference2.WebService1SoapClient serv = new WebClient.ServiceReference2.WebService1SoapClient();
                if (origin.Equals(target))
                {
                    result = inValue;
                }
                else
                {
                    if (origin.Equals("VIETNAM"))
                    {
                        result = serv.ConvertToVND(inValue, target);
                    }
                    else if (target.Equals("VIETNAM"))
                    {
                        result = serv.ConvertToForeignCurrencies(inValue, origin);
                    }
                    else
                    {
                        result = serv.ConvertToVND(serv.ConvertToForeignCurrencies(inValue, origin), target);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            lblResult.Text = result + "";
        }
    }
}