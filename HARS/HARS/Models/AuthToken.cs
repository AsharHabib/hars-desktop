using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace HARS.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class AuthToken
    {
        public string type { get; set; }
        public string username { get; set; }
        public string application_name { get; set; }
        public string client_id { get; set; }
        public string token_type { get; set; }
        public string access_token { get; set; }
        public int expires_in { get; set; }
        public string state { get; set; }
        public string scope { get; set; }

        public async static Task<string> GetAuthToken()
        {
            var values = new Dictionary<string, string>
                {
                    { "grant_type", "client_credentials" },
                    { "client_id", "OGORt5hAGLuW5GzewaxGCPFVNrKiB0WV" },
                    {"client_secret", "ik6GIT6Y7ui09KcA" }
                };

            var content = new FormUrlEncodedContent(values);
            content.Headers.Clear();
            content.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
            var response = await App.client.PostAsync("https://test.api.amadeus.com/v1/security/oauth2/token", content);
            AuthToken authToken = await response.Content.ReadFromJsonAsync<AuthToken>();
            
            return authToken.access_token;
        }

    }


}
