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

            double actual = ds.GetSumSeries(x, startValue, stopValue);

            double expected = 300 / (Math.Sin(5) + Math.Pow(5, 1));
            expected *= 300 / (Math.Sin(5) + Math.Pow(5, 2));
            expected = Math.Round(expected, 3);

            Assert.AreEqual(expected, actual);
        }
    }
}
