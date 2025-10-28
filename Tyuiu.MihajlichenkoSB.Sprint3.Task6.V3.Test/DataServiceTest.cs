using System.Numerics;
using Tyuiu.MihajlichenkoSB.Sprint3.Task6.V3.Lib;

namespace Tyuiu.MihajlichenkoSB.Sprint3.Task6.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest 
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 13;
            int endValue = 19;

            int res = ds.GetSumTheDivisors(startValue, endValue);

            int wait = 120;

            Assert.AreEqual(wait, res); 
        }
    }
}

