using System;
using System.Collections.Generic;

namespace ConsoleApplication10
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[,] temperature = new int[12, 30];
            Random r = new Random();

            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    temperature[0, j] = r.Next(-31, -15);
                    temperature[1, j] = r.Next(-25, -4);
                    temperature[2, j] = r.Next(-14, 3);
                    temperature[3, j] = r.Next(-7, 7);
                    temperature[4, j] = r.Next(-2, 15);
                    temperature[5, j] = r.Next(6, 25);
                    temperature[6, j] = r.Next(13, 31);
                    temperature[7, j] = r.Next(8, 26);
                    temperature[8, j] = r.Next(-3, 16);
                    temperature[9, j] = r.Next(-9, 9);
                    temperature[10, j] = r.Next(-16, 3);
                    temperature[11, j] = r.Next(-31, -10);
                }
            }
            void average()
            {
                int[] numbers = new int[12];

                for (int i = 0; i < 12; i++)
                {
                    int av = 0;
                    for (int j = 0; j < 30; j++)
                    {
                        av += temperature[i, j];
                    }

                    numbers[i] = av / 30;
                }

                Array.Sort(numbers);
                Console.Write("Средняя температура: ");
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write($"{numbers[i]} ");
                }
            }
            average();
        }
    }
}