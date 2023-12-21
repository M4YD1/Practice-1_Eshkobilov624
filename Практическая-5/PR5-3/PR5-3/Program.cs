using System;
using System.IO;

namespace ConsoleApplication10
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string path = "numsTask3.txt";
            using (StreamReader reader = new StreamReader(path))
            {
                string[] numbers = reader.ReadLine().Split(' '); 
                int[] nums = new int[numbers.Length];
                for (int i = 0; i < numbers.Length; i++)
                {
                    nums[i] = int.Parse(numbers[i]);
                }
                int min = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] < nums[min])
                    {
                        min = i;
                    }
                }
                double average = 0;
                int count = 0;
                for (int i = 0; i < nums.Length; i++) 
                {
                   
                    if (i < min)
                    {
                        count++;
                        average += nums[i];
                    }
                    else
                    {
                        break;
                    }
                }
                average /= count;
                Console.WriteLine("Среднее арифметическое элементов до минимального равно " + average);
            }
        }
    }
}