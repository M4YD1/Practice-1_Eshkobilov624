using System;
using System.Collections.Generic;

namespace ConsoleApplication10
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите количество строк: \n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов: ");
            int m = int.Parse(Console.ReadLine());
            int[,] a = new int[n, m];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i,j] = r.Next(0, 2);
                }
            }
            int[,] numbers = new int[n, m + 1];
            for (int i = 0; i < n; i++)
            {
                int count = 0;
                for (int j = 0; j < m; j++)
                {
                    numbers[i, j] = a[i, j];
                    if (a[i, j] == 1) count++;
                }

                if (count % 2 != 0)
                {
                    numbers[i, m] = 1;
                }
                else
                {
                    numbers[i, m] = 0;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m + 1; j++)
                {
                    Console.Write(numbers[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        }
    }
