
namespace jsondecoder.Models
{
    public class Period
    {
        public Guid Id { get; set; }

        public Guid ProjectId { get; set; }

        public string TimeZone { get; set; }

        public DateTime DateStart { get; set; }

        public DateTime DateEnd { get; set; }

        public DateTime DateIntervalStart { get; set; }

        public double Duration { get; set; }

        public DateTime? DateLastActive { get; set; }

        public string SessionId { get; set; }

        public List<Activity> Activitys { get; set; } = new List<Activity>();

        public List<AppTime> AppTime { get; set; } = new List<AppTime>();

        public DateTime? DownTime { get; set; }

        public PeriodV2Note Note { get; set; }

        public bool? RemoveDowntime { get; set; }

        public DateTime? DateSave { get; set; }

        public bool Billable { get; set; }

        public bool? Completed { get; set; }

        public bool? IsMeetingTime { get; set; }
    }
}
