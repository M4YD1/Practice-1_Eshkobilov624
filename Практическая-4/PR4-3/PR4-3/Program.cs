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
                string line = reader.ReadLine();
                string[] numbers = line.Split(", ");
                int[] nums = new int[numbers.Length];
                int min = int.MaxValue; 
                int max = int.MinValue; 

                for (int i = 0; i < numbers.Length; i++)
                {
                    nums[i] = int.Parse(numbers[i]);
                    if (nums[i] != 0)
                    {
                        
                    
                    if (nums[i] < min)
                    {
                        min = nums[i];
                    }
                    if (nums[i] > max)
                    {
                        max = nums[i];
                    }
                    }
                }
                
                double attitude = (double)min / max;
                Console.WriteLine("Отношение минимального и максимального элементов равно " + attitude);
            }
        }
    }
}