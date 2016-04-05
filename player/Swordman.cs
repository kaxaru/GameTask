﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGameApp
{
    sealed class Swordman : Player
    {
        public Swordman(Weapon invertory = null) : base(invertory)
        {
            this.invertory = invertory;
            this.canWield = WeaponList.Empty | WeaponList.Sword | WeaponList.Dagger;
        }

        public override string ToString()
        {
            return string.Format("you swordman");
        }

        /*public override void Equip(Weapon weapon)
        {

            if (player.GameRules.Equip(this))
            {
                foreach(var el in Enum.GetValues(typeof(WeaponList)))
                    {
                        if (el.ToString() == this.Invertory.GetType().Name)
                            this.hand = (WeaponList)el;
                    }
                Console.WriteLine("Weapon {0} is equiped", this.hand);
            }
            else
            {
                this.hand = WeaponList.Empty;               
            }
        }*/
    }
}
