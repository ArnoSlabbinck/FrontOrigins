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

      $
        public DepartmentPosition(long id) : base(id)
        {
        }

        public Employee Employee { get => employee; set => employee = value; }
        public Position Position { get => position; set => position = value; }
    }
}
