using HealthyAPI.ApplicationContext;
using HealthyAPI.models;
using HealthyAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyAPI.Services
{
    public interface IMoneyTaker: IGenericRepository<MoneyTaker>
    {
        Task<IEnumerable<MoneyTaker>> GetAllMoneyTakers();
        Task<IEnumerable<MoneyTaker>> GetMoneyTrackerByExpression(long Id);

        Task<MoneyTaker> GetMoneyTrackerByExpressionById(long Id);

        void DeleteMoneyTaker(MoneyTaker entity);

        void UpdateMoneyTaker(MoneyTaker entity);

        void CreateMoneyTaker(MoneyTaker entity);

        


       
    }
}
