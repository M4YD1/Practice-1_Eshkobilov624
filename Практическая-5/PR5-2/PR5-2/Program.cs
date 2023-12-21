using System;
using System.IO;

namespace ConsoleApplication10
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string path = "numsTask2.txt";
            List<double> nomera = new List<double>();
            using (StreamReader reader = new StreamReader(path))
            {
                string[] numbers = reader.ReadLine().Split("; ");
                double[] nums = new double[numbers.Length];
                for (int i = 0; i < numbers.Length; i++)
                {
                    nums[i] = double.Parse(numbers[i]);
                    nomera.Add(nums[i]);
                }
            }
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                double[] newnombers = new double[nomera.Count];
                for (int i = 0; i < nomera.Count; i++)
                {
                    newnombers[i] = nomera[i];
                }
                Array.Sort(newnombers);
                for (int i = 0; i < nomera.Count; i++)
                {
                    writer.Write(newnombers[i] + " ");
                }

            }
        }
    }
}