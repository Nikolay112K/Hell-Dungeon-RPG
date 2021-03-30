using Hell_Dungeon_RPG.Equipment;
using Hell_Dungeon_RPG.Characteristics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Dungeon_RPG
{
    public class MainHero
    {
        public int Health { get; set; }
        public ArmorType1 ArmorType1Obj { get; set; }
        public SwordType1 SwordType1Obj { get; set; }
        
        public MainHero(ArmorType1 armorType1, SwordType1 swordType1)
        {
            Health = 100;
            this.ArmorType1Obj = armorType1;
            this.SwordType1Obj = swordType1;

        }
        public void CheckMyStuff()
        {
            SwordType1Obj.GetSwordStats();
            ArmorType1Obj.GetArmorStats();
        }
    }
}
