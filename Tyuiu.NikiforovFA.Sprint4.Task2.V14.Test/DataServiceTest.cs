using Tyuiu.NikiforovFA.Sprint4.Task2.V14.Lib;
namespace Tyuiu.NikiforovFA.Sprint4.Task2.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] a = { 2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 1, 2 };
            Assert.AreEqual(ds.Calculate(a), 1);
        }
    }
}