using ArenaGame;
using static ArenaGame.Weapon;

namespace ConsoleGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of battles:");
            int rounds = int.Parse(Console.ReadLine());
            int oneWins = 0, twoWins = 0;

            for (int i = 0; i < rounds; i++)
            {
                Hero one = new Knight("Sir Arthur");
                Hero two = new Magician("Gandalf");

                
                one.EquipWeapon(new Weapon("Sword", 10, "None"));
                two.EquipWeapon(new Weapon("Bow", 8, "Long range attack"));

                Console.WriteLine($"Arena fight between {one.Name} and {two.Name}");
                Arena arena = new Arena(one, two);
                Hero winner = arena.Battle();
                Console.WriteLine($"Winner is: {winner.Name}");
                if (winner == one) oneWins++; else twoWins++;
            }

            Console.WriteLine();
            Console.WriteLine($"One has {oneWins} wins.");
            Console.WriteLine($"Two has {twoWins} wins.");
            Console.ReadLine();
        }
    }
}
    

