using System.Collections.Generic;
using Zoo.Contracts;
using Zoo.Models;

namespace Zoo
{
    public class Database : IDatabase
    {
        public List<Animal> Animals { get; set; } = new List<Animal>();
    }
}
