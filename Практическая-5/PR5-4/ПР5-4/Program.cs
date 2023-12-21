using System;
using System.IO;

namespace ConsoleApplication10
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string path = "numsTask4.txt";
            using (StreamReader reader = new StreamReader(path))
            {
                string[] numbers = reader.ReadLine().Split(' ');
                int[] nums = new int[numbers.Length];
                for (int i = 0; i < numbers.Length; i++)
                {
                    nums[i] = Convert.ToInt32(numbers[i]);
                }

                int max = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] > nums[max])
                    {
                        max = i;
                    }
                }

                int sum = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (Math.Abs(nums[i] - nums[max]) == 1)
                    {
                        sum += nums[i];
                    }
                }

                Console.WriteLine("Сумма элементов равна " + sum);
            }
        }
    }
}
