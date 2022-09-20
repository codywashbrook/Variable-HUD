using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable_HUD_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int health;
            int shield;
            int lives;
            int multiplier;

            string stats;
            string enemyAttacks;

            health = 100;
            shield = 100;
            lives = 1;

            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Variable HUD");
            Console.ResetColor();
            Console.WriteLine("");

            stats = "Health: " + health;
            Console.WriteLine(stats);
            stats = "Shield: " + shield;
            Console.WriteLine(stats);
            stats = "Lives: " + lives;
            Console.WriteLine(stats);



            Console.ReadKey(true);
        }
    }
}
