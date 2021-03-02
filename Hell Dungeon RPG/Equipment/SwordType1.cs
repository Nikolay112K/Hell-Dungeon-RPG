using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Dungeon_RPG.Equipment
{
    public class SwordType1
    {
        private int SwordStrength = 100;
        private int SwordDamage = 7;
        public SwordType1(int swordStrength,int swordDamage)
        {
            this.SwordDamage = swordDamage;
            this.SwordStrength = swordStrength;
        }
        public void GetSwordStrength()
        {
            Console.WriteLine(SwordStrength);
        }
        public void GetSwordDamage()
        {
            Console.WriteLine(SwordDamage);
        }
    }
}
