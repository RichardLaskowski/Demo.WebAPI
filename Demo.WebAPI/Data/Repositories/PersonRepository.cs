using CastleCredit.API.Base.Repository.Classes;

using Demo.WebAPI.Data.Contexts;
using Demo.WebAPI.Data.Entities;

namespace Demo.WebAPI.Data.Repositories;

public class PersonRepository : DbContextRepository<PersonEntity>, IPersonRepository
{
    public PersonRepository(IDefaultContext defaultContext) : base(defaultContext)
    {
    }
}
