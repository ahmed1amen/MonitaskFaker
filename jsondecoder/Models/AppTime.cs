using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsondecoder.Models
{
    public class AppTime
    {
        public Guid PeriodId { get; set; }

        public string ApplicationName { get; set; }

        public double Duration { get; set; }

        public DateTime Date { get; set; }
    }
}
