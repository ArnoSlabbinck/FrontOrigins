using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontorigins.Infrastructure.unitofwork
{
    public interface IUnitOfWork
    {
        Task SaveAsync(CancellationToken cancellationToken);
    }
}
