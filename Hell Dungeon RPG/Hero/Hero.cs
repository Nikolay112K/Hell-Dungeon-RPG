using Hell_Dungeon_RPG.Equipment;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Dungeon_RPG.Hero
{
    public class Hero
    {
        public ArmorType1 ArmorType1Obj { get; set; } 
        public SwordType1 SwordType1Obj { get; set; }
        public Hero()
        {

        }
        public void CheckMyStuff()
        {
            ArmorType1Obj.GetArmorStrength();
            ArmorType1Obj.GetArmorProtect();
        }
    }
}
