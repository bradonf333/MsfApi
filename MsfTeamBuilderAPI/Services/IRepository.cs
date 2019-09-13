using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MsfTeamBuilderAPI.Models.Entities;

namespace MsfTeamBuilderAPI.Services
{
  public interface IRepository<T> where T: BaseEntity
  {
    IEnumerable<T> List { get; }
    void Add(T entity);
    void Delete(T entity);
    void Update(T entity);
    T GetById(int id);
  }
}
