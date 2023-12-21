using System;
using System.Collections.Generic;

namespace ConsoleApplication9
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>();
            bool next= true;
            Console.Write("Введите числа: \n");
            while (next == true)
            {
                int number = int.Parse(Console.ReadLine());
                if (number != 0)
                {
                    list.Add(number);
                }
                else
                {
                    int product = 1;
                    int sum = 0;
                    double average = 0;
                    foreach (int num in list)
                    {
                        sum += num;
                        product *= num;
                        average += num;
                    }
                    average /= list.Count;
                    Console.WriteLine($"Сумма равна  {sum}");
                    Console.WriteLine("Произведение равно " + product);
                    Console.WriteLine("Среднее арифметическое равно "+average);
                    next = false;
                }
                
            }
            
           
        }
    }
}
