using Tyuiu.NikiforovFA.Sprint4.Task7.V21.Lib;
namespace Tyuiu.NikiforovFA.Sprint4.Task7.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculateValid()
        {
            DataService ds = new DataService();
            string s = "123456789012";
            Assert.AreEqual(ds.Calculate(4,3,s), 22);
        }
    }
}