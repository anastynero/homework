//В одномерном массиве из 100 чисел M[] подсчитайте количество элементов, удовлетворяющих условию 0 < M[i] <125
using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[100];
            Random rand = new Random();
            for (int x = 0; x < array.Length; x++)
            {
                int y = rand.Next(250);
                if ((y > 0) & (y < 125))
                {
                    Console.WriteLine($"{y}");
                }
            }
        }
    }
}
