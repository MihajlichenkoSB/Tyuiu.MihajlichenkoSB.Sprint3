using Tyuiu.MihajlichenkoSB.Sprint3.Task2.V18.Lib;

namespace Tyuiu.MihajlichenkoSB.Sprint3.Task2.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestGetMultiplySeries()
        {
            DataService ds = new DataService();
            int value = 1;
            int startValue = 1; 
            int stopValue = 14; 

            double result = ds.GetMultiplySeries(value, startValue, stopValue);

            double expected = 2.3; 
            Assert.AreEqual(expected, result, 0.001); 
        }
    }
}