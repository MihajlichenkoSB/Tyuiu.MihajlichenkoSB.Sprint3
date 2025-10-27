using Tyuiu.MihajlichenkoSB.Sprint3.Task5.V12.Lib;

namespace Tyuiu.MihajlichenkoSB.Sprint3.Task5.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double result = ds.GetSumSumSeries(5, 1, 1, 3, 10);
            Assert.AreEqual(55.748, Math.Round(result, 3));
        }
    }
}