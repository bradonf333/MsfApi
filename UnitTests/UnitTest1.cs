using FakeItEasy;
using MsfTeamBuilderAPI.Models.Entities;
using MsfTeamBuilderAPI.Services;
using MsfTeamBuilderAPI.Services.DataBase;
using NUnit.Framework;

namespace Tests
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
      var fakeRepo = A.Fake<IRepository<Toon>>();
      //A.CallTo(() => fakeRepo.Add(A<Toon>._)).MustHaveHappened();

      var x = new GetToonService(fakeRepo);
      Assert.Pass();
    }
  }
}