using System;

namespace ninjaWizard.Models {
    public class Wizard {
        public Wizard (string name, ISecretWeapon weapon) : base (name, weapon) {
            Health = 50;
            Intelligence = 25;
        }
    }
}