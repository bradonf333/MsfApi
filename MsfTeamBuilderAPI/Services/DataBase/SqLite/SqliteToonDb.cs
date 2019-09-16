using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Microsoft.Extensions.Options;
using MsfTeamBuilderAPI.Models;
using MsfTeamBuilderAPI.Models.BaseToons;
using MsfTeamBuilderAPI.Models.Entities;

namespace MsfTeamBuilderAPI.Services.DataBase.SqLite
{
  public class SqLiteToonDb : IDbInterface<Models.BaseToons.BaseToon>
  {
    private readonly IOptions<AppSettings> _config;

    public SqLiteToonDb(IOptions<AppSettings> config)
    {
      _config = config;
      var db = _config.Value.Database;
      //SeedSqlLiteDb(db);
    }

    public IEnumerable<Models.BaseToons.BaseToon> List =>
      new List<Models.BaseToons.BaseToon>
      {
        new DareDevil(),
        new LukeCage(),
        new Drax(),
        new Gamora(),
        new Groot(),
        new Mantis(),
        new RocketRaccoon()
      };

    public void Add(Models.BaseToons.BaseToon entity)
    {
      throw new NotImplementedException();
    }

    public void Delete(Models.BaseToons.BaseToon entity)
    {
      throw new NotImplementedException();
    }

    public void Update(Models.BaseToons.BaseToon entity)
    {
      throw new NotImplementedException();
    }

    public Models.BaseToons.BaseToon FindById(int id)
    {
      throw new NotImplementedException();
    }

    private void SeedSqlLiteDb(string db)
    {
      var connection = new SQLiteConnection($"Data Source={db}.sqlite;Version=3;");
      TableSeed(connection);
    }

    private void TableSeed(SQLiteConnection connection)
    {
      connection.Open();

      var toonSql =
        " CREATE TABLE BaseToons ( " +
        " 	Id	  INTEGER PRIMARY KEY AUTOINCREMENT, " +
        " 	Name  TEXT NOT NULL " +
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
        " 	Id			    INTEGER PRIMARY KEY AUTOINCREMENT, " +
        " 	ToonId		  INTEGER NOT NULL, " +
        " 	Type		    TEXT NOT NULL, " +
        " 	Level		    INTEGER NOT NULL, " +
        " 	Description	TEXT NOT NULL " +
        " ); ";

      SQLiteCommand abilityCommand = new SQLiteCommand(abilitySql, connection);
      abilityCommand.ExecuteNonQuery();

      var starSql =
        " CREATE TABLE StarRank ( " +
        " 	Id					      INTEGER PRIMARY KEY AUTOINCREMENT, " +
        " 	ToonId				    INTEGER NOT NULL, " +
        " 	Type				      TEXT NOT NULL, " +
        " 	YellowStars			  INTEGER NOT NULL, " +
        " 	RedStars			    INTEGER NOT NULL, " +
        " 	CurrentShards		  TEXT NOT NULL, " +
        " 	ShardsToNextRank	TEXT NOT NULL " +
        " ); ";

      SQLiteCommand starCommand = new SQLiteCommand(starSql, connection);
      starCommand.ExecuteNonQuery();

      connection.Close();
    }
  }
}