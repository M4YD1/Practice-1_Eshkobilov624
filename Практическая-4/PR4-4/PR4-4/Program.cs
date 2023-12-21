using System;
using System.IO;
using System.Collections.Generic;

namespace ConsoleApplication10
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string path = "numsTask4.txt";
            using (StreamReader reader = new StreamReader(path))
            {


                string[] numbers = reader.ReadLine().Split(" ");
                int[] nums = new int[numbers.Length];
                for (int i = 0; i < numbers.Length; i++)
                {
                    nums[i] = int.Parse(numbers[i]);
                }

               int count = 0;

                for (int i = 0; i < nums.Length - 1; i++)
                {
                    if (nums[i] == nums[i + 1])
                    {
                        count++;
                    }
                }

                Console.WriteLine("Количество чисел: " + count);
            }

        }
    }
}
