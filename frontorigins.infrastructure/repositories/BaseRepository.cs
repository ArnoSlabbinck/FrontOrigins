using frontorigins.Domain.common;
using frontorigins.Infrastructure.unitofwork;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Pomelo.EntityFrameworkCore.MySql.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontorigins.Infrastructure.repositories
{
    public abstract class BaseRepository<TEntity> : IRespository<TEntity> where TEntity : BaseEntity 
      
    {
        protected readonly DbContext DbContext;
        protected readonly IUnitOfWork unitOfWork;

        public BaseRepository(DbContext dbContext, IUnitOfWork unitOfWork)
        {
            DbContext = dbContext;
            this.unitOfWork = unitOfWork;
        }

        public async virtual Task Add(TEntity entity, CancellationToken cancellationToken)
        {
            await DbContext.AddAsync<TEntity>(entity, cancellationToken);
            await unitOfWork.SaveAsync(cancellationToken);
        }

        public async virtual Task Delete(int id, CancellationToken cancellationToken)
        {
            TEntity entity = await DbContext.FindAsync<TEntity>(id, cancellationToken);
            if(entity != null) DbContext.Remove<TEntity>(entity);
            await unitOfWork.SaveAsync(cancellationToken);

        }

        public async Task<IQueryable<TEntity>> GetAll(CancellationToken cancellationToken)
        {
            return DbContext.Set<TEntity>(); 
        }

        public async virtual Task<TEntity> GetById(int id, CancellationToken cancellationToken)
        {
            
            return await DbContext.FindAsync<TEntity>(id, cancellationToken);
            
        }

        public async virtual Task Update(TEntity updatedEntity,int id, CancellationToken cancellationToken)
        {
            TEntity entity = await DbContext.FindAsync<TEntity>(id, cancellationToken);
            if(entity != null) DbContext.Update(entity);
            await unitOfWork.SaveAsync(cancellationToken);

            
        }
    }
}
