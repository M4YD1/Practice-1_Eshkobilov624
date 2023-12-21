using System;
using System.Collections.Generic;

namespace ConsoleApplication10
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите число a: \n");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Вводите положительные числа: ");
            double sum = 0;
            while (true)
            {
                double num = double.Parse(Console.ReadLine());
                
                if (num % a == 0)
                {
                    sum += num;
                }
                if (num < 0)
                {
                    break;
                }
            }
            Console.WriteLine("Сумма чисел, делящихся на число a равна " + sum);
        }
    }
}