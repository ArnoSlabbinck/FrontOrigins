using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontorigins.Domain.common
{
    public class BaseEntitiy
    {
        public Guid Guid { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
