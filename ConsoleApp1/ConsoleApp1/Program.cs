using System;

namespace ConsoleApp1
{
    public class Example
    {
        delegate void Message();

        static void Main(string[] args)
        {
            Message mes;
            int seconds = 3;

            for (int i = 0; i < seconds; i++)
            {
                Console.WriteLine("Введите 1, чтобы прошла 1 секунда");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a != 1)
                {
                    Console.WriteLine("Вы ввели не 1");
                    i = i - 1;
                }
                else if (i == 2)
                {
                    mes = TimeIsUp;
                    mes();
                }
            }
            Console.ReadKey();
        }
        private static void TimeIsUp()
        {
            Console.WriteLine("Прошло 3 секунды");
        }
    }
}
