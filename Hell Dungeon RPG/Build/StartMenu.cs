using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Dungeon_RPG.Build
{
    public class StartMenu
    {
        public void Menu()
        {
            bool stop = true;

            for (; ; )
            {
                while (stop)
                {
                    Console.WriteLine("Вы находитесь в главном меню!");
                    Console.WriteLine("1. Начать игру");
                    Console.WriteLine("2. Загрузить игру");
                    Console.WriteLine("3. Выйти с игры");

                    string a = Console.ReadLine();
                    switch (a)
                    {
                        case "1":
                            Console.WriteLine("|||\tВы очнулись посреди арены..\t|||");
                            Console.WriteLine("|||\t Немного осмотревшись вы замечаете толпу людей смотрящих на вас и скандирующих \"Убить\"\t|||");
                            StartFight fight = new StartFight();
                            fight.HeroVsMonster();
                            Console.ReadKey();
                            break;
                        case "2":
                            break;
                        case "3":
                            stop = false;
                            break;
                        default:
                            Console.WriteLine("Неверно указано число, следуйте инструкциям");
                            break;
                    }
                }
                break;
            }
        }
    }
}
