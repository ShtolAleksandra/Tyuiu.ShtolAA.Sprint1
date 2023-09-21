using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShtolAA.Sprint1.Task2.V19.Lib;

namespace Tyuiu.ShtolAA.Sprint1.Task2.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 40;
            var res = ds.ConvertInchToKm(x);
            Assert.AreEqual(1, res);
        }
    }
}
