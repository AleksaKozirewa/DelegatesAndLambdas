using System;

namespace ConsoleApp4
{
    class Program
    {
        delegate bool IsEqual(int x);
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            bool targetNumbers = Operation(numbers, x => x < 4);

            Console.WriteLine(targetNumbers);
            Console.ReadKey();
        }

        private static bool Operation(int[] numbers, IsEqual func)
        {
            foreach (int number in numbers)
            {
                if (func(number))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
