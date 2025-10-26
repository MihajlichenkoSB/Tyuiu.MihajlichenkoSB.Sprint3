using Tyuiu.MihajlichenkoSB.Sprint3.Task1.V23.Lib;
using System;

namespace Tyuiu.MihajlichenkoSB.Sprint3.Task1.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 |  Выполнил: Михайличенко С.Б. | ИИПб-25-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #3                                                                *");
            Console.WriteLine("* Тема: Оператор цикла while                                               *");
            Console.WriteLine("* Задание #1                                                               *");
            Console.WriteLine("* Вариант #23                                                              *");
            Console.WriteLine("* Выполнил: Михайличенко Сергей Борисович | ИИПб-25-1                      *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу используя цикл while, которая вычисляет произведение  *");
            Console.WriteLine("* ряда по формуле, при x = 5.                                              *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* x = 5;                                                                   *");
            Console.WriteLine("****************************************************************************");

            double x = 5.0;
            double result = ds.GetMultiplySeries((int)x, 1, 5);
            Console.WriteLine($"x = {x}");

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine($"Произведение (формат) = {result:F12}");

            Console.ReadKey();
        }
    }
}