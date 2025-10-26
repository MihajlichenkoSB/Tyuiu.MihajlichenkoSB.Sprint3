using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MihajlichenkoSB.Sprint3.Task2.V18.Lib
{
    public class DataService : ISprint3Task2V18
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double product = 1.0;
            int k = 1;

            do
            {
                double addPart = Math.Pow((double)k / 8, 3);
                product *= (Math.Cos(value) + addPart);
                k++;
            }
            while (k <= 14);

            return Math.Round(product, 3); // округление до 3 знаков
        }
    }
}
