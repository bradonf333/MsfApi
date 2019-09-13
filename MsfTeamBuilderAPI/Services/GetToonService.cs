using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MsfTeamBuilderAPI.Models.Entities;
using MsfTeamBuilderAPI.Services.Interfaces;

namespace MsfTeamBuilderAPI.Services
{
  public class GetToonService : IGetToonService
  {
    private readonly IRepository<Toon> _repository;

    public GetToonService(IRepository<Toon> repository)
    {
      _repository = repository;
    }

    public IEnumerable<Toon> GetAllToons()
    {
      var result =_repository.List;
      return result;
    }
  }
}
