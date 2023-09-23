using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShtolAA.Sprint1.Task4.V28.Lib;

namespace Tyuiu.ShtolAA.Sprint1.Task4.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double wait = 0.018;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
            
        }
    }
}
