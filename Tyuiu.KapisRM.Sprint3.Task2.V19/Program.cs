using System;
using Tyuiu.KapisRM.Sprint3.Task2.V19.Lib;

namespace Tyuiu.KapisRM.Sprint3.Task2.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Капис Р. М. | СМАРТб-26-1";

            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* Спринт #3                                                                                                  *");
            Console.WriteLine("* Тема: Использование операторов цикла do-while                                                             *");
            Console.WriteLine("* Задание #2                                                                                                 *");
            Console.WriteLine("* Вариант #19                                                                                                *");
            Console.WriteLine("* Выполнил: Капис Роман Максимович | СМАРТб-26-1                                                             *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                   *");
            Console.WriteLine("* Написать программу используя цикл do...while, которая вычисляет сумму ряда по формуле[cite: 27]             *");
            Console.WriteLine("* S = сумма ( cos(i) * (1/2) ) при i от 1 до 10[cite: 27]                                                   *");
            Console.WriteLine("*                                                                                                            *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                           *");
            Console.WriteLine("**************************************************************************************************************");

            int startValue = 1;
            int stopValue = 10;

            Console.WriteLine($"Начало шага (startValue) = {startValue}");
            Console.WriteLine($"Конец шага (stopValue) = {stopValue}");

            DataService ds = new DataService();
            double res = ds.GetSumSeries(startValue, stopValue);

            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                *");
            Console.WriteLine("**************************************************************************************************************");

            Console.WriteLine($"Сумма ряда равна = {res}");

            Console.ReadKey();
        }
    }
}