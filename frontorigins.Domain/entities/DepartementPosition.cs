using frontorigins.Domain.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontorigins.Domain.entities
{
    public class DepartmentPosition : BaseEntity
    {
        public DepartmentPosition(long id) : base(id)
        {
        }

        private Employee employee;
        private Position position;


        public virtual Employee Employee { get => employee; set => employee = value; }
        public virtual Position Position { get => position; set => position = value; }

        public override bool Equals(object? obj)
        {
            return obj is DepartmentPosition position &&
                   base.Equals(obj) &&
                   Id == position.Id &&
                   CreatedDate == position.CreatedDate &&
                   ModifiedDate == position.ModifiedDate &&
                   EqualityComparer<Employee>.Default.Equals(employee, position.employee) &&
                   EqualityComparer<Position>.Default.Equals(this.position, position.position);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), Id, CreatedDate, ModifiedDate, employee, position);
        }
    }
}
