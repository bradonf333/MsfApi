using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MsfTeamBuilderAPI.Services.Interfaces
{
  public interface IGetToonService
  {
    Task<Toon> AddToon<Toon>(Toon toon);
  }
}
