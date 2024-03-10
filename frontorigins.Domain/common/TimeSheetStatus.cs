using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontorigins.Domain.common
{
    public enum TimeSheetStatus
    {
        [Description("Evening Shift")]
        NightShift,

        [Description("Morning Shift")]
        MorningShift,

        [Description("Regular WorkDay")]
        DayShift,

        [Description("Evening Shift")]
        EveningShift
    }
}
