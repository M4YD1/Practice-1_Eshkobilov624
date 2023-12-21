using System;
using System.IO;

namespace ConsoleApplication10
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string path = "numsTask5.txt";
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
                int max = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] > nums[max])
                    {
                        max = i;
                    }
                }
                double average = 0;
                int count = Math.Abs(max - min) - 1;
                for (int i = Math.Min(min, max) + 1; i < Math.Max(min, max); i++) 
                {
                    average += nums[i];
                }
                average /= count;
                Console.WriteLine("Среднее арифметическое элементов между максимальным и минимальным равно " + average);
            }
        }
    }
}