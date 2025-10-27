using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MihajlichenkoSB.Sprint3.Task4.V29.Lib
{
    public class DataService : ISprint3Task4V29
    {
        public double Calculate(int startValue, int stopValue)
        {
                double sum = 0;

                for (int x = -5; x <= 5; x++)
                {
                    if (x == 0) continue;
                    sum += Math.Cos(x) / x;
                }

                return sum;
            }
    }
}
