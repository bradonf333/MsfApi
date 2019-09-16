using System.Collections.Generic;
using MsfTeamBuilderAPI.Models.Entities;

namespace MsfTeamBuilderAPI.Models.BaseToons
{
  public class BaseToon : IToon
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Ability> Abilities { get; set; }
    public List<string> Traits { get; set; }
    public StarRank StarRank { get; set; }

    public BaseToon(string name)
    {
      Name = name;
    }
  }
}
