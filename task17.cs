//Написать программу, программу, которая осуществляет капитализацию введенного пользователем текста. В качестве разделителя слов использовать пробел
using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            string str = Convert.ToString(Console.ReadLine());
            string probel = "";
            for (int i = 0; i < (str.Length); i++)
            {
                if (i != 0)
                {
                    probel += str[i];
                }
                else
                {
                    probel += str[i];
                    probel = probel.ToUpper();
                }

            }
            Console.WriteLine($"{probel}");
        }
    }
}
