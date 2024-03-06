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

        public Timesheet(long id, DateTime workDay, TimeOnly startTime, TimeOnly endTime, TimeOnly overtime, int workingHours, string timesheetStatus, bool isHoliday, string comment) : base(id)
        {
            this.workDay = workDay;
            this.startTime = startTime;
            this.endTime = endTime;
            Overtime = overtime;
            this.workingHours = workingHours;
            this.timesheetStatus = timesheetStatus;
            this.isHoliday = isHoliday;
            this.comment = comment;
        }

        public DateTime WorkDay { get => workDay; set => workDay = value; }
        public TimeOnly StartTime { get => startTime; set => startTime = value; }
        public TimeOnly EndTime { get => endTime; set => endTime = value; }
        public TimeOnly Overtime1 { get => Overtime; set => Overtime = value; }
        public int WorkingHours { get => workingHours; set => workingHours = value; }
        public string TimesheetStatus { get => timesheetStatus; set => timesheetStatus = value; }
        public bool IsHoliday { get => isHoliday; set => isHoliday = value; }
        public string Comment { get => comment; set => comment = value; }

        public override bool Equals(object? obj)
        {
            return obj is Timesheet timesheet &&
                   base.Equals(obj) &&
                   Id == timesheet.Id &&
                   CreatedDate == timesheet.CreatedDate &&
                   ModifiedDate == timesheet.ModifiedDate &&
                   workDay == timesheet.workDay &&
                   startTime.Equals(timesheet.startTime) &&
                   endTime.Equals(timesheet.endTime) &&
                   Overtime.Equals(timesheet.Overtime) &&
                   workingHours == timesheet.workingHours &&
                   timesheetStatus == timesheet.timesheetStatus &&
                   isHoliday == timesheet.isHoliday &&
                   comment == timesheet.comment &&
                   Comment == timesheet.Comment;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(base.GetHashCode());
            hash.Add(Id);
            hash.Add(CreatedDate);
            hash.Add(ModifiedDate);
            hash.Add(workDay);
            hash.Add(startTime);
            hash.Add(endTime);
            hash.Add(Overtime);
            hash.Add(workingHours);
            hash.Add(timesheetStatus);
            hash.Add(isHoliday);
            hash.Add(comment);
            hash.Add(Comment);
            return hash.ToHashCode();
        }
    }
}