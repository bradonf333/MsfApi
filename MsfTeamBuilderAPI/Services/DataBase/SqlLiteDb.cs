using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using MsfTeamBuilderAPI.Models;
using MsfTeamBuilderAPI.Models.Entities;

namespace MsfTeamBuilderAPI.Services.DataBase
{
  public class SqlLiteDb : IRepository<Toon>
  {
    private readonly IOptions<AppSettings> _config;

    public SqlLiteDb(IOptions<AppSettings> config)
    {
      var toon = new BaseToon("DareDevil");
      toon.Traits.Add(Trait.Hero);
      toon.Traits.Add(Trait.City);
      toon.Traits.Add(Trait.Bio);
      toon.Traits.Add(Trait.Brawler);
      toon.Traits.Add(Trait.Defender);
      toon.Traits.Add(Trait.MartialArtist);
      toon.Abilities.Add(new Ability { Type = AbilityType.Basic, Name  = "Strike Without Fear", Level = 1});
      toon.Abilities.Add(new Ability { Type = AbilityType.Special, Name  = "Throw Baton", Level = 1 });
      toon.Abilities.Add(new Ability { Type = AbilityType.Ultimate, Name  = "Brawl", Level = 1 });
      toon.Abilities.Add(new Ability { Type = AbilityType.Passive, Name  = "Enhance Senses", Level = 1 });

      _config = config;
      var db = _config.Value.Database;
      SeedSqlLiteDb(db);
    }

    public IEnumerable<Toon> List { get; }

    public void Add(Toon entity)
    {
      throw new NotImplementedException();
    }

    public void Delete(Toon entity)
    {
      throw new NotImplementedException();
    }

    public void Update(Toon entity)
    {
      throw new NotImplementedException();
    }

    public Toon GetById(int id)
    {
      throw new NotImplementedException();
    }

    private void SeedSqlLiteDb(string db)
    {
      var connection = new SQLiteConnection($"Data Source={db}.sqlite;Version=3;");
      //TableSeed(connection);
    }

    private void TableSeed(SQLiteConnection connection)
    {
      connection.Open();

      var toonSql =
        " CREATE TABLE BaseToons ( " +
        " 	Name	TEXT NOT NULL, " +
        " 	Id		INTEGER PRIMARY KEY AUTOINCREMENT, " +
        " 	Level	INTEGER NOT NULL, " +
        " 	GearId  INTEGER NOT NULL " +
        " ); ";

      SQLiteCommand toonCommand = new SQLiteCommand(toonSql, connection);
      toonCommand.ExecuteNonQuery();

      var gearSql =
        " CREATE TABLE Gear ( " +
        " 	Id		INTEGER PRIMARY KEY AUTOINCREMENT, " +
        " 	Tier	INTEGER NOT NULL, " +
        " 	Slot1	INTEGER NOT NULL, " +
        " 	Slot2	INTEGER NOT NULL, " +
        " 	Slot3	INTEGER NOT NULL, " +
        " 	Slot4	INTEGER NOT NULL, " +
        " 	Slot5	INTEGER NOT NULL, " +
        " 	Slot6	INTEGER NOT NULL " +
        " ); ";

      SQLiteCommand gearCommand = new SQLiteCommand(gearSql, connection);
      gearCommand.ExecuteNonQuery();

      var abilitySql =
        " CREATE TABLE Abilities ( " +
        " 	Id			INTEGER PRIMARY KEY AUTOINCREMENT, " +
        " 	ToonId		INTEGER NOT NULL, " +
        " 	Type		TEXT NOT NULL, " +
        " 	Level		INTEGER NOT NULL, " +
        " 	Description	TEXT NOT NULL " +
        " ); ";

      SQLiteCommand abilityCommand = new SQLiteCommand(abilitySql, connection);
      abilityCommand.ExecuteNonQuery();

      var starSql =
      " CREATE TABLE StarRank ( " +
        " 	Id					INTEGER PRIMARY KEY AUTOINCREMENT, " +
        " 	ToonId				INTEGER NOT NULL, " +
        " 	Type				TEXT NOT NULL, " +
        " 	YellowStars			INTEGER NOT NULL, " +
        " 	RedStars			INTEGER NOT NULL, " +
        " 	CurrentShards		TEXT NOT NULL, " +
        " 	ShardsToNextRank	TEXT NOT NULL " +
        " ); ";

      SQLiteCommand starCommand = new SQLiteCommand(starSql, connection);
      starCommand.ExecuteNonQuery();

      connection.Close();
    }
  }
}
