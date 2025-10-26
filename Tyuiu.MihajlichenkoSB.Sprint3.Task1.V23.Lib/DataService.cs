using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MihajlichenkoSB.Sprint3.Task1.V23.Lib
{
    public class DataService : ISprint3Task1V23
    {
public double GetMultiplySeries(int value, int startValue, int stopValue)
{
    double product = 1.0;
    int k = startValue;

    while (k <= stopValue)
    {
        double denominator = Math.Sin(value) + Math.Pow(value, k);
        double fraction = 300.0 / denominator; // исправлено
        double term = Math.Pow(fraction, k);
        product *= term;

        k++;
    }

             return product;
        }
    }
}