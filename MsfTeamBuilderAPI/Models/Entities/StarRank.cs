using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MsfTeamBuilderAPI.Models.Entities
{
  public class StarRank
  {
    public int YellowStars { get; set; }
    public int RedStars { get; set; }
    public int CurrentShards { get; set; }
    public int ShardsToNextRank { get; set; }
  }
}
