using System.Collections.Generic;

namespace MsfTeamBuilderAPI.Services.DataBase
{
  /// <summary>
  /// TODO: Basically Need one of these for each object. Team, Toon, etc..
  /// </summary>
  /// <typeparam name="T"></typeparam>
  public interface IDbInterface<T> where T: class
  {
    IEnumerable<T> List { get; }
    void Add(T entity);
    void Delete(T entity);
    void Update(T entity);
    T FindById(int id);
  }
}
