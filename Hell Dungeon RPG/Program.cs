using Hell_Dungeon_RPG.Equipment;
using System;
using Hell_Dungeon_RPG;
using Hell_Dungeon_RPG.Build;
using System.Text;

namespace Hell_Dungeon_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            MainHero Hero1 = new MainHero(new ArmorType1(), new SwordType1());
            // Hero1.CheckMyStuff();
            Welcome welcome = new Welcome();
            welcome.SayHi();
            StartMenu startMenu = new StartMenu();
            startMenu.Menu();
            Console.ReadLine();
        }
    }
}
