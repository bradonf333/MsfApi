using MsfTeamBuilderAPI.Models.Entities;
using System.Collections.Generic;

namespace MsfTeamBuilderAPI.Models.BaseToons
{
  public class RocketRaccoon : BaseToon
  {
    public RocketRaccoon() : base("Rocket Raccoon")
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
        ShardsToNextRank = 80,
        YellowStars = 3
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
          Name  = "Rocket Rifle",
          Level = 1,
          Description = "Attack primary target for 180% damage +15% Crit chance. Attack all adjacent targets for 150% damage +15% Crit chance."
        },
        new Ability
        {
          Type = AbilityType.Special,
          Name  = "Pretty Good Plan",
          Level = 1,
          Description = "Attack primary target for 340% damage. If Groot is your ally, gain an Assist from Groot and apply Taunt to Groot. 70% chance to gain an Assist from a random ally."
        },
        new Ability
        {
          Type = AbilityType.Ultimate,
          Name  = "Maximum Damage",
          Level = 1,
          Description = "Attack all enemies for 300% damage. If Groot is ally, attack all enemies for 360% damage instead. Gain 2 Counter."
        },
        new Ability 
        {
          Type = AbilityType.Passive, 
          Name  = "Expert Tinker", 
          Level = 1, 
          Description = "Tech allies gain 5% damage. On Turn, 40% chance to apply a positive effect to 2 random allies."
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
        Trait.Tech,
        Trait.Blaster,
        Trait.Guardian
      };
    }

    #endregion

  }
}
