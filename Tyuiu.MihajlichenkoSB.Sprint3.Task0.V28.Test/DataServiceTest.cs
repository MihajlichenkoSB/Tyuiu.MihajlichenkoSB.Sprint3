using Tyuiu.MihajlichenkoSB.Sprint3.Task0.V28.Lib;
namespace Tyuiu.MihajlichenkoSB.Sprint3.Task0.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double value = 0.25;
            double result = ds.GetMultiplySeries(value);

            Assert.AreEqual(2.0, result, 1e-12, "Result should be approximately 2.0");
        }
    }
}