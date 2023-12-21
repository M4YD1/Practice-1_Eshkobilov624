using System;
using System.Collections.Generic;

namespace ConsoleApplication10
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[,] matrix = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[0, j] = 1;
                    matrix[i, 0] = 1;
                    
                }
            }

            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    matrix[i, j] = matrix[i - 1, j] + matrix[i, j - 1];
                    
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}