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

        static void ShowHint()
        {
            Console.WriteLine();
            Console.WriteLine("HINT");

            if (currentScene == "cellar")
            {
                Console.WriteLine("Take useful items before leaving the cellar.");
            }
            else if (currentScene == "courtyard")
            {
                Console.WriteLine("Explore the castle before trying to escape.");
            }
            else if (currentScene == "chapel")
            {
                Console.WriteLine("Search for something connected to the royal family.");
            }
            else if (currentScene == "tower")
            {
                Console.WriteLine("The guards may have left a key behind.");
            }
            else if (currentScene == "stables")
            {
                Console.WriteLine("Useful travel equipment may still be here.");
            }
            else if (currentScene == "gate")
            {
                Console.WriteLine("You need something that can open the castle gate.");
            }
            else if (currentScene == "woods")
            {
                Console.WriteLine("Think carefully before trusting strangers.");
            }
            else if (currentScene == "watchtower")
            {
                Console.WriteLine("Your earlier choices may decide the fate of Blackmoor.");
            }
            else
            {
                Console.WriteLine("Look around carefully.");
            }
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
            Console.WriteLine("4. Ask for a hint");
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
                ShowHint();
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