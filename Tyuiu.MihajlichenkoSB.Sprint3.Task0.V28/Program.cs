using Tyuiu.MihajlichenkoSB.Sprint3.Task0.V28.Lib;
namespace Tyuiu.MihajlichenkoSB.Sprint3.Task0.V28
{
    class Program
    {
        private static int xCubed;

        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 |  Выполнил: Михайличенко С.Б. | ИИПб-25-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #1                                                                *");
            Console.WriteLine("* Тема: Получение результата из Switch                                     *");
            Console.WriteLine("* Задание #6                                                               *");
            Console.WriteLine("* Вариант #1                                                               *");
            Console.WriteLine("* Выполнил: Михайличенко Сергей Борисович | ИИП6-25-1                      *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая использует сокращенную форму записи          *");
            Console.WriteLine("* оператора switch вычисляет требуемое значение и возвращает результат.    *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* x = 1075;                                                                *");
            Console.WriteLine("* y = 754;                                                                 *");
            Console.WriteLine("****************************************************************************");

            Console.Write("Введите номер месяца (1–12): ");
            if (int.TryParse(Console.ReadLine(), out int month))


                Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            for (int i = 1; i <= 17; i++)
            {
                double term = xCubed - i + 2;
                System.Console.WriteLine($"{i}\t{term:F6}");
            }

            Console.ReadKey();
        }
    }
}