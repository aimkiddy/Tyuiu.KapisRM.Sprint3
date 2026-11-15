using System;
using Tyuiu.KapisRM.Sprint3.Task7.V21.Lib;

namespace Tyuiu.KapisRM.Sprint3.Task7.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Капис Р. М. | СМАРТб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Капис Роман Максимович | СМАРТб-26-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Табулирование функции F(x) на диапазоне [-5; 5] с шагом 1.              *");
            Console.WriteLine("* Значения занести в массив, округлить до двух знаков.                    *");
            Console.WriteLine("* При делении на ноль вернуть значение 0.                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine($"Начало диапазона: {startValue}");
            Console.WriteLine($"Конец диапазона: {stopValue}");
            Console.WriteLine($"Шаг: 1");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double[] resArray = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("X \t| F(X)");
            Console.WriteLine("-----------------------------------");
            int currentX = startValue;
            foreach (var val in resArray)
            {
                Console.WriteLine($"{currentX}\t| {val}");
                currentX++;
            }

            Console.ReadKey();
        }
    }
}