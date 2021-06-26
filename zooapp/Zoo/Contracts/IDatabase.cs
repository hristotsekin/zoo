using System.Collections.Generic;
using Zoo.Models;

namespace Zoo.Contracts
{
    public interface IDatabase
    {
        List<Animal> Animals { get; }
    }
}
