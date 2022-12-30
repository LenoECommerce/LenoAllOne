using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using MySqlX.XDevAPI;
using System.IO;
using System.Net;

namespace EigenbelegToolAlpha
{
    public class BackMarketAPIHandler
    {
        public void Main()
        {

            string apiKey = "ZGFuZ2UuYnVzaW5lc3NlYmF5QGdtYWlsLmNvbTohRW5rdHVzczc=";
            string endpointUrl = "https://www.backmarket.fr/ws/buyback/v1/orders?status=RECEIVED";
            string userAgent = "Aufermann & Dange Online Handel GbR";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endpointUrl);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            request.Headers.Add("Authorization: Basic " + apiKey);
            request.Headers.Add("Accept-Language: de-de");
            request.UserAgent = userAgent;

            
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                // Check the status code of the response
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    // Get the response stream and read the contents
                    Stream responseStream = response.GetResponseStream();
                    string responseString = new StreamReader(responseStream).ReadToEnd();
                    MessageBox.Show("test");
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
