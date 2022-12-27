using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PayPal.Api;


namespace EigenbelegToolAlpha
{
    public class PayPalAPI
    {
        public void Main ()
        {

            string clientId = ConfigurationManager.AppSettings["PayPalClientId"];
            string clientSecret = ConfigurationManager.AppSettings["PayPalClientSecret"];
            string endpointUrl = "https://api-m.paypal.com/v1/reporting/transactions";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endpointUrl);
            request.Method = "GET";
            request.ContentType = "text/html";
            request.Accept = "text/html";
            request.Headers.Add("Authorization:" + clientId + "," + clientSecret);
            request.Headers.Add("Accept-Language:en_US");
            


            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                // Check the status code of the response
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    // Get the response stream and read the contents
                    Stream responseStream = response.GetResponseStream();
                    string responseString = new StreamReader(responseStream).ReadToEnd();

                    // Do something with the response string
                }
                else
                {
                    // Handle error
                }
            }




        }

    }
}
