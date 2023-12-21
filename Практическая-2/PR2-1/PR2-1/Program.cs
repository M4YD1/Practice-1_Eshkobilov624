using System;
using System.Collections.Generic;

namespace ConsoleApplication10
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = new int [100];
            for (int i = 0; i < 100; i++)
            {
                arr[i] = arr.Length - i * 3;
            }
            foreach (int num in arr)
            {
                Console.WriteLine(num);
            }
        }
    }
}