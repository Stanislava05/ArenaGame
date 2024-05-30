using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Magician:Hero
    {
            const int DoubleDamageChance = 30; // 30% chance to cast double damage spell
            const int ReflectDamageChance = 10; // 10% chance to reflect damage back to attacker

            public Magician() : this("Gandalf")
            {
            }

            public Magician(string name) : base(name)
            {
                Health = 300;
                StartingHealth = Health;
                Strength = 150;
            }

            public override void TakeDamage(int incomingDamage)
            {
               
                if (ThrowDice(ReflectDamageChance))
                {
                    Console.WriteLine($"{Name} reflected {incomingDamage} damage back to attacker!");
                   
                    return;
                }

                
                base.TakeDamage(incomingDamage);
            }

            public override int Attack()
            {
                int attack = base.Attack();
               
                if (ThrowDice(DoubleDamageChance)) attack *= 2;
                return attack;
            }
        
    }
}
