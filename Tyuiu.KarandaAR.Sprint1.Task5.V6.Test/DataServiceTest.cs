using Tyuiu.KarandaAR.Sprint1.Task5.V6.Lib;

namespace Tyuiu.KarandaAR.Sprint1.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate(27);
            Assert.AreEqual(6, res);
        }
    }
}