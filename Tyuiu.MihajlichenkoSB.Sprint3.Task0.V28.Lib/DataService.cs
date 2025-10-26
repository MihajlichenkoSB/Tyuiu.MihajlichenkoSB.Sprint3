using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MihajlichenkoSB.Sprint3.Task0.V28.Lib
{
    public class DataService : ISprint3Task0V28
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double product = 1.0;
            double xCubed = Math.Pow(value, 3);

            for (int i = startValue; i <= stopValue; i++)
            {
                double term = xCubed - i + 2;
                product *= term;
            }

            return Math.Round(product, 3);
        }

        public double GetMultiplySeries(double value)
        {
            throw new NotImplementedException();
        }
    }
}