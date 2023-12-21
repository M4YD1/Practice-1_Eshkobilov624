using System;
using System.Collections.Generic;

namespace ConsoleApplication10
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string st = Console.ReadLine();
            string[] words = st.Split(new char[] { ' ' });
            Console.WriteLine("Количество слов " + words.Length);
            string substr1 = "Start ";
            st = st.Insert(0, substr1);
            string substr2 = " End";
            st = st.Insert(st.Length, substr2);
            Console.WriteLine(st);
        }
    }
}