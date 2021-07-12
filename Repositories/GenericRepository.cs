using HealthyAPI.ApplicationContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace HealthyAPI.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly HealthContext _healthContext;

        public GenericRepository(HealthContext healthContext)
        {
            _healthContext = healthContext;
        }
        public void Add(T entity)
        {
           
           _healthContext.Set<T>().Add(entity);
            
        }

        public void Delete(T entity)
        {
            _healthContext.Set<T>().Remove(entity);
        }

        public IQueryable<T> GetAll()
        {
            return _healthContext.Set<T>();
        }

        public IQueryable<T> GetByExpression(Expression<Func<T, bool>> entity)
        {
            return _healthContext.Set<T>().Where(entity);
        }

        public T GetByExpressionBySingle(Expression<Func<T, bool>> entity)
        {
            return _healthContext.Set<T>().Where(entity).FirstOrDefault();
        }

      

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
