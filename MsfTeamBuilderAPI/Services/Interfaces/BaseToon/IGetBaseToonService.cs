using System.Collections.Generic;

namespace MsfTeamBuilderAPI.Services.Interfaces.BaseToon
{
  public interface IGetBaseToonService
  {
    IEnumerable<Models.BaseToons.BaseToon> GetAllBaseToons();
  }
}
