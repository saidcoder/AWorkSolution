using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using AWork.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AWork.Persistence;

namespace AWork.Persistence.Base
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected AdventureWorks2019Context _dbContext;

        protected RepositoryBase(AdventureWorks2019Context dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(T entity) => _dbContext.Set<T>().Add(entity);

        public void Delete(T entity) => _dbContext.Set<T>().Remove(entity);

        public IQueryable<T> FindAll(bool trackChanges) => !trackChanges ? _dbContext.Set<T>().AsNoTracking() : _dbContext.Set<T>();

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges) =>
            !trackChanges ? _dbContext.Set<T>().Where(expression).AsNoTracking() :
             _dbContext.Set<T>().Where(expression);


        public void Update(T entity) => _dbContext.Set<T>().Update(entity);
    }
}
