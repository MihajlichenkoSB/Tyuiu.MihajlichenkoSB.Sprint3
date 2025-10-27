using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MihajlichenkoSB.Sprint3.Task5.V12.Lib
{
    public class DataService : ISprint3Task5V12
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sum = 0.0;

            for (int i = 1; i <= 3; i++)
            {
                for (int k = 1; k <= 10; k++)
                {
                    sum += Math.Cos(k); 
                }
            }

            sum += x / 2.0;

            return sum;
        }
    }
}
