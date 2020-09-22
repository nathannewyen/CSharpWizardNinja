using System;

namespace ninjaWizard.Models
{
    public class Wizard : Human
    {
        public Wizard(string name) : base(name)
        {
            Intelligence = 25;
            health = 50;
        }
        public override int Attack(Human target)
        {
            base.Attack(target);
            if (target.Health < 50)
            {
                target.Health = 0;
            }
            return target.Health;
        }

        public int Heal(Human target)
        {
            int cure = Intelligence * 10;
            target.Health += cure;
            Console.WriteLine($"{Name} has healed {target.Name} and restored {cure.ToString()} hp!");
            return target.Health;
        }
    }
}