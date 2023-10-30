using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AshirbakievAR.Sprint4.Task0.V28.Lib;

namespace Tyuiu.AshirbakievAR.Sprint4.Task0.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] a = { 1, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Assert.AreEqual(384,ds.GetMultEvenArrEl(a));
        }
    }
}
