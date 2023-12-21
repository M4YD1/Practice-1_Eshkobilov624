using System;
using System.Collections.Generic;

namespace ConsoleApplication10
{
    internal class Program
    {
        public static void Main(string[] args)
        {
           Console.Write("Введите вещественное число a: \n");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите вещественное число b: ");
            double b = double.Parse(Console.ReadLine());
            if (a <= 3 && a >= -1)
            {
                if (b <= 4 && b >= -2)
                {
                    Console.WriteLine("Точка принадлежит");
                }
            }
            else
            {
                Console.WriteLine("Точка не принадлежит");
            }
        }
    }
}