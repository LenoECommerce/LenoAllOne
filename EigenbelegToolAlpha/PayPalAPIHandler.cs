using System;
using System.Net;
using System.Text;
using Google.Apis.Auth.OAuth2;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;

namespace EigenbelegToolAlpha
{
    public class PayPalAPIHandler
    {
        public static void Main()
        {
            ////live
            ////string clientId = "AYhBUzbrUZObLU-C33AGwzNUx7khYqQX2OtmpJHGAUzWZs9iH5PvuzQ7jj5Xukb94jbey7NLVpZfC66r";
            ////string clientSecret = "EOAxomtmtZuxpNc_ArGSjSNoikMfH7lAPU9oyIdReFWE5JmnNsMLcxwV370hnitXp88O8pfSc_Zp5Ogh";
            ////sandbox
            //string clientId = "AUyWjLzh3t-AD-VbOsYLZNXaZqJ8jpFjKOGnGbBXVWwTHzKqgRNhp89N_JuyPkdyEvLS00YkM-h3rYPp";
            //string clientSecret = "EE9vtz1xjOVaJKyfVHa-HMNh-xbNEwg__Z9dglsTuuqubyhuskPMZq2Dt8EJsyttXTORO1KI6bUqRI0l";

            //// Erstelle eine neue RestClient-Instanz und setze die Basis-URL der API
            //var client = new RestClient("https://api.paypal.com/");

            //// Erstelle eine neue RestRequest-Instanz und setze die gewünschte HTTP-Methode (in diesem Fall POST)
            //var request = new RestRequest("v1/oauth2/token", Method.Post);

            //// Setze den Authentifizierungstyp auf "Basic" und füge die benötigten Anmeldeinformationen hinzu
            //request.Authenticator = new HttpBasicAuthenticator("{CLIENT_ID}", "{CLIENT_SECRET}");

            //// Füge dem Request die benötigten Formularparameter hinzu
            //request.AddParameter("grant_type", "client_credentials");

            //// Führe den Request aus und speichere die Antwort in einer Variablen
            //var response = client.Execute(request);

            //// Überprüfe den Statuscode der Antwort und handle den Fall entsprechend
            //if (response.StatusCode == System.Net.HttpStatusCode.OK)
            //{
            //    // Parse den Access Token aus der Antwort
            //    var token = response.Data.access_token;

            //    // Speichere den Access Token für spätere Verwendung
            //}
            //else
            //{
            //    // Handle fehlgeschlagene Anfrage
            //}
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
