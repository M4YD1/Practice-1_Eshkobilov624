using System;
using System.IO;

namespace ConsoleApplication10
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string path = "numsTask1.txt";
            using (StreamReader reader = new StreamReader(path))
            {
                string[] numbers = reader.ReadLine().Split(' '); 
                int[] nums = new int[numbers.Length];
                for (int i = 0; i < numbers.Length; i++)
                {
                    nums[i] = Convert.ToInt32(numbers[i]);
                }
                int min = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] < nums[min])
                    {
                        min = i;
                    }
                }
                int product = 1;
                for (int i = 0; i < nums.Length; i++) 
                {
                    if (i > min)
                    {
                        product *= nums[i];
                    }
                }
                Console.WriteLine("Произведение элементов после минимального равно " + product);
            }
        }
    }
}