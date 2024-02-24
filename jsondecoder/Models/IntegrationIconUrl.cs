using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsondecoder.Models
{
    public class IntegrationIconUrl
    {
        [JsonProperty("12x12")]
        public string Size12x12 { get; set; }

        [JsonProperty("24x24")]
        public string Size24x24 { get; set; }

        [JsonProperty("36x36")]
        public string Size36x36 { get; set; }

        [JsonProperty("48x48")]
        public string Size48x48 { get; set; }

        [JsonProperty("96x96")]
        public string Size96x96 { get; set; }

        [JsonProperty("128x128")]
        public string Size128x128 { get; set; }

        [JsonProperty("256x256")]
        public string Size256x256 { get; set; }

        [JsonProperty("512x512")]
        public string Size512x512 { get; set; }
    }
}
