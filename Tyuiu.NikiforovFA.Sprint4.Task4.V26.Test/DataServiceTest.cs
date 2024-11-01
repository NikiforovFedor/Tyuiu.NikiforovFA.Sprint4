using Tyuiu.NikiforovFA.Sprint4.Task4.V26.Lib;
namespace Tyuiu.NikiforovFA.Sprint4.Task4.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] r = {{ 1, 2 },
                        { 3, 4 }};
            int[,] w = {{ 0, 2 },
                        { 0, 4 }};
            CollectionAssert.AreEqual(ds.Calculate(r), w);
        }
    }
}