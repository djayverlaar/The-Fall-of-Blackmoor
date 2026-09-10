using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Fall_of_Blackmoor
{
    static class Game
    {
        public static List<string> Inventory = new List<string>();
        public static string CurrentScene = "";

        public static void MainMenu()
        {
            Console.Clear();

            Console.WriteLine("================================");
            Console.WriteLine("       FALL OF BLACKMOOR");
            Console.WriteLine("================================");
            Console.WriteLine();
            Console.WriteLine("1. Start Game");
            Console.WriteLine("2. Instructions");
            Console.WriteLine("3. Exit");
            Console.WriteLine();

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Scenes.Cellar();
            }
            else if (choice == "2")
            {
                ShowInstructions();
            }
            else if (choice == "3")
            {
                Console.WriteLine("Goodbye.");
            }
            else
            {
                Console.WriteLine("Invalid choice.");
                Console.ReadLine();
                MainMenu();
            }
        }

        public static void ShowInstructions()
        {
            Console.Clear();

            Console.WriteLine("INSTRUCTIONS");
            Console.WriteLine();
            Console.WriteLine("Enter the number of the action you want to perform.");
            Console.WriteLine("Explore Castle Blackmoor and collect useful items.");
            Console.WriteLine("Some choices will affect what happens later.");
            Console.WriteLine("You can ask for a hint when you are stuck.");
            Console.WriteLine();
            Console.WriteLine("Press Enter to return.");

            Console.ReadLine();

            MainMenu();
        }
    }
}
