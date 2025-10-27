using Tyuiu.MihajlichenkoSB.Sprint3.Task4.V29.Lib;

namespace Tyuiu.MihajlichenkoSB.Sprint3.Task4.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();
            double result = ds.Calculate(-5, 5);

            Assert.AreEqual(0, result, 1e-12);
        }
    }
}