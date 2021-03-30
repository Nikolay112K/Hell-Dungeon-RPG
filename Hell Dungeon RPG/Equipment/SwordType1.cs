using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Dungeon_RPG.Equipment
{
    public class SwordType1
    {
        public int SwordDamage;
        public SwordType1()
        {
            SwordDamage = 4;
        }
        public void GetSwordStats()
        {
            Console.BackgroundColor = ConsoleColor.Red;

            Console.WriteLine($"Ваша зубочистка имеет {SwordDamage} урона.");

            Console.ResetColor();
        }
    }
}