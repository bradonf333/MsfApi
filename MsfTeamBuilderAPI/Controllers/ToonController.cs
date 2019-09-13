using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MsfTeamBuilderAPI.Models.Entities;
using MsfTeamBuilderAPI.Services.Interfaces;

namespace MsfTeamBuilderAPI.Controllers
{
  [Route("api/Toon")]
  public class ToonController
  {
    private readonly IGetToonService _getToonService;

    public ToonController(IGetToonService getToonService)
    {
      _getToonService = getToonService;
    }

    [HttpGet("toons")]
    public IEnumerable<Toon> GetAllToons()
    {
      var result = _getToonService.GetAllToons();
      return result;
    }
  }
}
