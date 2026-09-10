using System;
using System.Collections.Generic;

namespace TheFallOfBlackmoor
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
            Console.WriteLine("================================");
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
                Console.Clear();
                Main();
            }
        }

        static void ShowInstructions()
        {
            Console.Clear();

            Console.WriteLine("INSTRUCTIONS");
            Console.WriteLine();
            Console.WriteLine("Choose an action by entering a number.");
            Console.WriteLine("Some choices affect what happens later.");
            Console.WriteLine("You can collect useful items.");
            Console.WriteLine("Some items are needed to progress.");
            Console.WriteLine("You can ask for a hint if you are stuck.");
            Console.WriteLine();
            Console.WriteLine("Press Enter to return.");

            Console.ReadLine();
            Console.Clear();
        }

        static void ShowInventory()
        {
            Console.WriteLine();
            Console.WriteLine("INVENTORY");

            if (inventory.Count == 0)
            {
                Console.WriteLine("Your inventory is empty.");
            }
            else
            {
                foreach (string item in inventory)
                {
                    Console.WriteLine("- " + item);
                }
            }
        }

        static void ShowGoal()
        {
            Console.WriteLine();
            Console.WriteLine("CURRENT GOAL");
            Console.WriteLine("Escape Castle Blackmoor and discover who attacked the kingdom.");
        }

        static void SceneCellar()
        {
            currentScene = "cellar";
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
            Console.WriteLine("4. Show goal");
            Console.WriteLine();

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                if (!inventory.Contains("Torch"))
                {
                    inventory.Add("Torch");
                    Console.WriteLine("You take the torch.");
                }
                else
                {
                    Console.WriteLine("You already have the torch.");
                }

                Console.ReadLine();
                SceneCellar();
            }
            else if (choice == "2")
            {
                if (!inventory.Contains("Rusty Sword"))
                {
                    inventory.Add("Rusty Sword");
                    Console.WriteLine("You take the rusty sword.");
                }
                else
                {
                    Console.WriteLine("You already have the rusty sword.");
                }

                Console.ReadLine();
                SceneCellar();
            }
            else if (choice == "3")
            {
               
            }
            else if (choice == "4")
            {
                ShowGoal();
                Console.ReadLine();
                SceneCellar();
            }
            else
            {
                Console.WriteLine("Invalid choice.");
                Console.ReadLine();
                SceneCellar();
            }
        }
    }
}