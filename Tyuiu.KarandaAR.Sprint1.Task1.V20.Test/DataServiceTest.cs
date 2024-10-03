using Tyuiu.KarandaAR.Sprint1.Task1.V20.Lib;

namespace Tyuiu.KarandaAR.Sprint1.Task1.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(14, ds.Calculate(2, 4));
        }
    }
}