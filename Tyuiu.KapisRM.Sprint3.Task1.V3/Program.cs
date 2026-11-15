using System;
using Tyuiu.KapisRM.Sprint3.Task1.V3.Lib;

namespace Tyuiu.KapisRM.Sprint3.Task3.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Капис Р. М. | СМАРТб-26-1";

            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* Спринт #3                                                                                                  *");
            Console.WriteLine("* Тема: Оператор цикла while                                                                                 *");
            Console.WriteLine("* Задание #1                                                                                                 *");
            Console.WriteLine("* Вариант #3                                                                                                 *");
            Console.WriteLine("* Выполнил: Капис Роман Максимович | СМАРТб-26-1                                                             *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                   *");
            Console.WriteLine("* Написать программу используя цикл while, которая вычисляет произведение ряда по формуле:                   *");
            Console.WriteLine("* p = произведение ( k / (cos(5) + 1)^2 ) при k от 1 до 10[cite: 15]                                         *");
            Console.WriteLine("*                                                                                                            *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                           *");
            Console.WriteLine("**************************************************************************************************************");

            int startValue = 1;
            int stopValue = 10;

            Console.WriteLine($"Начало шага (startValue) = {startValue}");
            Console.WriteLine($"Конец шага (stopValue) = {stopValue}");

            DataService ds = new DataService();
            double res = ds.GetMultiplySeries(startValue, stopValue);

            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                *");
            Console.WriteLine("**************************************************************************************************************");

            Console.WriteLine($"Произведение ряда равно = {res}");

            Console.ReadKey();
        }
    }
}