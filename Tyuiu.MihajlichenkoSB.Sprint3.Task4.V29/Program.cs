using Tyuiu.MihajlichenkoSB.Sprint3.Task4.V29.Lib;

namespace Tyuiu.MihajlichenkoSB.Sprint3.Task4.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 |  Выполнил: Михайличенко С.Б. | ИИПб-25-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #3                                                                *");
            Console.WriteLine("* Тема: Использование операторов Continue и break в циклах                 *");
            Console.WriteLine("* Задание #1                                                               *");
            Console.WriteLine("* Вариант #29                                                              *");
            Console.WriteLine("* Выполнил: Михайличенко Сергей Борисович | ИИПб-25-1                      *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение      *");
            Console.WriteLine("* функции y=cos(x)/x\r\n\r\nПри х = 0 пропустить значение. Полученные      *");
            Console.WriteLine("* значения суммировать.                                                    *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* x = 5;                                                                   *");
            Console.WriteLine("****************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            double result = ds.Calculate(startValue, stopValue);


            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("Результат: " + result);
            Console.ReadKey();
        }
    }
}
