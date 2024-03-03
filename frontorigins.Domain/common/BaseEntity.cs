using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontorigins.Domain.common
{
    public abstract class BaseEntity
    {
        public virtual long Id { get; protected set; }

        public virtual DateTime CreatedDate { get; protected set; }

        public virtual DateTime ModifiedDate { get; protected set; }

        protected BaseEntity(long id)
        {
            Id = id;
        }

        public override bool Equals(object? obj)
        {
            return obj is BaseEntity entity &&
                   Id == entity.Id &&
                   CreatedDate == entity.CreatedDate &&
                   ModifiedDate == entity.ModifiedDate;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, CreatedDate, ModifiedDate);
        }
    }
}
