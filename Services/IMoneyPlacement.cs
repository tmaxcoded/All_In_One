using HealthyAPI.models;
using HealthyAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyAPI.Services
{
    public interface IMoneyPlacement:IGenericRepository<MoneyPlacement>
    {
        Task<IEnumerable<MoneyPlacement>> GetAllMoneyPlacement();
        Task<IEnumerable<MoneyPlacement>> GetMoneyMoneyPlacement(long Id);

        Task<MoneyPlacement> GetMoneyMoneyPlacementByExpressionById(long Id);

        void DeleteMoneyPlacement(MoneyPlacement entity);

        void UpdateMoneyPlacement(MoneyPlacement entity);

        void CreateMoneyPlacement(MoneyPlacement entity);
    }
}
