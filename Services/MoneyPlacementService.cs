using HealthyAPI.ApplicationContext;
using HealthyAPI.models;
using HealthyAPI.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyAPI.Services
{
    public class MoneyPlacementService: GenericRepository<MoneyPlacement>, IMoneyPlacement
    {
        public MoneyPlacementService(HealthContext context): base(context)
        {

        }

        public void CreateMoneyPlacement(MoneyPlacement entity)
        {
            Add(entity);
        }

        public void DeleteMoneyPlacement(MoneyPlacement entity)
        {
            Delete(entity);
        }

        public async Task<IEnumerable<MoneyPlacement>> GetAllMoneyPlacement()
        {
            return await GetAll().ToListAsync();
        }

        public async Task<IEnumerable<MoneyPlacement>> GetMoneyMoneyPlacement(long Id)
        {
            return await GetByExpression(x => x.Id.Equals(Id)).ToListAsync();
        }

        public async Task<MoneyPlacement> GetMoneyMoneyPlacementByExpressionById(long Id)
        {
            return await GetByExpression(x => x.Id.Equals(Id)).FirstOrDefaultAsync();
        }

        public void UpdateMoneyPlacement(MoneyPlacement entity)
        {
            Update(entity);
        }
    }
}
