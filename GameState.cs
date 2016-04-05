using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGameApp
{
    static class GameState
    {
        public static bool state;

        static GameState()
        {
            state = true;
        }

        public static void Init()
        {
            Commands.Help();
            while(state)
            {
                string command = Console.ReadLine();
                switch (command)
                {
                    case "help":
                        Commands.Help();
                        break;
                    case "quit":
                        Quit();
                        break;
                    case "create role":
                        Commands.CreateRole();
                        break;
                    case "info role":
                        Commands.InfoRole(Commands.Player);
                        break;
                    case "delete role":
                        Commands.DeleteRole();
                        break;
                    case "create weapon":
                        Commands.CreateWeapon();
                        break;
                    case "info weapon":
                        Commands.InfoWeapon(Commands.Weapon);
                        break;
                    case "delete weapon":
                        Commands.DeleteWeapon();
                        break;
                    case "equip weapon":
                        Commands.EquipWeapon(Commands.Player, Commands.Weapon);
                        break;
                    default:
                        Console.WriteLine("Unknown command. Try again:");
                        break;
                }
             }
        }

        public static void Pause() { }
        public static void Resume() { }
        public static void Draw() { }
        public static void Update() { }
        public static void Quit()
        {
            state = false;
            Commands.DeleteWeapon();
            Commands.DeleteRole();
        }

    }
}
