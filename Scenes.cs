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
        public static void Courtyard()
        {
            Game.CurrentScene = "courtyard";

            Console.Clear();

            Console.WriteLine("CASTLE COURTYARD");
            Console.WriteLine();
            Console.WriteLine("You step into the castle courtyard.");
            Console.WriteLine("Smoke rises above the walls.");
            Console.WriteLine("The sound of battle can still be heard outside.");
            Console.WriteLine();
            Console.WriteLine("You see the chapel, guard tower and stables.");
            Console.WriteLine();

            Console.WriteLine("1. Go to the chapel");
            Console.WriteLine("2. Go to the guard tower");
            Console.WriteLine("3. Go to the stables");
            Console.WriteLine("4. Show inventory");
            Console.WriteLine("5. Ask for a hint");
            Console.WriteLine();

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Chapel();
            }
            else if (choice == "2")
            {
               GuardTower();
            }


            else if (choice == "3")
            {
                Stables();
            }
            else if (choice == "4")
            {
                Game.ShowInventory();

                Console.ReadLine();
                Courtyard();
            }
            else if (choice == "5")
            {
                Game.ShowHint();

                Console.ReadLine();
                Courtyard();
            }
            else
            {
                Console.WriteLine("Invalid choice.");

                Console.ReadLine();
                Courtyard();
            }
        }
        public static void Chapel()
        {
            Game.CurrentScene = "chapel";

            Console.Clear();

            Console.WriteLine("CASTLE CHAPEL");
            Console.WriteLine();
            Console.WriteLine("The chapel is silent.");
            Console.WriteLine("Broken candles lie across the stone floor.");
            Console.WriteLine("A torn letter lies beside the altar.");
            Console.WriteLine();

            Console.WriteLine("1. Search the altar");
            Console.WriteLine("2. Read the letter");
            Console.WriteLine("3. Return to the courtyard");
            Console.WriteLine("4. Ask for a hint");
            Console.WriteLine();

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                if (!Game.Inventory.Contains("Royal Seal"))
                {
                    Game.Inventory.Add("Royal Seal");

                    Console.WriteLine();
                    Console.WriteLine("You find the Royal Seal of Blackmoor.");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("There is nothing else here.");
                }

                Console.ReadLine();
                Chapel();
            }
            else if (choice == "2")
            {
                Console.WriteLine();
                Console.WriteLine("The letter says:");
                Console.WriteLine();
                Console.WriteLine("\"The castle gates were opened from inside.\"");
                Console.WriteLine("\"Someone close to the king betrayed Blackmoor.\"");

                Console.ReadLine();
                Chapel();
            }
            else if (choice == "3")
            {
                Courtyard();
            }
            else if (choice == "4")
            {
                Game.ShowHint();

                Console.ReadLine();
                Chapel();
            }
            else
            {
                Console.WriteLine("Invalid choice.");

                Console.ReadLine();
                Chapel();
            }
        }

        public static void GuardTower()
        {
            Game.CurrentScene = "tower";

            Console.Clear();

            Console.WriteLine("GUARD TOWER");
            Console.WriteLine();
            Console.WriteLine("The tower has been abandoned.");
            Console.WriteLine("A wooden desk stands near the window.");
            Console.WriteLine();

            Console.WriteLine("1. Search the desk");
            Console.WriteLine("2. Look outside");
            Console.WriteLine("3. Return to the courtyard");
            Console.WriteLine("4. Ask for a hint");
            Console.WriteLine();

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                if (!Game.Inventory.Contains("Gate Key"))
                {
                    Game.Inventory.Add("Gate Key");

                    Console.WriteLine();
                    Console.WriteLine("You find the Castle Gate Key.");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("The desk is empty.");
                }

                Console.ReadLine();
                GuardTower();
            }
            else if (choice == "2")
            {
                Console.WriteLine();
                Console.WriteLine("Enemy soldiers surround the castle.");
                Console.WriteLine("The road is blocked, but the forest looks clear.");

                Console.ReadLine();
                GuardTower();
            }
            else if (choice == "3")
            {
                Courtyard();
            }
            else if (choice == "4")
            {
                Game.ShowHint();

                Console.ReadLine();
                GuardTower();
            }
            else
            {
                Console.WriteLine("Invalid choice.");

                Console.ReadLine();
                GuardTower();
            }
        }

        public static void Stables()
        {
            Game.CurrentScene = "stables";

            Console.Clear();

            Console.WriteLine("CASTLE STABLES");
            Console.WriteLine();
            Console.WriteLine("The stables smell of hay and smoke.");
            Console.WriteLine("Most of the horses are gone.");
            Console.WriteLine("A rope hangs from a wooden post.");
            Console.WriteLine();

            Console.WriteLine("1. Take the rope");
            Console.WriteLine("2. Check the horses");
            Console.WriteLine("3. Go to the castle gate");
            Console.WriteLine("4. Return to the courtyard");
            Console.WriteLine();

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                if (!Game.Inventory.Contains("Rope"))
                {
                    Game.Inventory.Add("Rope");

                    Console.WriteLine();
                    Console.WriteLine("You take the rope.");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("You already have the rope.");
                }

                Console.ReadLine();
                Stables();
            }
            else if (choice == "2")
            {
                Console.WriteLine();
                Console.WriteLine("One horse remains, but it is too frightened to ride.");

                Console.ReadLine();
                Stables();
            }
            else if (choice == "3")
            {
                CastleGate();
            }
            else if (choice == "4")
            {
                Courtyard();
            }
            else
            {
                Console.WriteLine("Invalid choice.");

                Console.ReadLine();
                Stables();
            }
        }

        public static void CastleGate()
        {
            Game.CurrentScene = "gate";

            Console.Clear();

            Console.WriteLine("CASTLE GATE");
            Console.WriteLine();
            Console.WriteLine("The enormous wooden gate is locked.");
            Console.WriteLine("Enemy soldiers are getting closer.");
            Console.WriteLine();

            Console.WriteLine("1. Try to open the gate");
            Console.WriteLine("2. Show inventory");
            Console.WriteLine("3. Return to the courtyard");
            Console.WriteLine("4. Ask for a hint");
            Console.WriteLine();

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                if (Game.Inventory.Contains("Gate Key"))
                {
                    Console.WriteLine();
                    Console.WriteLine("You use the Gate Key.");
                    Console.WriteLine("The heavy gate slowly opens.");
                    Console.WriteLine("You escape into the forest.");

                    Console.ReadLine();

                    Woods();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("The gate is locked.");
                    Console.WriteLine("You need a key.");

                    Console.ReadLine();

                    CastleGate();
                }
            }
            else if (choice == "2")
            {
                Game.ShowInventory();

                Console.ReadLine();
                CastleGate();
            }
            else if (choice == "3")
            {
                Courtyard();
            }
            else if (choice == "4")
            {
                Game.ShowHint();

                Console.ReadLine();
                CastleGate();
            }
            else
            {
                Console.WriteLine("Invalid choice.");

                Console.ReadLine();
                CastleGate();
            }
        }

        public static void Woods()
        {
            Game.CurrentScene = "woods";

            Console.Clear();

            Console.WriteLine("BLACKMOOR WOODS");
            Console.WriteLine();
            Console.WriteLine("The burning castle disappears behind the trees.");
            Console.WriteLine("Beside the road you find a wounded Blackmoor knight.");
            Console.WriteLine();

            Console.WriteLine("1. Help the knight");
            Console.WriteLine("2. Question the knight");
            Console.WriteLine("3. Ignore him");
            Console.WriteLine("4. Ask for a hint");
            Console.WriteLine();

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine();
                Console.WriteLine("You help the wounded knight.");
                Console.WriteLine("He tells you that Lord Varrick betrayed the king.");

                if (!Game.Inventory.Contains("Knight Trust"))
                {
                    Game.Inventory.Add("Knight Trust");
                }

                Console.ReadLine();

                Watchtower();
            }
            else if (choice == "2")
            {
                Console.WriteLine();
                Console.WriteLine("The knight tells you Lord Varrick disappeared before the attack.");
                Console.WriteLine("He believes Varrick is the traitor.");

                Console.ReadLine();

                Watchtower();
            }
            else if (choice == "3")
            {
                Console.WriteLine();
                Console.WriteLine("You leave the knight behind and continue alone.");

                Console.ReadLine();

                Watchtower();
            }
            else if (choice == "4")
            {
                Game.ShowHint();

                Console.ReadLine();

                Woods();
            }
            else
            {
                Console.WriteLine("Invalid choice.");

                Console.ReadLine();

                Woods();
            }
        }
    }

}



