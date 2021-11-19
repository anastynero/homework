//Вычислить факториал числа p(при p > 0), используя цикл do while.
using System;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            do
            {
                i*= p;
                p-=1;
            } while (p>1);
            Console.WriteLine(i);
        }
    }
}
