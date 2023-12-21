using System;
using System.IO;
using System.Collections.Generic;

namespace ConsoleApplication10
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string path = "numsTask2.txt";
            using (StreamReader reader = new StreamReader(path))
            {
                string[] numbers = reader.ReadLine().Split("; ");
                double[] nums = new double[numbers.Length];
                double sum = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    nums[i] = double.Parse(numbers[i]);
                    if (nums[i] >= 0)
                    {
                        sum += nums[i];
                    }
                }

                Console.WriteLine("Сумма положительных чисел равна " + sum);
            }

        }
    }
}

