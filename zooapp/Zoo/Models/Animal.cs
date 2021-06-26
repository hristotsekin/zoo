using System;
using System.Text;

namespace Zoo.Models
{
    public abstract class Animal
    {
        protected string status;
        protected static readonly int maxHealth = 100;
        protected static readonly int minHealth = 0;
        public Animal(string specie, double health)
        {
            this.Health = health;
            this.status = "alive";
            this.Specie = specie;
        }

        public int LifeThreshold { get; set; }
        public string Specie { get; set; }
        public double Health { get; set; }

        /// <summary>
        /// Increase health if animal is alive
        /// </summary>
        public abstract void Feed();

        /// <summary>
        /// Decrease health if animal is alive or paralized
        /// </summary>
        public abstract void Deplete();

        /// <summary>
        /// Check if animal is dead
        /// </summary>
        /// <param name="lifeThreshold">LifeThreshold for specific animal</param>
        /// <returns>bool value</returns>
        public virtual bool IsDead(int lifeThreshold)
        {
            if (this.Health < lifeThreshold)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int RandonNumberInRange(int min, int max)
        {
            Random r = new Random();
            return r.Next(min, max);
        }

        public override string ToString()
        {
            StringBuilder message = new StringBuilder();
            message.Append($"{this.Specie} health: {this.Health}");
            message.Append($" status: {this.status}");

            return message.ToString();
        }
    }
}
