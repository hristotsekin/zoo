using System;
using System.Collections.Generic;
using System.Linq;
using Zoo.Contracts;
using Zoo.Models;

namespace Zoo.Services
{
    public class ZooService : IZooService
    {
        private IDatabase database; 
        public ZooService(IDatabase db)
        {
            this.database = db;
        }

        public void Init()
        {

            for(int i = 0; i < 10; i++)
            {
                if(i <= 3)
                {
                    this.database.Animals.Add(new Monkey());
                }
                else if(i > 3 && i <= 6)
                {
                    this.database.Animals.Add(new Bear());
                }
                else
                {
                    this.database.Animals.Add(new Giraffe());
                }
            }
        }

        public List<Animal> GetAll()
        {
            return this.database.Animals;
        }

        public List<Animal> GetAlive()
        {
            return this.database.Animals.Where(a => a.IsDead(a.LifeThreshold) == false).ToList();
        }

        public Animal GetSpeciesMinHealth(string specie)
        {

            var result = this.database.Animals.Where(a => a.IsDead(a.LifeThreshold) == false
                    && a.Specie.ToLower().Equals(specie.ToLower()))
                .OrderBy(a => a.Health)
                .Take(1)
                .FirstOrDefault();

            return result;
        }

        public void HungerAnimals()
        {
            Console.WriteLine("Starving");

            foreach (var item in this.database.Animals)
            {
                item.Deplete();
            }
        }

        public void FeedAnimals()
        {
            Console.WriteLine("Feeding");

            var forFeeding = (int)Math.Floor(this.database.Animals.Count * 0.9);
            var animalsAsc = this.database.Animals.OrderBy(a => a.Health).Take(forFeeding);

            foreach (var item in animalsAsc)
            {
                item.Feed();
            }
        }
    }
}
