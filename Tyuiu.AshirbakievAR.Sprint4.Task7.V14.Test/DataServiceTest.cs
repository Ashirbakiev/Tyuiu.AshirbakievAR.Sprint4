using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AshirbakievAR.Sprint4.Task7.V14.Lib;

namespace Tyuiu.AshirbakievAR.Sprint4.Task7.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(38, ds.Calculate(3,4,"458712659137"));
        }
    }
}
