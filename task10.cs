// Посчитать количество и сумму парных чисел в диапазоне от 1 до N.
using System;

namespace task8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int k = 0;
            for (int i = 1; i < n; i++)
            {
                if (i % 2 == 0) {
                    k += 1;
                    sum += i;
                }
            }
            Console.WriteLine("{0}  {1}",  k, sum);

        }
    }
}
