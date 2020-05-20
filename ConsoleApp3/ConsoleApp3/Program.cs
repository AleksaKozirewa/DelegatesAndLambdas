using System;
using System.Collections;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp3
{
    class Program
    {
        delegate bool IsEqual(int x);
        static void Main(string[] args)
        {
            int[] numbers = {1, 2, 3, 4, 5};

            object targetNumbers = Operation(numbers, x => x < 4);
            
            Console.WriteLine(targetNumbers);
            Console.ReadKey();
        }
        private static object Operation(int[] numbers, IsEqual func)
        {
            Queue targetNumbers = new Queue();
            foreach (int number in numbers)
            {
                if (func(number))
                {
                    targetNumbers.Enqueue(number);
                    
                }

            }

            return targetNumbers;
        }

    }
}
