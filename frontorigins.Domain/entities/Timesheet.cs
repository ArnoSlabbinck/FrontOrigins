using frontorigins.Domain.common;

namespace frontorigins.Domain.entities
{
    public class Timesheet : BaseEntitiy
    {
        private DateTime workDay { get; set; }

        private TimeOnly startTime { get; set; }

        private TimeOnly endTime { get; set; }

        private TimeOnly Overtime { get; set; }

        private int workingHours
        {
            get
            {
                return int.Parse(endTime - startTime);
            }
        }

        private string timesheetStatus { get; set; }

        private bool isHoliday { get; set; } = false;

        private string comment { get; set; }
        public Timesheet() { }
    }
}