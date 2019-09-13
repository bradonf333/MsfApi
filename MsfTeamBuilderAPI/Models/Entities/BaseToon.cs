using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MsfTeamBuilderAPI.Models.Entities
{
  public class BaseToon : BaseEntity
  {
    public string Name { get; set; }
    public List<Ability> Abilities { get; set; }
    public List<Trait> Traits { get; set; }
    public StarRank StarRank { get; set; }

    public BaseToon()
    {
      Abilities = new List<Ability>();
      Traits = new List<Trait>();
    }
  }
}
