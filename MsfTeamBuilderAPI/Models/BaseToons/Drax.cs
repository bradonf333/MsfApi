using MsfTeamBuilderAPI.Models.Entities;
using System.Collections.Generic;

namespace MsfTeamBuilderAPI.Models.BaseToons
{
  public class Drax : BaseToon
  {
    public Drax() : base("Drax")
    {
      StarRank = PopulateStarRank();
      Abilities = PopulateAbilities();
      Traits = PopulateTraits();
    }

    #region StarRank

    private StarRank PopulateStarRank()
    {
      return new StarRank(2)
      {
        CurrentShards = 0,
        RedStars = 0,
      };
    }

    #endregion

    #region Abilities

    private static List<Ability> PopulateAbilities()
    {
      return new List<Ability>
      {
        new Ability
        {
          Type = AbilityType.Basic,
          Name  = "Knife Slash",
          Level = 1,
          Description = "Attack primary target for 250% damage + 30% Drain."
        },
        new Ability
        {
          Type = AbilityType.Special,
          Name  = "Fast Reflexes",
          Level = 1,
          Description = "Gain Taunt + 2 Counter + Defense UP for 1-2 turns."
        },
        new Ability
        {
          Type = AbilityType.Ultimate,
          Name  = "Good Fighting",
          Level = 1,
          Description = "Attack primary target for 300% damage and 50% Drain. Chain to 3-5 adjacent targets for 240% damage and 50% Drain."
        },
        new Ability
        {
          Type = AbilityType.Passive,
          Name  = "Destroyer",
          Level = 1,
          Description = "On spawn, gain Taunt. +20% increase to Drain"
        }
      };
    }

    #endregion

    #region Traits

    private static List<string> PopulateTraits()
    {
      return new List<string>
      {
        Trait.Hero,
        Trait.Cosmic,
        Trait.Bio,
        Trait.Protector,
        Trait.Guardian
      };
    }

    #endregion

  }
}
