// Вывести на экран, консольного приложения, прямоугольный треугольник из звездочек “*”, с длиной катета m.
using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= s; i++)
            {
                int num = 0;
                while (num < i)
                {
                    Console.Write("*");
                    num++;
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
    }
}
