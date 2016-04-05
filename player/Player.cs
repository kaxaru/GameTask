using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGameApp
{
     internal abstract class Player
    {
       protected Weapon invertory; 
       protected WeaponList hand;
       protected WeaponList canWield;
        
        public Weapon Invertory
        {
            get { return invertory; }
            set { invertory = value;  }
        }

        public WeaponList Hand
        {
            get { return hand; }
            set { hand = value; }
        }

        public WeaponList CanWield
        {
            get { return canWield; }
            set { canWield = value; }
        }

        public Player(Weapon invertory = null)
        {
            this.invertory = invertory;
            this.hand = WeaponList.Empty;
        }

       // public abstract void Equip(Weapon weapon);
    }
}
