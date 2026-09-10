using System;
using System.Collections.Generic;

namespace FallOfBlackmoor
{
    class Program
    {
        static List<string> inventory = new List<string>();
        static string currentScene = "";

        static void Main()
        {
            Console.Title = "Fall of Blackmoor";

            Console.WriteLine("================================");
            Console.WriteLine("       FALL OF BLACKMOOR");
            Console.WriteLine("================================\n test");
            Console.WriteLine();
            Console.WriteLine("1. Start Game");
            Console.WriteLine("2. Instructions");
            Console.WriteLine("3. Exit");
            Console.WriteLine();

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                SceneCellar();
            }
            else if (choice == "2")
            {
                ShowInstructions();
                Main();
            }
            else if (choice == "3")
            {
                Console.WriteLine("Goodbye.");
            }
            else
            {
                Console.WriteLine("Invalid choice.");
                Console.ReadLine();
                Main();
            }
        }
    }
}