﻿//Пользователь вводит целое число, преобразуйте значение номера дня недели в текстовое название.
//Если введенное значение не соответствует дню недели, выведите сообщение об ошибке.
using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            num = Convert.ToInt32(Console.ReadLine());
            switch(num){
                case 1:
                    Console.WriteLine("Понедельник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье");
                    break;
                default:
                    Console.WriteLine("Ошибка");
                    break;
            }
            

        }
    }
}
