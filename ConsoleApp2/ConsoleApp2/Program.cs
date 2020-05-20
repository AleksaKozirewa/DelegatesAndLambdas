using System;

namespace ConsoleApp2
{
    class Program
    {
        delegate void CompareOperation(int x, int y);

        static void Main(string[] args)
        {
            CompareOperation op = ComparingTwo;

            ComparingTwo(6, 3);

            Console.ReadKey();

        }

        private static void ComparingTwo(int x, int y)
        {
            if (x < y)
            {
                Console.WriteLine(y + " наибольшее число");
            }
            else
            {
                Console.WriteLine(x + " наибольшее число");
            }
        }
    }
}