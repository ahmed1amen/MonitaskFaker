using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsondecoder.Models
{
    public class NoteClientModel
    {
        public long Id { get; set; }

        public Guid InternalId { get; set; }

        public string Message { get; set; }

        public Guid ProjectId { get; set; }

        public DateTime DateTime { get; set; }

        public double Duration { get; set; }

        public NoteType Type { get; set; }

        public bool? IsDefault { get; set; }

        public string Description { get; set; }

        public string Source { get; set; }

        public string ExternalUrl { get; set; }

        public string FaviconPath { get; set; }

        [JsonProperty("iconUrl")]
        public IntegrationIconUrl IconUrl { get; set; }
    }
}
