using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsondecoder.Models
{
    public class ImageDetail
    {
        public DateTime Date { get; set; }

        public DateTime? LocalUtcTime { get; set; }

        public string FileName { get; set; }

        public bool IsUploaded { get; set; }

        [JsonIgnore]
        public string path { get; set; }
    }
}
