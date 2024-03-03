using frontorigins.Domain.common;

namespace frontorigins.Domain.entities
{
    public class Timesheet : BaseEntity
    {
        private DateTime workDay;

        private TimeOnly startTime;

        private TimeOnly endTime;

        private TimeOnly Overtime;

        private int workingHours;

        private string timesheetStatus;

        private bool isHoliday;

        private string comment;

        public Timesheet(long id) : base(id)
        {
        }

        public DateTime WorkDay { get => workDay; set => workDay = value; }
        public TimeOnly StartTime { get => startTime; set => startTime = value; }
        public TimeOnly EndTime { get => endTime; set => endTime = value; }
        public TimeOnly Overtime1 { get => Overtime; set => Overtime = value; }
        public int WorkingHours { get => workingHours; set => workingHours = value; }
        public string TimesheetStatus { get => timesheetStatus; set => timesheetStatus = value; }
        public bool IsHoliday { get => isHoliday; set => isHoliday = value; }
        public string Comment { get => comment; set => comment = value; }
    }
}