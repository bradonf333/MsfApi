using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MsfTeamBuilderAPI.Models.Entities
{
  public class Level
  {
    public int CurrentLevel { get; set; }
    public int Experience { get; set; }
    public int ExperienceToNextLevel { get; set; }
  }
}
