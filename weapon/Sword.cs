﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGameApp
{
     sealed class Sword : Weapon
    {
        Property property;
        public Sword(Property property = Property.Melee) : base()
            {
                this.property = property; 
            }

        public override void Info()
        {
            Console.WriteLine("Min dmg - {0}, Max dmg - {1}, property - {2}", minDmg, maxDmg, property);
        }
    }
}
