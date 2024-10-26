using Tyuiu.NikiforovFA.Sprint4.Task0.V29.Lib;
namespace Tyuiu.NikiforovFA.Sprint4.Task0.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] d = { 1, 2, 3 };
            Assert.AreEqual(ds.GetSumOddArrEl(d), 4);
        }
    }
}