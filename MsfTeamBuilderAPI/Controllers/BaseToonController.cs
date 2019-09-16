using Microsoft.AspNetCore.Mvc;
using MsfTeamBuilderAPI.Models.BaseToons;
using MsfTeamBuilderAPI.Services.Interfaces.BaseToon;
using System.Collections.Generic;

namespace MsfTeamBuilderAPI.Controllers
{
  [Route("api/BaseToon")]
  public class BaseToonController
  {
    private readonly IGetBaseToonService _getBaseToonService;

    public BaseToonController(IGetBaseToonService getBaseToonService)
    {
      _getBaseToonService = getBaseToonService;
    }

    [HttpGet("All")]
    public IEnumerable<BaseToon> GetAllBaseToons()
    {
      var result = _getBaseToonService.GetAllBaseToons();
      return result;
    }
  }
}
