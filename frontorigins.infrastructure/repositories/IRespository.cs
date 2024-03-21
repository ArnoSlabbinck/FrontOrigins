using frontorigins.Domain.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontorigins.Infrastructure.repositories
{
    public interface IRespository<TEntity> where TEntity :  class
    {
        Task<IQueryable<TEntity>> GetAll(CancellationToken cancellationToken);
        Task<TEntity> GetById(int id, CancellationToken cancellationToken);

        Task Add(TEntity entity, CancellationToken cancellationToken);

        Task Update(TEntity entity, int id, CancellationToken cancellationToken);

        Task Delete(int id, CancellationToken cancellationToken);

    }
}
