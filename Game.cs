using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Fall_of_Blackmoor
{
    //Game class that manages the main menu, inventory, current scene, and game flow.
    static class Game
    {
        //Used list for simple inventory.
        public static List<string> Inventory = new List<string>();
        public static string CurrentScene = "";

        //Main start of the game.
        public static void MainMenu()
        {
            Console.Clear();

            Console.WriteLine("================================");
            Console.WriteLine("       FALL OF BLACKMOOR");
            Console.WriteLine("================================");
            Console.WriteLine();
            Console.WriteLine("1. Start Game");
            Console.WriteLine("2. Load Game");
            Console.WriteLine("3. Instuctions");
            Console.WriteLine("4. Exit");
            Console.WriteLine();

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Scenes.Cellar();
            }
            else if (choice == "2")
            {
                SaveSystem.LoadGame();
            }
            else if (choice == "3")
            {
                ShowInstructions();
            }
            else if (choice == "4") {

                Console.WriteLine("Goodbye.");
            }
            else
            {
                Console.WriteLine("Invalid choice.");
                Console.ReadLine();
                MainMenu();
            }
        }

        public static void ReturnToMainMenu()
        {
            Console.Clear();

            Console.WriteLine("RETURN TO MAIN MENU");
            Console.WriteLine();
            Console.WriteLine("Do you want to save your game first?");
            Console.WriteLine();
            Console.WriteLine("1. Save and return to main menu");
            Console.WriteLine("2. Return without saving");
            Console.WriteLine();

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                SaveSystem.SaveGame();

                Console.WriteLine();
                Console.WriteLine("Press Enter to return to the main menu.");
                Console.ReadLine();

                Game.MainMenu();
            }
            else if (choice == "2")
            {
                Game.MainMenu();
            }
            else
            {
                Console.WriteLine("Invalid choice.");
                Console.ReadLine();

                ReturnToMainMenu();
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

        public static void ShowHint()
        {
            Console.WriteLine();
            Console.WriteLine("HINT");
            Console.WriteLine();

            if (CurrentScene == "cellar")
            {
                Console.WriteLine("Take useful items before leaving the cellar.");
            }
            else if (CurrentScene == "courtyard")
            {
                Console.WriteLine("Explore the castle before trying to escape.");
            }
            else if (CurrentScene == "chapel")
            {
                Console.WriteLine("Search near the altar.");
            }
            else if (CurrentScene == "tower")
            {
                Console.WriteLine("The guards may have left something useful behind.");
            }
            else if (CurrentScene == "stables")
            {
                Console.WriteLine("Search the supplies.");
            }
            else if (CurrentScene == "gate")
            {
                Console.WriteLine("You need something to unlock the gate.");
            }
            else if (CurrentScene == "woods")
            {
                Console.WriteLine("Think carefully before leaving the wounded knight behind.");
            }
            else if (CurrentScene == "watchtower")
            {
                Console.WriteLine("Your previous choices may decide the ending.");
            }
        }

        public static void ShowInventory()
        {
            Console.WriteLine();
            Console.WriteLine("INVENTORY");
            Console.WriteLine();

            if (Inventory.Count == 0)
            {
                Console.WriteLine("Your inventory is empty.");
            }
            else
            {
                foreach (string item in Inventory)
                {
                    Console.WriteLine("- " + item);
                }
            }
        }

        public static void ShowGoal()
        {
            Console.WriteLine();
            Console.WriteLine("CURRENT GOAL");
            Console.WriteLine();

            if (CurrentScene == "cellar")
            {
                Console.WriteLine("Escape the cellar.");
            }
            else if (CurrentScene == "courtyard")
            {
                Console.WriteLine("Explore Castle Blackmoor and find a way out.");
            }
            else if (CurrentScene == "gate")
            {
                Console.WriteLine("Find a way to open the castle gate.");
            }
            else if (CurrentScene == "woods")
            {
                Console.WriteLine("Discover who betrayed Blackmoor.");
            }
            else if (CurrentScene == "watchtower")
            {
                Console.WriteLine("Confront the traitor.");
            }
            else
            {
                Console.WriteLine("Discover what happened to Blackmoor.");
            }
        }
    }
}
