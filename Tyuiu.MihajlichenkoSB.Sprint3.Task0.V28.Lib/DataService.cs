using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MihajlichenkoSB.Sprint3.Task0.V28.Lib
{
    public class DataService
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double result = 1.0;

            for (int k = startValue; k <= stopValue; k++)
            {
                // Используем градусы → радианы
                double term = value + 1 / Math.Cos(k * Math.PI / 180);
                result *= term;
            }

            return Math.Round(result, 3);
        }
    }
}