using System;
using System.Collections.Generic;

namespace ConsoleApplication10
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double[] arr = new double[10];
            int num = 1;
            for (int i = 0; i < 10; i++)
            { 
                arr[i] = num;
                num+=2;
            }
            foreach (var number in arr)
            {
                Console.WriteLine(number);
            }
        }
    }
}