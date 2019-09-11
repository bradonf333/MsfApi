using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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
  }
}
