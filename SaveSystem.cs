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



    }
}
