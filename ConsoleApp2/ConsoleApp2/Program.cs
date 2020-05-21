using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstValue = int.Parse(Console.ReadLine());
            int secondValue = int.Parse(Console.ReadLine());

            GetMaximumValue(firstValue, secondValue, GetMax);

            Console.ReadKey();
        }
        
        private static void GetMaximumValue(int x, int y, Func<int, int, int> getMax)
        {
            Console.WriteLine($"Самое большое число: {getMax(x, y)}");
        }

        private static int GetMax(int x, int y)
        {
            return (x > y) ? x : y;
        }
    }
}