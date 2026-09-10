using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Fall_of_Blackmoor
{
    static class Scenes
    {

        public static void Cellar()
        {
            Game.CurrentScene = "cellar";

            Console.Clear();

            Console.WriteLine("CASTLE CELLAR");
            Console.WriteLine();
            Console.WriteLine("You wake up on the cold stone floor.");
            Console.WriteLine("Above you, you hear shouting and clashing swords.");
            Console.WriteLine("Castle Blackmoor is under attack.");
            Console.WriteLine();
            Console.WriteLine("A torch lies near a wooden barrel.");
            Console.WriteLine("An old rusty sword rests against the wall.");
            Console.WriteLine();

            Console.WriteLine("1. Take the torch");
            Console.WriteLine("2. Take the rusty sword");
            Console.WriteLine("3. Leave the cellar");
            Console.WriteLine("4. Ask for a hint");
            Console.WriteLine();

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                if (!Game.Inventory.Contains("Torch"))
                {
                    Game.Inventory.Add("Torch");
                    Console.WriteLine("You take the torch.");
                }
                else
                {
                    Console.WriteLine("You already have the torch.");
                }

                Console.ReadLine();
                Cellar();
            }
            else if (choice == "2")
            {
                if (!Game.Inventory.Contains("Rusty Sword"))
                {
                    Game.Inventory.Add("Rusty Sword");
                    Console.WriteLine("You take the rusty sword.");
                }
                else
                {
                    Console.WriteLine("You already have the sword.");
                }

                Console.ReadLine();
                Cellar();
            }
            else if (choice == "3")
            {
                Courtyard();
            }
            else if (choice == "4")
            {
                Game.ShowHint();

                Console.ReadLine();
                Cellar();
            }
            else
            {
                Console.WriteLine("Invalid choice.");

                Console.ReadLine();
                Cellar();
            }
        }
    }

}
}
