﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {1, 2, 3, 4, 5};
            
            List<int> targetNumbers = Operation(numbers, x => x < 4);

            string targetNumbersOutput = string.Join(", ", targetNumbers);

            Console.WriteLine(targetNumbersOutput);
            Console.ReadKey();
        }

        private static List<int> Operation(int[] numbers, Func<int,bool> isEqual)
        {
            List<int> targetNumbers = new List<int>();

            foreach (int number in numbers)
            {
                if (isEqual(number))
                {
                    targetNumbers.Add(number);
                }
            }
            return targetNumbers;
        }
    }
}
