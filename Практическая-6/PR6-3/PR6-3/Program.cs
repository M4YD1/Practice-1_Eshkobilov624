using System;
using System.Collections.Generic;

namespace ConsoleApplication10
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите число: \n");
            double a = double.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("Это число четное");
            }
            else
            {
                Console.WriteLine("Это число нечетное");
            }

            if (a % 10 == 0)
            {
                Console.WriteLine("Это число кратно 10");
            }
            else
            {
                Console.WriteLine("Это число не кратно 10");
            }
           
        }
    }
}