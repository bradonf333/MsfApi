using MsfTeamBuilderAPI.Models.Entities;
using System.Collections.Generic;

namespace MsfTeamBuilderAPI.Models.BaseToons
{
  public class DareDevil : BaseToon
  {
    public DareDevil() : base("DareDevil")
    {
      Abilities = PopulateAbilities();
      Traits = PopulateTraits();
      StarRank = PopulateStarRank();
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
          Name  = "Strike Without Fear",
          Level = 1,
          Description = "Attack primary target for 90% damage. 30% chance to gain a Bonus attack for 80% damage. If target is VILLAIN, chance to gain a Bonus attack is 60%."
        },
        new Ability
        {
          Type = AbilityType.Special,
          Name  = "Throw Baton",
          Level = 1,
          Description = "Attack primary target for 80% damage + 50% chance to Chain to 1 target within 2 spaces of previous target for 70% damage. Dodge breaks the chain. Gain Counter."
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
          Name  = "Enhance Senses", 
          Level = 1, 
          Description = "Self and Defender allies gain +5% Speed. This is applied after any character has taken an action. \nGain +5% Dodge chance per Defender ally."
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
        Trait.Brawler,
        Trait.Defender,
        Trait.MartialArtist
      };
    }

    #endregion

  }
}
