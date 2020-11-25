using Microsoft.EntityFrameworkCore;
using Permission.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Permission.Repositories.Repositories
{
    public class RepositoryBase<TEntity,U> : IRepositoryBase<TEntity> 
        where TEntity : class, new ()
        where U: DbContext
    {
        protected readonly U _Context;
        private readonly DbSet<TEntity> _DbSet;
        protected RepositoryBase(U context)
        {
            _Context = context;
            _DbSet = _Context.Set<TEntity>();
        }

        public virtual async  Task DeleteAsync(TEntity entity)
        {
            _Context.Attach(entity);
            _Context.Entry<TEntity>(entity).State = EntityState.Deleted;
            await _Context.SaveChangesAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync(string sortExpression = null)
        {
            var query = _DbSet;

            //Breaking Changes in EF Core 3: The Query Translator for EF Core 3 was changed and the query building
            //and evaluation is different. Now, when you try to order by a property name string then it crashes.
            //If an update fixes this or a workaround is found, then implement it into the OrderBy Extension
            //and uncomment the line below.

            return await query.ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter, string sortExpression = null)
        {
            var query = _DbSet.AsNoTracking().Where(filter);

            //Breaking Changes in EF Core 3: The Query Translator for EF Core 3 was changed and the query building
            //and evaluation is different. Now, when you try to order by a property name string then it crashes.
            //If an update fixes this or a workaround is found, then implement it into the OrderBy Extension
            //and uncomment the line below.

            return await query.ToListAsync();
        }
        public async Task<IEnumerable<TEntity>> GetAllAsync(Func<IQueryable<TEntity>, IQueryable<TEntity>> transform, Expression<Func<TEntity, bool>> filter = null, string sortExpression = null)
        {
            var query = filter == null ? _DbSet.AsNoTracking() : _DbSet.AsNoTracking().Where(filter);

            var notSortedResults = transform(query);

            //Breaking Changes in EF Core 3: The Query Translator for EF Core 3 was changed and the query building
            //and evaluation is different. Now, when you try to order by a property name string then it crashes.
            //If an update fixes this or a workaround is found, then implement it into the OrderBy Extension
            //and uncomment the line below.

            return await notSortedResults.ToListAsync();
        }

        public TResult Get<TResult>(Func<IQueryable<TEntity>, IQueryable<TResult>> transform, Expression<Func<TEntity, bool>> filter = null, string sortExpression = null)
        {
            var query = filter == null ? _DbSet : _DbSet.Where(filter);

            var notSortedResults = transform(query);

            //Breaking Changes in EF Core 3: The Query Translator for EF Core 3 was changed and the query building
            //and evaluation is different. Now, when you try to order by a property name string then it crashes.
            //If an update fixes this or a workaround is found, then implement it into the OrderBy Extension
            //and uncomment the line below.

            return notSortedResults.FirstOrDefault();
        }

        public virtual async Task<TEntity> InsertAsync(TEntity entity)
        {
            await _Context.Set<TEntity>().AddAsync(entity);
            await _Context.SaveChangesAsync();
            return entity;
        }

        public virtual async Task<TEntity> UpdateAsync(TEntity entity)
        {
            _Context.Attach(entity);
            _Context.Entry<TEntity>(entity).State = EntityState.Modified;
            await _Context.SaveChangesAsync();
            return entity;
        }
    }
}
