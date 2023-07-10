using Demo.WebAPI.Data.Entities;

using Microsoft.EntityFrameworkCore;

namespace Demo.WebAPI.Data.Contexts;

public interface IDefaultContext
{
    DbSet<PersonEntity> Persons { get; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
