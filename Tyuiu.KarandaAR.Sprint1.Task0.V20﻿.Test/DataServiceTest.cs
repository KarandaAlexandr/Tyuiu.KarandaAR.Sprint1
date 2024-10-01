using Tyuiu.KarandaAR.Sprint1.Task0.V20.Lib;

namespace Tyuiu.KarandaAR.Sprint1.Task0.V20﻿.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            var res = dataService.Calculate();
            Assert.AreEqual(13, res);
        }
    }
}