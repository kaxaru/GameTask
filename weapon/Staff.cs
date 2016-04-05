using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGameApp
{
    sealed class Staff : Weapon
    {
        Property property;
        public Staff(Property property = Property.Magic) : base()
        {
            this.property = property;
        }

        public override void Info()
        {
            Console.WriteLine("Min dmg - {0}, Max dmg - {1}, property - {2}", minDmg, maxDmg, property);
        }
    }
}
