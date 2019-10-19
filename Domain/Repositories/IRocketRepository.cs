using System.Collections.Generic;
using TestAPI.Domain.Models;

namespace TestAPI.Domain.Repositories
{
    public interface IRocketRepository
    {
        List<Rocket> Get();

        Rocket Get(int id);
    }
}