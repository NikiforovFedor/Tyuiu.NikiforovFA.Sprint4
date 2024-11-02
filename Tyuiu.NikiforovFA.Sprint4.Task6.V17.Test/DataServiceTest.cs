using Tyuiu.NikiforovFA.Sprint4.Task6.V17.Lib;
namespace Tyuiu.NikiforovFA.Sprint4.Task6.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] r = { "kjldfa", "akljsf;d" };
            Assert.AreEqual(ds.Calculate(r), 1);
        }
    }
}