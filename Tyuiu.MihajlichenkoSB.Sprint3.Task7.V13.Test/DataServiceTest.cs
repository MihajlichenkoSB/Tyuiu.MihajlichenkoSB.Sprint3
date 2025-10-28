using Tyuiu.MihajlichenkoSB.Sprint3.Task7.V13.Lib;
namespace Tyuiu.MihajlichenkoSB.Sprint3.Task7.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

                DataService ds = new DataService();
                int start = -5, stop = 5;
                double[] result = ds.GetMassFunction(start, stop);

                Assert.AreEqual(stop - start + 1, result.Length);
        }
    }
}