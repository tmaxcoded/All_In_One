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
    public class MoneyTakerService :  GenericRepository<MoneyTaker>, IMoneyTaker
    {
        public MoneyTakerService(HealthContext context): base(context)
        {

        }


        public void CreateMoneyTaker(MoneyTaker entity)
        {
            Add(entity);

           
        }

        public async Task<IEnumerable<MoneyTaker>> GetAllMoneyTakers()
        {
            return await GetAll().ToListAsync();
        }

        public async Task<IEnumerable<MoneyTaker>> GetMoneyTrackerByExpression(long Id)
        {
            return await GetByExpression(x => x.Id.Equals(Id)).ToListAsync();
        }

        public async Task<MoneyTaker> GetMoneyTrackerByExpressionById(long Id)
        {
            return await GetByExpression(x => x.Id.Equals(Id)).FirstOrDefaultAsync();
        }

        public void DeleteMoneyTaker(MoneyTaker entity)
        {
            Delete(entity);
        }

        public void UpdateMoneyTaker(MoneyTaker entity)
        {
            Update(entity);
        }
    }
}
