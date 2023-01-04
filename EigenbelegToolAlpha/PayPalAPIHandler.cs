using System;
using System.Net;
using System.Text;
using Google.Apis.Auth.OAuth2;
using Newtonsoft.Json;
using RestSharp;
using RestSharp;

namespace EigenbelegToolAlpha
{
    public class PayPalAPIHandler
    {
        public static void Main()
        {
            //live
            //string clientId = "AYhBUzbrUZObLU-C33AGwzNUx7khYqQX2OtmpJHGAUzWZs9iH5PvuzQ7jj5Xukb94jbey7NLVpZfC66r";
            //string clientSecret = "EOAxomtmtZuxpNc_ArGSjSNoikMfH7lAPU9oyIdReFWE5JmnNsMLcxwV370hnitXp88O8pfSc_Zp5Ogh";
            //sandbox
            string clientId = "AUyWjLzh3t-AD-VbOsYLZNXaZqJ8jpFjKOGnGbBXVWwTHzKqgRNhp89N_JuyPkdyEvLS00YkM-h3rYPp";
            string clientSecret = "EE9vtz1xjOVaJKyfVHa-HMNh-xbNEwg__Z9dglsTuuqubyhuskPMZq2Dt8EJsyttXTORO1KI6bUqRI0l";
            string apiEndpoint = "https://api-m.sandbox.paypal.com";
            string accessToken = GetAccessToken(apiEndpoint, clientId, clientSecret);

            RestClient client = new RestClient("https://api-m.sandbox.paypal.com");
            RestRequest request = new RestRequest();
        
            

        }
        static string GetAccessToken(string apiEndpoint, string clientId, string clientSecret)
        {
            // Set the API endpoint and request body
            string apiUrl = apiEndpoint + "/v1/oauth2/token";
            string requestBody = $"grant_type=client_credentials&client_id={clientId}&client_secret={clientSecret}";

            // Send the request and get the response
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(apiUrl);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            byte[] requestData = Encoding.UTF8.GetBytes(requestBody);
            request.ContentLength = requestData.Length;
            request.GetRequestStream().Write(requestData, 0, requestData.Length);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string responseData = new System.IO.StreamReader(response.GetResponseStream()).ReadToEnd();

            // Deserialize the response and return the access token
            dynamic json = JsonConvert.DeserializeObject(responseData);
            return json.access_token;
        }
    }
}
