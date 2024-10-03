using Tyuiu.KarandaAR.Sprint1.Task2.V13.Lib;

namespace Tyuiu.KarandaAR.Sprint1.Task2.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            Assert.AreEqual(dataService.ConvertMilesToKm(2), 3.218);
        }
    }
}