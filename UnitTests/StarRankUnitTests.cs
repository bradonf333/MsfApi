using MsfTeamBuilderAPI.Models.Entities;
using NUnit.Framework;

namespace UnitTests
{

  public class StarRankUnitTests
  {
    [TestCase(1, 30)]
    [TestCase(4, 130)]
    [TestCase(7, 0)]
    public void ShardsToNextRank_IsCorrectWhenGivenYellowStarLevel(int yellowStars, int expectedShards)
    {
      var starRank = new StarRank(yellowStars);
      var actual = starRank.ShardsToNextRank;
      Assert.That(expectedShards, Is.EqualTo(actual));
    }

    [TestCase(-1, 1)]
    [TestCase(0, 1)]
    [TestCase(3, 3)]
    [TestCase(7, 7)]
    [TestCase(9, 7)]
    public void YellowStars_WhenCreated_FollowsGuidelines(int yellowStars, int expectedStars)
    {
      var starRank = new StarRank(yellowStars);
      var actual = starRank.YellowStars;
      Assert.That(expectedStars, Is.EqualTo(actual));
    }
  }
}
