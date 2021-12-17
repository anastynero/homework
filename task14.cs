//Выполнить: Вводятся три числа — длины трех сторон треугольника. Создайте функцию Perimeter(), которая вычисляет периметр треугольника по длинам трех его сторон.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    class Program
    {
        static int Perimeter(int a, int b, int c)
        {
            int result = a + b + c;
            return result;
        }
    static void Main(string[] args)
    {
        int a, b, c, res;
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        c = int.Parse(Console.ReadLine());
        res = Perimeter(a, b, c);
        Console.WriteLine(res);
    }
}
}
