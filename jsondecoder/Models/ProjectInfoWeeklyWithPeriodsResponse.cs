using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsondecoder.Models
{
    public class ProjectInfoWeeklyWithPeriodsResponse
    {
        public List<ProjectDailyItem> Projects { get; set; }
        public WeeklyPeriodsResponse WeeklyPeriods { get; set; }
    }
}
