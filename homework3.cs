
//Даны три целых числа. Выбрать из них те, которые принадлежат интервалу [1,3].

using System;

namespace homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            num1 = Convert.ToInt32(Console.ReadLine()); 
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > 1 && num1 < 3)
                Console.WriteLine(num1);
            if (num2 > 1 && num2 < 3)
                Console.WriteLine(num2);
            if (num3 > 1 && num3 < 3)
                Console.WriteLine(num3);
        }
    }
}
