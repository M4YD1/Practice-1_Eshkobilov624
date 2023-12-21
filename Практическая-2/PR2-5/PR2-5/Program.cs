
using System;
using System.Collections.Generic;

namespace test
{
    internal class Program
    {
        void Medium (Dictionary<string, int[]> temperature)
        {
            Dictionary<string, int> temperatureMedium = new Dictionary<string, int>();
            int medium;
            foreach (var n in temperature)
            {
                int sum = 0;
                for (int i = 0; i < n.Value.Length; i++)
                {
                    sum += n.Value[i];
                }

                medium = sum / n.Value.Length;
                temperatureMedium.Add(n.Key, medium);
            }
            foreach (var n in temperatureMedium)
            {
                Console.WriteLine($"{n.Key}: {n.Value}");
            }
        }
        public static void Main(string[] args)
        {
            Program tempMedium = new Program();
            Dictionary<string, int[]> weather = new Dictionary<string, int[]>();
            string[] month = new string[12]
            {
                "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"
            };
            int min = -30, max = -15;
            for (int i = 0; i < month.Length; i++)
            {
                int[] temperature = new int[30];
                Random r = new Random();
                if (i == 0)
                {
                    max = -15;
                    min = -30;
                }
                if (i == 1)
                {
                    max = -5;
                    min = -15;
                }
                if (i == 2)
                {
                    max = -3;
                    min = -10;
                }
                if (i == 3)
                {
                    max = 5;
                    min = -3;
                }
                if (i == 4)
                {
                    max = 15;
                    min = 0;
                }
                if (i == 5)
                {
                    max = 20;
                    min = 5;
                }
                if (i == 6)
                {
                    max = 30;
                    min = 10;
                }
                if (i == 7)
                {
                    max = 25;
                    min = 5;
                }
                if (i == 8)
                {
                    max = 15;
                    min = 0;
                }
                if (i == 9)
                {
                    max = 10;
                    min = -5;
                }
                if (i == 10)
                {
                    max = 5;
                    min = -10;
                }
                if (i == 11)
                {
                    max = -10;
                    min = -25;
                }
                for (int j = 0; j < temperature.Length; j++)
                {
                    temperature[j] = r.Next(min, max);
                }
                weather.Add(month[i], temperature);
            }

            tempMedium.Medium(weather);

        }
    }
}
