using System;
using Zoo.Messages;

namespace Zoo.Models
{
    public class Monkey : Animal
    {
        public Monkey() : base("Monkey", 100)
        {
            this.LifeThreshold = 40;
        }

        public override void Deplete()
        {
            if (!this.IsDead(this.LifeThreshold))
            {
                this.Health -= this.RandonNumberInRange(15, 35);

                if (this.IsDead(this.LifeThreshold))
                    this.status = "dead";
            }
            else
            {
                Console.WriteLine(string.Format(UiMessages.starving, this.Specie));
            }
        }

        public override void Feed()
        {
            if (!this.IsDead(this.LifeThreshold))
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
                Console.WriteLine(string.Format(UiMessages.feeding, this.Specie));
            }
        }
    }
}
