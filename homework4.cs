//Найти сумму первых N членов арифметической прогрессии с использованием цикла for.
using System;

namespace homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i < num; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}
