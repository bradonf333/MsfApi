using System.Security.Cryptography.X509Certificates;
using FakeItEasy;
using MsfTeamBuilderAPI.Models.BaseToons;
using MsfTeamBuilderAPI.Models.Entities;
using MsfTeamBuilderAPI.Services;
using MsfTeamBuilderAPI.Services.Interfaces;
using NUnit.Framework;
using System.Linq;
using MsfTeamBuilderAPI.Models;

namespace UnitTests
{
  public class Tests
  {
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
      var dareDevil = new DareDevil();
      var basicAbility = dareDevil.Abilities.Where(a => a.Type == AbilityType.Basic).FirstOrDefault();

      Assert.Pass();
    }
  }
}