using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGameApp
{
     static class GameRules
        {
             public static bool Equip(Player pl)
                {
                    if (pl.Invertory == null)
                    {
                        Console.WriteLine("invertory is empty, try to find a weapon ");
                        return false;
                    }

                    if (pl.CanWield.ToString().Contains(pl.Invertory.GetType().Name))
                        return true;


                    Console.WriteLine("This character cann't to equip the weapon");
                    return false;
                }
        }
}
