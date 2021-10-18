using System;

namespace homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму: ");
            int num;
            num = Convert.ToInt32(Console.ReadLine());
            if (num > 500)
            {
                Console.WriteLine(num -((num * 3) / 100));
            }
            else if (num>1000)
            {
                Console.WriteLine(num - ((num * 5) / 100));
            }

        }
    }
}
