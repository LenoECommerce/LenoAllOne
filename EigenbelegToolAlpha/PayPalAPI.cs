using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using PayPal.Api;


namespace EigenbelegToolAlpha
{
    public class PayPalAPI
    {
        public void Main ()
        {























            //string clientId = "AYhBUzbrUZObLU-C33AGwzNUx7khYqQX2OtmpJHGAUzWZs9iH5PvuzQ7jj5Xukb94jbey7NLVpZfC66r";
            //string clientSecret = "EOAxomtmtZuxpNc_ArGSjSNoikMfH7lAPU9oyIdReFWE5JmnNsMLcxwV370hnitXp88O8pfSc_Zp5Ogh";

            //string endpointTest = "https://api-m.paypal.com";
            //string accessToken = GetAccessToken(endpointTest);

            //string endpointUrl = "https://api-m.paypal.com/v1/reporting/transactions";
            //HttpWebRequest request2 = (HttpWebRequest)WebRequest.Create(endpointUrl);
            //request2.Method = "GET";
            //request2.ContentType = "text/html";
            //request2.Accept = "text/html";
            //request2.Headers.Add("Authorization:" + clientId + "," + clientSecret);
            //request2.Headers.Add("Accept-Language:en_US");
            


            //using (HttpWebResponse response = (HttpWebResponse)request2.GetResponse())
            //{
            //    // Check the status code of the response
            //    if (response.StatusCode == HttpStatusCode.OK)
            //    {
            //        // Get the response stream and read the contents
            //        Stream responseStream = response.GetResponseStream();
            //        string responseString = new StreamReader(responseStream).ReadToEnd();

            //        // Do something with the response string
            //    }
            //    else
            //    {
            //        // Handle error
            //    }
            //}

            //string GetAccessToken(string apiEndpoint)
            //{
            //    // Set the API endpoint and request body
            //    string apiUrl = apiEndpoint + "/v1/oauth2/token";
            //    string requestBody = $"grant_type=client_credentials&client_id={clientId}&client_secret={clientSecret}";

            //    // Send the request and get the response
            //    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(apiUrl);
            //    request.Method = "POST";
            //    request.ContentType = "application/x-www-form-urlencoded";
            //    byte[] requestData = Encoding.UTF8.GetBytes(requestBody);
            //    request.ContentLength = requestData.Length;
            //    request.GetRequestStream().Write(requestData, 0, requestData.Length);
            //    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            //    string responseData = new System.IO.StreamReader(response.GetResponseStream()).ReadToEnd();

            //    // Deserialize the response and return the access token
            //    dynamic json = JsonConvert.DeserializeObject(responseData);
            //    return json.access_token;
            //}


        }

    }
}
