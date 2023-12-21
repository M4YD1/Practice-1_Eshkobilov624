using System;
using System.Collections.Generic;

namespace ConsoleApplication10
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Console.WriteLine("Введите начало диапазона: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите конец диапазона: ");
            int b = int.Parse(Console.ReadLine());
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                list.Add(r.Next(a,b)); 
            }

            foreach (int number in list)
            {
                Console.Write(number + " ");
            }
        }
    }
}