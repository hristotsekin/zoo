using System;
using Zoo.Contracts;
using Zoo.Services;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            IDatabase data = new Database();
            IZooService zooService = new ZooService(data);
            zooService.Init();

            Console.WriteLine();
            Console.WriteLine("Initial ");
            foreach (var item in zooService.GetAll())
            {
                Console.WriteLine(item);
            }

            zooService.HungerAnimals();

            Console.WriteLine();
            Console.WriteLine("After Starving");
            foreach (var item in zooService.GetAll())
            {
                Console.WriteLine(item);
            }

            zooService.HungerAnimals();

            Console.WriteLine();
            Console.WriteLine("After Starving");
            foreach (var item in zooService.GetAll())
            {
                Console.WriteLine(item);
            }

            zooService.FeedAnimals();
            
            Console.WriteLine();
            Console.WriteLine("After Feeding");
            foreach (var item in zooService.GetAll())
            {
                Console.WriteLine(item);
            }

            zooService.HungerAnimals();

            Console.WriteLine();
            Console.WriteLine("After Starving");
            foreach (var item in zooService.GetAll())
            {
                Console.WriteLine(item);
            }


            Console.WriteLine();
            Console.WriteLine("We have: " + zooService.GetAll().Count + " in our Zoo");
            Console.WriteLine("Alive animals: " + zooService.GetAlive().Count);

            var minMonkey = zooService.GetSpeciesMinHealth("Monkey");
            if (minMonkey != null)
            {
                Console.WriteLine("Weakest: " + minMonkey);
            }
            else
            {
                Console.WriteLine("All monkeys are dead");
            }

            var minBear = zooService.GetSpeciesMinHealth("Bear");
            if (minBear != null)
            {
                Console.WriteLine("Weakest: " + minBear);
            }
            else
            {
                Console.WriteLine("All bears are dead");
            }

            var minGiraff = zooService.GetSpeciesMinHealth("Giraffe");
            if (minGiraff != null)
            {
                Console.WriteLine("Weakest: " + minGiraff);
            }
            else
            {
                Console.WriteLine("All giraffes are dead");
            }


        }
    }
}
