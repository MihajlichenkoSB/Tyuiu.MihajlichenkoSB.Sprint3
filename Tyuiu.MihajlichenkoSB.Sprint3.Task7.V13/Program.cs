using Tyuiu.MihajlichenkoSB.Sprint3.Task7.V13.Lib;

namespace Tyuiu.MihajlichenkoSB.Sprint3.Task7.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Михайличенко С.Б. | ИИПб-25-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #3                                                                *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                  *");
            Console.WriteLine("* Задание #7                                                               *");
            Console.WriteLine("* Вариант #13                                                              *");
            Console.WriteLine("* Выполнил: Михайличенко Сергей Борисович | группа ИИПб-25-1               *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:            *");
            Console.WriteLine("* F(x) = 3x + 2 - (2x - x) / (cos(x) + 1)                                  *");
            Console.WriteLine("* Выполнить табулирование функции на отрезке [-5; 5] с шагом 1.            *");
            Console.WriteLine("* При делении на ноль вернуть значение 0.                                  *");
            Console.WriteLine("* Округлить значения до двух знаков после запятой.                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine($"Начало диапазона: {startValue}");
            Console.WriteLine($"Конец диапазона : {stopValue}");
            Console.WriteLine("****************************************************************************");

            double[] results = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("   x  |    F(x)");
            Console.WriteLine("------|------------");

            int index = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                Console.WriteLine($"{x,5} | {results[index],10}");
                index++;
            }

            Console.WriteLine("------|------------");
            Console.WriteLine("\nМассив значений:");
            Console.WriteLine(string.Join("; ", results));

            Console.ReadKey();
        }
    }
}