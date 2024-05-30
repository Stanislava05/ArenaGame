namespace ArenaGame
{
    public class Hero
    {
        public string Name { get;  set; }

        public int Health { get;  set; }

        public int Strength { get;  set; }

        protected int StartingHealth { get;  set; }

        public bool IsDead { get { return Health <= 0; } }
        public Weapon EquippedWeapon { get; private set; }

        public Hero(string name)
        {
            Name = name;
            Health = 500;
            StartingHealth = Health;
            Strength = 100;
        }
        public void EquipWeapon(Weapon weapon)
        {
            EquippedWeapon = weapon;
        }

        

        public virtual int Attack()
        {
            int weaponBonus = EquippedWeapon != null ? EquippedWeapon.AttackPoints : 0;
            return ((Strength + weaponBonus) * new Random().Next(80, 121)) / 100;

        }

        public virtual void TakeDamage(int incomingDamage)
        {
            if (incomingDamage < 0) return;
            Health = Health - incomingDamage;
        }

        protected bool ThrowDice(int chance)
        {
            int dice = Random.Shared.Next(101);
            return dice <= chance;
        }

        protected void Heal(int value)
        {
            Health = Health + value;
            if (Health > StartingHealth) Health = StartingHealth;
        }
    }
}
