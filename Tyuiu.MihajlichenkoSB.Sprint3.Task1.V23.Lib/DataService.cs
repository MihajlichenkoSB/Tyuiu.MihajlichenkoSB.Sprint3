using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MihajlichenkoSB.Sprint3.Task1.V23.Lib
{
    public class DataService : ISprint3Task0V23
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double result = 1.0;
            int k = startValue;

            while (k <= stopValue)
            {
                result *= 300 / (Math.Sin(value) + Math.Pow(value, k));
                k++;
            }

            return Math.Round(result, 3);
        }
    }
}
