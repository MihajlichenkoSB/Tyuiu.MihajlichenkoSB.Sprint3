using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MihajlichenkoSB.Sprint3.Task7.V13.Lib
{
    public class DataService : ISprint3Task7V13
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] results = new double[length];
            int index = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = Math.Cos(x) + 1;

                double f;
                if (Math.Abs(denominator) < 1e-9)
                {
                    f = 0;
                }
                else
                {
                    f = 3 * x + 2 - (2 * x - x) / denominator;
                }

                results[index] = Math.Round(f, 2);
                index++;
            }

            return results;
        }
    }
}