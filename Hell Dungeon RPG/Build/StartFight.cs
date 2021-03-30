using System;
using System.Collections.Generic;
using System.Text;
using Hell_Dungeon_RPG.Build;
using Hell_Dungeon_RPG.Monsters;
using Hell_Dungeon_RPG.Equipment;
using System.Threading.Tasks;

namespace Hell_Dungeon_RPG.Build
{
    public class StartFight
    {
        public ArmorType1 ArmorType1Obj { get; set; }
        public SwordType1 SwordType1Obj { get; set; }
        public StartFight(ArmorType1 armorType1, SwordType1 swordType1)
        {
            ArmorType1Obj = armorType1;
            SwordType1Obj = swordType1;
        }
        public static void HeroVsMonster()
        {

            MainHero h = new MainHero(armorType1,swordType1);
            MonsterHexo m = new MonsterHexo();

            bool a = true;
            while (a)
            {
                if (h.ArmorType1Obj.ArmorStrength > 0)
                {
                    h.ArmorType1Obj.ArmorStrength = h.ArmorType1Obj.ArmorStrength - m.Damage;
                    Console.WriteLine("|||\t Монстр ударяет по вам! Но урон прошёл по броне \t|||");
                }
                else
                {
                    h.Health = h.Health - m.Damage;
                    Console.WriteLine($"|||\t Монстр нанёс вам {m.Damage} урона, теперь у вас {h.Health} жизней \t|||");
                }
                if (m.Health > 0)
                {
                    m.Health = m.Health - h.SwordType1Obj.SwordDamage;
                    Console.WriteLine($"|||\t Вы нанесли {h.SwordType1Obj.SwordDamage} урона монстру! У монстра осталось {m.Health} жизней \t|||");
                }
                if (h.Health < 0)
                {
                    Console.WriteLine($"|||\t Вы были побеждены монстром! \t|||");

                    a = false;
                }
                if (m.Health < 0)
                {
                    Console.WriteLine($"|||\t Вы победили монстра!! \t|||");

                    a = false;
                }
            }
            StartMenu gotoMenu = new StartMenu();
            gotoMenu.Menu();
        }
    }
}