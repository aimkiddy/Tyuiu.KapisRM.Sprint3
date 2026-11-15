using System;
using Tyuiu.KapisRM.Sprint3.Task5.V3.Lib;

namespace Tyuiu.KapisRM.Sprint3.Task5.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Капис Р. М. | СМАРТб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двойные циклы                                                     *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Капис Роман Максимович | СМАРТб-26-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить двойную сумму по формуле при X = 5.                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("********************************-------------------------------------------");

            int x = 5;
            int startValue1 = 1, stopValue1 = 3;
            int startValue2 = 1, stopValue2 = 11;

            Console.WriteLine($"Значение X: {x}");
            Console.WriteLine($"Интервал 1: от {startValue1} до {stopValue1}");
            Console.WriteLine($"Интервал 2: от {startValue2} до {stopValue2}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("********************************-------------------------------------------");

            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
            Console.WriteLine($"Результат вычисления: {res}");

            Console.ReadKey();
        }
    }
}