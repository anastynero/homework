//Найти сумму первых N членов арифметической прогрессии с использованием цикла for
using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= num1; i++)
            {
                sum += i;  
            }
            Console.WriteLine(sum);

        }
    }
}
