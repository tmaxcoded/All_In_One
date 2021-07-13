using HealthyAPI.ApplicationContext;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyAPI.Repositories
{
    public class UnitOfWorkService : IUnitOfWork
    {
        private readonly HealthContext _healthContext;

        public UnitOfWorkService(HealthContext healthContext)
        {
            _healthContext = healthContext;
        }
        public IDbContextTransaction BeginTransaction()
        {
            return _healthContext.Database.BeginTransaction();
        }

        public async Task SavechangesAsync()
        {
           await  _healthContext.SaveChangesAsync();
        }
    }
}
