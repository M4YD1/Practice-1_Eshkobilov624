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
            double x1 = 0;
            double y1 = 2;
            double x2 = 2;
            double y2 = -3;
            double x3 = -2;
            double y3 = -3;
            if ((a - x1) * (y2 - y1) - (x2 - x1) * (b - y1) >= 0)
            {
                if ((a - x2) * (y3 - y2) - (x3 - x2) * (b - y2) >= 0)
                {
                    if ((a - x3) * (y1 - y3) - (x1 - x3) * (b - y3) >= 0)
                    {
                        Console.WriteLine("Точка принадлежит");
                    }
                }
            }
            else
            {
                Console.WriteLine("Точка не принадлежит");
            }
        }
    }
}