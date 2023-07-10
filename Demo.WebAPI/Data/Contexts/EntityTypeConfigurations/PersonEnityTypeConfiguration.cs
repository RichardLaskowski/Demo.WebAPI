using Demo.WebAPI.Data.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Demo.WebAPI.Data.Contexts.Configurations;

public class PersonEnityTypeConfiguration : IEntityTypeConfiguration<PersonEntity>
{
    public void Configure(EntityTypeBuilder<PersonEntity> builder)
    {
        builder.ToTable("Person")
            .HasKey("PersonId");
    }
}
