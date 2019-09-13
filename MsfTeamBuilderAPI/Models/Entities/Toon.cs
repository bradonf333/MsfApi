﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MsfTeamBuilderAPI.Models.BaseToons;

namespace MsfTeamBuilderAPI.Models.Entities
{
  public class Toon : BaseToon
  {
    public int Power { get; set; }
    public int Level { get; set; }
    public Gear Gear { get; set; }

    public Toon(string name) : base(name)
    {
      
    }
  }


}
