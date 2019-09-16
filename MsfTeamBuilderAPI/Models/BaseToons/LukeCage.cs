using MsfTeamBuilderAPI.Models.Entities;
using System.Collections.Generic;

namespace MsfTeamBuilderAPI.Models.BaseToons
{
  public class LukeCage : BaseToon
  {
    public LukeCage() : base("LukeCage")
    {
      StarRank = PopulateStarRank();
      Abilities = PopulateAbilities();
      Traits = PopulateTraits();
    }

    #region StarRank

    private StarRank PopulateStarRank()
    {
      return new StarRank
      {
        CurrentShards = 0,
        RedStars = 0,
        ShardsToNextRank = 55,
        YellowStars = 2
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
          Name  = "Beat Up",
          Level = 1,
          Description = "30% chance to apply Assist Now to a Random Hero Ally. If that ally is a Defender they also gain Offense Up. Attack primary target for 330% damage."
        },
        new Ability
        {
          Type = AbilityType.Special,
          Name  = "Bring It On!",
          Level = 1,
          Description = "Gain Taunt for 2 turns + 2 Regeneration. Clear all negative effect from self. Apply Regeneration to all Defender Allies."
        },
        new Ability
        {
          Type = AbilityType.Ultimate,
          Name  = "Brawl",
          Level = 1,
          Description = "Attack primary target for 170% damage + Chain to 2 adjacent targets for 120% damage. Counterattack breaks the chain."
        },
        new Ability 
        {
          Type = AbilityType.Passive, 
          Name  = "Unbreakable", 
          Level = 1, 
          Description = "Gain Defense Up for 2 turns + Deathproof. Apply Defense Up to all allies for 2 turns. Generate 1-3 ability energy for random ally."
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
        Trait.City,
        Trait.Bio,
        Trait.Protector,
        Trait.Defender
      };
    }

    #endregion

  }
}
