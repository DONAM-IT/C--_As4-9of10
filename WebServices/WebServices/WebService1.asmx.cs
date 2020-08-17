using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServices
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        private string[] ForeginName = { "AUST.DOLLAR", "EURO", "BRITISPOUND", "HONGKONG DOLLAR", "JAPANESE YEN", "SINGAPORE DOLLAR", "THAI BAHT", "US DOLLAR" };
        private double[] DefaultVND = { 15394.88, 25400.81, 29295.26, 2911.78, 203.3, 16690.08, 747.79, 23110.00 };
        [WebMethod]
        public double ConvertToVND(double vnd, String name)
        {
            for (int i = 0; i < ForeginName.Length; i++)
            {
                if (ForeginName[i].Equals(name))
                {
                    return vnd / DefaultVND[i];
                }
            }
            return 0;
        }

        [WebMethod]
        public double ConvertToForeignCurrencies(double foregin, String name)
        {
            for (int i = 0; i < ForeginName.Length; i++)
            {
                if (ForeginName[i].Equals(name))
                {
                    return foregin * DefaultVND[i];
                }
            }
            return 0;
        }
    }
}
