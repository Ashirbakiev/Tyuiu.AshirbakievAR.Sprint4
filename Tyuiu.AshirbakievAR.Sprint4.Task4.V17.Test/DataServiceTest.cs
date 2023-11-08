using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AshirbakievAR.Sprint4.Task4.V17.Lib;

namespace Tyuiu.AshirbakievAR.Sprint4.Task4.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] numsArray = new int[5, 5] { { 2, 3, 2, 4, 3 }, { 4, 7, 4, 2, 2 }, { 5, 2, 3, 4, 6 }, { 5, 2, 7, 6, 5 }, { 6, 3, 5, 7, 7 } };
            int res = ds.Calculate(numsArray);
            Assert.AreEqual(46, res);
        }
    }
}
