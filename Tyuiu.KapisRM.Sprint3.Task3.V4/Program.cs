using System;
using Tyuiu.KapisRM.Sprint3.Task3.V4.Lib;

namespace Tyuiu.KapisRM.Sprint3.Task3.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Капис Р. М. | СМАРТб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Капис Роман Максимович | СМАРТб-26-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach удалить из строки все буквы j.                   *");
            Console.WriteLine("* Исходная строка: plkjjdw cvjkl, удаляемый символ: 'j'                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string inputStr = "plkjjdw cvjkl";
            char charToRemove = 'j';

            Console.WriteLine($"Исходная строка: {inputStr}");
            Console.WriteLine($"Удаляемый символ: {charToRemove}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.DeleteCharInString(inputStr, charToRemove);
            Console.WriteLine($"Результат: {res}");

            Console.ReadKey();
        }
    }
}