using Tyuiu.NikiforovFA.Sprint4.Task1.V24.Lib;
namespace Tyuiu.NikiforovFA.Sprint4.Task1.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] r = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            Assert.AreEqual(1, ds.Calculate(r));
        }
    }
}