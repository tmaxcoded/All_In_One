using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyAPI.Repositories
{
    public interface IUnitOfWork
    {
        IDbContextTransaction BeginTransaction();
        Task SavechangesAsync();
    }
}
