using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MihajlichenkoSB.Sprint3.Task1.V23.Lib
{
    public class DataService : ISprint3Task1V23
    {

        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double x = value; // конвертируем int в double
            double result = 1.0;
            int k = startValue;

            while (k <= stopValue)
            {
                result *= 300.0 / (Math.Pow(x, k) - Math.Sin(x)); // используем правильную формулу
                k++;
            }

            return Math.Round(result, 3);
        }

        public double GetMultiplySeries(double x, int startValue, int stopValue)
        {
            throw new NotImplementedException();
        }
    }
}