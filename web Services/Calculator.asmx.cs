using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace web_Services
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.None)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        List<string> Calculations;

        [WebMethod(EnableSession =true,Description ="This method is for add two numbers",CacheDuration =20)]
        public int Add(int a , int b)
        {
            if (Session["Calculation"] == null)
            {
                Calculations = new List<string>();
            }
            else
            {
                Calculations = (List<string>)Session["Calculation"];
            }

            string strCalculation = a.ToString() + " + " + b.ToString() + " = " + (a + b).ToString();
            Calculations.Add(strCalculation);
            Session["Calculation"] = Calculations;
            return a + b;
        }
        [WebMethod(MessageName ="Multiply two numbers")]
        public int mul(int a, int b)
        {
            return a * b;
        }

        [WebMethod(MessageName ="Multiply three numbers")]
        public int mul(int a, int b,int c)
        {
            return a * b * c;
        }

        [WebMethod(EnableSession =true)]
        public List<string> GetCalculation()
        {
            
            if (Session["Calculation"] == null)
            {
                List<string> result = new List<string>();
                result.Add("you have not perform any calculaton");
                return result;
            }
            else
            {
                return (List<string>)Session["Calculation"];
            }           

        }



    }
}
