using System;
namespace ninjaWizard.Models
{
    public class Samurai : Human
    {
        public Samurai(string name) : base(name)
        {
            health = 200;
        }

        public override int Attack(Human target)
        {
            int dmg = Intelligence * 5;
            target.Health -= dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            health += dmg;
            return target.Health;
        }
        public int Meditate()
        {
            Health = 200;
            Console.WriteLine($"{Name} has healed {Health.ToString()} hp!");
            return Health;
        }
    }
}