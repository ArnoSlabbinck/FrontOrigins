using frontorigins.Domain.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontorigins.Infrastructure.repositories
{
    public interface IRespository<TEntity> where TEntity : BaseEntity
    {
        Task<IQueryable<TEntity>> GetAll(CancellationToken cancellationToken);
        Task<TEntity> GetById(int id, CancellationToken cancellationToken);

        void Add(TEntity entity, CancellationToken cancellationToken);

        void Update(TEntity entity, int id, CancellationToken cancellationToken);

        void Delete(int id, CancellationToken cancellationToken);

    }
}
