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
using System.Drawing;
using PayPal.Api;

namespace EigenbelegToolAlpha
{
    public class BackMarketAPIHandler
    {
        public static Dictionary<string, string> conditionsEqualization = new Dictionary<string, string>
        {
            { "DIAMOND", "A" },
            { "PLATINUM", "B" },
            { "GOLD", "C" },
            { "SILVER", "D" },
            { "BRONZE", "E" },
            { "STALLONE", "F" },
        };

        public static Dictionary<string, string> conditionsExplanations = new Dictionary<string, string>
        {
            { "A", "Technisch: Funktionsfähig\r\nOptisch: Hervorragend" },
            { "B", "Technisch: Funktionsfähig\r\nOptisch: Sehr Gut" },
            { "C", "Technisch: Funktionsfähig\r\nOptisch: Gut" },
            { "D", "Technisch: Funktionsfähig\r\nOptisch: Beschädigt" },
            { "E", "Technisch: Nicht funktionsfähig\r\nOptisch: Gut" },
            { "F", "Technisch: Nicht funktionsfähig\r\nOptisch: Beschädigt" },
        };


        public string MainAccess(string endpointUrl)
        {
            string apiKey = "ZGFuZ2UuYnVzaW5lc3NlYmF5QGdtYWlsLmNvbTohRW5rdHVzczc=";
            string userAgent = "Aufermann & Dange Online Handel GbR";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endpointUrl);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            request.Headers.Add("Authorization:Basic " + apiKey);
            request.Headers.Add("Accept-Language:de-de");
            request.UserAgent = userAgent;

            
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                // Check the status code of the response
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    // Get the response stream and read the contents
                    Stream responseStream = response.GetResponseStream();
                    string responseString = new StreamReader(responseStream).ReadToEnd();
                    return responseString;
                    // Do something with the response string
                }
                else
                {
                    // Handle error
                }
            }
            return "";
        }
        public string[] PullBuyBackDataFromOrderID(string trackingNumber)
        {
            try
            {
                string response = MainAccess("https://www.backmarket.fr/ws/buyback/v1/orders?page=1&pageSize=100");
                string totalOrders = FindOutTotalOrders(response);
                response = MainAccess("https://www.backmarket.fr/ws/buyback/v1/orders?page="+GiveBackPageNumber(totalOrders)+"&pageSize=100");
                string orderID = FindOrderIdViaShippingNumber(response, trackingNumber);
                return ConvertResponse(response, orderID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                string[] test = new string[8] {"/", "/" , "/" , "/" , "0", "/", "/", "/"};
                return test;
            }
        }
        public int GiveBackPageNumber(string checkValue)
        {
            int firstDigit = Convert.ToInt32(checkValue.Substring(0,1));
            return firstDigit + 1;
        }
        public string FindOutTotalOrders(string response)
        {
            string temp = response.Substring(0,17);
            var posComma = temp.IndexOf(",");
            return temp.Substring(9, posComma - 9);
        }
        public string FindOrderIdViaShippingNumber (string response, string shippingNumber)
        {
            var fullLength = response.Length;
            string textBefore = response.Substring(0, response.IndexOf(shippingNumber));
            var posOrderID = textBefore.LastIndexOf("orderId");
            return response.Substring(posOrderID + 9,7);
        }
        public string[] ConvertResponse(string response, string orderID)
        {
            string[] feedback = new string[8];
            string[] temp = new string[2];
            var fullLength = response.Length;
            //12. Komma
            string textAfter = response.Substring(response.IndexOf(orderID), fullLength - response.IndexOf(orderID));
            string product = Decode(textAfter, "title");
            temp = SeperateModelAndStorage(product);
            feedback[0] = temp[0];
            feedback[1] = temp[1];
            feedback[2] = Decode(textAfter, "firstName") + " " + Decode(textAfter, "lastName");
            feedback[3] = feedback[2] + ", " + Decode(textAfter, "address1") + ", " + Decode(textAfter, "zipcode") + " " + Decode(textAfter, "city");
            feedback[4] = DecodeAmount(textAfter, "value");
            feedback[5] = orderID;
            feedback[6] = conditionsEqualization[Decode(textAfter, "grade")];
            feedback[7] = conditionsExplanations[feedback[6]];
            return feedback;
        }
        public string Decode(string main, string type)
        {
            var fullLength = main.Length;
            var posType = main.IndexOf(type);
            var nextComma = main.Substring(posType, fullLength - posType).IndexOf(",");
            int actualBegin = posType + type.Length + 3;
            return main.Substring(actualBegin, nextComma - type.Length - 4);
        }
        public string DecodeAmount(string main, string type)
        {
            var fullLength = main.Length;
            var posType = main.IndexOf(type);
            var nextComma = main.Substring(posType, fullLength - posType).IndexOf(",");
            int actualBegin = posType + type.Length + 2;
            return main.Substring(actualBegin, nextComma - type.Length - 2);
        }
        public string[] SeperateModelAndStorage(string mainValue)
        {
            string[]returnValues = new string[2];
            var fullLength = mainValue.Length;
            //storage part
            var posLastSpaceSign = mainValue.LastIndexOf(" ");
            var posSpaceSignBeforeStorage = mainValue.Substring(0, posLastSpaceSign).LastIndexOf(" ");
            returnValues[1] = mainValue.Substring(posSpaceSignBeforeStorage+1,fullLength-posSpaceSignBeforeStorage-1);
            //model part
            returnValues[0] = mainValue.Substring(6, posSpaceSignBeforeStorage-6);
            return returnValues;
        }
    }
}
