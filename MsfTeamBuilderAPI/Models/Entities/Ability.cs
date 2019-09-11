using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MsfTeamBuilderAPI.Models.Entities
{
  public class Ability
  {
    public AbilityType Type { get; set; }
    public int Level { get; set; }
    public string Description { get; set; }
  }

  public enum AbilityType
  {
    Basic,
    Special,
    Ultimate,
    Passive
  }
}
