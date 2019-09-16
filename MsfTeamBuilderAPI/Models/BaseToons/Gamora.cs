using MsfTeamBuilderAPI.Models.Entities;
using System.Collections.Generic;

namespace MsfTeamBuilderAPI.Models.BaseToons
{
  public class Gamora : BaseToon
  {
    public Gamora() : base("Gamora")
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
          Name  = "Sleeeeep",
          Level = 1,
          Description = "Attack primary target for 240% damage. If Charged, then in addition, Stun the target. Then lose Charged. If Drax is ally, Always apply Deflect to Drax."
        },
        new Ability
        {
          Type = AbilityType.Special,
          Name  = "Empathy",
          Level = 1,
          Description = "Heal self and adjacent allies for 3000 Health +15% of this character's Max Health. Heal additional allies for 1750 Health + 10% of this character's Max Health. Apply Regeneration to self and adjacent allies. In Raids, apply additional Regeneration to all allies."
        },
        new Ability
        {
          Type = AbilityType.Ultimate,
          Name  = "Soothe",
          Level = 1,
          Description = "Redistribute Health between self and lowest Health ally evenly + heal self and that ally for 2000. In Raids, Transfer 2 negative effect from both self and that ally to primary target. Clear 2 positive effect from primary target. This ability cannot target summoned allies."
        },
        new Ability
        {
          Type = AbilityType.Passive,
          Name  = "Will To Power",
          Level = 1,
          Description = "On Spawn, Gain Charged. On Turn, Heal for 15% of this character's Max Health. Gain 5% Max Health per Guardian ally."
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
        Trait.Controller,
        Trait.Guardian
      };
    }

    #endregion

  }
}
