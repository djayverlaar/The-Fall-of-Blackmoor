using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Fall_of_Blackmoor
{
    static class SaveSystem
    {
        public static void SaveGame()
        {
            File.WriteAllLines("inventory.txt", Game.Inventory);
            File.WriteAllText("scene.txt", Game.CurrentScene);

            Console.WriteLine();
            Console.WriteLine("Game saved.");
        }

        public static void LoadGame()
        {
            if (!File.Exists("inventory.txt") || !File.Exists("scene.txt"))
            {
                Console.WriteLine();
                Console.WriteLine("No saved game found.");

                Console.ReadLine();

                Game.MainMenu();

                return;
            }

            Game.Inventory.Clear();
            Game.Inventory.AddRange(File.ReadAllLines("inventory.txt"));

            Game.CurrentScene = File.ReadAllText("scene.txt");

            if (Game.CurrentScene == "cellar")
            {
                Scenes.Cellar();
            }
            else if (Game.CurrentScene == "courtyard")
            {
                Scenes.Courtyard();
            }
            else if (Game.CurrentScene == "chapel")
            {
                Scenes.Chapel();
            }
            else if (Game.CurrentScene == "tower")
            {
                Scenes.GuardTower();
            }
            else if (Game.CurrentScene == "stables")
            {
                Scenes.Stables();
            }
            else if (Game.CurrentScene == "gate")
            {
                Scenes.CastleGate();
            }
            else if (Game.CurrentScene == "woods")
            {
                Scenes.Woods();
            }
            else if (Game.CurrentScene == "watchtower")
            {
                Scenes.Watchtower();
            }
            else
            {
                Scenes.Cellar();
            }
        }



    }
}
