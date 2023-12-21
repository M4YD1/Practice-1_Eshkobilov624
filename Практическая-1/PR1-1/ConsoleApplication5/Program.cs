using System;

namespace ConsoleApplication5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = new int[10];
            Random a = new Random();
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = a.Next(-100, 100);
                Console.WriteLine(numbers[i]+" ");
            }

            
            int min = numbers[0];
            int minNum = 0;
            for (int i = 1; i < 10; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                    minNum = i;
                }
            }
            Console.WriteLine("Номер минимального элемента "+minNum);
        }
    }
}
