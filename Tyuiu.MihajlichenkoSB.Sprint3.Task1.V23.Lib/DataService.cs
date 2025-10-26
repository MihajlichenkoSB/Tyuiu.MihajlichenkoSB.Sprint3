using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MihajlichenkoSB.Sprint3.Task1.V23.Lib
{
    public class DataService : ISprint3Task1V23
    {

        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double result = 1.0;
            int k = startValue;

            while (k <= stopValue)
            {
                result *= 300.0 / (Math.Pow(value, k) - Math.Sin(value)); // изменил знак
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