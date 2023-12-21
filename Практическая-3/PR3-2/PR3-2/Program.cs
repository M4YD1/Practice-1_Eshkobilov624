using System;
using System.IO;
using System.Collections.Generic;

namespace ConsoleApplication10
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string path = "nums.txt";
            List<double> newnumbers = new List<double>();
            using (StreamReader reader = new StreamReader(path))
            {
                string[] numbers = reader.ReadLine().Split(' ');
                double[] numbersdouble = new double[numbers.Length];
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbersdouble[i] = double.Parse(numbers[i]);

                    if (numbersdouble[i] % 2 != 0)
                    {
                        newnumbers.Add(numbersdouble[i]);
                    }
                }
                
            }
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                foreach (double num in newnumbers)
                {
                    writer.Write(num + " ");
                }
                    
            }
        }
    }
}