using System;

namespace ConsoleApp1
{
    public class Example
    {
        static void Main(string[] args)
        {
            int userTickCount = int.Parse(Console.ReadLine());

            TickTimer(userTickCount, OnTimerFinish);

            Console.ReadLine();
        }

        private static void OnTimerFinish()
        {
            Console.WriteLine("Time is up");
        }

        private static void TickTimer(int tickCount, Action timeIsUp)
        {
            for (var tickCounter = tickCount; tickCounter >= 0; tickCounter--)
            {
                Console.WriteLine($"Timer value is {tickCounter}");
                Console.ReadLine();
                
                if (tickCounter == 0)
                {
                    timeIsUp?.Invoke();
                }
            }
        }
    }
}
