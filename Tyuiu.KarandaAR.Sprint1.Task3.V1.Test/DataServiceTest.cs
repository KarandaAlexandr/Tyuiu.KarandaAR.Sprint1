using Tyuiu.KarandaAR.Sprint1.Task3.V1.Lib;

namespace Tyuiu.KarandaAR.Sprint1.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            Assert.AreEqual(25.133, dataService.CylinderVolume(2, 2));
        }
    }
}