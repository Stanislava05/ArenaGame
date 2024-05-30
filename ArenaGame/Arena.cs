namespace ArenaGame
{
    public class Arena
    {
        public Hero HeroA { get; private set; }
        public Hero HeroB { get; private set; }

        public Arena(Hero a, Hero b)
        {
            HeroA = a;
            HeroB = b;
        }

        public Hero Battle()
        {
            Hero attacker, defender;
            if (new Random().Next(2) == 0)
            {
                attacker = HeroA;
                defender = HeroB;
            }
            else
            {
                attacker = HeroB;
                defender = HeroA;
            }

            while (true)
            {
                int damage = attacker.Attack();
                defender.TakeDamage(damage);
                if (defender.IsDead) return attacker;

                
                (attacker, defender) = (defender, attacker);
            }
        }
    }
}
