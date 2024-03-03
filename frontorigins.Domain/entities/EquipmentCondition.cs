using frontorigins.Domain.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontorigins.Domain.entities
{
    public class EquipmentCondition : BaseEntity
    {
        private DateTime checkDate;
        private string condition;
        private string notes;
        private Employee checkedBy;

        public EquipmentCondition(long id) : base(id)
        {
        }

        public DateTime CheckDate { get => checkDate; set => checkDate = value; }
        public string Condition { get => condition; set => condition = value; }
        public string Notes { get => notes; set => notes = value; }
        public Employee CheckedBy { get => checkedBy; set => checkedBy = value; }
    }
}
