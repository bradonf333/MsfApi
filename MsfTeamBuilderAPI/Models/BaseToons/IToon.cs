using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MsfTeamBuilderAPI.Models.Entities;

namespace MsfTeamBuilderAPI.Models.BaseToons
{
  public interface IToon
  {
    int Id { get; set; }
    string Name { get; set; }
    //List<Ability> Abilities { get; set; }
    //List<string> Traits { get; set; }
    StarRank StarRank { get; set; }
  }
}
