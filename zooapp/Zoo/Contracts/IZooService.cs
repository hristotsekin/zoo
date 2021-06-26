using System.Collections.Generic;
using Zoo.Models;

namespace Zoo.Contracts
{
    public interface IZooService
    {
        /// <summary>
        /// Load 10 default Animals
        /// </summary>
        void Init();

        /// <summary>
        /// Gets all animals
        /// </summary>
        /// <returns>List with all Animals</returns>
        List<Animal> GetAll();

        /// <summary>
        /// Gets all alive animals
        /// </summary>
        /// <returns>List with all alive Animals</returns>
        List<Animal> GetAlive();

        /// <summary>
        /// Gets animals from specific specie with min health
        /// </summary>
        /// <param name="specie">Specie to choose</param>
        /// <returns>Weekest animal</returns>
        Animal GetSpeciesMinHealth(string specie);

        /// <summary>
        /// Feed all animals in the Zoo
        /// </summary>
        void HungerAnimals();

        /// <summary>
        /// Starve all animals in the Zoo
        /// </summary>
        void FeedAnimals();
    }
}
