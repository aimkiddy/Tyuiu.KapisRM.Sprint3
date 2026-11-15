using System;
using Tyuiu.KapisRM.Sprint3.Task0.V13.Lib;

namespace Tyuiu.KapisRM.Sprint3.Task0.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Капис Р. М. | СМАРТб-26-1";

            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* Спринт #3                                                                                                  *");
            Console.WriteLine("* Тема: Оператор цикла for                                                                                   *");
            Console.WriteLine("* Задание #0                                                                                                 *");
            Console.WriteLine("* Вариант #13                                                                                                *");
            Console.WriteLine("* Выполнил: Капис Роман Максимович | СМАРТб-26-1                                                             *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                   *");
            Console.WriteLine("* Написать программу, используя цикл for, которая вычисляет сумму ряда по формуле, при a = 0,5               *");
            Console.WriteLine("* S = sum((a^k + 1/2) * cos(k)) при к от 1 до 20                                                             *");
            Console.WriteLine("*                                                                                                            *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                           *");
            Console.WriteLine("**************************************************************************************************************");

            double a = 0.5;
            int startValue = 1;
            int stopValue = 20;

            Console.WriteLine($"Исходное значение a = {a}");
            Console.WriteLine($"Начало суммирования (startValue) = {startValue}");
            Console.WriteLine($"Конец суммирования (stopValue) = {stopValue}");

            DataService ds = new DataService();
            double result = ds.GetSumSeries(a, startValue, stopValue);

            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                *");
            Console.WriteLine("**************************************************************************************************************");

            Console.WriteLine($"Сумма ряда равна = {result}");

            Console.ReadKey();
        }
    }
}