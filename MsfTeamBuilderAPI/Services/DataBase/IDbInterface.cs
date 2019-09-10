using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MsfTeamBuilderAPI.Models.Entities;

namespace MsfTeamBuilderAPI.Services.DataBase
{
  /// <summary>
  /// TODO: Basically Need one of these for each object. Team, Toon, etc..
  /// </summary>
  /// <typeparam name="T"></typeparam>
  public interface IDbInterface<T> where T: BaseEntity
  {
    IEnumerable<T> List { get; }
    void Add(T entity);
    void Delete(T entity);
    void Update(T entity);
    T FindById(int id);
  }
}
