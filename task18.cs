//Написать программу для получения реверсированной строки.
using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Convert.ToString(Console.ReadLine());
            string revers = "";
            for (int i = 0; i < (str.Length); i++)
            {
                revers += str[(str.Length) - 1 - i];

            }
            Console.WriteLine(revers);
        }
    }
}
