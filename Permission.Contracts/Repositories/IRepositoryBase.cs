using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Permission.Contracts.Repositories
{
    public interface IRepositoryBase<T> where T : class
    {
        Task<T> InsertAsync(T entity);
        Task<T> UpdateAsync(T entity);
        TResult Get<TResult>(Func<IQueryable<T>, IQueryable<TResult>> transform, Expression<Func<T, bool>> filter = null, string sortExpression = null);
        Task<IEnumerable<T>> GetAllAsync(string sortExpression = null);
        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> filter, string sortExpression = null);
        Task<IEnumerable<T>> GetAllAsync(Func<IQueryable<T>, IQueryable<T>> transform, Expression<Func<T, bool>> filter = null, string sortExpression = null);

        Task DeleteAsync(T entity);
    }
}
