//Задан массив из n целых чисел.Найти сумму и количество чисел, больших среднего арифметического элементов массива
using System;
using System.Linq;

namespace ConsoleApp1

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Array.ConvertAll(Console.ReadLine().Split(), input => int.Parse(input));
            double arif = (double)nums.Sum() / nums.Length;
            int k = nums.Count(x => x > arif);
            int sum = 0;
            Array.ForEach(nums, x => sum += x > arif ? x : 0);

            Console.WriteLine($"сумма = {sum}\n" + $"количество = {k} ");
        }
    }
}
