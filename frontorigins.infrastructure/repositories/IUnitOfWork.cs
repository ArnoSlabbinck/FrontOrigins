using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontorigins.Infrastructure.repositories
{
    public interface IUnitOfWork
    {
        Task SaveAsync(DbContext context,CancellationToken cancellationToken);
    }
}
