using System.Collections.Generic;
using MsfTeamBuilderAPI.Models.BaseToons;
using MsfTeamBuilderAPI.Models.Entities;

namespace MsfTeamBuilderAPI.Services.Interfaces
{
  public interface IRepository<T> where T: IToon
  {
    IEnumerable<T> List { get; }
    void Add(T entity);
    void Delete(T entity);
    void Update(T entity);
    T GetById(int id);
  }
}
