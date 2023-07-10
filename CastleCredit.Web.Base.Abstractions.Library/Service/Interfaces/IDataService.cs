using System.Collections.ObjectModel;

namespace CastleCredit.API.Base.Service.Interfaces;

public interface IDataService<TEntity>
{
    TEntity Create(TEntity entity);
    void Update(TEntity entity);
    void Delete(TEntity entity);
    TEntity GetById<T>(object id);
    ReadOnlyCollection<TEntity> GetAll();
}
