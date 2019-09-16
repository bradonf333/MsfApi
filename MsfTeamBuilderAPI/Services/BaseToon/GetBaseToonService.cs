using System.Collections.Generic;
using MsfTeamBuilderAPI.Models.Entities;
using MsfTeamBuilderAPI.Services.DataBase;
using MsfTeamBuilderAPI.Services.Interfaces;
using MsfTeamBuilderAPI.Services.Interfaces.BaseToon;

namespace MsfTeamBuilderAPI.Services.BaseToon
{
  public class GetBaseToonService : IGetBaseToonService
  {
    private readonly IDbInterface<Models.BaseToons.BaseToon> _repository;

    public GetBaseToonService(IDbInterface<Models.BaseToons.BaseToon> repository)
    {
      _repository = repository;
    }

    public IEnumerable<Models.BaseToons.BaseToon> GetAllBaseToons()
    {
      var result =_repository.List;
      return result;
    }
  }
}
