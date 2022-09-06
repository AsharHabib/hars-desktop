using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
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

        

    }


}
