using MsfTeamBuilderAPI.Models.Entities;
using NUnit.Framework;

namespace UnitTests
{
  public class AbilityUnitTests
  {
    [Test]
    public void Ability_WhenTypeIsUltimate_MaxLevelIsFive()
    {
      var ability = new Ability {Type = AbilityType.Ultimate};

      Assert.That(ability.MaxLevel, Is.EqualTo(5));
    }

    [TestCase(AbilityType.Passive)]
    [TestCase(AbilityType.Special)]
    [TestCase(AbilityType.Basic)]
    public void Ability_WhenTypeIsNotUltimate_MaxLevelIsSeven(AbilityType type)
    {
      var ability = new Ability {Type = type};

      Assert.That(ability.MaxLevel, Is.EqualTo(7));
    }

    [TestCase(AbilityType.Passive, 10)]
    [TestCase(AbilityType.Special, 20)]
    [TestCase(AbilityType.Basic, 90)]
    [TestCase(AbilityType.Ultimate, 7)]
    public void Ability_WhenLevelIsGreaterThanMaxLevel_WillBeEqualToMaxLevel(AbilityType type, int level)
    {
      var ability = new Ability {Type = type, Level = level};

      Assert.That(ability.Level, Is.EqualTo(ability.MaxLevel));
    }
  }
}
