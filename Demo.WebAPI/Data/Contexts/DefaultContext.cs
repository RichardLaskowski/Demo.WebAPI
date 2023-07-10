using Demo.WebAPI.Data.Contexts.Configurations;
using Demo.WebAPI.Data.Entities;

using Microsoft.EntityFrameworkCore;

namespace Demo.WebAPI.Data.Contexts;

public class DefaultContext : DbContext, IDefaultContext
{
    public DbSet<PersonEntity> Persons => Set<PersonEntity>();

    public DefaultContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration<PersonEntity>(new PersonEnityTypeConfiguration());
    }
}
