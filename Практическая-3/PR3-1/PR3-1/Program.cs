using System;
using System.IO;

namespace test
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string path1 = "input.txt";
            string path2 = "output.txt";

            using (StreamReader reader = new StreamReader(path1))
            {
                using (StreamWriter writer = new StreamWriter(path2, false))
                {
                    string[] chosenNumbers = (reader.ReadLine()).Split(' ');
                    int[] chosenNumbersInt = new int[chosenNumbers.Length];
                    for (int i = 0; i < chosenNumbers.Length; i++)
                    {
                        chosenNumbersInt[i] = int.Parse(chosenNumbers[i]);
                    }
                    int n = int.Parse(reader.ReadLine());
                    for (int i = 0; i < n; i++)
                    {
                        string[] tickets = (reader.ReadLine()).Split(' ');
                        int[] ticketsInt = new int[tickets.Length];
                        for (int k = 0; k < tickets.Length; k++)
                        {
                            ticketsInt[k] = int.Parse(tickets[k]);
                        }
                        int count = 0;
                        for (int j = 0; j < 6; j++)
                        {
                            if (Array.Exists(chosenNumbersInt, element => element == ticketsInt[j]))
                            {
                                count++;
                            }
                        }
                        if (count >= 3)
                        {
                            writer.WriteLine($"Lucky");
                        }
                        else
                        {
                            writer.WriteLine($"Unlucky");
                        }
                    }
                }
            }
        }
    }
}