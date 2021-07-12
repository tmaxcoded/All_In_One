using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace HealthyAPI.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetByExpression(Expression<Func<T,bool>> entity);

        T GetByExpressionBySingle(Expression<Func<T, bool>> entity);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

    }
}
