//Найти все целые числа из промежутка от 1 до 300, у которых ровно пять делителей.
using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 2; i < 300; i++)
            {
                int k = 0;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        k++;
                    }
                    if (k == 5)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
