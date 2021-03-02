using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Dungeon_RPG.Equipment
{
    public class ArmorType1
    {
        private int ArmorStrength = 100;
        private int ArmorProtect = 4;
        public ArmorType1(int armorStrength, int armorProtect)
        {
            this.ArmorProtect = armorProtect;
            this.ArmorStrength = armorStrength;
        }
        public void GetArmorStrength()
        {
            Console.WriteLine(ArmorStrength);
        }
        public void GetArmorProtect()
        {
            Console.WriteLine(ArmorProtect);
        }
    }
}
