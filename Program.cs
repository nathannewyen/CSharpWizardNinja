using System;
using ninjaWizard.Models;

namespace ninjaWizard
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard nathanWiz = new Wizard("Wizar");
            Ninja nathanNinja = new Ninja("Ninja");
            Samurai nathanSamurai = new Samurai("Samurai");
            nathanWiz.Attack(nathanNinja);
            nathanNinja.Attack(nathanSamurai);
            nathanWiz.Attack(nathanSamurai);
            nathanSamurai.Attack(nathanWiz);
            nathanSamurai.Meditate();
        }
    }
}
