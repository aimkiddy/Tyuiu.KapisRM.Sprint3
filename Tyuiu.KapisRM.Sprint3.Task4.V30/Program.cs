using System;
using Tyuiu.KapisRM.Sprint3.Task4.V30.Lib;

namespace Tyuiu.KapisRM.Sprint3.Task4.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Капис Р. М. | СМАРТб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Использование операторов continue и break в цихклах               *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Капис Роман Максимович | СМАРТб-26-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* На отрезке от -5 до 5 вычислить значение функции y = sin(x)/x.          *");
            Console.WriteLine("* При x = 0 значение пропустить. Полученные значения суммировать.         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("********************************-------------------------------------------");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine($"Начало отрезка: {startValue}");
            Console.WriteLine($"Конец отрезка: {stopValue}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("********************************-------------------------------------------");

            double res = ds.Calculate(startValue, stopValue);
            Console.WriteLine($"Сумма значений функции: {res}");

            Console.ReadKey();
        }
    }
}