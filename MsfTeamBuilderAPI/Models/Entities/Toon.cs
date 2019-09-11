using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MsfTeamBuilderAPI.Models.Entities
{
  public class Toon : BaseEntity
  {
    public string Name { get; set; }
    public int Power { get; set; }
    public int Level { get; set; }
    public Gear Gear { get; set; }
    public List<Ability> Abilities { get; set; }
    public StarRank StarRank { get; set; }
  }
}
