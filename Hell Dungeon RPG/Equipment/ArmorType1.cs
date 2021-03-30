using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Dungeon_RPG.Equipment
{
    public class ArmorType1
    {
        public int ArmorStrength;
        public ArmorType1()
        {
            ArmorStrength = 100;
        }
        public void GetArmorStats()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine($"Ваши портки имеют {ArmorStrength} прочности.");

            Console.ResetColor();
        }
    }
}
