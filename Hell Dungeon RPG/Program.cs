using Hell_Dungeon_RPG.Equipment;
using System;
using Hell_Dungeon_RPG.Hero;
using Hell_Dungeon_RPG;

namespace Hell_Dungeon_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            ArmorType1 armorType1 = new ArmorType1(100,4);
            Hero.Hero Hero1 = new Hero.Hero();
            Hero1.CheckMyStuff();
            Console.ReadLine();
        }
    }
}
