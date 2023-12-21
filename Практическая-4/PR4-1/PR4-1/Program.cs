using System;
using System.Collections.Generic;

namespace ConsoleApplication10
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите число n: \n");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            int product = 1;
            for (int i = 3; i <= n; i+=3)
            {
                product *= i;
            }
            Console.WriteLine("Произведение равно " + product);
        }
    }
}