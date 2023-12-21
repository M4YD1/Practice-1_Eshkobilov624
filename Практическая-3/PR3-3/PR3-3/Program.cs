using System;
using System.IO;
using System.Collections.Generic;
namespace MaxWaterContainer
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string path = "nums.txt";
            using (StreamReader reader = new StreamReader(path))
            {
                string[] heightstr = reader.ReadLine().Split(", ");
                int[] height = new int[heightstr.Length];
                for (int i = 0; i < heightstr.Length; i++)
                {
                   height[i] = int.Parse(heightstr[i]);
                }
                int maxVolume = MaxWaterContainer(height);
                Console.WriteLine("Максимальное количество воды: " + maxVolume);
            }

            static int MaxWaterContainer(int[] height)
            {
                int maxVolume = 0;
                int left = 0;
                int right = height.Length - 1;

                while (left < right)
                {
                    int currentVolume = (right - left) * Math.Min(height[left], height[right]);
                    maxVolume = Math.Max(maxVolume, currentVolume);

                    if (height[left] < height[right])
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }

                return maxVolume;
            }
        }
    }
}