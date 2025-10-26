using Tyuiu.MihajlichenkoSB.Sprint3.Task3.V17.Lib;

namespace Tyuiu.MihajlichenkoSB.Sprint3.Task3.V17
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

            string input = "vn98n! b,";

            int digits = ds.ConvertStringToInt(input);
            Console.WriteLine($"Digits only: {digits}");

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            int number = ds.ConvertStringToInt(digits);
            Console.WriteLine($"Converted to number: {number}");

            Console.ReadKey();
        }
    }
}