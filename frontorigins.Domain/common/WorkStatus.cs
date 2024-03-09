using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontorigins.Domain.common
{
    public enum WorkStatus
    {
        [Description("Fulltime Employment")]
        Fulltime,
        [Description("Parttime Employment")]
        Parttime
    }
}
