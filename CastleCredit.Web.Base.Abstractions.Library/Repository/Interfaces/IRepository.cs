using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CastleCredit.API.Base.Repository.Interfaces;

public interface IRepository<TEntity> : IDisposable where TEntity : class
{
    TEntity? Get<U>(U id);
    Task<TEntity?> GetAsync<U>(U id);
    IEnumerable<TEntity> GetAll();
    Task<IEnumerable<TEntity>?> GetAllAsync();
    IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
    Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate);
    void Add(TEntity entity);
    Task AddAsync(TEntity entity);
    void AddRange(IEnumerable<TEntity> entities);
    Task AddRangeAsync(IEnumerable<TEntity> entities);
    void Remove(TEntity entity);
    Task RemoveAsync(TEntity entity);
    void RemoveRange(IEnumerable<TEntity> entities);
    Task RemoveRangeAsync(IEnumerable<TEntity> entities);
    void Update(TEntity entity);
    Task UpdateAsync(TEntity entity);
    void UpdateRange(IEnumerable<TEntity> entities);
    Task UpdateRangeAsync(IEnumerable<TEntity> entities);
    int SaveChanges();
    Task<int> SaveChangesAsync();
}
