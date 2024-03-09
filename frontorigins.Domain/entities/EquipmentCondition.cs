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

        public override bool Equals(object? obj)
        {
            return obj is EquipmentCondition condition &&
                   base.Equals(obj) &&
                   Id == condition.Id &&
                   CreatedDate == condition.CreatedDate &&
                   ModifiedDate == condition.ModifiedDate &&
                   checkDate == condition.checkDate &&
                   this.condition == condition.condition &&
                   notes == condition.notes &&
                   EqualityComparer<Employee>.Default.Equals(checkedBy, condition.checkedBy);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), Id, CreatedDate, ModifiedDate, checkDate, condition, notes, checkedBy);
        }
    }
}
