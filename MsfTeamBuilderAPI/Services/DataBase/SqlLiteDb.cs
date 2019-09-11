using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SQLite;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using MsfTeamBuilderAPI.Models;
using MsfTeamBuilderAPI.Models.Entities;

namespace MsfTeamBuilderAPI.Services.DataBase
{
  public class SqlLiteDb : IRepository<Toon>
  {
    private readonly IOptions<AppSettings> _config;

    public SqlLiteDb(IOptions<AppSettings> config )
    {
      _config = config;
      var db = _config.Value.Database;
      SQLiteConnection.CreateFile($"{db}.sqlite");
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

    public Toon FindById(int id)
    {
      throw new NotImplementedException();
    }
  }
}
