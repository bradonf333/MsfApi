using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MsfTeamBuilderAPI.Services.DataBase
{
  public class JsonFileDb
  {
    private readonly string _location;

    public JsonFileDb(string location)
    {
      _location = location;
    }
  }
}
