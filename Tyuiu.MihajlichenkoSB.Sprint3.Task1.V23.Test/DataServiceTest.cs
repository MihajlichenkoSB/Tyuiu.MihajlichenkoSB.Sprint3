using Tyuiu.MihajlichenkoSB.Sprint3.Task1.V23.Lib;

namespace Tyuiu.MihajlichenkoSB.Sprint3.Task1.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestGetMultiplySeries()
        {

            DataService ds = new DataService();
            int value = 5;
            int startValue = 1;
            int stopValue = 5;

            double expected = -0.071331455025152;

            double actual = ds.GetMultiplySeries(value, startValue, stopValue);

            double delta = 1e-12;
            Assert.AreEqual(expected, actual, delta);
        }
    }
}