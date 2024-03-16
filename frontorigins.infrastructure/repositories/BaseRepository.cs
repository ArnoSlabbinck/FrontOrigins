using frontorigins.Domain.common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontorigins.Infrastructure.repositories
{
    public abstract class BaseRepository<TEntity> : IRespository<TEntity> where TEntity : BaseEntity
    {
        private readonly DbContext DbContext;
        private readonly IUnitOfWork unitOfWork;

        public BaseRepository(DbContext dbContext, IUnitOfWork unitOfWork)
        {
            DbContext = dbContext;
            this.unitOfWork = unitOfWork;
        }

        public async virtual void Add(TEntity entity, CancellationToken cancellationToken)
        {
            await DbContext.AddAsync<TEntity>(entity, cancellationToken);
            await unitOfWork.SaveAsync(DbContext,cancellationToken);
        }

        public async virtual void Delete(int id, CancellationToken cancellationToken)
        {
            TEntity entity = await DbContext.FindAsync<TEntity>(id, cancellationToken);
            if(entity != null) DbContext.Remove<TEntity>(entity);
            await unitOfWork.SaveAsync(DbContext,cancellationToken);

        }

        public async Task<IQueryable<TEntity>> GetAll(CancellationToken cancellationToken)
        {
            return DbContext.Set<TEntity>(); 
        }

        public async virtual Task<TEntity> GetById(int id, CancellationToken cancellationToken)
        {
            
            return await DbContext.FindAsync<TEntity>(id, cancellationToken);
            
        }

        public async virtual void Update(TEntity updatedEntity,int id, CancellationToken cancellationToken)
        {
            TEntity entity = await DbContext.FindAsync<TEntity>(id, cancellationToken);
            if(entity != null) DbContext.Update(entity);
            await unitOfWork.SaveAsync(DbContext,cancellationToken);

            
        }
    }
}
