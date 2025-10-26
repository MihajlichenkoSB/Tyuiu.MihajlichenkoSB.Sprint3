using Tyuiu.MihajlichenkoSB.Sprint3.Task3.V17.Lib;

namespace Tyuiu.MihajlichenkoSB.Sprint3.Task3.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // arrange
            DataService ds = new DataService();
            string input = "vn98n! b,";
            int expected = 98; // expected теперь int

            // act
            int result = ds.ConvertStringToInt(input); // исправлено

            // assert
            Assert.AreEqual(expected, result);
        }
    }
}