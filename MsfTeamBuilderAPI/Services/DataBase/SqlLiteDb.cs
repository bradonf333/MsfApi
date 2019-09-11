using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SQLite;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using MsfTeamBuilderAPI.Models;

namespace MsfTeamBuilderAPI.Services.DataBase
{
  public class SqlLiteDb
  {
    private readonly IOptions<AppSettings> _config;

    public SqlLiteDb(IOptions<AppSettings> config )
    {
      _config = config;
      var db = _config.Value.Database;
      SQLiteConnection.CreateFile("MyDatabase.sqlite");
    }
  }
}
