using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGameApp
{
    [Flags]
    public enum WeaponList
    {
        Empty = 0x0,
        Sword = 0x1,
        Dagger = 0x2,
        Staff = 0x4
    }

    public enum Property
    {
        Magic,
        Melee,
        Range
    }

    abstract class Weapon
    {
        public int minDmg;
        public int maxDmg;

        Random r = new Random();

        public Weapon()
        {
            this.minDmg = r.Next(10);
            this.maxDmg = r.Next(100);
        }

        public virtual void Info()
        {
            Console.WriteLine("Min dmg - {0}, Max dmg - {1}", minDmg, maxDmg);
        }

    }
}
