using System;
using Zoo.Messages;

namespace Zoo.Models
{
    public class Giraffe : Animal
    {
        public Giraffe() : base("Giraffe", 100)
        {
            this.LifeThreshold = 60;
        }

        public override void Deplete()
        {
            if (this.status.Equals("alive") || this.status.Equals("paralyzed"))
            {
                this.Health -= this.RandonNumberInRange(15, 35);

                if (this.Health < this.LifeThreshold && this.status.Equals("alive"))
                {
                    this.status = "paralyzed";
                }
                else if (this.Health < this.LifeThreshold && this.status.Equals("paralyzed"))
                {
                    this.status = "dead";
                }
            }
            else
            {
                Console.WriteLine(string.Format(UiMessages.starving, this.Specie));
            }
        }

        public override void Feed()
        {
            if (!this.IsDead(this.LifeThreshold) && this.status.ToLower().Equals("alive"))
            {
                var tmp = this.RandonNumberInRange(10, 25);
                if (this.Health + tmp <= Animal.maxHealth)
                {
                    this.Health += tmp;
                }
                else
                {
                    this.Health = Animal.maxHealth;
                }
            }
            else
            {
                Console.WriteLine(UiMessages.feedingGiraffe);
            }
        }

        public override bool IsDead(int lifeThreshold)
        {
            if (this.Health < lifeThreshold && this.status.Equals("dead"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
