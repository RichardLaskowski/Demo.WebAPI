using System.Collections.Generic;

namespace CastleCredit.API.Base.Service.Interfaces;
public interface IDataMapperService<TContract, TEntity>
{
    TContract Map(TEntity enttity);
    TEntity Map(TContract contract);
    IEnumerable<TContract> Map(IEnumerable<TEntity> entities);
    IEnumerable<TEntity> Map(IEnumerable<TContract> entities);
}
