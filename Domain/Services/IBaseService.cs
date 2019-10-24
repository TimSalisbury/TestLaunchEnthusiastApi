using System.Collections.Generic;

namespace TestAPI.Domain.Services
{
    public interface IBaseService<T>
    {
        List<T> Get();

        T Get(int id);
    }
}