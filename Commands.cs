using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGameApp
{
    static class Commands
    {
      
        static Player pl;
        static Weapon weapon;

        static Commands()
        {
            pl = null;
            weapon = null;
        }

        public static Player Player
        {
            get
            {
                return pl;
            }
        }

        public static Weapon Weapon
        {
            get
            {
                return weapon;
            }
        }

        public static void Help()
        {
            Console.WriteLine("List commands:\n-help");
            Console.WriteLine("-create role\n-delete role\n-info role");
            Console.WriteLine("-create weapon\n-equip weapon\n-delete weapon\n-info weapon");
            Console.WriteLine("-quit\n");
        }

        public static void CreateRole()
        {
            if (pl == null)
            {
                Console.WriteLine("Change Role: Swordman - S, Mage - M, Rogue - R");
                string role = Console.ReadLine();
                switch (role)
                {
                    case "S":
                        Console.WriteLine("You create role - swordman");
                        pl = new Swordman();
                        break;
                    case "M":
                        Console.WriteLine("You create role - wizard");
                        pl = new Wizard();
                        break;
                    case "R":
                        Console.WriteLine("You create role - rogue");
                        pl = new Rogue();
                        break;
                    default:
                        Console.WriteLine("Unknown role. Try again choose your destiny");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Role already created");
            }
        }

        public static void DeleteRole()
        {            
            pl = null;
            Console.WriteLine("Role has been deleted");
        }

        public static void InfoRole(Player pl)
        {
            if (pl != null)
                Console.WriteLine(pl);
            else
                Console.WriteLine("The Role has not create yet");
        }


        public static void CreateWeapon()
        {
            if (weapon == null)
            {
                Console.WriteLine("Change Weapon: Sword - Sw, Dagger - D, Staff - St, Bow - B");
                string playerWeapon = Console.ReadLine();

                switch (playerWeapon)
                {
                    case "Sw":
                        Console.WriteLine("The sword added into the invertory");
                        weapon = new Sword(Property.Melee);
                        break;
                    case "D":
                        Console.WriteLine("The dagger added into the invertory");
                        weapon = new Dagger(Property.Melee);
                        break;
                    case "St":
                        Console.WriteLine("The staff added into the invertory");
                        weapon = new Staff(Property.Magic);
                        break;
                    case "B":
                        Console.WriteLine("The bow added into the invertory");
                        weapon = new Bow(Property.Range);
                        break;
                    default:
                        Console.WriteLine("Unknown weapon. Try to create again own weapon");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Weapon already created");
            }
        }

        public static void EquipWeapon(Player pl, Weapon weapon)
        {
            if (pl != null)
            {
                pl.Invertory = weapon;

                if (GameRules.Equip(pl))
                {
                    foreach (var el in Enum.GetValues(typeof(WeaponList)))
                    {
                        if (el.ToString() == pl.Invertory.GetType().Name)
                            pl.Hand = (WeaponList)el;
                    }
                    Console.WriteLine("Weapon {0} is equiped", pl.Hand);
                }
                else
                {
                    pl.Hand = WeaponList.Empty;
                }
            }
            else
                Console.WriteLine("Role not created");
          
        }

        public static void DeleteWeapon()
        {
            Console.WriteLine("Weapon has been deleted");
            weapon = null;
        } 

        public static void InfoWeapon(Weapon weapon)
        {
            if (weapon != null)
                Weapon.Info();
            else
                Console.WriteLine("The weapon has not create yet");
        }

    }
}
