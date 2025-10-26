using Tyuiu.MihajlichenkoSB.Sprint3.Task0.V28.Lib;

namespace Tyuiu.MihajlichenkoSB.Sprint3.Task0.V28.Test
{
    [TestClass]
    public class DataServiceTests
    {
        [TestMethod]
        public void TestGetMultiplySeries()
        {
            DataService ds = new DataService();
            double value = 0.25;
            int startValue = 1;
            int stopValue = 17;
            double expected = 411589.537;

            double actual = ds.GetMultiplySeries(value, startValue, stopValue);

            Assert.AreEqual(expected, actual);
        }
    }
}