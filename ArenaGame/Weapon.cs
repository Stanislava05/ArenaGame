using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Weapon
    {
        
            public string Name { get; set; }
            public int AttackPoints { get; set; }
        public string SpecAbility { get; set; }

        public Weapon(string name, int attackPoints, string specAbility = null)
            {
                Name = name;
                AttackPoints = attackPoints;
                SpecAbility = specAbility;
            }
        public class Sword : Weapon
        {
            public Sword() : base("Sword", 10, "None") { }
        }

        public class Bow : Weapon
        {
            public Bow() : base("Bow", 8, "Long distance attack") { }
        }

        public class Axe : Weapon
        {
            public Axe() : base("Axe", 12, "High damage attack") { }
        }
    }
}
