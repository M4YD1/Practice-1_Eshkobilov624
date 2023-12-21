using System;
using System.Collections.Generic;

namespace ConsoleApplication10
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double[] numbers = new double[] { 1.5, 4.6, -3.2, -9.7, 8.4, -2.1 };
            List<double> positiveNums = new List<double>();
            List<double> negativeNums = new List<double>();
            foreach (double num in numbers)
            {
                if (num > 0)
                {
                    positiveNums.Add(num);
                }
            }
            foreach (double num in numbers)
            {
                if (num < 0)
                {
                    negativeNums.Add(num);
                }
            }
            Console.WriteLine("Положительные элементы: ");
            foreach (double num in positiveNums)
            {
               Console.WriteLine(num);
            }
            Console.WriteLine("Отрицательные элементы: ");
            foreach (double num in negativeNums)
            {
                Console.WriteLine(num);
            }
        }
    }
}