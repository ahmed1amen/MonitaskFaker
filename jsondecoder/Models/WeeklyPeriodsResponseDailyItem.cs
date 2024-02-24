using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsondecoder.Models
{
    public class WeeklyPeriodsResponseDailyItem
    {

        public DateTime DateUtc { get; set; }

       
        public int DayNumberLocal { get; set; }

        public bool IsCurrentDay { get; set; }

        public List<PeriodLightModel> Periods { get; set; }

        public List<BreakPeriodLightModel> Breaks { get; set; }
    }
}
