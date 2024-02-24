using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsondecoder.Models
{
    public class WeeklyPeriodsResponse
    {
        public double Total { get; set; }

        public string Timezone { get; set; }

        public bool WeeklyLimitEnabled { get; set; }

        public int WeeklyLimit { get; set; }

        public List<WeeklyPeriodsResponseDailyItem> DailyItems { get; set; }
    }
}
