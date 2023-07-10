using Demo.WebAPI.Data.Entities;
using Demo.WebAPI.Data.Repositories;

using Microsoft.AspNetCore.Mvc;

namespace Demo.WebAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class PersonController : ControllerBase
{
    private readonly IPersonRepository _repo;

    public PersonController(IPersonRepository repo)
    {
        _repo = repo;
    }

    [HttpGet]
    public IEnumerable<PersonEntity> GetAll()
    {
        return _repo.GetAll();
    }
}
