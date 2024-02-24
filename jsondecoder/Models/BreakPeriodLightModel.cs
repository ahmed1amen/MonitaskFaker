using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsondecoder.Models
{
    public class BreakPeriodLightModel
    {
        public Guid Id { get; set; }
        public string BreakId { get; set; }
        public double Duration { get; set; }
    }
}
