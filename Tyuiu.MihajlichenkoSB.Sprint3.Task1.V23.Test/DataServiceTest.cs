using Tyuiu.MihajlichenkoSB.Sprint3.Task1.V23.Lib;

namespace Tyuiu.MihajlichenkoSB.Sprint3.Task1.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 5;
            int startValue = 1;
            int stopValue = 5;

            double actual = ds.GetMultiplySeries(x, startValue, stopValue);

            double expected = 1.0;
            for (int k = startValue; k <= stopValue; k++)
            {
                expected *= 300.0 / (Math.Sin(x) + Math.Pow(x, k));
            }
            expected = Math.Round(expected, 3);

            Assert.AreEqual(expected, actual);
        }
    }
}