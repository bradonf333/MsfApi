using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MsfTeamBuilderAPI.Models.Entities;

namespace MsfTeamBuilderAPI.Services.Interfaces
{
  public interface IGetToonService
  {
    IEnumerable<Toon> GetAllToons();
  }
}
