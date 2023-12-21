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
                string[] words = reader.ReadLine().Split(' ');
                foreach (string word in words)
                {
                    if (word.Length % 2 != 0)
                    {
                        Console.WriteLine(word);
                    }
                }
            }
        }
    }
}