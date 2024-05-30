using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    internal class Paladin : Hero
    {
        const int HealChance = 20; 
        private const int HealAmount = 50;
        const int ShieldBlockChance = 10; 

        public Paladin() : this("Sir Arthur")
        {
        }

        public Paladin(string name) : base(name)
        {
        }

        public override void TakeDamage(int incomingDamage)
        {
            
            if (ThrowDice(ShieldBlockChance)) incomingDamage = 0;

            
            base.TakeDamage(incomingDamage);

            
            if (ThrowDice(HealChance)) Heal(HealAmount);
        }

        public override int Attack()
        {
            int attack = base.Attack();
            
            return attack;
        }
    }
}
    

