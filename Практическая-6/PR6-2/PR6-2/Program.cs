using System;
using System.IO;

namespace ConsoleApplication10
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string path = "numsTask2.txt";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                string words = "";
                while ((line = reader.ReadLine()) != null)
                {
                    words += line + " ";
                } 
                Console.WriteLine(words);
            }
        }
    }
}