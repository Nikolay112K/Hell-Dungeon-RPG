using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Dungeon_RPG.Build
{
    public class Welcome
    {
        public void SayHi()
        {
            Console.Beep();
            
            Console.WriteLine($"|||\t Здравствуй путник! \t|||");
            Console.ReadLine();
            Console.Beep();

            Console.WriteLine($"|||\t Назови своё имя: \t|||");
            string PlayerName = Console.ReadLine();

            for (; ; )
            {
                Console.WriteLine($"|||\t Подтвердите действие, введите: \'1\' \t|||");
                string check = Console.ReadLine();

                if (check == "1")
                {
                    break;
                }
                else 
                {
                    Console.WriteLine($"|||\t Назови своё имя: \t|||");
                    PlayerName = Console.ReadLine();

                }
            }
            Console.WriteLine($"|||\t Приветствуем тебя в Темных Подземельях!, {PlayerName} \t|||");
            Console.WriteLine($"Приступим к ознакомлению!");
            Console.ReadLine();
            Console.Beep();
            Console.Beep();
            Console.Beep();
            StartFight startFight = new StartFight();
            Console.ResetColor();
        }
    }
}
