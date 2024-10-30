using Tyuiu.NikiforovFA.Sprint4.Task3.V10.Lib;
namespace Tyuiu.NikiforovFA.Sprint4.Task3.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] r = {{ 1,2,3,4,5},
                        { 1,2,3,4,5},
                        { 1,2,3,4,5},
                        { 1,2,3,4,5},
                        { 1,2,3,4,5}};
            Assert.AreEqual(5, ds.Calculate(r));
        }
    }
}