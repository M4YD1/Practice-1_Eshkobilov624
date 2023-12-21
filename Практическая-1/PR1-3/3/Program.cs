using System;
using System.Collections.Generic;

namespace ConsoleApplication10
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<string> list = new List<string>();
            bool next= true;
            Console.Write("Вводите элементы: \n");
            while (next == true)
            {
                string st = Console.ReadLine();
                if (st != "" )
                {
                    list.Add(st);
                }
                else
                {
                    string max = list[0];
                    for (int i = 0; i< list.Count; i++)
                    {
                        if (list[i].Length > max.Length)
                        {
                            max = list[i]; 
                        }
                    }
                    string min = list[0];
                    for (int i = 0; i< list.Count; i++)
                    {
                        if (list[i].Length < min.Length)
                        {
                            min = list[i]; 
                        }
                    }
                    Console.WriteLine("Самый длинный элемент: " + max);
                    Console.WriteLine("Самый короткий элемент: " + min);
                    break; 


                }
                
            }
        }
    }
}