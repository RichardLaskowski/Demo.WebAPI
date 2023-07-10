using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

using CastleCredit.API.Base.Repository.Interfaces;

using Microsoft.EntityFrameworkCore;

namespace CastleCredit.API.Base.Repository.Classes;

public class DbContextRepository<TEntity> : IRepository<TEntity>
    where TEntity : class
{
    internal protected readonly DbContext Context;
    private bool _disposedValue;

    public DbContextRepository(DbContext context) => Context = context;

    public virtual void Add(TEntity entity) => Context.Set<TEntity>().Add(entity);
    public virtual async Task AddAsync(TEntity entity) => await Context.Set<TEntity>().AddAsync(entity);
    public virtual void AddRange(IEnumerable<TEntity> entities) => Context.Set<TEntity>().AddRange(entities);
    public virtual async Task AddRangeAsync(IEnumerable<TEntity> entities) => await Context.Set<TEntity>().AddRangeAsync(entities);
    public virtual IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate) => Context.Set<TEntity>().Where(predicate).ToList();
    public virtual async Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate) => await Context.Set<TEntity>().Where(predicate).ToListAsync();
    public virtual TEntity? Get<U>(U id) => Context.Set<TEntity>().Find(id);
    public virtual IEnumerable<TEntity> GetAll() => Context.Set<TEntity>().ToList();
    public virtual async Task<IEnumerable<TEntity>?> GetAllAsync() => await Context.Set<TEntity>().ToListAsync();
    public virtual async Task<TEntity?> GetAsync<U>(U id) => await Context.FindAsync<TEntity>(id);
    public virtual void Remove(TEntity entity) => Context.Set<TEntity>().Remove(entity);
    public virtual async Task RemoveAsync(TEntity entity) => await Task.Run(() => Remove(entity));
    public virtual void RemoveRange(IEnumerable<TEntity> entities) => Context.Set<TEntity>().RemoveRange(entities);
    public virtual async Task RemoveRangeAsync(IEnumerable<TEntity> entities) => await Task.Run(() => RemoveRange(entities));
    public virtual int SaveChanges() => Context.SaveChanges();
    public virtual async Task<int> SaveChangesAsync() => await Context.SaveChangesAsync();
    public virtual void Update(TEntity entity) => Context.Set<TEntity>().Update(entity);
    public virtual async Task UpdateAsync(TEntity entity) => await Task.Run(() => Update(entity));
    public virtual void UpdateRange(IEnumerable<TEntity> entities) => Context.Set<TEntity>().UpdateRange(entities);
    public virtual async Task UpdateRangeAsync(IEnumerable<TEntity> entities) => await Task.Run(() => UpdateRange(entities));
    public void Dispose()
    {
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
    protected virtual void Dispose(bool disposing)
    {
        if (!_disposedValue)
        {
            if (disposing)
            {
                Context.Dispose();
            }

            _disposedValue = true;
        }
    }

    ~DbContextRepository() => Dispose(disposing: false);
}
