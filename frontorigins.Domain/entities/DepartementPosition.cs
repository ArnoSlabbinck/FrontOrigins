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
        private Employee employee;
        private Position position;

      
        public DepartmentPosition(long id) : base(id)
        {
        }

        public DepartmentPosition(long id, Employee employee, Position position) : base(id)
        {
            this.employee = employee;
            this.position = position;
        }

        public Employee Employee { get => employee; set => employee = value; }
        public Position Position { get => position; set => position = value; }

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
