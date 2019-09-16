using MsfTeamBuilderAPI.Models.Entities;
using System.Collections.Generic;

namespace MsfTeamBuilderAPI.Models.BaseToons
{
  public class Groot : BaseToon
  {
    public Groot() : base("Groot")
    {
      StarRank = PopulateStarRank();
      Abilities = PopulateAbilities();
      Traits = PopulateTraits();
    }

    #region StarRank

    private StarRank PopulateStarRank()
    {
      return new StarRank(3)
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
          Name  = "Crushing Blow",
          Level = 1,
          Description = "Attack primary target for 340% damage."
        },
        new Ability
        {
          Type = AbilityType.Special,
          Name  = "Overgrowth",
          Level = 1,
          Description = "Gain 2 Deathproof. Apply Deathproof + Defense Up to all allies."
        },
        new Ability
        {
          Type = AbilityType.Ultimate,
          Name  = "Life Spores",
          Level = 1,
          Description = "Heal all allies for 6000 health + 5% of this character's Max Health. Clear 2 negative effects from all allies. Apply Immunity to the lowest health Guardian ally for 2 turns."
        },
        new Ability
        {
          Type = AbilityType.Passive,
          Name  = "I am Groot",
          Level = 1,
          Description = "When Groot is attacked, always apply slow to attacker for 2 turns. \nOn Death, >20% chance to Revive with 25% of this character's Max Health. >Apply Deathproof to Rocket Raccoon. Always apply Defense Up to all allies. Always apply Speed Up + Offense Up + Counter to Guardian allies On Death, Deathproof Rocket Raccoon if ally."
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
        Trait.Support,
        Trait.Guardian
      };
    }

    #endregion

  }
}
