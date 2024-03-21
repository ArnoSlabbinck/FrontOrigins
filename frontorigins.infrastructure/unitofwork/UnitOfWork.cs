using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontorigins.Infrastructure.unitofwork
{
    public class UnitOfWork : IUnitOfWork 
    {
        private readonly DbContext dbContext;
        public UnitOfWork(DbContext dbContext) 
        {
            this.dbContext = dbContext;
        }
        public async Task SaveAsync(CancellationToken cancellationToken)
        {
            await dbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
