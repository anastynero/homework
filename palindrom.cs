// Проверить является введенный пользователем палиндромом или нет. Пробелы и регистр символов в строке игнорировать.
using System;

namespace palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string s1 = s.Replace(" ", "");
            Console.WriteLine($"{s1}");
            bool tr = true;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] == s1[s1.Length - 1 - i])
                {
                    tr = true;
                }
                else
                {
                    tr = false;
                }
                if (!tr)
                {
                    Console.WriteLine("Это не палиндром");
                    break;
                }
            }
            if (tr)
            {
                Console.WriteLine("Это палиндром");
            }
        }
    }
}
