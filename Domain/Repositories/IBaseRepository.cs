using System.Collections.Generic;
using TestAPI.Domain.Models;

namespace TestAPI.Domain.Repositories
{
    public interface IBaseRepository<T> where T: DatabaseObject
    {
        List<T> Get();

        T Get(int id);
    }
}