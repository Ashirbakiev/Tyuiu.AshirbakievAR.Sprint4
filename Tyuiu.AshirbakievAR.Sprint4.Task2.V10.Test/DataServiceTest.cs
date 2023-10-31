using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AshirbakievAR.Sprint4.Task2.V10.Lib;

namespace Tyuiu.AshirbakievAR.Sprint4.Task2.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] a = { 8, 0, 4, 7, 5, 3, 9, 2, 7, 0 };
            Assert.AreEqual(6615, ds.Calculate(a));
        }
    }
}
