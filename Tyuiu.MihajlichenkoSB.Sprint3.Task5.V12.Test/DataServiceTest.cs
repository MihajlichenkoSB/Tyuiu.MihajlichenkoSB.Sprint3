using Tyuiu.MihajlichenkoSB.Sprint3.Task5.V12.Lib;

namespace Tyuiu.MihajlichenkoSB.Sprint3.Task5.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetSumSumSeries()
        {
            DataService ds = new DataService();
            int x = 5;

            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 10;

            double expected = 3 * (
                Math.Cos(1) + Math.Cos(2) + Math.Cos(3) + Math.Cos(4) + Math.Cos(5) +
                Math.Cos(6) + Math.Cos(7) + Math.Cos(8) + Math.Cos(9) + Math.Cos(10)
            ) + x / 2.0;

            double result = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            Assert.AreEqual(expected, result, 1e-12);
        }
    }
}