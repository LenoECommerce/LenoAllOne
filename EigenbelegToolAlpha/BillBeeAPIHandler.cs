using ExcelLibrary.BinaryFileFormat;
using MathNet.Numerics;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace EigenbelegToolAlpha
{
    public class BillBeeAPIHandler

    {

        public static void MainAccess()
        {
            // API-Schlüssel für die BillBee API
            string apiUsername = "developeraccess";
            string apiPassword = "CjAMgF-XMy>42ZV-WE27h6g";
            string apiKey = "4414BB64-33FD-49C8-AE83-584C5F889115";
            string externalOrderId = "02-09219-08342";
            // Erstelle einen HttpClient und setze den X-Billbee-Api-Key-Header
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("X-Billbee-Api-Key", apiKey);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes($"{apiUsername}:{apiPassword}")));

            // Sende eine GET-Anfrage an die BillBee API mit dem "externalId" - Filter
            HttpResponseMessage getResponse = client.GetAsync($"https://api.billbee.io/api/v1/orders/findbyextref/{externalOrderId}").Result;
            if (getResponse.IsSuccessStatusCode)
            {
                // Lese den Inhalt der Antwort als String
                string result = getResponse.Content.ReadAsStringAsync().Result;

                // Parsen des JSON-Ergebnisses
                JObject json = JObject.Parse(result);
                var pos = result.IndexOf("BillBeeOrderId");
                string tempId = result.Substring(pos+16,17);
                long orderId = Convert.ToInt64(tempId);

                HttpRequestMessage request = new HttpRequestMessage(new HttpMethod("PATCH"), $"https://api.billbee.io/api/v1/orders/{orderId}");

                // Erstelle ein HttpContent-Objekt mit dem PATCH-Inhalt
                string patchContent = "{ \"CustomInvoiceNote\": \"Test\" }";
                request.Content = new StringContent(patchContent, Encoding.UTF8, "application/json");
                // Sende die PATCH-Anfrage
                HttpResponseMessage putResponse = client.SendAsync(request).Result;

                if (putResponse.IsSuccessStatusCode)
                {
                    MessageBox.Show ("Feld 'Individueller Rechnungstext' erfolgreich aktualisiert");
                }
                else
                {
                    MessageBox.Show("Fehler beim Aktualisieren des Feldes 'Individueller Rechnungstext'");
                }
            }
        }
    }
}
